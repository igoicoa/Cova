using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;
using Cova.WebService;
using Cova.WebService.Dtos;

namespace Cova.WebAPI.Controllers
{
    [RoutePrefix("api/cobertura")]
    public class CoberturaMedicaController : ApiController
    {
        public CoberturaService coberturaService = new CoberturaService();

        [HttpGet]
        [Route("")]
        public IList<PacienteDto> GetCoberturas()
        {
            return this.coberturaService.GetCoberturas();
        }

        [HttpGet]
        [Route("{coberturaId:int}")]
        public PacienteDto GetCobertura(int coberturaId)
        {
            return this.coberturaService.GetCobertura(coberturaId);
        }

        [HttpPost]
        [Route("")]
        public CoberturaMedicaPacienteDto CrearCobertura([FromBody] CoberturaMedicaPacienteDto cobertura)
        {
            return this.coberturaService.CrearCobertura(cobertura);
        }

        [HttpPut]
        [Route("{coberturaId:int}")]
        public CoberturaMedicaPacienteDto ActualizarCobertura([FromBody] CoberturaMedicaPacienteDto cobertura)
        {
            return this.coberturaService.ActualizarCobertura(cobertura);
        }

        [HttpDelete]
        [Route("{coberturaId:int}")]
        public PacienteDto BorrarCobertura(int coberturaId)
        {
            return this.coberturaService.BorrarCobertura(coberturaId);
        }
    }
}