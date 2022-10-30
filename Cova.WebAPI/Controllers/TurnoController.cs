using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;
using Cova.WebService;
using Cova.WebService.Dtos;

namespace Cova.WebAPI.Controllers
{
    [RoutePrefix("api/turno")]
    public class TurnoController : ApiController
    {
        public TurnoService TurnosDisponibleDto = new TurnoService();

        [HttpGet]
        [Route("")]
        public IList<TurnosDisponibleDto> GetTurnos()
        {
            return this.TurnosDisponibleDto.GetTurnos();
        }

        [HttpGet]
        [Route("/paciente{usuarioId:int}")]
        public IList<TurnosDisponibleDto> GetTurnosUsuario(int usuarioId)
        {
            return this.TurnosDisponibleDto.GetTurnosUsuario(usuarioId);
        }

        [HttpPost]
        [Route("")]
        public TurnosDisponibleDto CrearTurno([FromBody] TurnosDisponibleDto turnosDisponible)
        {
            return this.TurnosDisponibleDto.CrearTurno(turnosDisponible);
        }

        [HttpPut]
        [Route("{turnoId:int}")]
        public TurnosDisponibleDto ActualizarTurno([FromBody] TurnosDisponibleDto turnosDisponible)
        {
            return this.TurnosDisponibleDto.ActualizarTurno(turnosDisponible);
        }

        [HttpDelete]
        [Route("{turnoId:int}")]
        public PacienteDto Borrarturno(int turnoId)
        {
            return this.TurnosDisponibleDto.Borrarturno(turnoId);
        }
    }
}