using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;
using Cova.WebService;
using Cova.WebService.Dtos;

namespace Cova.WebAPI.Controllers
{
    [RoutePrefix("api/Cobertura")]
    public class CoberturaMedicaController : ApiController
    {
        public CoberturaService coberturaService = new CoberturaService();

        [HttpGet]
        [Route("")]
        public IList<CoberturaMedicaDto> GetCoberturas()
        {
            return this.coberturaService.GetCoberturas();
        }

        [HttpGet]
        [Route("{coberturaId:int}")]
        public CoberturaMedicaDto GetCobertura(int coberturaId)
        {
            return this.coberturaService.GetCobertura(coberturaId);
        }

        [HttpPost]
        [Route("")]
        public CoberturaMedicaDto CrearCobertura([FromBody] CoberturaMedicaDto cobertura)
        {
            return this.coberturaService.CrearCobertura(cobertura);
        }

        [HttpPut]
        [Route("{coberturaId:int}")]
        public CoberturaMedicaDto ActualizarCobertura([FromBody] CoberturaMedicaDto cobertura)
        {
            return this.coberturaService.ActualizarCobertura(cobertura);
        }

        [HttpDelete]
        [Route("{coberturaId:int}")]
        public CoberturaMedicaDto BorrarCobertura(int coberturaId)
        {
            return this.coberturaService.BorrarCobertura(coberturaId);
        }
    }
}