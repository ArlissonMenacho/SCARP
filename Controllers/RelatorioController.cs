using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SCARP.Helpers;
using SCARP.Models;
using SCARP.Repository.Interfaces;
using SCARP.ViewModels;

namespace SCARP.Controllers
{
    public class RelatorioController : Controller
    {
        private readonly IConsultasRepository _consultasRepository;
        public RelatorioController(IConsultasRepository consultasRepository)
        {
            _consultasRepository = consultasRepository;
        }
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
        public async Task<IActionResult> ConsultaAta(int codigoAta, int anoAta, string descricaoAta,  bool adesao = false)
        {

            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new System.Uri("http://localhost:64270/api/");
           
                HttpResponseMessage resposta = await httpClient.GetAsync($"Consulta/{codigoAta}/{anoAta}");
                resposta.EnsureSuccessStatusCode();
              var model = await resposta.Content.ReadAsAsync<IList<AtaViewModel>>();

            if (model != null)
            {
                return PartialView("_listaDeAtas", model);
            }
            return View();
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
        public IActionResult ConsultaItens(ItemViewModel viewModel, bool adesao = false)
        {
            return View(viewModel);
        }

    }
}
