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
        [Route("")]
        public IList<RecetaDto> GetReceta()
        {
            return this.recetaService.GetReceta();
        }

        [HttpGet]
        [Route("{recetaId:int}")]
        public RecetaDto GetReceta(int recetaId)
        {
            return this.recetaService.GetReceta(recetaId);
        }

        [HttpPost]
        [Route("")]
        public RecetaDto CrearReceta ([FromBody] RecetaDto receta)
        {
            return this.recetaService.CrearReceta(receta);
        }

        [HttpPut]
        [Route("{recetaId:int}")]
        public RecetaDto ActualizarReceta([FromBody] RecetaDto receta)
        {
            return this.recetaService.ActualizarReceta(receta);
        }

        //[HttpDelete]
        //[Route("{recetaId:int}")]
        //public RecetaDto BorrarReceta(int recetaId)
        //{
        //    return this.RecetaDto.BorrarReceta(recetaId);
        //}
    }
}