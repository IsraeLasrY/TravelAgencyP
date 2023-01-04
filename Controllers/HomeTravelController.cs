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

namespace TravelAgencyP.Controllers
{
    public class HomeTravelController : Controller
    {
        private FlightDAL db = new FlightDAL();
        private AdminDAL DB = new AdminDAL();


        // GET: HomeTravel
        public ActionResult HomePage()
        {
            return View(db.FlightsInfo.ToList());
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
            con.ConnectionString = "data source=ISRAELASRY;initial catalog=tempdb;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
            //con.ConnectionString = "Data Source=YAM;Initial Catalog=tempdb;Integrated Security=True";

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
            
            return View("FindFlight", db.FlightsInfo);
        }
        [HttpPost]
        public ActionResult SearchFlight()
        {
            try
            {
                FlightsInfo info = new FlightsInfo();
                info.OriginFlight = Request.Form["OLocation"];
                info.DestinationFlight = Request.Form["DLocation"];
                info.DepDateFlight = Convert.ToDateTime(Request.Form["depdate"]);
                return View("FindFlight", db.FlightsInfo.Where(p => p.OriginFlight == info.OriginFlight && p.DestinationFlight == info.DestinationFlight && p.DepDateFlight == info.DepDateFlight));
            }
            catch (Exception ex)
            {
                return View("FindFlight", db.FlightsInfo);
            }
        }
        public ActionResult Payment()
        {
            var tickets = Request.Form["numtickets"];

            return View("Payment");
        }

        public ActionResult LoginForPayment()
        {
            return View();
        }

        public ActionResult VerifyUser(UserInfo userInfo)
        {
            UserInfo User = new UserInfo();
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
