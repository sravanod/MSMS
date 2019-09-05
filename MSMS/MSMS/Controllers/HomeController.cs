using MSMS.BusinessAccessLayer;
using MSMS.Repositary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MSMS.Controllers
{
    public class HomeController : Controller
    {
        BAL ObjBal = new BAL(new Reposit());
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}