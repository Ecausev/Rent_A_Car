using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rent_A_Car.Controllers
{
    public class ContractsController : Controller
    {
        // GET: Contracts
        public ActionResult CreateContract()
        {
            ViewBag.CountryList = _V.GetAll();
            return View();
        }
    }
}