using System;
using System.Security.Cryptography;
using System.Text;

namespace Cova.Servicios.Encriptacion
{
    public static class HashHelper
    {
        public static string HashMD5(string password)
        {
            return GenerarHash(password, new MD5CryptoServiceProvider());
        }

        public static string Hash256(string password)
        {
            return GenerarHash(password, new SHA256CryptoServiceProvider());
        }

        private static string GenerarHash(string input, HashAlgorithm algorithm)
        {
            Byte[] inputBytes = Encoding.UTF8.GetBytes(input);

            Byte[] hashedBytes = algorithm.ComputeHash(inputBytes);

            return BitConverter.ToString(hashedBytes);
        }

    }
}
