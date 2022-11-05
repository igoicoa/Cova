using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;
using Cova.WebService;
using Cova.WebService.Dtos;

namespace Cova.WebAPI.Controllers
{
    [RoutePrefix("api/Receta")]
    public class RecetaController : ApiController
    {
        public RecetaService recetaService = new RecetaService();

        [HttpGet]
        [Route("")]
        public IList<RecetaDto> GetRecetas()
        {
            int pacienteId = 0;
            return this.recetaService.GetRecetas(pacienteId);
        }

        [HttpGet]
        [Route("paciente/{pacienteId:int}")]
        public IList<RecetaDto> GetRecetasUsuario(int pacienteId)
        {
            return this.recetaService.GetRecetasUsuario(pacienteId);
        }

        [HttpPost]
        [Route("")]
        public RecetaDto CrearReceta([FromBody] RecetaDto receta)
        {
            return this.recetaService.CrearReceta(receta);
        }

        [HttpPut]
        [Route("{RecetaId:int}")]
        public RecetaDto ActualizarReceta([FromBody] RecetaDto receta)
        {
            return this.recetaService.ActualizarReceta(receta);
        }
    }
}