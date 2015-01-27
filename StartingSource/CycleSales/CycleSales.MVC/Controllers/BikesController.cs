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
    public class BikesController : Controller
    {
        private CycleSalesContext catalogDb = new CycleSalesContext();
        private WarrantyContext warrantyDb = new WarrantyContext();

        public ActionResult Index()
        {
            return View(catalogDb.Bikes.ToList());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var bike = (from b in catalogDb.Bikes
                        where b.Bike_Id == id
                        select b).Single();

            if (bike == null)
            {
                return HttpNotFound();
            }

            return View(bike);
        }

        public ActionResult WarrantyLookup()
        {
            return View();
        }

        public ActionResult Warranty(string modelNo, string serialNo)
        {
            if (modelNo == null || serialNo == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var warranty = (from w in warrantyDb.Warranties
                            where w.BikeModelNo == modelNo 
                                   && w.BikeSerialNo == serialNo
                            select w).SingleOrDefault();

            if (warranty == null)
            {
                return HttpNotFound();
            }

            return View(warranty);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Bike_Id,Name,ModelNo,Retail,Description,ImageUrl")] Bike bike)
        {
            if (ModelState.IsValid)
            {
                catalogDb.Bikes.Add(bike);
                catalogDb.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bike);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var bike = (from b in catalogDb.Bikes
                        where b.Bike_Id == id
                        select b).Single();

            return View(bike);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Bike_Id,Name,ModelNo,Retail,Description,ImageUrl")] Bike bike)
        {
            if (ModelState.IsValid)
            {
                catalogDb.Bikes.Update(bike);
                catalogDb.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bike);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var bike = (from b in catalogDb.Bikes
                        where b.Bike_Id == id
                        select b).Single();

            return View(bike);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Bike bike = catalogDb.Bikes.Single(b => b.Bike_Id == id);
            catalogDb.Bikes.Remove(bike);
            catalogDb.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                catalogDb.Dispose();
                warrantyDb.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
