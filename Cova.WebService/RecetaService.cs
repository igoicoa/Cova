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
    public class RecetaService
    {
        private BLReceta bLReceta = new BLReceta();

        public IList<RecetaDto> GetRecetas()
        {
            IList<BEReceta> recetas = this.bLReceta.BuscarRecetas(new BEPaciente());
            IList<RecetaDto> recetaDtos = new List<RecetaDto>();

            foreach (BEReceta receta in recetas)
            {
                recetaDtos.Add(Mapear(receta));
            }
            return recetaDtos;
        }

        public IList<RecetaDto> GetRecetasUsuario(int pacienteId)
        {
            BEPaciente bEPaciente = new BEPaciente();
            bEPaciente.PacienteId = pacienteId;
            IList<BEReceta> recetas = this.bLReceta.BuscarRecetas(bEPaciente);
            IList<RecetaDto> recetasDtos = new List<RecetaDto>();
            foreach (BEReceta receta in recetas)
            {
                recetasDtos.Add(Mapear(receta));
            }

            return recetasDtos;
        }

        public RecetaDto CrearReceta(RecetaDto recetaDtos)
        {
            if (this.bLReceta.CrearReceta(Mapear(recetaDtos)))
            {
                return recetaDtos;
            }
            else
            {
                return null;
            }
        }

        public RecetaDto ActualizarReceta(RecetaDto receta)
        {
            if (this.bLReceta.ActualizarReceta(Mapear(receta)))
            {
                return receta;
            }
            else
            {
                return null;
            }
        }

        //public RecetaDto BorrarCertificado(int certificadoId)
        //{
        //    return certificadoId;
        //}

        private static RecetaDto Mapear(BEReceta receta)
        {
            RecetaDto recetaDto = new RecetaDto();
            MedicoDto medicoDto = new MedicoDto();
            PacienteDto pacienteDto = new PacienteDto();
            medicoDto.ProfesionalId = receta.Medico.ProfesionalId;
            recetaDto.FechaPrescripcion = receta.FechaPrescripcion;
            recetaDto.Observacion = receta.Observacion;
            pacienteDto.PacienteId = receta.Paciente.PacienteId;

            return recetaDto;
        }

        private static BEReceta Mapear(RecetaDto recetaDto)
        {
            BEReceta receta = new BEReceta();
            BEPaciente paciente = new BEPaciente();
            BEMedico medico = new BEMedico();
            medico.ProfesionalId = recetaDto.Medico.ProfesionalId;
            receta.FechaPrescripcion = recetaDto.FechaPrescripcion;
            receta.Observacion = recetaDto.Observacion;
            paciente.PacienteId = recetaDto.Paciente.PacienteId;

            return receta;
        }
    }
}
