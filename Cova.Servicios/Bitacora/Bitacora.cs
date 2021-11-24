using System;
using System.Collections.Generic;
using Cova.Common.Excepciones;
using Cova.BE.Bitacora;
using Cova.MPP;
using Microsoft.Win32;
using System.IO;
using System.Xml;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;

namespace Cova.Servicios.Bitacora
{
    public class Bitacora : IBitacora
    {
        private static Bitacora _bitacora;

        public static Bitacora GetInstance
        {
            get
            {
                return _bitacora;
            }
        }

        public static void CrearBitacora()
        {
            if (_bitacora == null)
            {
                _bitacora = new Bitacora();
            }
            else
            {
                throw new BitacoraYaCreadaException();
            }
        }

        public void RegistrarBitacora(BEBitacora bitacora)
        {
            MPPBicatora mPPBicatora = new MPPBicatora();
            mPPBicatora.CrearRegistroBitacora(bitacora);
            if (bitacora.Criticidad == TipoCriticidad.Error)
            {
                bitacora.Usuario.Password = "***";
                SerializarError(bitacora);
            }
        }

        public IList<BEBitacora> ConsultarBitacora(BEBitacora bitacoraABuscar, DateTime fechaDesde, DateTime fechaHasta)
        {
            MPPBicatora mPPBicatora = new MPPBicatora();
            return mPPBicatora.BuscarBitacora(bitacoraABuscar, fechaDesde, fechaHasta);
        }
        private void SerializarError(object obj)
        {
            string downloadPath = Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "{374DE290-123F-4565-9164-39C4925E467B}", String.Empty).ToString();
            string pathToSave = downloadPath + @"\SistemaCova\Errores";
            Directory.CreateDirectory(pathToSave);
            File.WriteAllText(pathToSave + $"\\${Guid.NewGuid()}.json", JsonConvert.SerializeObject(obj, Formatting.Indented));
        }

    }
}
