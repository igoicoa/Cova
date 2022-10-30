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
    public class CoberturaService
    {
        private BLCoberturaMedica bLCoberturaMedica = new BLCoberturaMedica();

        public IList<CoberturaMedicaPlanDto> GetCoberturas()
        {
            IList<BECoberturaMedica> recetas = this.BLCoberturaMedica.ObtenerCoberturasMedicas(new BECoberturaMedica());
            IList<RecetaDto> recetaDtos = new List<RecetaDto>();

            foreach (BEReceta receta in recetas)
            {
                recetaDtos.Add(Mapear(receta));
            }
            return recetaDtos;
        }

        public IList<RecetaDto> GetCobertura(int pacienteId)
        {
            BEPaciente bEPaciente = new BEPaciente();
            bEPaciente.PacienteId = pacienteId;
            IList<BEReceta> recetas = this.BLCoberturaMedica.BuscarRecetas(bEPaciente);
            IList<RecetaDto> recetasDtos = new List<RecetaDto>();
            foreach (BEReceta receta in recetas)
            {
                recetasDtos.Add(Mapear(receta));
            }

            return recetasDtos;
        }

        public RecetaDto CrearCobertura(RecetaDto recetaDtos)
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

        public RecetaDto ActualizarCobertura(RecetaDto receta)
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
        public PacienteDto BorrarCobertura(int usuarioId)
        {
            BEPaciente bEPaciente = new BEPaciente();
            bEPaciente.UsuarioID = usuarioId;
            if (this.bLPaciente.InactivarPaciente(bEPaciente))
            {
                PacienteDto pacienteDto = new PacienteDto();
                pacienteDto.UsuarioID = usuarioId;
                return pacienteDto;
            }
            else
            {
                return new PacienteDto();
            }
        }

    }
}
