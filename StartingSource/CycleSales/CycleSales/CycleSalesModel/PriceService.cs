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

        public IEnumerable<Bike> UpdatePrices(decimal multiplier)
        {
            var bikes = _context.Bikes.ToList();

            foreach (var item in bikes)
            {
                item.Retail = RoundPrice(item.Retail * multiplier);
            }

            _context.SaveChanges();

            return bikes;
        }

        public IEnumerable<ConversionResult> CalculateForeignPrices(decimal exchangeRate)
        {
            var query = from b in _context.Bikes
                        orderby b.Bike_Id
                        select new ConversionResult
                        {
                            BikeName = b.Name,
                            USPrice = b.Retail,
                            ForeignPrice = RoundPrice(b.Retail * exchangeRate)
                        };

            return query.ToList();
        }

        private static decimal RoundPrice(decimal price)
        {
            var rounded = Math.Round(price * 20, 0) / 20;

            if (rounded % 1 == 0)
            {
                rounded -= 0.05M;
            }

            return rounded;
        }

        public class ConversionResult
        {
            public string BikeName { get; set; }
            public decimal USPrice { get; set; }
            public decimal ForeignPrice { get; set; }
        }
    }
}
