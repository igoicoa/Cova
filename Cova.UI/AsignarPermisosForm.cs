using System.Windows.Forms;
using Cova.BE.Permisos;
using Cova.Servicios.Sesion;
using Cova.BE;
using Cova.BL;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System;

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

        private void btn_buscar_Click(object sender, System.EventArgs e)
        {
            BLUsuario bLUsuario = new BLUsuario();
            string nombreABuscar = txt_usuarioNombre.Text;
            string apellidoABuscar = txt_usuarioApellido.Text;
            IList<BEUsuario> usuarios = bLUsuario.BuscarUsuarios(nombreABuscar, apellidoABuscar);
            DataTable tableUsuarios = new DataTable();
            tableUsuarios.Columns.Add("Apellido");
            tableUsuarios.Columns.Add("Nombre");
            tableUsuarios.Columns.Add("Email");
            tableUsuarios.Columns.Add("Usuario");
            tableUsuarios.Columns.Add("Tipo Usuario");
            tableUsuarios.Columns.Add("UsuarioID");
            foreach (BEProfesional usuario in usuarios.OfType<BEProfesional>())
            {
                DataRow filaUsuario = tableUsuarios.NewRow();
                filaUsuario["Apellido"] = usuario.Apellido;
                filaUsuario["Nombre"] = usuario.Nombre;
                filaUsuario["Email"] = usuario.Email;
                filaUsuario["Usuario"] = usuario.Usuario;
                filaUsuario["Tipo Usuario"] = "Profesional";
                filaUsuario["UsuarioID"] = usuario.UsuarioID;

                tableUsuarios.Rows.Add(filaUsuario);
            }
            foreach (BEPaciente usuario in usuarios.OfType<BEPaciente>())
            {
                DataRow filaUsuario = tableUsuarios.NewRow();
                filaUsuario["Apellido"] = usuario.Apellido;
                filaUsuario["Nombre"] = usuario.Nombre;
                filaUsuario["Email"] = usuario.Email;
                filaUsuario["Usuario"] = usuario.Usuario;
                filaUsuario["Tipo Usuario"] = "Paciente";
                filaUsuario["UsuarioID"] = usuario.UsuarioID;

                tableUsuarios.Rows.Add(filaUsuario);
            }
            dgv_usuarios.DataSource = tableUsuarios;
            dgv_usuarios.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuarios.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuarios.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuarios.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuarios.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuarios.Columns[5].Visible = false;

        }

        private void btn_seleccionar_Click(object sender, System.EventArgs e)
        {
            if (dgv_usuarios.SelectedRows.Count != 0)
            {
                long usuarioID = Convert.ToInt64(dgv_usuarios.SelectedRows[0].Cells["UsuarioID"].Value);
                BLUsuario bLUsuario = new BLUsuario();
                ComponentePermiso permisosUsuario = bLUsuario.ObtenerPermisosUsuario(usuarioID);
                this.tv_PermisosUsuario.Nodes.Clear();
                TreeNode raizPermisoUsuario = new TreeNode("Permisos Usuario");
                this.tv_PermisosUsuario.Nodes.Add(raizPermisoUsuario);
                MostrarPermisosRecursivo(permisosUsuario, raizPermisoUsuario);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario para administrar sus permisos");
            }
        }
    }
}
