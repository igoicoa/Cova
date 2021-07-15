using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.BE
{
    public class BECoberturaMedica
    {
        public int CoberturaMedicaId { get; set; }
        public string Nombre { get; set; }
        public IList<BECoberturaMedicaPlan> Plan { get; set; }

        public BECoberturaMedica()
        {
            this.Plan = new List<BECoberturaMedicaPlan>();
        }
    }
}
