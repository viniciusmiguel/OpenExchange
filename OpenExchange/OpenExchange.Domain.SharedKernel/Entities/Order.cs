
namespace OpenExchange.Domain.SharedKernel.Entities
{
    public abstract class Order :  Entity
    {
        private decimal ratio;
        private decimal destinyValue;

        Currency OriginCurrency { get; set;}
        public decimal OriginValue { get; set; }
        Currency DestinyCurrency { get; set; }
        public decimal DestinyValue {
            get
            {
                return destinyValue;
            }
            set
            {
                destinyValue = value;
                ratio = destinyValue / OriginValue;
            }
        }
        public decimal Ratio {
            get
            {
                return ratio;
            }
            set
            {
                ratio = value;
                destinyValue = OriginValue * ratio;
            }
        }
    }
}
