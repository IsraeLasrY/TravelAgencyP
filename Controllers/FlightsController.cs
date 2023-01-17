using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TravelAgencyP.Dal;
using TravelAgencyP.Models;

namespace TravelAgencyP.Controllers
{
    public class FlightsController : Controller
    {
        private FlightsDAL db = new FlightsDAL();

        // GET: Flights
        public ActionResult AdminHP()
        {
           
            return View(db.FlightsInfo.ToList());
        }

        // GET: Flights/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FlightsInfo flightsInfo = db.FlightsInfo.Find(id);
            if (flightsInfo == null)
            {
                return HttpNotFound();
            }
            return View(flightsInfo);
        }

        // GET: Flights/Create
        public ActionResult AddFlights()
        {
            return View();
        }

        // POST: Flights/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddFlights([Bind(Include = "FlightNumber,AirLine,Terminal,DestinationF,OriginF,DepDateF,LandDateF,DepT,LandT,Seats,PriceTicket,RoundTrip")] FlightsInfo flightsInfo)
        {
            //SubmitCreate
            if (ModelState.IsValid)
            {
                db.FlightsInfo.Add(flightsInfo);
                db.SaveChanges();
                return RedirectToAction("AdminHP");
            }

            return View(flightsInfo);
        }



        // GET: Flights/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FlightsInfo flightsInfo = db.FlightsInfo.Find(id);
            if (flightsInfo == null)
            {
                return HttpNotFound();
            }
            return View(flightsInfo);
        }

        // POST: Flights/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FlightNumber,AirLine,Terminal,DestinationF,OriginF,DepDateF,LandDateF,DepT,LandT,Seats,PriceTicket,RoundTrip")] FlightsInfo flightsInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(flightsInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("AdminHP");
            }
            return View(flightsInfo);
        }

        // GET: Flights/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FlightsInfo flightsInfo = db.FlightsInfo.Find(id);
            if (flightsInfo == null)
            {
                return HttpNotFound();
            }
            return View(flightsInfo);
        }

        // POST: Flights/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            FlightsInfo flightsInfo = db.FlightsInfo.Find(id);
            db.FlightsInfo.Remove(flightsInfo);
            db.SaveChanges();
            return RedirectToAction("AdminHP");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
