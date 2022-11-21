using Shop.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop.WebSite.Controllers
{
    public class CustomersController : Controller
    {
		public CustomersBusiness customersBusiness = new CustomersBusiness();
        // GET: Customers
        public ActionResult Index()
        {
			var result= customersBusiness.GetCustomers(x => 1 == 1).ToList();
            return View(result);
        }
    }
}