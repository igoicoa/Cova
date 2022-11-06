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
            BEPaciente pacienteTurno = new BEPaciente();
            pacienteTurno.PacienteId = pacienteId;
            IList<BETurno> turnos = this.bLTurno.ObtenerTurnos(pacienteTurno);
            IList<TurnoDto> turnoDtos = new List<TurnoDto>();

            foreach (BETurno turno in turnos)
            {
                turnoDtos.Add(Mapear(turno));
            }
            return turnoDtos;
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
            if (this.bLTurno.CancelarTurno(turnoId))
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
            turnoDto.FechaTurno = turno.FechaTurno;
            turnoDto.Asistio = turno.Asistio;
            turnoDto.Comentarios = turno.Comentarios;
            turnoDto.CentroMedico = centroMedicoDto;
            turnoDto.CentroMedico.CentroMedicoId = turno.CentroMedico.CentroMedicoId;
            turnoDto.CentroMedico.Nombre = turno.CentroMedico.Nombre;
            turnoDto.CentroMedico.Telefono = turno.CentroMedico.Telefono;
            turnoDto.CentroMedico.Email = turno.CentroMedico.Email;
            turnoDto.CentroMedico.Domicilio = domicilioDto;
            turnoDto.CentroMedico.Domicilio.Calle = turno.CentroMedico.Domicilio.Calle;
            turnoDto.CentroMedico.Domicilio.Numero = turno.CentroMedico.Domicilio.Numero;
            turnoDto.CentroMedico.Domicilio.Piso = turno.CentroMedico.Domicilio.Piso;
            turnoDto.CentroMedico.Domicilio.Localidad = turno.CentroMedico.Domicilio.Localidad;
            turnoDto.CentroMedico.Domicilio.Provincia = turno.CentroMedico.Domicilio.Provincia;
            turnoDto.CentroMedico.Domicilio.Pais = turno.CentroMedico.Domicilio.Pais;
            turnoDto.Paciente = pacienteDto;
            turnoDto.Paciente.UsuarioId = turno.Paciente.UsuarioID;
            turnoDto.Paciente.PacienteId = turno.Paciente.PacienteId;
            turnoDto.Paciente.Apellido = turno.Paciente.Apellido;
            turnoDto.Paciente.Nombre = turno.Paciente.Nombre;
            turnoDto.Paciente.DNI = turno.Paciente.DNI;
            turnoDto.Paciente.FechaNacimiento = turno.Paciente.FechaNacimiento;
            turnoDto.Paciente.Sexo = turno.Paciente.Sexo;
            turnoDto.Paciente.EstadoCivil = turno.Paciente.EstadoCivil;
            turnoDto.Paciente.Telefono = turno.Paciente.Telefono;
            turnoDto.Paciente.Email = turno.Paciente.Email;
            turnoDto.Paciente.Domicilio = domicilioDto;
            turnoDto.Paciente.Domicilio.IDDomicilio = turno.Paciente.Domicilio.IDDomicilio;
            turnoDto.Paciente.Domicilio.Calle = turno.Paciente.Domicilio.Calle;
            turnoDto.Paciente.Domicilio.Numero = turno.Paciente.Domicilio.Numero;
            turnoDto.Paciente.Domicilio.Piso = turno.Paciente.Domicilio.Piso;
            turnoDto.Paciente.Domicilio.Localidad = turno.Paciente.Domicilio.Localidad;
            turnoDto.Paciente.Domicilio.Provincia = turno.Paciente.Domicilio.Provincia;
            turnoDto.Paciente.Domicilio.Pais = turno.Paciente.Domicilio.Pais;
            turnoDto.Paciente.CoberturaMedica = coberturaMedicaPacienteDto;
            if (turnoDto.Paciente.CoberturaMedica != null)
            {
                turnoDto.Paciente.CoberturaMedica = coberturaMedicaPacienteDto;
                turnoDto.Paciente.CoberturaMedica.CoberturaMedicaId = turno.Paciente.CoberturaMedica.CoberturaMedicaId;
                turnoDto.Paciente.CoberturaMedica.Nombre = turno.Paciente.CoberturaMedica.Nombre;
                turnoDto.Paciente.CoberturaMedica.NumeroAfiliado = turno.Paciente.CoberturaMedica.NumeroAfiliado;
                turnoDto.Paciente.CoberturaMedica.FechaVencimiento = turno.Paciente.CoberturaMedica.FechaVencimiento;
                turnoDto.Paciente.CoberturaMedica.Plan = coberturaMedicaPlanDto;
                turnoDto.Paciente.CoberturaMedica.Plan.PlanId = turno.Paciente.CoberturaMedica.Plan.PlanId;
                turnoDto.Paciente.CoberturaMedica.Plan.Nombre = turno.Paciente.CoberturaMedica.Plan.Nombre;
            }
            turnoDto.Profesional = medicoDto;
            turnoDto.Profesional.ProfesionalId = turno.Profesional.ProfesionalId;
            turnoDto.Profesional.Apellido = turno.Profesional.Apellido;
            turnoDto.Profesional.Nombre = turno.Profesional.Nombre;
            turnoDto.Profesional.DNI = turno.Profesional.DNI;
            turnoDto.Profesional.FechaNacimiento = turno.Profesional.FechaNacimiento;
            turnoDto.Profesional.Sexo = turno.Profesional.Sexo;
            turnoDto.Profesional.EstadoCivil = turno.Profesional.EstadoCivil;
            turnoDto.Profesional.Telefono = turno.Profesional.Telefono;
            turnoDto.Profesional.Email = turno.Profesional.Email;
            turnoDto.Profesional.Domicilio = domicilioDto;
            turnoDto.Profesional.Domicilio.IDDomicilio = turno.Profesional.Domicilio.IDDomicilio;
            turnoDto.Profesional.Domicilio.Calle = turno.Profesional.Domicilio.Calle;
            turnoDto.Profesional.Domicilio.Numero = turno.Profesional.Domicilio.Numero;
            turnoDto.Profesional.Domicilio.Piso = turno.Profesional.Domicilio.Piso;
            turnoDto.Profesional.Domicilio.Localidad = turno.Profesional.Domicilio.Localidad;
            turnoDto.Profesional.Domicilio.Provincia = turno.Profesional.Domicilio.Provincia;
            turnoDto.Profesional.Domicilio.Pais = turno.Profesional.Domicilio.Pais;
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
            turno.FechaTurno = turnoDto.FechaTurno;
            turno.Asistio = turnoDto.Asistio;
            turno.Comentarios = turnoDto.Comentarios;
            turno.CentroMedico = centroMedico;
            turno.CentroMedico.CentroMedicoId = turnoDto.CentroMedico.CentroMedicoId;
            turno.CentroMedico.Nombre = turnoDto.CentroMedico.Nombre;
            turno.CentroMedico.Telefono = turnoDto.CentroMedico.Telefono;
            turno.CentroMedico.Email = turnoDto.CentroMedico.Email;
            turno.CentroMedico.Domicilio = domicilio;
            turno.CentroMedico.Domicilio.Calle = turnoDto.CentroMedico.Domicilio.Calle;
            turno.CentroMedico.Domicilio.Numero = turnoDto.CentroMedico.Domicilio.Numero;
            turno.CentroMedico.Domicilio.Piso = turnoDto.CentroMedico.Domicilio.Piso;
            turno.CentroMedico.Domicilio.Localidad = turnoDto.CentroMedico.Domicilio.Localidad;
            turno.CentroMedico.Domicilio.Provincia = turnoDto.CentroMedico.Domicilio.Provincia;
            turno.CentroMedico.Domicilio.Pais = turnoDto.CentroMedico.Domicilio.Pais;
            turno.Paciente = paciente;
            turno.Paciente.UsuarioID = turnoDto.Paciente.UsuarioId;
            turno.Paciente.PacienteId = turnoDto.Paciente.PacienteId;
            turno.Paciente.Apellido = turnoDto.Paciente.Apellido;
            turno.Paciente.Nombre = turnoDto.Paciente.Nombre;
            turno.Paciente.DNI = turnoDto.Paciente.DNI;
            turno.Paciente.FechaNacimiento = turnoDto.Paciente.FechaNacimiento;
            turno.Paciente.Sexo = turnoDto.Paciente.Sexo;
            turno.Paciente.EstadoCivil = turnoDto.Paciente.EstadoCivil;
            turno.Paciente.Telefono = turnoDto.Paciente.Telefono;
            turno.Paciente.Email = paciente.Email;
            turno.Paciente.Domicilio = domicilio;
            turno.Paciente.Domicilio.IDDomicilio = turnoDto.Paciente.Domicilio.IDDomicilio;
            turno.Paciente.Domicilio.Calle = turnoDto.Paciente.Domicilio.Calle;
            turno.Paciente.Domicilio.Numero = turnoDto.Paciente.Domicilio.Numero;
            turno.Paciente.Domicilio.Piso = turnoDto.Paciente.Domicilio.Piso;
            turno.Paciente.Domicilio.Localidad = turnoDto.Paciente.Domicilio.Localidad;
            turno.Paciente.Domicilio.Provincia = turnoDto.Paciente.Domicilio.Provincia;
            turno.Paciente.Domicilio.Pais = turnoDto.Paciente.Domicilio.Pais;
            turno.Paciente.CoberturaMedica = coberturaMedicaPaciente;
            if (paciente.CoberturaMedica != null)
            {
                turno.Paciente.CoberturaMedica = coberturaMedicaPaciente;
                turno.Paciente.CoberturaMedica.CoberturaMedicaId = turnoDto.Paciente.CoberturaMedica.CoberturaMedicaId;
                turno.Paciente.CoberturaMedica.Nombre = turnoDto.Paciente.CoberturaMedica.Nombre;
                turno.Paciente.CoberturaMedica.NumeroAfiliado = turnoDto.Paciente.CoberturaMedica.NumeroAfiliado;
                turno.Paciente.CoberturaMedica.FechaVencimiento = turnoDto.Paciente.CoberturaMedica.FechaVencimiento;
                turno.Paciente.CoberturaMedica.Plan = coberturaMedicaPlan;
                turno.Paciente.CoberturaMedica.Plan.PlanId = turnoDto.Paciente.CoberturaMedica.Plan.PlanId;
                turno.Paciente.CoberturaMedica.Nombre = turnoDto.Paciente.CoberturaMedica.Plan.Nombre;
            }
            turno.Profesional = medico;
            turno.Profesional.ProfesionalId = turnoDto.Profesional.ProfesionalId;
            turno.Profesional.Apellido = turnoDto.Profesional.Apellido;
            turno.Profesional.Nombre = turnoDto.Profesional.Nombre;
            turno.Profesional.DNI = turnoDto.Profesional.DNI;
            turno.Profesional.FechaNacimiento = turnoDto.Profesional.FechaNacimiento;
            turno.Profesional.Sexo = turnoDto.Profesional.Sexo;
            turno.Profesional.EstadoCivil = turnoDto.Profesional.EstadoCivil;
            turno.Profesional.Telefono = turnoDto.Profesional.Telefono;
            turno.Profesional.Email = turnoDto.Profesional.Email;
            turno.Profesional.Domicilio = domicilio;
            turno.Profesional.Domicilio.IDDomicilio = turnoDto.Profesional.Domicilio.IDDomicilio;
            turno.Profesional.Domicilio.Calle = turnoDto.Profesional.Domicilio.Calle;
            turno.Profesional.Domicilio.Numero = turnoDto.Profesional.Domicilio.Numero;
            turno.Profesional.Domicilio.Piso = turnoDto.Profesional.Domicilio.Piso;
            turno.Profesional.Domicilio.Localidad = turnoDto.Profesional.Domicilio.Localidad;
            turno.Profesional.Domicilio.Provincia = turnoDto.Profesional.Domicilio.Provincia;
            turno.Profesional.Domicilio.Pais = turnoDto.Profesional.Domicilio.Pais;
            turno.Profesional.TurnosDisponibles = medico.TurnosDisponibles;

            return turno;
        }
    }
}
