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
        public MedicoDto GetMedico(int usuarioId)
        {
            return this.profesionalService.GetMedico(usuarioId);
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
        public MedicoDto BorrarMedico(int usuarioId)
        {
            return this.profesionalService.BorrarMedico(usuarioId);
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
        public EnfermeroDto GetEnfermero(int usuarioId)
        {
            return this.profesionalService.GetEnfermero(usuarioId);
        }

        [HttpPost]
        [Route("")]
        public EnfermeroDto CrearProfesionalEnfermero([FromBody] EnfermeroDto enfermero)
        {
            return this.profesionalService.CrearProfesionalMedico(enfermero);
        }

        [HttpPut]
        [Route("{usuarioId:int}")]
        public EnfermeroDto ActualizarProfesionalEnfermero([FromBody] EnfermeroDto enfermero)
        {
            return this.profesionalService.ActualizarProfesionalMedico(enfermero);

        }

        [HttpDelete]
        [Route("{usuarioId:int}")]
        public EnfermeroDto BorrarEnfermero(int usuarioId)
        {
            return this.profesionalService.BorrarEnfermero(usuarioId);
        }


    }
}


