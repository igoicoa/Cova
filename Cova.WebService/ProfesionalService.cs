using System;
using System.Collections.Generic;
using System.Linq;
using Cova.BL;
using Cova.BE;
using Cova.WebService.Dtos;
using Cova.BE.Enum;
using Cova.Servicios.Encriptacion;

namespace Cova.WebService
{
    public class ProfesionalService
    {
        private BLProfesional bLProfesional = new BLProfesional();
        private BLMedico blMedico = new BLMedico();
        private BLEnfermero bLEnfermero = new BLEnfermero();

        public IList<MedicoDto> GetProfesionalesMedicos() 
        {
            IList<BEMedico> medicos = this.blMedico.BuscarMedicos("", "");
            IList<MedicoDto> medicoDto = new List<MedicoDto>();

            foreach (BEMedico medico in medicos)
            {
                medicoDto.Add(Mapear(medico));
            }
            return medicoDto;
            //return new List<MedicoDto>();
        }

        public MedicoDto GetProfesionalMedico(int usuarioId)
        {
            IList<BEMedico> medicos = this.blMedico.BuscarMedicos(usuarioId, "", "");
            MedicoDto medicoDto = Mapear(medicos.Where(x => x.UsuarioID == usuarioId).FirstOrDefault());

            return medicoDto;
        }

        public IList<TurnoDisponibleDto> GetProfesionalMedicoHorarios(int usuarioId)
        {
            IList<BEMedico> medicos = this.blMedico.BuscarMedicos(usuarioId, "", "");
            MedicoDto medicoDto = Mapear(medicos.Where(x => x.UsuarioID == usuarioId).FirstOrDefault());
            IList<TurnoDisponibleDto> horariosMedico = medicoDto.TurnosDisponibles;

            return horariosMedico;
        }

        public ProfesionalDto GuardarProfesionalMedicoHorarios(int profesionalId, IList<TurnoDisponibleDto> turnosDisponiblesDto)
        {
            BEProfesional bEProfesional = new BEProfesional();
            bEProfesional.ProfesionalId = profesionalId;
            bEProfesional.TurnosDisponibles = new List<BETurnoDisponible>();
            foreach(TurnoDisponibleDto turnoDisponible in turnosDisponiblesDto)
            {
                bEProfesional.TurnosDisponibles.Add(Mapear(turnoDisponible));
            }
            ProfesionalDto profesionalDto = new ProfesionalDto();
            profesionalDto.ProfesionalId = profesionalId;
            profesionalDto.TurnosDisponibles = turnosDisponiblesDto;
            if (this.bLProfesional.ActualizarTurnosDisponibles(bEProfesional))
            {
                return profesionalDto;
            }
            else
            {
                return null;
            }
        }

        public IList<TurnoDto> GetProfesionalMedicoTurnosDisponibles(int profesionalId, DateTime fechadesde, DateTime fechahasta)
        {
            BEProfesional bEProfesional = new BEProfesional();
            bEProfesional.ProfesionalId = profesionalId;
            List<BETurno> turnosDisponibles = this.bLProfesional.ObtenerTurnosLibres(bEProfesional, fechadesde, fechahasta).ToList();
            IList<TurnoDto> turnosProfesional = new List<TurnoDto>();
            foreach(BETurno turno in turnosDisponibles)
            {
                turnosProfesional.Add(Mapear(turno));
            }
            return turnosProfesional;
        }

        public MedicoDto CrearProfesionalMedico(MedicoDto medico)
        {
            BEMedico bEMedico = Mapear(medico);
            bEMedico.Password = HashHelper.HashMD5(medico.Apellido.Substring(0, 4) + medico.Nombre.Substring(0, 4));
            if (this.blMedico.CrearProfesionalMedico(bEMedico))
            {
                return medico;
            }
            else
            {
                return null;
            }
        }

        public MedicoDto ActualizarProfesionalMedico(MedicoDto medico)
        {
            if (this.blMedico.ActualizarProfesionalMedico(Mapear(medico), Mapear(medico)))
            {
                return medico;
            }
            else
            {
                return null;
            }
        }

