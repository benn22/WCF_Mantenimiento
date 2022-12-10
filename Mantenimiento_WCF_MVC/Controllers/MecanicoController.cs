using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//Extensiones...
using Mantenimiento_WCF_MVC.ProxyMecanicos;

namespace Mantenimiento_WCF_MVC.Controllers
{
    public class MecanicoController : Controller
    {
        MecanicoClient miServMecanico = new MecanicoClient();
        // GET: Mecanico
        public ActionResult Index()
        {
            ViewBag.ListarMecanicos = miServMecanico.ListarMecanico();            
            return View();
        }
    }
}