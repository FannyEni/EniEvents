using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EniEvents.Controllers
{
    public class RedirectController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return RedirectPermanent("/Public/Home");
        }
    }
}