        public MedicoDto BorrarProfesionalMedico(int usuarioId)
        {
            BEMedico beMedico = new BEMedico();
            beMedico.UsuarioID = usuarioId;
            if (this.blMedico.InactivarMedico(beMedico))
            {
                MedicoDto medicoDto = new MedicoDto();
                medicoDto.UsuarioId = usuarioId;
                return medicoDto;
            }
            else
            {
                return new MedicoDto();
            }
        }

        private static MedicoDto Mapear(BEMedico medico)
        {
            MedicoDto medicoDto = new MedicoDto();
            DomicilioDto domicilioDto = new DomicilioDto();
            medicoDto.ProfesionalId = medico.ProfesionalId;
            medicoDto.Apellido = medico.Apellido;
            medicoDto.Nombre = medico.Nombre;
            medicoDto.DNI = medico.DNI;
            medicoDto.FechaNacimiento = medico.FechaNacimiento;
            medicoDto.Sexo = medico.Sexo;
            medicoDto.EstadoCivil = medico.EstadoCivil;
            medicoDto.Telefono = medico.Telefono;
            medicoDto.Email = medico.Email;
            medicoDto.Domicilio = domicilioDto;
            medicoDto.Domicilio.Calle = medico.Domicilio.Calle;
            medicoDto.Domicilio.Numero = medico.Domicilio.Numero;
            medicoDto.Domicilio.Piso = medico.Domicilio.Piso;
            medicoDto.Domicilio.Localidad = medico.Domicilio.Localidad;
            medicoDto.Domicilio.Provincia = medico.Domicilio.Provincia;
            medicoDto.Domicilio.Pais = medico.Domicilio.Pais;
            medicoDto.MatriculaNacional = medico.MatriculaNacional;
            medicoDto.MatriculaProvincial = medico.MatriculaProvincial;
            medicoDto.Especialidad = medico.Especialidad.ToString();
            medicoDto.Usuario = medico.Usuario;
            medicoDto.UsuarioId = medico.UsuarioID;
            medicoDto.Password = medico.Password;
            medicoDto.UltimoLogin = medico.UltimoLogin;
            medicoDto.Activo = medico.Activo;
            medicoDto.TipoUsuario = medico.TipoUsuario.ToString();

            return medicoDto;
        }

        private static BEMedico Mapear(MedicoDto medicoDto)
        {
            BEMedico medico = new BEMedico();
            BEDomicilio domicilio = new BEDomicilio();
            medico.ProfesionalId = medicoDto.ProfesionalId;
            medico.Apellido = medicoDto.Apellido;
            medico.Nombre = medicoDto.Nombre;
            medico.DNI = medicoDto.DNI;
            medico.FechaNacimiento = medicoDto.FechaNacimiento;
            medico.Sexo = medicoDto.Sexo;
            medico.EstadoCivil = medicoDto.EstadoCivil;
            medico.Telefono = medicoDto.Telefono;
            medico.Email = medicoDto.Email;
            medico.Domicilio = domicilio;
            medico.Domicilio.Calle = medicoDto.Domicilio.Calle;
            medico.Domicilio.Numero = medicoDto.Domicilio.Numero;
            medico.Domicilio.Piso = medicoDto.Domicilio.Piso;
            medico.Domicilio.Localidad = medicoDto.Domicilio.Localidad;
            medico.Domicilio.Provincia = medicoDto.Domicilio.Provincia;
            medico.Domicilio.Pais = medicoDto.Domicilio.Pais;
            medico.MatriculaNacional = medicoDto.MatriculaNacional;
            medico.MatriculaProvincial = medicoDto.MatriculaProvincial;
            medico.Especialidad = (Especialidad)Enum.Parse(typeof(Especialidad), medicoDto.Especialidad.ToString());
            medico.Usuario = medicoDto.Usuario;
            medico.UsuarioID = medicoDto.UsuarioId;
            medico.Password = medicoDto.Password;
            medico.UltimoLogin = medicoDto.UltimoLogin;
            medico.Activo = medicoDto.Activo;
            medico.TipoUsuario = TipoUsuario.Medico;

            return medico;
        }

