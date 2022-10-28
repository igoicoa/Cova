using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;
using Cova.WebService;
using Cova.WebService.Dtos;

namespace Cova.WebAPI.Controllers
{
    [RoutePrefix("api/administrador")]
    public class AdministradorController : ApiController
    {
        public AdministradorService administradorService = new AdministradorService();

        [HttpGet]
        [Route("")]
        public IList<AdministradorDto> GetAdministrador()
        {
            return this.administradorService.GetAdministrador();
        }

        [HttpGet]
        [Route("{usuarioId:int}")]
        public AdministradorDto GetAdministrador(int usuarioId)
        {
            return this.administradorService.GetAdministrador(usuarioId);
        }

        [HttpPost]
        [Route("")]
        public AdministradorDto CrearAdministrador([FromBody] AdministradorDto administrador)
        {
            return this.administradorService.CrearAdministrador(administrador);
        }

        [HttpPut]
        [Route("{usuarioId:int}")]
        public AdministradorDto ActualizarAdministrador([FromBody] AdministradorDto administrador)
        {
            return this.administradorService.ActualizarAdministrador(administrador);
        }

        [HttpDelete]
        [Route("{usuarioId:int}")]
        public AdministradorDto BorrarAdministrador(int usuarioId)
        {
            return this.administradorService.BorrarAdministrador(usuarioId);
        }
    }
}
