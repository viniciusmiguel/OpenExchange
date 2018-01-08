
using System;

namespace OpenExchange.Domain.SharedKernel.Entities
{
    public class MarketPeriodRatio : Entity
    {
        Market Market { get; set; }

        public decimal Ratio { get; set; }

        public TimeSpan Period { get; set; }

        public DateTime DateTime { get; set; }
    }
}
