using System;
using System.Collections.Generic;
using Cova.Common.Constantes;

namespace Cova.Common.Utils
{
    public static class CalendarioUtils
    {

        public static IEnumerable<DateTime> ObtenerDias(DateTime desde, DateTime hasta)
        {
            for (var dia = desde.Date; dia.Date <= hasta.Date; dia = dia.AddDays(1))
            {
                yield return dia;
            }
        }

        public static IEnumerable<DateTime> ObtenerRangoHorario(DateTime diaHoraDesde, DateTime diaHoraHasta)
        {
            for (var dia = diaHoraDesde.Date; dia.Date <= diaHoraHasta.Date; dia = dia.AddMinutes(Constantes.Constantes.DURACION_TURNO))
            {
                yield return dia;
            }
        }

        public static DateTime CambiarHorario(this DateTime fecha, int horas, int minutos, int segundos = 0, int milisegundos = 0)
        {
            return new DateTime(
                fecha.Year,
                fecha.Month,
                fecha.Day,
                horas,
                minutos,
                segundos,
                milisegundos,
                fecha.Kind);
        }

    }
}
