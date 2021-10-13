using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.BE
{
    public class BECoberturaMedicaPlan
    {
        public int PlanId { get; set; }
        public string Nombre { get; set; }

        public BECoberturaMedicaPlan(string nombre)
        {
            this.Nombre = nombre;
        }

        public BECoberturaMedicaPlan()
        {

        }
    }
}
