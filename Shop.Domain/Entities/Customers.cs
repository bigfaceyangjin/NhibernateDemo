using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain.Entities
{
	public class Customers
	{
		/// <summary>
		/// 客户ID
		/// </summary>
		public virtual string CustomerID { get; set; }
		/// <summary>
		/// 所在公司
		/// </summary>
		public virtual string CompanyName { get; set; }
		/// <summary>
		/// 客户姓名
		/// </summary>
		public virtual string ContactName { get; set; }
		/// <summary>
		/// 客户头衔
		/// </summary>
		public virtual string ContactTitle { get; set; }
		/// <summary>
		/// 客户ID
		/// </summary>
		public virtual string Address { get; set; }
		/// <summary>
		/// 所在城市
		/// </summary>
		public virtual string City { get; set; }
		/// <summary>
		/// 所在地区
		/// </summary>
		public virtual string Region { get; set; }
		/// <summary>
		/// 邮编
		/// </summary>
		public virtual string PostalCode { get; set; }
		/// <summary>
		/// 国家
		/// </summary>
		public virtual string Country { get; set; }
		/// <summary>
		/// 电话
		/// </summary>
		public virtual string Phone { get; set; }
		/// <summary>
		/// 传真
		/// </summary>
		public virtual string Fax { get; set; }
	}
}
