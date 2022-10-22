using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;
using Cova.WebService;
using Cova.WebService.Dtos;

namespace Cova.WebAPI.Controllers
{
    [RoutePrefix("api/paciente")]
    public class PacienteController : ApiController
    {
        public PacienteService pacienteService = new PacienteService();

        [HttpGet]
        [Route("")]
        public IList<PacienteDto> GetPacientes()
        {
            return this.pacienteService.GetPacientes();
        }

        [HttpGet]
        [Route("{usuarioId:int}")]
        public PacienteDto GetPaciente(int usuarioId)
        {
            return this.pacienteService.GetPaciente(usuarioId);
        }

        [HttpPost]
        [Route("")]
        public PacienteDto CrearPaciente([FromBody] PacienteDto paciente)
        {
            return this.pacienteService.CrearPaciente(paciente);
        }

        [HttpPut]
        [Route("{usuarioId:int}")]
        public PacienteDto ActualizarPaciente([FromBody] PacienteDto paciente)
        {
            return this.pacienteService.ActulizarPaciente(paciente);
        }

        [HttpDelete]
        [Route("{usuarioId:int}")]
        public PacienteDto BorrarPaciente(int usuarioId)
        {
            return this.pacienteService.BorrarPaciente(usuarioId);
        }
    }
}
