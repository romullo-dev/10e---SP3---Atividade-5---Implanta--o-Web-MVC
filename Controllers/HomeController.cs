using System.Collections.Generic;
using System.Diagnostics;
using LHPET.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LHPET.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var clientes = new List<Cliente>
            {
                new Cliente(1, "Arthur Lira", "434.434.546-76", "santos@gmail.com", "Arthur"),
                new Cliente(2, "Daniel", "434.257.978.23", "danielsantana@gmail.com", "Daniel"),
                new Cliente(3, "Gabriel", "324.445.098.34", "sgabrielsantos@gmail.com", "Gabriel"),
                new Cliente(4, "Messias", "098.543.776.45", "messias@gmail.com", "Messias"),
                new Cliente(5, "Daiv Lira", "234.467.987.32", "daivlitra@gmail.com", "Daiv")
            };

            var fornecedores = new List<Fornecedor>
            {
                new Fornecedor(
                    1,
                    "Alpha Solutions",
                    "71.016.268-4368/47",
                    "alphasolutions@sample.com"
                ),
                new Fornecedor(
                    2,
                    "Beta Innovations",
                    "43.239.224-5983/47",
                    "betainnovations@demo.com"
                ),
                new Fornecedor(
                    3,
                    "Gamma Enterprises",
                    "71.917.987-4718/06",
                    "gammaenterprises@example.com"
                ),
                new Fornecedor(4, "Delta Systems", "05.907.330-2654/10", "deltasystems@test.com"),
                new Fornecedor(
                    5,
                    "Epsilon Technologies",
                    "54.069.228-6945/18",
                    "epsilontechnologies@sample.com"
                )
            };

            ViewBag.ListaClientes = clientes;
            ViewBag.ListaFornecedor = fornecedores;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(
                new ErrorViewModel
                {
                    RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
                }
            );
        }
    }
}
