using System;
using System.Collections.Generic;

namespace Cova.Common.Permisos
{
    public abstract class ComponentePermiso
    {
        public TipoPermiso TipoPermiso { get; set; }
        public DateTime FechaCreacion { get; set; }
        public abstract void AgregarPermiso(ComponentePermiso permiso);
        public abstract void EliminarPermiso(ComponentePermiso permiso);
        public abstract IList<ComponentePermiso> ObtenerHijos();
        public abstract bool TienePermiso(TipoPermiso tipoPermiso);

        public ComponentePermiso(TipoPermiso tipoPermiso)
        {
            this.TipoPermiso = tipoPermiso;
        }

    }
}

    
