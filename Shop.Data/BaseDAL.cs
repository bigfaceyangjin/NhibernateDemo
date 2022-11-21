using NHibernate;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data
{
	/// <summary>
	///DAL基类、泛型重用
	/// </summary>
	public  class BaseDAL:IDisposable
	{
		ISession _session;
		/// <summary>
		/// 条件查询
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="whereLambda"></param>
		/// <returns></returns>
		public IEnumerable<T> GetT<T>(Expression<Func<T,bool>> whereLambda)
		{
				if (_session == null)
					_session = NHibernateHelper.CreateSession().OpenSession();
				return _session.Query<T>().Where(whereLambda);
		}
		public void Dispose()
		{
			if (_session != null)
				_session.Dispose();
		}
	}
}
