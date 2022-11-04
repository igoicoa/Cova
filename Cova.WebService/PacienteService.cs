using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cova.WebService.Dtos;
using Cova.BL;
using Cova.BE;
using Cova.BE.Enum;

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
            pacienteDto.PacienteId = paciente.PacienteId;
            pacienteDto.Apellido = paciente.Apellido;
            pacienteDto.Nombre = paciente.Nombre;
            pacienteDto.DNI = paciente.DNI;
            pacienteDto.FechaNacimiento = paciente.FechaNacimiento;
            pacienteDto.Sexo = paciente.Sexo;
            pacienteDto.EstadoCivil = paciente.EstadoCivil;
            pacienteDto.Telefono = paciente.Telefono;
            pacienteDto.Email = paciente.Email;
            pacienteDto.Domicilio = domicilioDto;
            pacienteDto.Domicilio.Calle = paciente.Domicilio.Calle;
            pacienteDto.Domicilio.Numero = paciente.Domicilio.Numero;
            pacienteDto.Domicilio.Piso = paciente.Domicilio.Piso;
            pacienteDto.Domicilio.Localidad = paciente.Domicilio.Localidad;
            pacienteDto.Domicilio.Provincia = paciente.Domicilio.Provincia;
            pacienteDto.Domicilio.Pais = paciente.Domicilio.Pais;
            pacienteDto.CoberturaMedica = coberturaMedicaPacienteDto;
            if (pacienteDto.CoberturaMedica != null)
            {
                pacienteDto.CoberturaMedica = coberturaMedicaPacienteDto;
                pacienteDto.CoberturaMedica.CoberturaMedicaId = paciente.CoberturaMedica.CoberturaMedicaId;
                pacienteDto.CoberturaMedica.Nombre = paciente.CoberturaMedica.Nombre;
                pacienteDto.CoberturaMedica.NumeroAfiliado = paciente.CoberturaMedica.NumeroAfiliado;
                pacienteDto.CoberturaMedica.FechaVencimiento = paciente.CoberturaMedica.FechaVencimiento;
                pacienteDto.CoberturaMedica.Plan = coberturaMedicaPlanDto;
                pacienteDto.CoberturaMedica.Plan.PlanId = paciente.CoberturaMedica.Plan.PlanId;
                pacienteDto.CoberturaMedica.Plan.Nombre = paciente.CoberturaMedica.Plan.Nombre;
            }
            pacienteDto.Usuario = paciente.Usuario;
            pacienteDto.UsuarioID = paciente.UsuarioID;
            pacienteDto.Password = paciente.Password;
            pacienteDto.UltimoLogin = paciente.UltimoLogin;
            pacienteDto.Activo = paciente.Activo;
            pacienteDto.TipoUsuario = paciente.TipoUsuario.ToString();

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
            paciente.Domicilio.Calle = pacienteDto.Domicilio.Calle;
            paciente.Domicilio.Numero = pacienteDto.Domicilio.Numero;
            paciente.Domicilio.Piso = pacienteDto.Domicilio.Piso;
            paciente.Domicilio.Localidad = pacienteDto.Domicilio.Localidad;
            paciente.Domicilio.Provincia = pacienteDto.Domicilio.Provincia;
            paciente.Domicilio.Pais = pacienteDto.Domicilio.Pais;
            paciente.CoberturaMedica = coberturaMedicaPaciente;
            if (paciente.CoberturaMedica != null)
            {
                paciente.CoberturaMedica.CoberturaMedicaId = pacienteDto.CoberturaMedica.CoberturaMedicaId;
                paciente.CoberturaMedica.Nombre = pacienteDto.CoberturaMedica.Nombre;
                paciente.CoberturaMedica.NumeroAfiliado = pacienteDto.CoberturaMedica.NumeroAfiliado;
                paciente.CoberturaMedica.FechaVencimiento = pacienteDto.CoberturaMedica.FechaVencimiento;
                paciente.CoberturaMedica.Plan= coberturaMedicaPlan;
                paciente.CoberturaMedica.Plan.PlanId = pacienteDto.CoberturaMedica.Plan.PlanId;
                paciente.CoberturaMedica.Plan.Nombre = pacienteDto.CoberturaMedica.Plan.Nombre;
            }
            paciente.Usuario = pacienteDto.Usuario;
            paciente.UsuarioID = pacienteDto.UsuarioID;
            paciente.Password = pacienteDto.Password;
            paciente.UltimoLogin = pacienteDto.UltimoLogin;
            paciente.Activo = pacienteDto.Activo;
            paciente.TipoUsuario = TipoUsuario.Paciente;

            return paciente;
        }
    }
}
