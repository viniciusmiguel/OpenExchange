
namespace OpenExchange.Domain.SharedKernel.Entities
{
    public class ExchangeFee : Entity
    {
        Exchange Exchange { get; set; }

        public decimal FeeMaximumValue { get; set; }

        public decimal MakerFee { get; set; }

        public decimal TakerFee { get; set; }
    }
}
