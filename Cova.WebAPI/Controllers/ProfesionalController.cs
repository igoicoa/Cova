using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;
using Cova.WebService;
using Cova.WebService.Dtos;

namespace Cova.WebAPI.Controllers
{
    [RoutePrefix("api/profesional")]
    public class ProfesionalController : ApiController
    {
        public ProfesionalService profesionalService = new ProfesionalService();

        [HttpGet]
        [Route("/medico")]
        public IList<MedicoDto> GetProfesionalesMedicos()
        {
            return this.profesionalService.GetProfesionalesMedicos();
        }

        [HttpGet]
        [Route("{usuarioId:int}")]
        public MedicoDto GetProfesionalMedico(int usuarioId)
        {
            return this.profesionalService.GetProfesionalMedico(usuarioId);
        }

        [HttpGet]
        [Route("{usuarioId:int}")]
        public IList<TurnosDisponibleDto> GetProfesionalMedicoHorarios(int usuarioId)
        {
            return this.profesionalService.GetProfesionalMedicoHorarios(usuarioId);
        }

        [HttpPost]
        [Route("/medico/{profesionalId:int}/horarios")]
        public ProfesionalDto GuardarProfesionalMedicoHorarios(int profesionalId, IList<TurnosDisponibleDto> turnosDisponibles)
        {
            return this.profesionalService.GuardarProfesionalMedicoHorarios(profesionalId, turnosDisponibles);
        }

        [HttpGet]
        [Route("{usuarioId:int}")]
        public IList<TurnoDto> GetProfesionalMedicoTurnosDisponibles(int usuarioId, DateTime fechadesde, DateTime fechahasta)
        {
            return this.profesionalService.GetProfesionalMedicoTurnosDisponibles(usuarioId, fechadesde, fechahasta);
        }

        [HttpPost]
        [Route("")]
        public MedicoDto CrearProfesionalMedico([FromBody] MedicoDto medico)
        {
            return this.profesionalService.CrearProfesionalMedico(medico);
        }

        [HttpPut]
        [Route("{usuarioId:int}")]
        public MedicoDto ActualizarProfesionalMedico([FromBody] MedicoDto medico)
        {
            return this.profesionalService.ActualizarProfesionalMedico(medico);
        }

        [HttpDelete]
        [Route("{usuarioId:int}")]
        public MedicoDto BorrarProfesionalMedico(int usuarioId)
        {
            return this.profesionalService.BorrarProfesionalMedico(usuarioId);
        }

//ENFERMERO
        [HttpGet]
        [Route("/enfermero")]
        public IList<EnfermeroDto> GetProfesionalesEnfermeros()
        {
            return this.profesionalService.GetProfesionalesEnfermeros();
        }

        [HttpGet]
        [Route("{usuarioId:int}")]
        public EnfermeroDto GetProfesionalEnfermero(int usuarioId)
        {
            return this.profesionalService.GetProfesionalEnfermero(usuarioId);
        }

        [HttpPost]
        [Route("")]
        public EnfermeroDto CrearProfesionalEnfermero([FromBody] EnfermeroDto enfermero)
        {
            return this.profesionalService.CrearProfesionalEnfermero(enfermero);
        }

        [HttpPut]
        [Route("{usuarioId:int}")]
        public EnfermeroDto ActualizarProfesionalEnfermero([FromBody] EnfermeroDto enfermero)
        {
            return this.profesionalService.ActualizarProfesionalEnfermero(enfermero);

        }

        [HttpDelete]
        [Route("{usuarioId:int}")]
        public EnfermeroDto BorrarProfesionalEnfermero(int usuarioId)
        {
            return this.profesionalService.BorrarProfesionalEnfermero(usuarioId);
        }


    }
}


