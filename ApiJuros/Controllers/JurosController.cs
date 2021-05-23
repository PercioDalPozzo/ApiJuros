using ApiJuros.Models;
using Aplicacao;
using Aplicacao.ConfigJuro;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ApiJuros.Controllers
{
    public class JurosController : Controller
    {
        private readonly IAplicConfigJuros _aplicConfigJuros;

        public JurosController(IAplicConfigJuros aplicConfigJuros)
        {
            _aplicConfigJuros = aplicConfigJuros;
        }

        [HttpGet]
        public decimal ObterTaxaJuros()
        {
            return _aplicConfigJuros.ObterTaxaJuros();
        }
}
}
