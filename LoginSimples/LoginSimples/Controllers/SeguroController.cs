using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginSimples.Controllers
{
    public class SeguroController : Controller
    {
        //
        // GET: /Seguro/

        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
    }
}