        //ENFERMERO
        public IList<EnfermeroDto> GetProfesionalesEnfermeros()
        {
            IList<BEEnfermero> enfermeros = this.bLEnfermero.BuscarEnfermeros("", "");
            IList<EnfermeroDto> enfermeroDto = new List<EnfermeroDto>();

            foreach (BEEnfermero enfermero in enfermeros)
            {
                enfermeroDto.Add(Mapear(enfermero));
            }
            return enfermeroDto;
        }

        public EnfermeroDto GetProfesionalEnfermero(int usuarioId)
        {
            IList<BEEnfermero> enfermeros = this.bLEnfermero.BuscarEnfermeros("", "");
            EnfermeroDto enfermeroDto = Mapear(enfermeros.Where(x => x.UsuarioID == usuarioId).FirstOrDefault());

            return enfermeroDto;
        }

        public EnfermeroDto CrearProfesionalEnfermero(EnfermeroDto enfermero)
        {
            BEEnfermero bEEnfermero = Mapear(enfermero);
            bEEnfermero.Password = HashHelper.HashMD5(enfermero.Apellido.Substring(0, 4) + enfermero.Nombre.Substring(0, 4));
            if (this.bLEnfermero.CrearProfesionalEnfermero(bEEnfermero))
            {
                return enfermero;
            }
            else
            {
                return null;
            }
        }

        public EnfermeroDto ActualizarProfesionalEnfermero(EnfermeroDto enfermero)
        {
            if (this.bLEnfermero.ActualizarProfesionalEnfermero(Mapear(enfermero), Mapear(enfermero)))
            {
                return enfermero;
            }
            else
            {
                return null;
            }
        }

        public EnfermeroDto BorrarProfesionalEnfermero(int usuarioId)
        {
            BEEnfermero beEnfermero = new BEEnfermero();
            beEnfermero.UsuarioID = usuarioId;
            if (this.bLEnfermero.InactivarEnfermero(beEnfermero))
            {
                EnfermeroDto enfermeroDto = new EnfermeroDto();
                enfermeroDto.UsuarioId = usuarioId;
                return enfermeroDto;
            }
            else
            {
                return new EnfermeroDto();
            }
        }

        private static EnfermeroDto Mapear(BEEnfermero enfermero)
        {
            EnfermeroDto enfermeroDto = new EnfermeroDto();
            DomicilioDto domicilioDto = new DomicilioDto();
            enfermeroDto.ProfesionalId = enfermero.ProfesionalId;
            enfermeroDto.Apellido = enfermero.Apellido;
            enfermeroDto.Nombre = enfermero.Nombre;
            enfermeroDto.DNI = enfermero.DNI;
            enfermeroDto.FechaNacimiento = enfermero.FechaNacimiento;
            enfermeroDto.Sexo = enfermero.Sexo;
            enfermeroDto.EstadoCivil = enfermero.EstadoCivil;
            enfermeroDto.Telefono = enfermero.Telefono;
            enfermeroDto.Email = enfermero.Email;
            enfermeroDto.Domicilio = domicilioDto;
            enfermeroDto.Domicilio.Calle = enfermero.Domicilio.Calle;
            enfermeroDto.Domicilio.Numero = enfermero.Domicilio.Numero;
            enfermeroDto.Domicilio.Piso = enfermero.Domicilio.Piso;
            enfermeroDto.Domicilio.Localidad = enfermero.Domicilio.Localidad;
            enfermeroDto.Domicilio.Provincia = enfermero.Domicilio.Provincia;
            enfermeroDto.Domicilio.Pais = enfermero.Domicilio.Pais;
            enfermeroDto.MatriculaEnfermero = enfermero.MatriculaEnfermero;
            enfermeroDto.Usuario = enfermero.Usuario;
            enfermeroDto.UsuarioId = enfermero.UsuarioID;
            enfermeroDto.Password = enfermero.Password;
            enfermeroDto.UltimoLogin = enfermero.UltimoLogin;
            enfermeroDto.Activo = enfermero.Activo;
            enfermeroDto.TipoUsuario = enfermero.TipoUsuario.ToString();

            return enfermeroDto;
        }

