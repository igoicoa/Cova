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
            DomicilioDto domicilioDto = new DomicilioDto();
            CoberturaMedicaPacienteDto coberturaMedicaPacienteDto = new CoberturaMedicaPacienteDto();
            CoberturaMedicaPlanDto coberturaMedicaPlanDto = new CoberturaMedicaPlanDto();
            pacienteDto.UsuarioID = paciente.UsuarioID;
            pacienteDto.Apellido = paciente.Apellido;
            pacienteDto.Nombre = paciente.Nombre;
            pacienteDto.DNI = paciente.DNI;
            pacienteDto.FechaNacimiento = paciente.FechaNacimiento;
            pacienteDto.Sexo = paciente.Sexo;
            pacienteDto.EstadoCivil = paciente.EstadoCivil;
            pacienteDto.Telefono = paciente.Telefono;
            pacienteDto.Email = paciente.Email;
            pacienteDto.Domicilio = domicilioDto;
            pacienteDto.Domicilio.Calle = domicilioDto.Calle;
            pacienteDto.Domicilio.Numero = domicilioDto.Numero;
            pacienteDto.Domicilio.Piso = domicilioDto.Piso;
            pacienteDto.Domicilio.Localidad = domicilioDto.Localidad;
            pacienteDto.Domicilio.Provincia = domicilioDto.Provincia;
            pacienteDto.Domicilio.Pais = domicilioDto.Pais;
            pacienteDto.CoberturaMedica = coberturaMedicaPacienteDto;
            pacienteDto.CoberturaMedica.Nombre = coberturaMedicaPacienteDto.Nombre;
            pacienteDto.CoberturaMedica.NumeroAfiliado = coberturaMedicaPacienteDto.NumeroAfiliado;
            pacienteDto.CoberturaMedica.FechaVencimiento = coberturaMedicaPacienteDto.FechaVencimiento;
            pacienteDto.CoberturaMedica.Plan = coberturaMedicaPlanDto;
            pacienteDto.CoberturaMedica.Nombre = coberturaMedicaPlanDto.Nombre;

            return pacienteDto;
        }

        private static BEPaciente Mapear(PacienteDto pacienteDto)
        {
            BEPaciente paciente = new BEPaciente();
            BEDomicilio domicilio = new BEDomicilio();
            BECoberturaMedicaPaciente coberturaMedicaPaciente = new BECoberturaMedicaPaciente();
            BECoberturaMedicaPlan coberturaMedicaPlan = new BECoberturaMedicaPlan();
            paciente.UsuarioID = pacienteDto.UsuarioID;
            paciente.Apellido = pacienteDto.Apellido;
            paciente.Nombre = pacienteDto.Nombre;
            paciente.DNI = pacienteDto.DNI;
            paciente.FechaNacimiento = pacienteDto.FechaNacimiento;
            paciente.Sexo = paciente.Sexo;
            paciente.EstadoCivil = pacienteDto.EstadoCivil;
            paciente.Telefono = pacienteDto.Telefono;
            paciente.Email = pacienteDto.Telefono;
            paciente.Domicilio = domicilio;
            paciente.Domicilio.Calle = domicilio.Calle;
            paciente.Domicilio.Numero = domicilio.Numero;
            paciente.Domicilio.Piso = domicilio.Piso;
            paciente.Domicilio.Localidad = domicilio.Localidad;
            paciente.Domicilio.Provincia = domicilio.Provincia;
            paciente.Domicilio.Pais = domicilio.Pais;
            paciente.CoberturaMedica = coberturaMedicaPaciente;
            paciente.CoberturaMedica.Nombre = coberturaMedicaPaciente.Nombre;
            paciente.CoberturaMedica.NumeroAfiliado = coberturaMedicaPaciente.NumeroAfiliado;
            paciente.CoberturaMedica.FechaVencimiento = coberturaMedicaPaciente.FechaVencimiento;
            paciente.CoberturaMedica.Plan= coberturaMedicaPlan;
            paciente.CoberturaMedica.Nombre = coberturaMedicaPlan.Nombre;

            return paciente;
        }
    }
}
