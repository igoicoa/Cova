using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.BE.Permisos
{
    public class PermisosMaestro
    {
        public FamiliaPermisos PermisoMaestro { get; set; }

        public PermisosMaestro()
        {
            this.ConstruirArbolPermisos();
        }

        public void ConstruirArbolPermisos()
        {
            this.PermisoMaestro = new FamiliaPermisos(TipoPermiso.Raiz);

            //Administrar

            //Administrar Cuenta
            Permiso crearCuenta = new Permiso(TipoPermiso.CrearCuenta);
            Permiso modificarCuenta = new Permiso(TipoPermiso.ModificarCuenta);
            Permiso verUsuarios = new Permiso(TipoPermiso.VerUsuarios);

            FamiliaPermisos administrarCuenta = new FamiliaPermisos(TipoPermiso.AdministrarCuenta);
            administrarCuenta.AgregarPermiso(crearCuenta);
            administrarCuenta.AgregarPermiso(modificarCuenta);
            administrarCuenta.AgregarPermiso(verUsuarios);

            //Administrar Vacunas
            Permiso calendarioVacunacion = new Permiso(TipoPermiso.CalendarioVacunacion);
            Permiso crearVacuna = new Permiso(TipoPermiso.CrearVacunas);
            Permiso modificarVacunas = new Permiso(TipoPermiso.ModificarVacunas);
            Permiso verVacunas = new Permiso(TipoPermiso.VerVacunas);

            FamiliaPermisos administrarVacunas = new FamiliaPermisos(TipoPermiso.AdministrarVacunas);
            administrarVacunas.AgregarPermiso(calendarioVacunacion);
            administrarVacunas.AgregarPermiso(crearVacuna);
            administrarVacunas.AgregarPermiso(modificarVacunas);
            administrarVacunas.AgregarPermiso(verVacunas);

            //Administrar Turnos


            FamiliaPermisos administrar = new FamiliaPermisos(TipoPermiso.Administrar);
            administrar.AgregarPermiso(administrarCuenta);
            administrar.AgregarPermiso(administrarVacunas);

            //Permiso maestro
            //this.PermisoMaestro.AgregarPermiso(inicio);
            this.PermisoMaestro.AgregarPermiso(administrar);
        }
    }
}