        private static BEEnfermero Mapear(EnfermeroDto enfermeroDto)
        {
            BEEnfermero enfermero = new BEEnfermero();
            BEDomicilio domicilio = new BEDomicilio();
            enfermero.ProfesionalId = enfermeroDto.ProfesionalId;
            enfermero.Apellido = enfermeroDto.Apellido;
            enfermero.Nombre = enfermeroDto.Nombre;
            enfermero.DNI = enfermeroDto.DNI;
            enfermero.FechaNacimiento = enfermeroDto.FechaNacimiento;
            enfermero.Sexo = enfermeroDto.Sexo;
            enfermero.EstadoCivil = enfermeroDto.EstadoCivil;
            enfermero.Telefono = enfermeroDto.Telefono;
            enfermero.Email = enfermeroDto.Email;
            enfermero.Domicilio = domicilio;
            enfermero.Domicilio.Calle = enfermeroDto.Domicilio.Calle;
            enfermero.Domicilio.Numero = enfermeroDto.Domicilio.Numero;
            enfermero.Domicilio.Piso = enfermeroDto.Domicilio.Piso;
            enfermero.Domicilio.Localidad = enfermeroDto.Domicilio.Localidad;
            enfermero.Domicilio.Provincia = enfermeroDto.Domicilio.Provincia;
            enfermero.Domicilio.Pais = enfermeroDto.Domicilio.Pais;
            enfermero.MatriculaEnfermero = enfermeroDto.MatriculaEnfermero;
            enfermero.Usuario = enfermeroDto.Usuario;
            enfermero.UsuarioID = enfermeroDto.UsuarioId;
            enfermero.Password = enfermeroDto.Password;
            enfermero.UltimoLogin = enfermeroDto.UltimoLogin;
            enfermero.Activo = enfermeroDto.Activo;
            enfermero.TipoUsuario = TipoUsuario.Enfermero;

            return enfermero;
        }

        private static BETurnoDisponible Mapear(TurnoDisponibleDto turnoDisponibleDto)
        {
            BETurnoDisponible turnoDisponible = new BETurnoDisponible();
            turnoDisponible.TurnoDisponibleId = turnoDisponibleDto.TurnoDisponibleId;
            turnoDisponible.DiaSemana = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), turnoDisponibleDto.DiaSemana);
            turnoDisponible.HoraDesde = turnoDisponibleDto.HoraDesde;
            turnoDisponible.HoraHasta = turnoDisponibleDto.HoraHasta;

