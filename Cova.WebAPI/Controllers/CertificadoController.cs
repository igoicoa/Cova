using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;
using Cova.WebService;
using Cova.WebService.Dtos;

namespace Cova.WebAPI.Controllers
{
    [RoutePrefix("api/certificado")]
    public class CertificadoController : ApiController
    {
        public CertificadoService certificadoService = new CertificadoService();

        [HttpGet]
        [Route("")]
        public IList<CertificadoDto> GetCertificado()
        {
            return this.certificadoService.GetCertificado();
        }

        [HttpGet]
        [Route("{certificadoId:int}")]
        public CertificadoDto GetCertificado(int certificadoId)
        {
            return this.certificadoService.GetCertificado(certificadoId);
        }

        [HttpPost]
        [Route("")]
        public CertificadoDto CrearCertificado([FromBody] CertificadoDto certificado)
        {
            return this.certificadoService.CrearCertificado(certificado);
        }

        [HttpPut]
        [Route("{certificadoId:int}")]
        public CertificadoDto ActualizarCertificado([FromBody] CertificadoDto certificado)
        {
            return this.certificadoService.ActualizarCertificado(certificado);
        }

        //[HttpDelete]
        //[Route("{certificadoId:int}")]
        //public CertificadoDto BorrarCertificado(int certificadoId)
        //{
        //    return this.certificadoService.BorrarCertificado(certificadoId);
        //}
    }
}