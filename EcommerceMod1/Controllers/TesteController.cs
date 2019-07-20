using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EcommerceMod1.Controllers
{
    public class TesteController : Controller
    {
        [Authorize]
        // GET: Teste
        public ActionResult Identity()
        {
            return Content(" Estou usando Identity");
        }
        [AllowAnonymous]
        public ActionResult NonIdentity()
        {
            return View(" Não estou usando Identity");
        }


    }
}