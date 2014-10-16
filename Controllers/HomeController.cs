using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MySql.Data.MySqlClient;
using System.Reflection;
using TestingWeb.Models;
using System.Diagnostics;

namespace TestingWeb.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
		private MySql.Data.MySqlClient.MySqlConnection conn
		{
			get {
				string ConnetStr = "SERVER=localhost;" + "DATABASE=portal;" + "UID=root;" + "PASSWORD=root;";
				return new MySql.Data.MySqlClient.MySqlConnection ( ConnetStr );
			}
		}
        public ActionResult Index()
        {
            return View();
        }
		public ActionResult RegisterStep1 ( )
		{
			return View ( );
		}
		public ActionResult RegisterStep2 ( )
		{
			Session [ "email" ]		= Request.Form [ "email" ];
			Session [ "name" ]		= Request.Form [ "name" ];
			Session [ "telephon" ]	= Request.Form [ "telephon" ];
			Session [ "country" ]	= Request.Form [ "country" ];
			return View ( );
		}

		public void CreateAccount ( )
		{
			Entities user = new Entities();
			user.Email = System.Text.Encoding.UTF8.GetBytes(Session [ "email" ].ToString());
			user.FirstName = System.Text.Encoding.UTF8.GetBytes ( Session [ "name" ].ToString ( ).Split ( ' ' ) [ 0 ] );
			user.LastName = System.Text.Encoding.UTF8.GetBytes ( Session [ "name" ].ToString ( ).Split ( ' ' ) [ 1 ] );
			user.Phone = System.Text.Encoding.UTF8.GetBytes ( Session [ "telephon" ].ToString() );
			user.Country = System.Text.Encoding.UTF8.GetBytes ( Session [ "country" ].ToString ( ) );
			user.Password = System.Text.Encoding.UTF8.GetBytes ( Request [ "password" ].ToString ( ) );
			user.City = System.Text.Encoding.UTF8.GetBytes ( Request [ "city" ].ToString ( ) );
			user.Zip = System.Text.Encoding.UTF8.GetBytes ( Request [ "zip" ].ToString ( ) );
			user.Promocode = System.Text.Encoding.UTF8.GetBytes ( Request [ "promocode" ].ToString ( ) );

			Int64 lastID = StaticFunction.Insert<Entities> ( conn , user );

			Response.Write ( ( lastID > 0) ? "Account is created" : "Account creating error" );
		}
	}
}
