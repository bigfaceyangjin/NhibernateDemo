using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data
{
	/// <summary>
	/// ISessionFactory是线程安全的，可以同时访问 ISession通过其打开，
	/// 之后的数据类操作均可通过其创建ISession
	/// </summary>
	public  class NHibernateHelper:IDisposable
	{
		private static ISessionFactory _sessionFactory = null;
		public static ISessionFactory CreateSession()
		{
			if (_sessionFactory == null)
			{
						_sessionFactory = (new Configuration()).Configure().BuildSessionFactory();
			}
			return _sessionFactory;
		}
		public void Dispose()
		{
			if (_sessionFactory != null)
			{
				_sessionFactory.Dispose();
			}
		}
	}
}
