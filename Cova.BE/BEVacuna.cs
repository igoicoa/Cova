using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.BE
{
    public class BEVacuna
    {
        public long Lote { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Prospecto { get; set; }
        public string Contraindicaciones { get; set; }
        public int CantidadDosis { get; set; }
        public DateTime FechaElaboracion { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public int Stock { get; set; }
        public BELaboratorio Laboratorio { get; set; }
    }
}
