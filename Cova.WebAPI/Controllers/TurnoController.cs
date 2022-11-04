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
        public TurnoService turnoService = new TurnoService();

        [HttpGet]
        [Route("")]
        public IList<TurnoDto> GetTurnos()
        {
            return this.turnoService.GetTurnos();
        }

        [HttpGet]
        [Route("paciente/{pacienteId:int}")]
        public IList<TurnoDto> GetTurnosUsuario(int pacienteId)
        {
            return this.turnoService.GetTurnosUsuario(pacienteId);
        }

        [HttpPost]
        [Route("")]
        public TurnoDto CrearTurno([FromBody] TurnoDto turnoDto)
        {
            return this.turnoService.CrearTurno(turnoDto);
        }

        [HttpPut]
        [Route("{turnoId:int}")]
        public TurnoDto ActualizarTurno([FromBody] TurnoDto turnoDto)
        {
            return this.turnoService.ActualizarTurno(turnoDto);
        }

        [HttpDelete]
        [Route("{turnoId:int}")]
        public TurnoDto Borrarturno(int turnoId)
        {
            return this.turnoService.Borrarturno(turnoId);
        }
    }
}