using System;

namespace Cova.BE.ControlCambios
{
    public class BEControlDeCambioPaciente
    {
        public long ControlCambioId { get; set; }
        public BEPaciente Paciente { get; set; }
        public BEUsuario UsuarioModificador { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string TipoCambio { get; set; }
    }
}
