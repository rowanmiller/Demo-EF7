using CycleSales.CycleSalesModel;
using Microsoft.Data.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace CycleSales.Tests
{
    [TestClass]
    public class PriceConvertorTests
    {
        [TestMethod]
        public void SimpleConversion()
        {
            var options = new DbContextOptions()
                .UseInMemoryStore();

            using (var db = new CycleSalesContext(options))
            {
                // Arange
                db.Bikes.Add(new Bike { Bike_Id = 1, Retail = 100M });
                db.Bikes.Add(new Bike { Bike_Id = 2, Retail = 99.95M });
                db.SaveChanges();

                // Act
                var convertor = new PriceService(db);
                var results = convertor.CalculateForeignPrices(exchangeRate: 2).ToArray();

                // Assert
                Assert.AreEqual(2, results.Length);

                Assert.AreEqual(100M, results[0].USPrice);
                Assert.AreEqual(199.95M, results[0].ForeignPrice);

                Assert.AreEqual(99.95M, results[1].USPrice);
                Assert.AreEqual(199.90M, results[1].ForeignPrice);
            }
        }
    }
}
