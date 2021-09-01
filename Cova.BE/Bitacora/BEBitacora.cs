using System;

namespace Cova.BE.Bitacora
{
    public class BEBitacora
    {
        private DateTime now;
        private TipoCriticidad info;
        private string v;

        public long BitacoraId { get; set; }
        public DateTime Fecha { get; set; }
        public BEUsuario Usuario { get; set; }
        public TipoCriticidad Criticidad { get; set; }
        public string Mensaje { get; set; }
        public string Funcionalidad { get; set; }

        public BEBitacora(DateTime fecha, BEUsuario usuario, TipoCriticidad criticidad, string mensaje, string funcionalidad)
        {
            this.Fecha = fecha;
            this.Usuario = usuario;
            this.Criticidad = criticidad;
            this.Mensaje = mensaje;
            this.Funcionalidad = funcionalidad;
        }

        public BEBitacora()
        {

        }

        public BEBitacora(DateTime now, BEUsuario usuario, TipoCriticidad info, string v)
        {
            this.now = now;
            Usuario = usuario;
            this.info = info;
            this.v = v;
        }
    }
}
