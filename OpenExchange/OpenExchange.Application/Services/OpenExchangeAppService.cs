using System.Collections.Generic;
using OpenExchange.Application.Interfaces;
using OpenExchange.Application.ViewModels;

namespace OpenExchange.Application.Services
{
    public class OpenExchangeAppService : IOpenExchangeAppService
    {
        public IEnumerable<ExchangeViewModel> GetExchangeList()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<MarketViewModel> GetMarketListByExchangeName()
        {
            throw new System.NotImplementedException();
        }
    }
}
