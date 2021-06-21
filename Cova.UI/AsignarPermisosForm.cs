using System.Windows.Forms;
using Cova.BE.Permisos;
using Cova.Servicios.Sesion;

namespace Cova.UI
{
    public partial class AsignarPermisosForm : Form
    {
        public AsignarPermisosForm()
        {
            InitializeComponent();
            CargarPermisosMaestro();
        }

        public void CargarPermisosMaestro()
        {
            PermisosMaestro permisosMaestro = new PermisosMaestro();
            ComponentePermiso permisosUsuario = Sesion.GetInstance.Usuario.Permisos;
            this.tv_PermisosMaster.Nodes.Clear();
            this.tv_PermisosUsuario.Nodes.Clear();
            TreeNode raizPermisoMaestro = new TreeNode("Permisos");
            TreeNode raizPermisoUsuario = new TreeNode("Permisos Usuario");
            this.tv_PermisosMaster.Nodes.Add(raizPermisoMaestro);
            this.tv_PermisosUsuario.Nodes.Add(raizPermisoUsuario);
            MostrarPermisosRecursivo(permisosMaestro.PermisoMaestro, raizPermisoMaestro);
            MostrarPermisosRecursivo(permisosUsuario, raizPermisoUsuario);
        }

        private void MostrarPermisosRecursivo(ComponentePermiso componentePermiso, TreeNode nodoPadre)
        {
            foreach (ComponentePermiso permiso in componentePermiso.ObtenerHijos())
            {
                TreeNode nodoHijo = CrearNodo(permiso);
                nodoPadre.Nodes.Add(nodoHijo);


                if (permiso.ObtenerHijos().Count > 0)
                {
                    MostrarPermisosRecursivo(permiso, nodoHijo);
                }
            }
        }

        private TreeNode CrearNodo(ComponentePermiso componentePermiso)
        {
            TreeNode nuevoNodo = new TreeNode(componentePermiso.TipoPermiso.ToString());
            nuevoNodo.Tag = componentePermiso;

            return nuevoNodo;
        }

    }
}
