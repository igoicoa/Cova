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
    public class PacienteService
    {
        private BLPaciente bLPaciente = new BLPaciente();

        public IList<PacienteDto> GetPacientes()
        {
            IList<BEPaciente> pacientes = this.bLPaciente.BuscarPacientes("", "");
            IList<PacienteDto> pacienteDtos = new List<PacienteDto>();

            foreach(BEPaciente paciente in pacientes)
            {
                pacienteDtos.Add(Mapear(paciente));
            }
            return pacienteDtos;
        }

        public PacienteDto GetPaciente(int usuarioId)
        {
            IList<BEPaciente> pacientes = this.bLPaciente.BuscarPacientes("", "");
            PacienteDto pacienteDto = Mapear(pacientes.Where(x => x.UsuarioID == usuarioId).FirstOrDefault());

            return pacienteDto;
        }

        public PacienteDto CrearPaciente(PacienteDto paciente)
        {
            if(this.bLPaciente.CrearPaciente(Mapear(paciente)))
            {
                return paciente;
            } else
            {
                return null;
            }
        }

        public PacienteDto ActulizarPaciente(PacienteDto paciente)
        {
            if (this.bLPaciente.ActualizarPaciente(Mapear(paciente), Mapear(paciente)))
            {
                return paciente;
            }
            else
            {
                return null;
            }
        }

        public PacienteDto BorrarPaciente(int usuarioId)
        {
            BEPaciente bEPaciente = new BEPaciente();
            bEPaciente.UsuarioID = usuarioId;
            if(this.bLPaciente.InactivarPaciente(bEPaciente))
            {
                PacienteDto pacienteDto = new PacienteDto();
                pacienteDto.UsuarioID = usuarioId;
                return pacienteDto;
            } else
            {
                return new PacienteDto();
            }
        }

        private static PacienteDto Mapear(BEPaciente paciente)
        {
            PacienteDto pacienteDto = new PacienteDto();
            pacienteDto.UsuarioID = paciente.UsuarioID;
            pacienteDto.Apellido = paciente.Apellido;
            pacienteDto.Nombre = paciente.Nombre;
            pacienteDto.Sexo = paciente.Sexo;

            return pacienteDto;
        }

        private static BEPaciente Mapear(PacienteDto pacienteDto)
        {
            BEPaciente paciente = new BEPaciente();
            paciente.UsuarioID = pacienteDto.UsuarioID;
            paciente.Apellido = pacienteDto.Apellido;
            paciente.Nombre = pacienteDto.Nombre;
            paciente.Sexo = pacienteDto.Sexo;

            return paciente;
        }
    }
}
