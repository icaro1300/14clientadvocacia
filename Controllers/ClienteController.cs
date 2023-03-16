using AdvocaciaCliente.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor.Compilation;

namespace AdvocaciaCliente.Controllers
{
    public class ClienteController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {

            ClienteDAO dados = new ClienteDAO();
            ViewBag.listaCliente = dados.getTodosClientes();
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        //Na COntroller
        [HttpPost]
        public IActionResult Create(string idnome, string idendereco, string idnumero)
        {
            Cliente novoCliente = new Cliente();
            novoCliente.CLINOME = idnome;
            novoCliente.CLIENDERECO = idendereco;
            novoCliente.CLINUMEROENDERECO = idnumero;

            ClienteDAO dados = new ClienteDAO();
            bool result = dados.inserirCliente(novoCliente);
            if (result)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }

        }
        [HttpPost]
        public IActionResult Create(int idpesid, int idproid, int idtipid, DateTime iddatavinculo)
        {
            ClienteProcesso = new ClienteProcesso();
            ClienteProcesso.PESID = idpesid;
            ClienteProcesso.PROID = idproid;
            ClienteProcesso.TIPID = idtipid;
            ClienteProcesso.DATAVINCULO = iddatavinculo;



            ClienteProcesso dados = new ClienteProcesso();
            bool result = dados.inserirCASO(ClienteProcesso);
            if (result)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
    }
}