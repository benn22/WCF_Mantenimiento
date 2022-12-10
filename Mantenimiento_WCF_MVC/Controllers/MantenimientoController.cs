using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//Extensiones...
using Mantenimiento_WCF_MVC.ProxyMantenimientos;

namespace Mantenimiento_WCF_MVC.Controllers
{
    public class MantenimientoController : Controller
    {
        MantenimientoClient miServMantenimiento = new MantenimientoClient();
        // GET: Mantenimiento
        public ActionResult Index()
        {            
            return View();
        }        
    }
}