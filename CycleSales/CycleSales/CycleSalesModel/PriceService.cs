using System;
using System.Collections.Generic;
using System.Linq;

namespace CycleSales.CycleSalesModel
{
    public class PriceService
    {
        private CycleSalesContext _context;

        public PriceService(CycleSalesContext context)
        {
            _context = context;
        }

        public IEnumerable<ConversionResult> CalculateForeignPrices(decimal exchangeRate)
        {
            var query = from b in _context.Bikes
                        orderby b.Bike_Id
                        select new ConversionResult
                        {
                            BikeName = b.Name,
                            USPrice = b.Retail,
                            ForeignPrice = CalculatePrice(b.Retail, exchangeRate)
                        };

            return query.ToList();
        }

        public static decimal CalculatePrice(decimal price, decimal multiplier)
        {
            var unrounded = price * multiplier;

            var roundedToFiveCents = Math.Round(unrounded * 20, 0) / 20;

            if (roundedToFiveCents % 1 == 0)
            {
                roundedToFiveCents -= 0.05M;
            }

            return roundedToFiveCents;
        }

        public class ConversionResult
        {
            public string BikeName { get; set; }
            public decimal USPrice { get; set; }
            public decimal ForeignPrice { get; set; }
        }
    }
}