            return turnoDisponible;
        }

        private static TurnoDisponibleDto Mapear(BETurnoDisponible bETurnoDisponible)
        {
            TurnoDisponibleDto turnoDisponibleDto = new TurnoDisponibleDto();
            turnoDisponibleDto.TurnoDisponibleId = bETurnoDisponible.TurnoDisponibleId;
            turnoDisponibleDto.DiaSemana = bETurnoDisponible.DiaSemana.ToString();
            turnoDisponibleDto.HoraDesde = bETurnoDisponible.HoraDesde;
            turnoDisponibleDto.HoraHasta = bETurnoDisponible.HoraHasta;

            return turnoDisponibleDto;
        }

        private static BETurno Mapear(TurnoDto turnoDto)
        {
            BETurno turno = new BETurno();
            BECentroMedico centroMedico = new BECentroMedico();
            BEDomicilio domicilio = new BEDomicilio();
            BEDomicilio domicilioProfesional = new BEDomicilio();
            BEProfesional bEProfesional = new BEProfesional();
            BEPaciente bEPaciente = new BEPaciente();

            centroMedico.CentroMedicoId = turnoDto.CentroMedico.CentroMedicoId;
            centroMedico.Nombre = turnoDto.CentroMedico.Nombre;
            centroMedico.Domicilio = domicilio;
            centroMedico.Domicilio.Calle = turnoDto.CentroMedico.Domicilio.Calle;
            centroMedico.Domicilio.Numero = turnoDto.CentroMedico.Domicilio.Numero;
            centroMedico.Domicilio.Piso = turnoDto.CentroMedico.Domicilio.Piso;
            centroMedico.Domicilio.Localidad = turnoDto.CentroMedico.Domicilio.Localidad;
            centroMedico.Domicilio.Provincia = turnoDto.CentroMedico.Domicilio.Provincia;
            centroMedico.Domicilio.Pais = turnoDto.CentroMedico.Domicilio.Pais;
            turno.CentroMedico = centroMedico;

            bEProfesional.ProfesionalId = turnoDto.Profesional.ProfesionalId;
            bEProfesional.Apellido = turnoDto.Profesional.Apellido;
            bEProfesional.Nombre = turnoDto.Profesional.Nombre;
            bEProfesional.Domicilio = domicilioProfesional;
            bEProfesional.Domicilio.Calle = turnoDto.Profesional.Domicilio.Calle;
            bEProfesional.Domicilio.Numero = turnoDto.Profesional.Domicilio.Numero;
            bEProfesional.Domicilio.Piso = turnoDto.Profesional.Domicilio.Piso;
            bEProfesional.Domicilio.Localidad = turnoDto.Profesional.Domicilio.Localidad;
            bEProfesional.Domicilio.Provincia = turnoDto.Profesional.Domicilio.Provincia;
            bEProfesional.Domicilio.Pais = turnoDto.Profesional.Domicilio.Pais;
            turno.Profesional = bEProfesional;

            bEPaciente.PacienteId = turnoDto.Paciente.PacienteId;
            bEPaciente.UsuarioID = turnoDto.Paciente.UsuarioId;
            bEPaciente.Apellido = turnoDto.Paciente.Apellido;
            bEPaciente.Nombre = turnoDto.Paciente.Nombre;
            bEPaciente.DNI = turnoDto.Paciente.DNI;
            bEPaciente.FechaNacimiento = turnoDto.Paciente.FechaNacimiento;
            bEPaciente.Sexo = turnoDto.Paciente.Sexo;
            bEPaciente.EstadoCivil = turnoDto.Paciente.EstadoCivil;
            bEPaciente.Telefono = turnoDto.Paciente.Telefono;
            bEPaciente.Email = turnoDto.Paciente.Telefono;
            bEPaciente.CoberturaMedica = new BECoberturaMedicaPaciente();
            if (bEPaciente.CoberturaMedica != null)
            {
                bEPaciente.CoberturaMedica.CoberturaMedicaId = turnoDto.Paciente.CoberturaMedica.CoberturaMedicaId;
                bEPaciente.CoberturaMedica.Nombre = turnoDto.Paciente.CoberturaMedica.Nombre;
                bEPaciente.CoberturaMedica.NumeroAfiliado = turnoDto.Paciente.CoberturaMedica.NumeroAfiliado;
                bEPaciente.CoberturaMedica.FechaVencimiento = turnoDto.Paciente.CoberturaMedica.FechaVencimiento;
                bEPaciente.CoberturaMedica.Plan = new BECoberturaMedicaPlan();
                bEPaciente.CoberturaMedica.Plan.PlanId = turnoDto.Paciente.CoberturaMedica.Plan.PlanId;
                bEPaciente.CoberturaMedica.Plan.Nombre = turnoDto.Paciente.CoberturaMedica.Plan.Nombre;
            }
            bEPaciente.Usuario = turnoDto.Paciente.Usuario;
            bEPaciente.UsuarioID = turnoDto.Paciente.UsuarioId;
            turno.Paciente = bEPaciente;

            turno.TurnoId = turnoDto.TurnoId;
            turno.FechaTurno = turnoDto.FechaTurno;
            turno.Asistio = turnoDto.Asistio;
            turno.Comentarios = turnoDto.Comentarios;

            return turno;
        }

        private static TurnoDto Mapear(BETurno turno)
        {
            TurnoDto turnoDto = new TurnoDto();

            turnoDto.CentroMedico = new CentroMedicoDto();
            turnoDto.CentroMedico.CentroMedicoId = turno.CentroMedico.CentroMedicoId;
            turnoDto.CentroMedico.Nombre = turno.CentroMedico.Nombre;
            turnoDto.CentroMedico.Domicilio = new DomicilioDto();
            turnoDto.CentroMedico.Domicilio.Calle = turno.CentroMedico.Domicilio.Calle;
            turnoDto.CentroMedico.Domicilio.Numero = turno.CentroMedico.Domicilio.Numero;
            turnoDto.CentroMedico.Domicilio.Piso = turno.CentroMedico.Domicilio.Piso;
            turnoDto.CentroMedico.Domicilio.Localidad = turno.CentroMedico.Domicilio.Localidad;
            turnoDto.CentroMedico.Domicilio.Provincia = turno.CentroMedico.Domicilio.Provincia;
            turnoDto.CentroMedico.Domicilio.Pais = turno.CentroMedico.Domicilio.Pais;

            turnoDto.Profesional = new ProfesionalDto();
            turnoDto.Profesional.ProfesionalId = turno.Profesional.ProfesionalId;
            turnoDto.Profesional.Apellido = turno.Profesional.Apellido;
            turnoDto.Profesional.Nombre = turno.Profesional.Nombre;
            turnoDto.Profesional.Domicilio = new DomicilioDto();
            turnoDto.Profesional.Domicilio.Calle = turno.Profesional.Domicilio.Calle;
            turnoDto.Profesional.Domicilio.Numero = turno.Profesional.Domicilio.Numero;
            turnoDto.Profesional.Domicilio.Piso = turno.Profesional.Domicilio.Piso;
            turnoDto.Profesional.Domicilio.Localidad = turno.Profesional.Domicilio.Localidad;
            turnoDto.Profesional.Domicilio.Provincia = turno.Profesional.Domicilio.Provincia;
            turnoDto.Profesional.Domicilio.Pais = turno.Profesional.Domicilio.Pais;

            turnoDto.Paciente = new PacienteDto();
            turnoDto.Paciente.PacienteId = turno.Paciente.PacienteId;
            turnoDto.Paciente.UsuarioId = turno.Paciente.UsuarioID;
            turnoDto.Paciente.Apellido = turno.Paciente.Apellido;
            turnoDto.Paciente.Nombre = turno.Paciente.Nombre;
            turnoDto.Paciente.DNI = turno.Paciente.DNI;
            turnoDto.Paciente.FechaNacimiento = turno.Paciente.FechaNacimiento;
            turnoDto.Paciente.Sexo = turno.Paciente.Sexo;
            turnoDto.Paciente.EstadoCivil = turno.Paciente.EstadoCivil;
            turnoDto.Paciente.Telefono = turno.Paciente.Telefono;
            turnoDto.Paciente.Email = turno.Paciente.Telefono;
            turnoDto.Paciente.CoberturaMedica = new CoberturaMedicaPacienteDto();
            if (turnoDto.Paciente.CoberturaMedica != null)
            {
                turnoDto.Paciente.CoberturaMedica.CoberturaMedicaId = turno.Paciente.CoberturaMedica.CoberturaMedicaId;
                turnoDto.Paciente.CoberturaMedica.Nombre = turno.Paciente.CoberturaMedica.Nombre;
                turnoDto.Paciente.CoberturaMedica.NumeroAfiliado = turno.Paciente.CoberturaMedica.NumeroAfiliado;
                turnoDto.Paciente.CoberturaMedica.FechaVencimiento = turno.Paciente.CoberturaMedica.FechaVencimiento;
                turnoDto.Paciente.CoberturaMedica.Plan = new CoberturaMedicaPlanDto();
                turnoDto.Paciente.CoberturaMedica.Plan.PlanId = turno.Paciente.CoberturaMedica.Plan.PlanId;
                turnoDto.Paciente.CoberturaMedica.Plan.Nombre = turno.Paciente.CoberturaMedica.Plan.Nombre;
            }
            turnoDto.Paciente.Usuario = turno.Paciente.Usuario;
            turnoDto.Paciente.UsuarioId = turno.Paciente.UsuarioID;

            turnoDto.TurnoId = turno.TurnoId;
            turnoDto.FechaTurno = turno.FechaTurno;
            turnoDto.Asistio = turno.Asistio;
            turnoDto.Comentarios = turno.Comentarios;

            return turnoDto;
        }

    }
}
    
   
