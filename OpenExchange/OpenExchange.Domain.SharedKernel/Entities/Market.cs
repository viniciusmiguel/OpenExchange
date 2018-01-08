
namespace OpenExchange.Domain.SharedKernel.Entities
{
    public class Market : Entity
    {
        public Market()
        {

        }
        public Market(Currency baseCurrency, Currency secondaryCurrency, Exchange exchange)
        {
            BaseCurrency = baseCurrency;
            SecondaryCurrency = secondaryCurrency;
            Exchange = exchange;
        }
        Currency BaseCurrency { get; set; }

        Currency SecondaryCurrency { get; set; }

        Exchange Exchange { get; set; }
    }
}
