using System;
using System.Security.Cryptography;
using System.Text;

namespace Cova.Common.Encriptacion
{
    public static class HashHelper
    {
        public static string HashMD5(string input)
        {
            return GenerarHash(input, new MD5CryptoServiceProvider());
        }

        public static string Hash256(string input)
        {
            return GenerarHash(input, new SHA256CryptoServiceProvider());
        }

        private static string GenerarHash(string input, HashAlgorithm algorithm)
        {
            Byte[] inputBytes = Encoding.UTF8.GetBytes(input);

            Byte[] hashedBytes = algorithm.ComputeHash(inputBytes);

            return BitConverter.ToString(hashedBytes);
        }

    }
}
