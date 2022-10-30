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

        public IList<TurnosDisponibleDto> GetRecetas()
        {
            IList<BETurno> turnos = this.bLTurno.ValidarDisponibilidadTurno(new BETurno());
            IList<TurnosDisponibleDto> turnoDtos = new List<TurnosDisponibleDto>();

            foreach (BETurno turno in turnos)
            {
                turnoDtos.Add(Mapear(turno));
            }
            return turnoDtos;
        }

        public IList<TurnosDisponibleDto> GetRecetasUsuario(int turnoId)
        {
            BETurno bETurno = new BETurno();
            bETurno.TurnoId = turnoId;
            IList<BETurno> turnos = this.bLTurno.ObtenerTurnos(bETurno);
            IList<TurnosDisponibleDto> turnosDtos = new List<TurnosDisponibleDto>();
            foreach (BETurno turno in turnos)
            {
                turnosDtos.Add(Mapear(turno));
            }

            return turnosDtos;
        }

        public TurnosDisponibleDto CrearTurno(TurnosDisponibleDto turnosDtos)
        {
            if (this.bLTurno.CrearTurno(Mapear(turnosDtos)))
            {
                return turnosDtos;
            }
            else
            {
                return null;
            }
        }

        public TurnosDisponibleDto ActualizarTurno(TurnosDisponibleDto turno)
        {
            if (this.bLTurno.ActualizarTurno(Mapear(turno)))
            {
                return turno;
            }
            else
            {
                return null;
            }
        }

        public TurnosDisponibleDto Borrarturno(int turnoId)
        {
            BEPaciente bEPaciente = new BEPaciente();
            bEPaciente.UsuarioID = turnoId;
            if (this.bLTurno.InactivarTurno(bETurno))
            {
                TurnosDisponibleDto turnoDto = new TurnosDisponibleDto();
                turnoDto.UsuarioID = turnoId;
                return turnoDto;
            }
            else
            {
                return new TurnosDisponibleDto();
            }
        }

        private static TurnosDisponibleDto Mapear(BETurnoDisponible turnoDisponible)
        {
            TurnosDisponibleDto turnoDisponibleDto = new TurnosDisponibleDto();

            turnoDisponibleDto.TurnoDisponibleId = turnoDisponible.TurnoDisponibleId;
            turnoDisponibleDto.DiaSemana = turnoDisponible.DiaSemana.ToString();
            turnoDisponibleDto.HoraDesde = turnoDisponible.HoraDesde;
            turnoDisponibleDto.HoraHasta = turnoDisponible.HoraHasta;

            return turnoDisponibleDto;
        }

        private static BETurnoDisponible Mapear(TurnosDisponibleDto turnosDisponibleDto)
        {
            BETurnoDisponible turnoDisponible = new BETurnoDisponible();
            turnoDisponible.TurnoDisponibleId= turnosDisponibleDto.TurnoDisponibleId;
            turnoDisponible.DiaSemana = turnosDisponibleDto.DiaSemana;
            turnoDisponible.HoraDesde = turnosDisponibleDto.HoraDesde;
            turnoDisponible.HoraHasta = turnosDisponibleDto.HoraHasta;

            return turnoDisponible;
        }
    }
}
