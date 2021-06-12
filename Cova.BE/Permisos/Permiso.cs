using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.BE.Permisos
{
    public class Permiso : ComponentePermiso
    {
        public Permiso(TipoPermiso tipoPermiso) : base(tipoPermiso)
        {

        }

        public override void AgregarPermiso(ComponentePermiso p)
        {
            throw new NotImplementedException();
        }

        public override void EliminarPermiso(ComponentePermiso p)
        {
            throw new NotImplementedException();
        }

        public override IList<ComponentePermiso> ObtenerHijos()
        {
            throw new NotImplementedException();
        }

        public override bool TienePermiso(TipoPermiso tipoPermiso)
        {
            return tipoPermiso == this.TipoPermiso;
        }
        
    }
}
