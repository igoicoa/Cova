using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cova.BL;
using Cova.BE;
using Cova.WebService.Dtos;

namespace Cova.WebService
{
    public class ProfesionalService
    {
        private BLProfesional bLProfesional = new BLProfesional();
        private BLMedico blMedico = new BLMedico();
        private BLEnfermero bLEnfermero = new BLEnfermero();

        public IList<MedicoDto> GetProfesionalesMedicos() 
        {
            return new List<MedicoDto>();
        }

        public MedicoDto GetProfesionalMedico(int usuarioId)
        {
            IList<BEMedico> medicos = this.blMedico.BuscarMedicos(usuarioId, "", "");
            MedicoDto medicoDto = Mapear(medicos.Where(x => x.UsuarioID == usuarioId).FirstOrDefault());

            return medicoDto;
        }

        public IList<TurnosDisponibleDto> GetProfesionalMedicoHorarios(int usuarioId)
        {
            IList<BEMedico> medicos = this.blMedico.BuscarMedicos(usuarioId, "", "");
            MedicoDto medicoDto = Mapear(medicos.Where(x => x.UsuarioID == usuarioId).FirstOrDefault());
            IList<TurnosDisponibleDto> horariosMedico = medicoDto.TurnosDisponibles;

            return horariosMedico;
        }

        public ProfesionalDto GuardarProfesionalMedicoHorarios(int profesionalId, IList<TurnosDisponibleDto> turnosDisponiblesDto)
        {
            BEProfesional bEProfesional = new BEProfesional();
            bEProfesional.ProfesionalId = profesionalId;
            bEProfesional.TurnosDisponibles = Mapear(turnosDisponiblesDto);
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

        public IList<TurnosDisponibleDto> GetProfesionalMedicoTurnosDisponibles(int profesionalId, DateTime fechadesde, DateTime fechahasta)
        {
            BEProfesional bEProfesional = new BEProfesional();
            bEProfesional.ProfesionalId = profesionalId;
            IList<TurnosDisponibleDto> turnosDisponibles = Mapear(this.bLProfesional.ObtenerTurnosLibres(bEProfesional, fechadesde, fechahasta));

            return turnosDisponibles;
        }

        public MedicoDto CrearProfesionalMedico(MedicoDto medico)
        {
            if (this.blMedico.CrearProfesionalMedico(Mapear(medico)))
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
                medicoDto.UsuarioID = usuarioId;
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
            medicoDto.UsuarioID = medico.UsuarioID;
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
            medico.Especialidad = medicoDto.Especialidad;
            medico.Usuario = medicoDto.Usuario;
            medico.UsuarioID = medicoDto.UsuarioID;
            medico.Password = medicoDto.Password;
            medico.UltimoLogin = medicoDto.UltimoLogin;
            medico.Activo = medicoDto.Activo;
            medico.TipoUsuario = medicoDto.TipoUsuario;

            return medico;
        }

        //ENFERMERO
        public IList<EnfermeroDto> GetProfesionalesEnfermeros()
        {
            return new List<EnfermeroDto>();
        }

        public EnfermeroDto GetProfesionalEnfermero(int usuarioId)
        {
            IList<BEEnfermero> enfermeros = this.bLEnfermero.BuscarEnfermeros("", "");
            EnfermeroDto enfermeroDto = Mapear(enfermeros.Where(x => x.UsuarioID == usuarioId).FirstOrDefault());

            return enfermeroDto;
        }

        public EnfermeroDto CrearProfesionalEnfermero(EnfermeroDto enfermero)
        {
            if (this.bLEnfermero.CrearProfesionalEnfermero(Mapear(enfermero)))
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
                enfermeroDto.UsuarioID = usuarioId;
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
            enfermeroDto.UsuarioID = enfermero.UsuarioID;
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
            enfermero.Domicilio.Calle = enfermero.Domicilio.Calle;
            enfermero.Domicilio.Numero = enfermero.Domicilio.Numero;
            enfermero.Domicilio.Piso = enfermero.Domicilio.Piso;
            enfermero.Domicilio.Localidad = enfermero.Domicilio.Localidad;
            enfermero.Domicilio.Provincia = enfermero.Domicilio.Provincia;
            enfermero.Domicilio.Pais = enfermero.Domicilio.Pais;
            enfermero.MatriculaEnfermero = enfermeroDto.MatriculaEnfermero;
            enfermero.Usuario = enfermeroDto.Usuario;
            enfermero.UsuarioID = enfermeroDto.UsuarioID;
            enfermero.Password = enfermeroDto.Password;
            enfermero.UltimoLogin = enfermeroDto.UltimoLogin;
            enfermero.Activo = enfermeroDto.Activo;
            enfermero.TipoUsuario = enfermeroDto.TipoUsuario;

            return enfermero;
        }

    }
}
    
   
