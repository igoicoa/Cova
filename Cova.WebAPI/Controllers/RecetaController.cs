using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;
using Cova.WebService;
using Cova.WebService.Dtos;

namespace Cova.WebAPI.Controllers
{
    [RoutePrefix("api/receta")]
    public class RecetaController : ApiController
    {
        public RecetaService recetaService = new RecetaService();

        [HttpGet]
        //Route("")]
        public IList<RecetaDto> GetRecetas()
        {
            return this.recetaService.GetRecetas();
        }

        [HttpGet]
        [Route("Paciente/{usuarioId:int}")]
        public IList<RecetaDto> GetRecetasUsuario(int pacienteId)
        {
            return this.recetaService.GetRecetasUsuario(pacienteId);
        }

        [HttpPost]
        //[Route("")]
        public RecetaDto CrearReceta ([FromBody] RecetaDto receta)
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