using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cova.WebService.Dtos;
using Cova.BL;
using Cova.BE;

namespace Cova.WebService
{
    public class CertificadoService
    {
        private BLCertificado bLCertificado = new BLCertificado();

        public IList<CertificadoDto> GetCertificado()
        {
            IList<BECertificado> certificados = this.bLCertificado.BuscarCertificados();
            IList<CertificadoDto> certificadoDtos = new List<CertificadoDto>();

            foreach (BECertificado certificado in certificados)
            {
                certificadoDtos.Add(Mapear(certificado));
            }
            return certificadoDtos;
        }

        public CertificadoDto GetCertificado(int certificadoId)
        {
            IList<BECertificado> certificado = this.bLCertificado.BuscarCertificados();
            CertificadoDto certificadoDto = Mapear(certificado.FirstOrDefault(x => x.CertificadoId == certificadoId));

            return certificadoDto;
        }

        private CertificadoDto Mapear(BECertificado bECertificado)
        {
            throw new NotImplementedException();
        }

        public CertificadoDto CrearCertificado(CertificadoDto certificado)
        {
            if (this.bLCertificado.CrearCertificado(Mapear(certificado)))
            {
                return certificado;
            }
            else
            {
                return null;
            }
        }

        public CertificadoDto ActualizarCertificado(CertificadoDto certificado)
        {
            if (this.bLCertificado.ActualizarCertificado(Mapear(certificado), Mapear(certificado)))
            {
                return certificado;
            }
            else
            {
                return null;
            }
        }

        //public CertificadoDto BorrarCertificado(int certificadoId)
        //{
        //    return certificadoId;
        //}

        private static CertificadoDto Mapear(BECertificado certificado, BEMedico medico, BEPaciente paciente)
        {
            CertificadoDto certificadoDto = new CertificadoDto();
            MedicoDto medicoDto = new MedicoDto();
            PacienteDto pacienteDto = new PacienteDto();
            medicoDto.ProfesionalId = medico.ProfesionalId;
            certificadoDto.FechaPrescripcion = certificado.FechaPrescripcion;
            certificadoDto.Observacion = certificado.Observacion;
            pacienteDto.PacienteId = paciente.PacienteId;

            return certificadoDto;
        }

        private static BECertificado Mapear(CertificadoDto certificadoDto, MedicoDto medicoDto, PacienteDto pacientesDto)
        {
            BECertificado certificado = new BECertificado();
            BEPaciente paciente = new BEPaciente();
            BEMedico medico = new BEMedico();
            medico.ProfesionalId = medicoDto.ProfesionalId;
            certificado.FechaPrescripcion = certificadoDto.FechaPrescripcion;
            certificado.Observacion = certificadoDto.Observacion;
            paciente.PacienteId = pacientesDto.PacienteId;

            return certificado;
        }
    }
}
