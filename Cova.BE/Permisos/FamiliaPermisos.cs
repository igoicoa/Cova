using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.BE.Permisos
{
    public class FamiliaPermisos : ComponentePermiso
    {
        private IList<ComponentePermiso> _hijos;

        public FamiliaPermisos(TipoPermiso tipoPermiso) : base(tipoPermiso)
        {
            _hijos = new List<ComponentePermiso>();
        }

        public override void AgregarPermiso(ComponentePermiso permiso)
        {
            if (!_hijos.Contains(permiso))
                _hijos.Add(permiso);
        }

        public override void EliminarPermiso(ComponentePermiso permiso)
        {
            if (_hijos.Contains(permiso))
                _hijos.Remove(permiso);
        }

        public override IList<ComponentePermiso> ObtenerHijos()
        {
            return _hijos.ToArray();
        }

        public override bool TienePermiso(TipoPermiso tipoPermisoAVerificar)
        {
            bool tienePermiso = false;
            if (this.TipoPermiso == tipoPermisoAVerificar)
                return true;
            foreach (ComponentePermiso permiso in this._hijos)
            {
                tienePermiso = permiso.TienePermiso(tipoPermisoAVerificar);
                if (tienePermiso)
                    return tienePermiso;
            }
            return tienePermiso;
        }

    }
}
