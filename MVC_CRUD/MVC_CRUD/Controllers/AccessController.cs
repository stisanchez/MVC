using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_CRUD.Controllers
{
    public class AccessController : Controller
    {
        // GET: Access
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Enter(string user, string pass)
        {
            try
            {
                return Content("1");
            }catch(Exception error)
            {
                return Content("Ocurrió un error :( " + error.Message);
            }
        }
    }
}