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

        public IList<RecetaDto> GetReceta()
        {
            IList<BEReceta> recetas = this.bLReceta.BuscarRecetas();
            IList<RecetaDto> recetaDtos = new List<RecetaDto>();

            foreach (BEReceta receta in recetas)
            {
                recetaDtos.Add(Mapear(receta));
            }
            return recetaDtos;
        }

        public RecetaDto GetReceta(int recetaId)
        {
            IList<BEReceta> recetas = this.bLReceta.BuscarRecetas();
            RecetaDto recetaDtos = Mapear(recetas.FirstOrDefault(x => x.RecetaId == recetaId));

            return recetaDtos;
        }

        public RecetaDto CrearReceta(RecetaDto recetaDtos)
        {
            if (this.bLReceta.ActualizarReceta(Mapear(receta)))
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
            if (this.bLReceta.ActualizarReceta(Mapear(receta), Mapear(receta)))
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

        private static RecetaDto Mapear(BEReceta receta, BEMedico medico, BEPaciente paciente)
        {
            RecetaDto recetaDto = new RecetaDto();
            MedicoDto medicoDto = new MedicoDto();
            PacienteDto pacienteDto = new PacienteDto();
            medicoDto.ProfesionalId = medico.ProfesionalId;
            recetaDto.FechaPrescripcion = receta.FechaPrescripcion;
            recetaDto.Observacion = receta.Observacion;
            pacienteDto.PacienteId = paciente.PacienteId;

            return recetaDto;
        }

        private static BEReceta Mapear(RecetaDto recetaDto, MedicoDto medicoDto, PacienteDto pacienteDto)
        {
            BEReceta receta = new BEReceta();
            BEPaciente paciente = new BEPaciente();
            BEMedico medico = new BEMedico();
            medico.ProfesionalId = medicoDto.ProfesionalId;
            receta.FechaPrescripcion = recetaDto.FechaPrescripcion;
            receta.Observacion = recetaDto.Observacion;
            paciente.PacienteId = pacienteDto.PacienteId;

            return receta;
        }
    }
}
