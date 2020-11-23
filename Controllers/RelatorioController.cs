using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SCARP.ViewModels;

namespace SCARP.Controllers
{
    public class RelatorioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ConsultaAta()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ConsultaAta(AtaViewModel viewModel)
        {
            return View(viewModel);
        }

        [HttpGet]
        public IActionResult ConsultaCarona()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ConsultaCarona(AtaViewModel viewModel)
        {
            return View(viewModel);
        }
        [HttpGet]
        public IActionResult ConsultaItens()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ConsultaItens(AtaViewModel viewModel)
        {
            return View(viewModel);
        }

    }
}
