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
        [Route("/enfermero")]
        public IList<EnfermeroDto> GetProfesionalesEnfermeros()
        {
            return this.profesionalService.GetProfesionalesEnfermeros();
        }

    }
}
