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
using System.Data.SqlClient;
using System.Web.UI;
using Microsoft.Ajax.Utilities;

namespace TravelAgencyP.Controllers
{
    public class HomeTravelController : Controller
    {
        private FlightDAL db = new FlightDAL();
        private AdminDAL DB = new AdminDAL();
        private CreditCardsDAL DbC = new CreditCardsDAL();

        // GET: HomeTravel
        public ActionResult HomePage()
        {
            return View(db.FlightsInfo.Where(p=>p.DepDateFlight >= DateTime.Now));
        }

       
        public ActionResult AboutUS()
        {
            return View("AboutUS");
        }

        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        [HttpGet]
        public ActionResult LoginAdmin()
        {
            return View();
        }

        void connectionString()
        {
            //con.ConnectionString = "data source=ISRAELASRY;initial catalog=tempdb;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
            con.ConnectionString = "Data Source=YAM;Initial Catalog=tempdb;Integrated Security=True";

        }
        [HttpPost]
        public ActionResult Verify(AdminInfo adminAcc)
        {
            AdminInfo admin = new AdminInfo();
            admin.AdminEmail = Request.Form["AdminEmail"];
            admin.AdminPassword = Request.Form["AdminPassword"];
            connectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from AdminInfo where AdminEmail = '" + adminAcc.AdminEmail + "' and AdminPassword= '" + adminAcc.AdminPassword + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                con.Close();
                return RedirectToAction("AdminHP", "Flights");
            }
            else
            {
                con.Close();
                return View("LoginAdmin");
            }


        }
        public ActionResult FindFlight()
        {
            
            return View("FindFlight", db.FlightsInfo.Where(p => p.DepDateFlight >= DateTime.Now));
        }
        [HttpPost]
        public ActionResult SearchFlight()
        {
            bool trip;
            int max = -1 , min = -1 , Travelers = -1;
            FlightsInfo info = new FlightsInfo();
            IQueryable<FlightsInfo> temp = db.FlightsInfo.Where(p => p.DepDateFlight >= DateTime.Now);
            if (Request.Form["OLocation"] != "From")
                info.OriginFlight = Request.Form["OLocation"];
            if (Request.Form["DLocation"] != "To")
                info.DestinationFlight = Request.Form["DLocation"];
            try
            {
                Travelers = Convert.ToInt32(Request.Form["Travelers"]);
            }
            catch {  }
            try
            {
                max = Convert.ToInt32(Request.Form["Maxprice"]);
            }
            catch(Exception ex)
            {

            }
            try
            {
                min = Convert.ToInt32(Request.Form["Minprice"]);
            }
            catch(Exception ex) { }
            try
            {

                info.DepDateFlight = Convert.ToDateTime(Request.Form["depdate"]);
            }
            catch (Exception error)
            { }
            trip = Convert.ToBoolean(Request.Form["Roundtrip"]);
            if (trip) {
                temp = temp.Where(p => p.RoundTrip != "");
                
            }
            if (info.OriginFlight != null)
            {
                temp = temp.Where(p => p.OriginFlight == info.OriginFlight);
            }
            if (info.DestinationFlight != null)
            {
                temp = temp.Where(p => p.DestinationFlight == info.DestinationFlight);
            }
            if (!info.DepDateFlight.Year.Equals(0001))
            {
                temp = temp.Where(p => p.DepDateFlight == info.DepDateFlight);
            }
            if (min != -1)
            {
                temp = temp.Where(p => p.PriceTicket >= min);
            }
            if (max != -1)
            {
                temp = temp.Where(p => p.PriceTicket <= max);
            }
            if(Travelers != -1)
            {
                temp = temp.Where(p => p.Seats - Travelers >= 0);
            }
            Session["searchdb"] = temp;
            return View("FindFlight", temp);
        }
        //public ActionResult SortFlights(object obj)
        //{


        //}
        [HttpPost]
        public ActionResult VerifyPayment()
        {
            FlightsInfo fi = (FlightsInfo)Session["flight"];
            var ti = Session["tickets"];
            CreditCard creditCard = new CreditCard();
            creditCard.CardNumber = Request.Form["number"];
            creditCard.NameOnCard = Request.Form["name"];
            creditCard.ID = (string)Session["id"];
            creditCard.ExpirationDate =Convert.ToDateTime( "01/"+Request.Form["expiration-month-and-year"]);
            DbC.CreditCard.Add(creditCard);
            db.FlightsInfo.Find(fi.FlightNumber).Seats = Convert.ToInt32(fi.Seats) - Convert.ToInt32(ti);
            db.SaveChanges();
            DbC.SaveChanges();
            return View("HomePage",db.FlightsInfo);
        }
       

        public ActionResult LoginForPayment()
        {
            FlightsInfo fi = new FlightsInfo();
            var tickets = Request.Form["numtickets"];
            fi.FlightNumber = Request.Form["FlightNum"];
            if ((Convert.ToInt32(db.FlightsInfo.Find(fi.FlightNumber).Seats.Value) - Convert.ToInt32(tickets)) < 0)
            {
                Response.Write("<script>alert('There are not enough seats left on the flight, choose a smaller amount or another flight');</script>");
                return View("FindFlight", db.FlightsInfo);
            }
            fi.Seats = db.FlightsInfo.Find(fi.FlightNumber).Seats.Value;
            fi.PriceTicket = Convert.ToInt32(db.FlightsInfo.Find(fi.FlightNumber).PriceTicket)*Convert.ToInt32(tickets);
            Session["flight"] = fi;
            Session["tickets"] = tickets;
            return View();
        }

        public ActionResult VerifyUser(UserInfo userInfo)
        {
            UserInfo User = new UserInfo();
            CreditCard ci = new CreditCard();
            User.ID = Request.Form["ID"];
            User.UserEmail = Request.Form["UserEmail"];
            User.UserPassword = Request.Form["UserPassword"];
            connectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from UserInfo where ID = '" + userInfo.ID + "' and UserEmail = '" + userInfo.UserEmail + "' and UserPassword= '" + userInfo.UserPassword + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                con.Close();
                ci = DbC.CreditCard.Where(p=> p.ID == User.ID).Single();
                if (ci == null)
                {
                    ViewData["namecard"] = "";
                    ViewData["numcard"] = "";
                    ViewData["expcard"] = "";
                }
                else
                {
                    ViewData["namecard"] = ci.NameOnCard;
                    ViewData["numcard"] = ci.CardNumber;
                    ViewData["expcard"] = ci.ExpirationDate;
                }
                Session["id"] = User.ID;
                FlightsInfo fi = (FlightsInfo)Session["flight"];
                ViewData["price"] = fi.PriceTicket;
                return View("Payment");
            }
            else
            {
                con.Close();
                return View("LoginForPayment");
            }
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
