using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Windows.Forms;
using Cova.Servicios.Backup;
using Cova.BE.Backup;
using Cova.Servicios.Sesion;
using Cova.BE;

namespace Cova.UI.Realizar_Backup
{
    public partial class RealizarBackupForm : Form
    {
        private List<BEBackup> _backups;
        public RealizarBackupForm()
        {
            InitializeComponent();
            CargarBackups();
        }

        private void CargarBackups()
        {
            try
            {
                this._backups = Backup.ObtenerBackups().ToList();

                DataTable tableBackups = new DataTable();
                tableBackups.Columns.Add("BackupId");
                tableBackups.Columns.Add("Nombre");
                tableBackups.Columns.Add("Archivo");
                tableBackups.Columns.Add("Usuario");
                tableBackups.Columns.Add("Fecha Backup");

                foreach (BEBackup backup in this._backups)
                {
                    DataRow filaBackups = tableBackups.NewRow();
                    filaBackups["BackupId"] = backup.BackupId;
                    filaBackups["Nombre"] = backup.Nombre;
                    filaBackups["Archivo"] = backup.Archivo;
                    filaBackups["Usuario"] = backup.Usuario.Usuario;
                    filaBackups["Fecha Backup"] = backup.FechaBackup;
                    tableBackups.Rows.Add(filaBackups);
                }

                DataView dataviewBackup = new DataView(tableBackups);
                dgv_Backups.DataSource = dataviewBackup;
                dgv_Backups.Columns[0].Visible = false;
                dgv_Backups.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgv_Backups.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgv_Backups.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgv_Backups.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;            }
            catch(Exception ex)
            {
                MessageBox.Show("Huo un error al cargar los backups");
            }
        }

        private void btn_Cancelar_RealizarBackup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_IniciarBackup_RealizarRestore_Click(object sender, EventArgs e)
        {
            string backupNombre = txt_nombre.Text;
            try
            {
                BEBackup backup = new BEBackup();
                backup.Nombre = backupNombre;
                BEUsuario usuario = new BEUsuario();
                usuario.UsuarioID = Sesion.GetInstance.Usuario.UsuarioID;
                backup.Usuario = usuario;
                if (Backup.RealizarBakup(backup))
                {
                    MessageBox.Show("Backup realizado con exito");
                    CargarBackups();
                }
                else
                {
                    MessageBox.Show("Hubo un error al realizar el backup");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_IniciarRestore_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Backups.SelectedRows.Count != 0)
                {
                    int backupId = Convert.ToInt32(dgv_Backups.SelectedRows[0].Cells["BackupId"].Value);
                    BEBackup backup = new BEBackup();
                    backup.BackupId = backupId;
                    if (Backup.RealizarRestore(backup))
                    {
                        MessageBox.Show("Restore realizado con exito");
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al realizar el restore");
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un backup para hacer restore");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
