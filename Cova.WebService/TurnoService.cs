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
    public class TurnoService
    {
        private BLTurno bLTurno = new BLTurno();

        public IList<TurnoDto> GetTurnos()
        {
            IList<BETurno> turnos = this.bLTurno.ObtenerTurnos();
            IList<TurnoDto> turnoDtos = new List<TurnoDto>();

            foreach (BETurno turno in turnos)
            {
                turnoDtos.Add(Mapear(turno));
            }
            return turnoDtos;
        }

        public IList<TurnoDto> GetTurnosUsuario(int pacienteId)
        {
            IList<TurnosDisponibleDto> turnosdisponibleDtos = new List<TurnosDisponibleDto>();
            foreach (BETurnoDisponible turno in turnos)
            {
                turnosdisponibleDtos.Add(Mapear(turnos));
            }

            return turnosdisponibleDtos;
        }

        public TurnoDto CrearTurno(TurnoDto turnoDtos)
        {
            if (this.bLTurno.GenerarTurno(Mapear(turnoDtos)))
            {
                return turnoDtos;
            }
            else
            {
                return null;
            }
        }

        public TurnoDto ActualizarTurno(TurnoDto turno)
        {
            if (this.bLTurno.AsistioTurno(Mapear(turno)))
            {
                return turno;
            }
            else
            {
                return null;
            }
        }

        public TurnoDto Borrarturno(int turnoId)
        {
            BETurno bETurno = new BETurno();
            if (this.bLTurno.CancelarTurno(bETurno))
            {
                TurnoDto turnoDto = new TurnoDto();

                return turnoDto;
            }
            else
            {
                return new TurnoDto();
            }
        }

        private static TurnoDto Mapear(BETurno turno)
        {
            TurnoDto turnoDto = new TurnoDto();
            CentroMedicoDto centroMedicoDto = new CentroMedicoDto();
            ProfesionalDto profesionalDto = new ProfesionalDto();
            PacienteDto pacienteDto = new PacienteDto();
            DomicilioDto domicilioDto = new DomicilioDto();
            CoberturaMedicaPacienteDto coberturaMedicaPacienteDto = new CoberturaMedicaPacienteDto();
            CoberturaMedicaPlanDto coberturaMedicaPlanDto = new CoberturaMedicaPlanDto();
            MedicoDto medicoDto = new MedicoDto();
            turnoDto.TurnoId = turno.TurnoId;
            turnoDto.Comentarios = turno.Comentarios.ToString();
            turnoDto.FechaTurno = turno.FechaTurno;
            turnoDto.Asistio = turno.Asistio;
            turnoDto.Comentarios = turno.Comentarios;
            turnoDto.CentroMedico = centroMedicoDto;
            turnoDto.CentroMedico.CentroMedicoId = centroMedicoDto.CentroMedicoId;
            turnoDto.CentroMedico.Nombre = centroMedicoDto.Nombre;
            turnoDto.CentroMedico.Telefono = centroMedicoDto.Telefono;
            turnoDto.CentroMedico.Email = centroMedicoDto.Email;
            turnoDto.CentroMedico.Domicilio = domicilioDto;
            turnoDto.CentroMedico.Domicilio.Calle = domicilioDto.Calle;
            turnoDto.CentroMedico.Domicilio.Numero = domicilioDto.Numero;
            turnoDto.CentroMedico.Domicilio.Piso = domicilioDto.Piso;
            turnoDto.CentroMedico.Domicilio.Localidad = domicilioDto.Localidad;
            turnoDto.CentroMedico.Domicilio.Provincia = domicilioDto.Provincia;
            turnoDto.CentroMedico.Domicilio.Pais = domicilioDto.Pais;
            turnoDto.Paciente = pacienteDto;
            turnoDto.Paciente.UsuarioID = pacienteDto.UsuarioID;
            turnoDto.Paciente.Apellido = pacienteDto.Apellido;
            turnoDto.Paciente.Nombre = pacienteDto.Nombre;
            turnoDto.Paciente.DNI = pacienteDto.DNI;
            turnoDto.Paciente.FechaNacimiento = pacienteDto.FechaNacimiento;
            turnoDto.Paciente.Sexo = pacienteDto.Sexo;
            turnoDto.Paciente.EstadoCivil = pacienteDto.EstadoCivil;
            turnoDto.Paciente.Telefono = pacienteDto.Telefono;
            turnoDto.Paciente.Email = pacienteDto.Telefono;
            turnoDto.Paciente.Domicilio = domicilioDto;
            turnoDto.Paciente.Domicilio.Calle = domicilioDto.Calle;
            turnoDto.Paciente.Domicilio.Numero = domicilioDto.Numero;
            turnoDto.Paciente.Domicilio.Piso = domicilioDto.Piso;
            turnoDto.Paciente.Domicilio.Localidad = domicilioDto.Localidad;
            turnoDto.Paciente.Domicilio.Provincia = domicilioDto.Provincia;
            turnoDto.Paciente.Domicilio.Pais = domicilioDto.Pais;
            turnoDto.Paciente.CoberturaMedica = coberturaMedicaPacienteDto;
            turnoDto.Paciente.CoberturaMedica.Nombre = coberturaMedicaPacienteDto.Nombre;
            turnoDto.Paciente.CoberturaMedica.NumeroAfiliado = coberturaMedicaPacienteDto.NumeroAfiliado;
            turnoDto.Paciente.CoberturaMedica.FechaVencimiento = coberturaMedicaPacienteDto.FechaVencimiento;
            turnoDto.Paciente.CoberturaMedica.Plan = coberturaMedicaPacienteDto.Plan;
            turnoDto.Paciente.CoberturaMedica.Nombre = coberturaMedicaPacienteDto.Nombre;
            turnoDto.Profesional = medicoDto;
            turnoDto.Profesional.ProfesionalId = medicoDto.ProfesionalId;
            turnoDto.Profesional.Apellido = medicoDto.Apellido;
            turnoDto.Profesional.Nombre = medicoDto.Nombre;
            turnoDto.Profesional.DNI = medicoDto.DNI;
            turnoDto.Profesional.FechaNacimiento = medicoDto.FechaNacimiento;
            turnoDto.Profesional.Sexo = medicoDto.Sexo;
            turnoDto.Profesional.EstadoCivil = medicoDto.EstadoCivil;
            turnoDto.Profesional.Telefono = medicoDto.Telefono;
            turnoDto.Profesional.Email = medicoDto.Email;
            turnoDto.Profesional.Domicilio = medicoDto.Domicilio;
            turnoDto.Profesional.Domicilio.Calle = medicoDto.Domicilio.Calle;
            turnoDto.Profesional.Domicilio.Numero = medicoDto.Domicilio.Numero;
            turnoDto.Profesional.Domicilio.Piso = medicoDto.Domicilio.Piso;
            turnoDto.Profesional.Domicilio.Localidad = medicoDto.Domicilio.Localidad;
            turnoDto.Profesional.Domicilio.Provincia = medicoDto.Domicilio.Provincia;
            turnoDto.Profesional.Domicilio.Pais = medicoDto.Domicilio.Pais;
            turnoDto.Profesional.TurnosDisponibles = medicoDto.TurnosDisponibles;

            return turnoDto;
        }

        private static BETurno Mapear(TurnoDto turnoDto)
        {
            BETurno turno = new BETurno();
            BECentroMedico centroMedico = new BECentroMedico();
            BEMedico medico = new BEMedico();
            BEDomicilio domicilio = new BEDomicilio();
            BEPaciente paciente = new BEPaciente();
            BECoberturaMedicaPaciente coberturaMedicaPaciente = new BECoberturaMedicaPaciente();
            BECoberturaMedicaPlan coberturaMedicaPlan = new BECoberturaMedicaPlan();
            turno.TurnoId = turnoDto.TurnoId;
            turno.Comentarios = turnoDto.Comentarios;
            turno.FechaTurno = turnoDto.FechaTurno;
            turno.Asistio = turnoDto.Asistio;
            turno.Comentarios = turnoDto.Comentarios;
            turno.CentroMedico = centroMedico;
            turno.CentroMedico.CentroMedicoId = centroMedico.CentroMedicoId;
            turno.CentroMedico.Nombre = centroMedico.Nombre;
            turno.CentroMedico.Telefono = centroMedico.Telefono;
            turno.CentroMedico.Email = centroMedico.Email;
            turno.CentroMedico.Domicilio = domicilio;
            turno.CentroMedico.Domicilio.Calle = domicilio.Calle;
            turno.CentroMedico.Domicilio.Numero = domicilio.Numero;
            turno.CentroMedico.Domicilio.Piso = domicilio.Piso;
            turno.CentroMedico.Domicilio.Localidad = domicilio.Localidad;
            turno.CentroMedico.Domicilio.Provincia = domicilio.Provincia;
            turno.CentroMedico.Domicilio.Pais = domicilio.Pais;
            turno.Paciente = paciente;
            turno.Paciente.UsuarioID = paciente.UsuarioID;
            turno.Paciente.Apellido = paciente.Apellido;
            turno.Paciente.Nombre = paciente.Nombre;
            turno.Paciente.DNI = paciente.DNI;
            turno.Paciente.FechaNacimiento = paciente.FechaNacimiento;
            turno.Paciente.Sexo = paciente.Sexo;
            turno.Paciente.EstadoCivil = paciente.EstadoCivil;
            turno.Paciente.Telefono = paciente.Telefono;
            turno.Paciente.Email = paciente.Telefono;
            turno.Paciente.Domicilio = domicilio;
            turno.Paciente.Domicilio.Calle = domicilio.Calle;
            turno.Paciente.Domicilio.Numero = domicilio.Numero;
            turno.Paciente.Domicilio.Piso = domicilio.Piso;
            turno.Paciente.Domicilio.Localidad = domicilio.Localidad;
            turno.Paciente.Domicilio.Provincia = domicilio.Provincia;
            turno.Paciente.Domicilio.Pais = domicilio.Pais;
            turno.Paciente.CoberturaMedica = coberturaMedicaPaciente;
            turno.Paciente.CoberturaMedica.Nombre = coberturaMedicaPaciente.Nombre;
            turno.Paciente.CoberturaMedica.NumeroAfiliado = coberturaMedicaPaciente.NumeroAfiliado;
            turno.Paciente.CoberturaMedica.FechaVencimiento = coberturaMedicaPaciente.FechaVencimiento;
            turno.Paciente.CoberturaMedica.Plan = coberturaMedicaPaciente.Plan;
            turno.Paciente.CoberturaMedica.Nombre = coberturaMedicaPaciente.Nombre;
            turno.Profesional = medico;
            turno.Profesional.ProfesionalId = medico.ProfesionalId;
            turno.Profesional.Apellido = medico.Apellido;
            turno.Profesional.Nombre = medico.Nombre;
            turno.Profesional.DNI = medico.DNI;
            turno.Profesional.FechaNacimiento = medico.FechaNacimiento;
            turno.Profesional.Sexo = medico.Sexo;
            turno.Profesional.EstadoCivil = medico.EstadoCivil;
            turno.Profesional.Telefono = medico.Telefono;
            turno.Profesional.Email = medico.Email;
            turno.Profesional.Domicilio = medico.Domicilio;
            turno.Profesional.Domicilio.Calle = medico.Domicilio.Calle;
            turno.Profesional.Domicilio.Numero = medico.Domicilio.Numero;
            turno.Profesional.Domicilio.Piso = medico.Domicilio.Piso;
            turno.Profesional.Domicilio.Localidad = medico.Domicilio.Localidad;
            turno.Profesional.Domicilio.Provincia = medico.Domicilio.Provincia;
            turno.Profesional.Domicilio.Pais = medico.Domicilio.Pais;
            turno.Profesional.TurnosDisponibles = medico.TurnosDisponibles;

            return turno;
        }
    }
}
