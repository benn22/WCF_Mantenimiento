using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//Extensiones...
using Mantenimiento_WCF_MVC.ProxyClientes;

namespace Mantenimiento_WCF_MVC.Controllers
{
    public class ClientesController : Controller
    {
        //Instanciamos el servicio de clientes...
        ServicioClienteClient miServCliente = new ServicioClienteClient();
        // GET: Clientes
        public ActionResult Index()
        {
            ViewBag.ListarClientes = miServCliente.ListarCliente();
            return View();
        }
    }
}