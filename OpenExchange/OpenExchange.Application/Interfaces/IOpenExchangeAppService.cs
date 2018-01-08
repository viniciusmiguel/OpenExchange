using OpenExchange.Application.ViewModels;
using System.Collections.Generic;

namespace OpenExchange.Application.Interfaces
{
    public interface IOpenExchangeAppService
    {
        IEnumerable<ExchangeViewModel> GetExchangeList();
        IEnumerable<MarketViewModel> GetMarketListByExchangeName();
    }
}
