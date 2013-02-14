﻿using System.Reflection;
using NHibernate;
using NHibernate.Cfg;

namespace Molimentum.Providers.NHibernate
{
    public class NHibernateHelper
    {
        private static ISessionFactory _sessionFactory;

        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {
                    var configuration = new Configuration();

                    configuration.Configure();
                    configuration.AddAssembly(Assembly.GetExecutingAssembly());

                    _sessionFactory = configuration.BuildSessionFactory();
                }

                return _sessionFactory;
            }
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}