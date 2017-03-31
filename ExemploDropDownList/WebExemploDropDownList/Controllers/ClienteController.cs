using System.Web.Mvc;
using WebExemploDropDownList.Models;

namespace WebExemploDropDownList.Controllers
{
    public class ClienteController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.ClienteId = new SelectList
                                (
                                    new Cliente().ListaClientes(),
                                    "ClienteId", 
                                    "Nome"
                                );

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(string clienteId)
        {
            ViewBag.ClienteId = new SelectList
                                (
                                    new Cliente().ListaClientes(),
                                    "ClienteId",
                                    "Nome",
                                    clienteId
                                );


            return View();
        }
    }
}