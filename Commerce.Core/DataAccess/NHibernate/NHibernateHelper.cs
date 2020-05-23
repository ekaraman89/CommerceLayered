﻿using NHibernate;
using System;

namespace Commerce.Core.DataAccess.NHibernate
{
    public abstract class NHibernateHelper : IDisposable
    {
        private static ISessionFactory _sessionFactory;

        public virtual ISessionFactory SessionFactory => _sessionFactory ?? (_sessionFactory = InitializeFactory());

        protected abstract ISessionFactory InitializeFactory();

        public virtual ISession OpenSession()
        {
            return _sessionFactory.OpenSession();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}