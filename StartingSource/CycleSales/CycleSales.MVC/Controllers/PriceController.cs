using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CycleSales.CycleSalesModel;
using CycleSales.WarrantyModel;
using Microsoft.Data.Entity;

namespace CycleSalesPublicSite.Controllers
{
    public class PriceController : Controller
    {
        private CycleSalesContext catalogDb = new CycleSalesContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Convert(decimal exchangeRate)
        {
            var service = new PriceService(catalogDb);
            return View(service.CalculateForeignPrices(exchangeRate));
        }

        public ActionResult BulkUpdate(decimal multiplier)
        {
            var service = new PriceService(catalogDb);
            return View(service.UpdatePrices(multiplier));
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                catalogDb.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
