using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.BE.Permisos
{
    public abstract class ComponentePermiso
    {
        public int IDPermiso { get; set; }
        public TipoPermiso TipoPermiso { get; set; }
        public DateTime FechaCreacion { get; set; }
        public abstract void AgregarPermiso(ComponentePermiso permiso);
        public abstract void EliminarPermiso(ComponentePermiso permiso);
        public abstract IList<ComponentePermiso> ObtenerHijos();
    }
}
