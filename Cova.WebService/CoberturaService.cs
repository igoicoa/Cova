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

        public IList<CoberturaMedicaDto> GetCoberturas()
        {
            IList<BECoberturaMedica> coberturas = this.bLCoberturaMedica.ObtenerCoberturasMedicas();
            IList<CoberturaMedicaDto> coberturasDtos = new List<CoberturaMedicaDto>();

            foreach (BECoberturaMedica cobertura in coberturas)
            {

                coberturasDtos.Add(Mapear(cobertura));
            }
            return coberturasDtos;
        }

        public CoberturaMedicaDto GetCobertura(int coberturaId)
        {
            List<BECoberturaMedica> coberturasMedica = bLCoberturaMedica.ObtenerCoberturasMedicas().ToList();
            BECoberturaMedica coberturaMedica = coberturasMedica.Where(x => x.CoberturaMedicaId == coberturaId).FirstOrDefault();
            CoberturaMedicaDto coberturaMedicaDto = Mapear(coberturaMedica);

            coberturaMedicaDto.Plan =
                coberturaMedica.Plan.Select(plan => new CoberturaMedicaPlanDto()
                {
                    PlanId = plan.PlanId,
                    Nombre = plan.Nombre
                }).ToList();


            return coberturaMedicaDto;
        }

        public CoberturaMedicaDto CrearCobertura(CoberturaMedicaDto coberturaMedicaDto)
        {
            if (this.bLCoberturaMedica.CrearCoberturaMedica(Mapear(coberturaMedicaDto)))
            {
                return coberturaMedicaDto;
            }
            else
            {
                return null;
            }
        }

        public CoberturaMedicaDto ActualizarCobertura(CoberturaMedicaDto coberturaMedicaDto)
        {
            if (this.bLCoberturaMedica.ModificarCoberturaMedica(Mapear(coberturaMedicaDto)))
            {
                return coberturaMedicaDto;
            }
            else
            {
                return null;
            }
        }
        public CoberturaMedicaDto BorrarCobertura(int coberturaMedicaId)
        {
            BECoberturaMedica bECoberturaMedica = new BECoberturaMedica();
            bECoberturaMedica.CoberturaMedicaId = coberturaMedicaId;
            if (this.bLCoberturaMedica.EliminarCoberturaMedica(bECoberturaMedica))
            {
                CoberturaMedicaDto coberturaMedicaDto = new CoberturaMedicaDto();
                coberturaMedicaDto.CoberturaMedicaId = coberturaMedicaId;
                return coberturaMedicaDto;
            }
            else
            {
                return new CoberturaMedicaDto();
            }
        }

        private static CoberturaMedicaDto Mapear(BECoberturaMedica coberturaMedica)
        {
            CoberturaMedicaDto coberturaMedicaDto = new CoberturaMedicaDto();
            List<CoberturaMedicaPlanDto> coberturaMedicaPlanDto = new List<CoberturaMedicaPlanDto>();
            coberturaMedicaDto.CoberturaMedicaId = coberturaMedica.CoberturaMedicaId;
            coberturaMedicaDto.Nombre = coberturaMedica.Nombre;
            coberturaMedicaDto.Plan = coberturaMedica.Plan.Select(plan => new CoberturaMedicaPlanDto()
            {
                PlanId = plan.PlanId,
                Nombre = plan.Nombre
            }).ToList();

            return coberturaMedicaDto;
        }
        private static BECoberturaMedica Mapear(CoberturaMedicaDto coberturaMedicaDto)
        {
            BECoberturaMedica coberturaMedica = new BECoberturaMedica();
            List<BECoberturaMedicaPlan> coberturaMedicaPlan = new List<BECoberturaMedicaPlan>();
            coberturaMedica.CoberturaMedicaId = coberturaMedicaDto.CoberturaMedicaId;
            coberturaMedica.Nombre = coberturaMedicaDto.Nombre;
            coberturaMedica.Plan = (List<BECoberturaMedicaPlan>)coberturaMedicaDto.Plan;

            return coberturaMedica;
        }

    }
}
