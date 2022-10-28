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
        public MedicoDto GetMedico(int usuarioId)
        {
            IList<BEMedico> medicos = this.blMedico.BuscarMedicos("", "");
            MedicoDto medicoDto = Mapear(medicos.Where(x => x.UsuarioID == usuarioId).FirstOrDefault());

            return medicoDto;
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

        //public MedicoDto BorrarMedico(int usuarioId)
        //{
        //    return usuarioId;
        //}

        private static MedicoDto Mapear(BEMedico medico)
        {
            MedicoDto medicoDto = new MedicoDto();
            medicoDto.ProfesionalId = medico.ProfesionalId; //llamo al profesional ID y no al usuario ID
            medicoDto.Apellido = medico.Apellido;
            medicoDto.Nombre = medico.Nombre;
            medicoDto.Sexo = medico.Sexo;

            return medicoDto;
        }

        private static BEMedico Mapear(MedicoDto medicoDto)
        {
            BEMedico medico = new BEMedico();
            medico.ProfesionalId = medicoDto.ProfesionalId; //llamo al profesional ID y no al usuario ID
            medico.Apellido = medicoDto.Apellido;
            medico.Nombre = medicoDto.Nombre;
            medico.Sexo = medicoDto.Sexo;
            //medico.Especialidad = medicoDto.Especialidad;


            return medico;
        }

        //ENFERMERO
        public IList<EnfermeroDto> GetProfesionalesEnfermeros()
        {
            return new List<EnfermeroDto>();
        }

        public EnfermeroDto GetEnfermero (int usuarioId)
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

        //public MedicoDto BorrarEnfermero (int usuarioId)
        //{
        //    return usuarioId;
        //}

        private static EnfermeroDto Mapear(BEEnfermero enfermero)
        {
            EnfermeroDto enfermeroDto = new EnfermeroDto();
            enfermeroDto.ProfesionalId = enfermero.ProfesionalId; //llamo al profesional ID y no al usuario ID
            enfermeroDto.Apellido = enfermero.Apellido;
            enfermeroDto.Nombre = enfermero.Nombre;
            enfermeroDto.Sexo = enfermero.Sexo;

            return enfermeroDto;
        }

        private static BEEnfermero Mapear(EnfermeroDto enfermeroDto)
        {
            BEEnfermero enfermero = new BEEnfermero();
            enfermero.ProfesionalId = enfermeroDto.ProfesionalId; //llamo al profesional ID y no al usuario ID
            enfermero.Apellido = enfermeroDto.Apellido;
            enfermero.Nombre = enfermeroDto.Nombre;
            enfermero.Sexo = enfermeroDto.Sexo;

            return enfermero;
        }

    }
}
    
   
