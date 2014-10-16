using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Reflection;
using System.Data;
using System.Data.SqlClient;

namespace TestingWeb.Controllers
{
	public static class StaticFunction
	{
		public static List<T> Query<T> ( this MySqlConnection conn , string query ) where T : new ( )
		{
			List<T> objs = new List<T> ( );
			conn.Open ( );
			using ( MySqlCommand command = new MySqlCommand ( query , conn ) )
			{
				using ( MySqlDataReader reader = command.ExecuteReader ( ) )
				{
					while ( reader.Read ( ) )
					{
						T obj = new T ( );

						PropertyInfo [ ] propertyInfos;
						propertyInfos = typeof ( T ).GetProperties ( );

						for ( int i = 0; i < reader.FieldCount; i++ )
						{
							var name = reader.GetName ( i );

							foreach ( var item in propertyInfos )
							{
								if ( item.Name.Equals ( name , StringComparison.InvariantCultureIgnoreCase ) && item.CanWrite )
								{
									item.SetValue ( obj , reader [ i ] , null );
								}
							}
							objs.Add ( obj );
						}
					}
				}
			}
			conn.Dispose ( );
			return objs;
		}

		public static Int64 Insert<T> (MySqlConnection conn, T obj )
		{
			Int64 lastID = 0;
			string query = "INSERT INTO " + typeof ( T ).Name;
			string fields = "(";
			string values = "(";

			conn.Open ( );
			using ( MySqlCommand command = conn.CreateCommand ( ) )
			{
				foreach ( var prop in obj.GetType().GetProperties() )
				{
					fields += prop.Name + ",";
					values += "@" + prop.Name + ",";
					SqlDbType SqlType = SqlDbType.BigInt;
					switch ( prop.PropertyType.Name )
					{
						case "Int32":
							SqlType = SqlDbType.Int;
							break;
						case "Int64":
							SqlType = SqlDbType.BigInt;
							break;
						case "String":
							SqlType = SqlDbType.VarChar;
							break;
						case "DateTime":
							SqlType = SqlDbType.DateTime;
							break;
						case "Double":
							SqlType = SqlDbType.Float;
							break;
						case "Byte[]":
							SqlType = SqlDbType.VarBinary;
							break;
						case "Boolean":
							SqlType = SqlDbType.Bit;
							break;
					}
					command.Parameters.Add ( new MySqlParameter ( "@" + prop.Name , SqlType )
												{
													Value = prop.GetValue(obj, null)
												}
											);
				}
				fields = fields.TrimEnd ( ',' );
				values = fields.TrimEnd ( ',' );
				fields += ')';
				values += ')';
				command.CommandText = query + fields + " VALUES  " + values;
				command.ExecuteNonQuery ( );
				lastID = command.LastInsertedId; 
			}
			conn.Close ( );

			return lastID;

		}
	}
}