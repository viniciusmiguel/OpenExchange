using OpenExchange.Application.Interfaces;
using OpenExchange.Application.Services;
using SimpleInjector;
using System;

namespace OpenExchange.Infrastructure.DI
{
    public class DependencyInjector
    {
        private Container Container;
        public DependencyInjector()
        {
            Container = new Container();
        }
        public bool Inject()
        {
            try
            {
                // Domain

                // Infrastructure

                // Application
                Container.Register<IOpenExchangeAppService, OpenExchangeAppService>();

                Container.Verify();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }
    }
}
