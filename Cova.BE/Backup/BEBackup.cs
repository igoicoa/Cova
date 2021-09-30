using System;

namespace Cova.BE.Backup
{
    public class BEBackup
    {
        public int BackupId { get; set; }
        public BEUsuario Usuario { get; set; }
        public DateTime FechaBackup { get; set; }
        public string Archivo { get; set; }
        public string Nombre { get; set; }
    }
}
