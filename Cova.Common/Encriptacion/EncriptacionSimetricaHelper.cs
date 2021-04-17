using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Cova.Common.Encriptacion
{
    public class EncriptacionSimetricaHelper
    {
        private SymmetricAlgorithm algoritmo;

        public EncriptacionSimetricaHelper()
        {
            this.ConfigurarAlgoritmo();
            this.GenerarClave();
            this.GenerarIV();
        }

        private void ConfigurarAlgoritmo()
        {
            this.algoritmo.BlockSize = 128;
            this.algoritmo.Mode = CipherMode.CBC;
            this.algoritmo.Padding = PaddingMode.PKCS7;
        }

        private void GenerarClave()
        {
            this.algoritmo.KeySize = 256;
            this.algoritmo.GenerateKey();
            RandomNumberGenerator randomNumberGenerator = RandomNumberGenerator.Create();
            randomNumberGenerator.GetBytes(algoritmo.Key);
        }
       
        private void GenerarIV()
        {
            this.algoritmo.GenerateIV();
        }

        public byte[] Encriptar(string valorAEncriptar)
        {
            ICryptoTransform encriptador = this.algoritmo.CreateEncryptor();
            
            byte[] textoPlano = Encoding.Default.GetBytes(valorAEncriptar);
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, encriptador, CryptoStreamMode.Write);

            cryptoStream.Write(textoPlano, 0, textoPlano.Length);
            cryptoStream.FlushFinalBlock();
            memoryStream.Close();
            cryptoStream.Close();

            return memoryStream.ToArray();
        }
        
        public byte[] Desencriptar(byte[] valorEncriptado)
        {
            int numeroBytesDesencriptados = 0;
            byte[] mensajeDesencriptado = new byte[valorEncriptado.Length];

            ICryptoTransform desencriptador = this.algoritmo.CreateDecryptor();

            MemoryStream memoryStream = new MemoryStream(valorEncriptado);
            CryptoStream cryptoStream = new CryptoStream(memoryStream, desencriptador, CryptoStreamMode.Read);
            numeroBytesDesencriptados = cryptoStream.Read(mensajeDesencriptado, 0, mensajeDesencriptado.Length);

            memoryStream.Close();
            cryptoStream.Close();

            return mensajeDesencriptado;
        }

    }
}
