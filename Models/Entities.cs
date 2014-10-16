using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestingWeb.Models
{
	public class Entities
	{
#region Properties
		public Int64 EntityID{ get; set; }
		public Int32 CreatedBy { get; set; }
		public Int64 CategoryID { get; set; }
		public byte [ ] FirstName { get; set; }
		public byte [ ] LastName{ get;set; }
		public byte [ ] Company { get; set; }
		public byte [ ] Address { get; set; }
		public byte [ ] City { get; set; }
		public byte [ ] State { get; set; }
		public byte [ ] Country { get; set; }
		public byte [ ] Zip { get; set; }
		public byte [ ] Phone { get; set; }
		public Boolean AllowPhone { get; set; }
		public byte [ ] Mobile { get; set; }
		public Boolean AllowMobile { get; set; }
		public byte [ ] Fax { get; set; }
		public Boolean AllowFax { get; set; }
		public byte [ ] Email { get; set; }
		public Boolean AllowEmail { get; set; }
		public byte [ ] IsChecked { get; set; }
		public Int64 CryptedID { get; set; }
		public byte [ ] SharedUsers { get; set; }
		public Boolean IsDeleted { get; set; }
		public DateTime DeletedDate { get; set; }
		public Int32 DeletedBy { get; set; }
		public Int32 MergedID { get; set; }
		public Boolean CustomField3 { get; set; }
		public byte [ ] CustomField9 { get; set; }
		public byte [ ] CustomField10 { get; set; }
		public byte [ ] CustomField14 { get; set; }
		public byte [ ] CustomField15 { get; set; }
		public byte [ ] CustomField16 { get; set; }
		public byte [ ] CustomField17 { get; set; }
		public Int32 CustomField18 { get; set; }
		public byte [ ] CustomField19 { get; set; }
		public Int32 CustomField20 { get; set; }
		public Int32 CustomField21 { get; set; }
		public DateTime CustomAction6 { get; set; }
		public byte [ ] CustomField23 { get; set; }
		public byte [ ] CustomField24 { get; set; }
		public byte [ ] CustomField25 { get; set; }
		public Int32 CustomField39 { get; set; }
		public byte [ ] CustomField51 { get; set; }
		public Boolean CustomField52 { get; set; }
		public Int32 CustomField53 { get; set; }
		public byte [ ] CustomField60 { get; set; }
		public DateTime CustomField61 { get; set; }
		public byte [ ] CustomField62 { get; set; }
		public DateTime CustomField64 { get; set; }
		public Int32 CustomField65 { get; set; }
		public byte [ ] CustomField67 { get; set; }
		public Int32 CountryID { get; set; }
		public Boolean IsSupplier { get; set; }
		public Boolean IsUser { get; set; }
		public Boolean IsCustomer { get; set; }
		public byte [ ] Password { get; set; }
		public byte [ ] Promocode { get; set; }
#endregion
	}
}