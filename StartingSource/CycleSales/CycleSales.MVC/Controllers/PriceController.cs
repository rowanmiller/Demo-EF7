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
            var convertor = new PriceService(catalogDb);
            return View(convertor.CalculateForeignPrices(exchangeRate));
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
