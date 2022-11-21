using Shop.Data;
using Shop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Business
{
	public class CustomersBusiness
	{
		public CustomersDAL customersDAL = null;
		public CustomersBusiness()
		{
			customersDAL = new CustomersDAL();
		}
		/// <summary>
		/// 条件查询
		/// </summary>
		/// <param name="whereLambda"></param>
		/// <returns></returns>
		public IEnumerable<Customers> GetCustomers(Expression<Func<Customers,bool>> whereLambda)
		{
			return customersDAL.GetT(whereLambda);
		}
	}
}
