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
