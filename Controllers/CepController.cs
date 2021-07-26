using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Dominio.Servicos;
using WebApplication1.Dominio.ModelView;

namespace WebApplication1.Controllers
{
    [ApiController]
    public class CepController : ControllerBase
    {
        private readonly ILogger<CepController> _logger;

        public CepController(ILogger<CepController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("/fake-cep")]
        public async Task<CepView> Index()
        {
            return await CepServico.Get("102803820");
        }

        [HttpGet]
        [Route("/cep/{cep}")]
        public async Task<CepView> Index(string cep)
        {
            return await CepServico.Get(cep);
        }
    }
}
