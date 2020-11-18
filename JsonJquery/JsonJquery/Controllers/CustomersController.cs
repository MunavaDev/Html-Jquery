using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using JsonJquery.Models;
using System.Web.Services;

namespace JsonJquery.Controllers
{
    public class CustomersController : Controller
    {
        private ReportStoreEntities db = new ReportStoreEntities();

        //------------------------------------------------------------------------JSON--------------------------------------------------------------------------------------\\
        [WebMethod]
        [HttpPost]
        public JsonResult CreateCustomer(string name, string surname)
        {
            var status = false;
            using ( db )
            {
                Customer newCustomer = new Customer();
                newCustomer.CustomerName = name;
                newCustomer.CustomerSurname = surname;
                db.Customers.Add(newCustomer);
                db.SaveChangesAsync();
                status = true;
            }


            return new JsonResult { Data = new { status } };
        }







    }
}
