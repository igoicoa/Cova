using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cova.BE;
using Cova.BL;

namespace Cova.Test
{
    [TestClass]
    public class UsuarioTest
    {

        [TestMethod]
        public void UsuarioPuedeCambiarPassword()
        {
            BEUsuario usuario = new BEUsuario();
            BLUsuario usuarioBL = new BLUsuario();
            string nuevoPassword = "Test2";

            usuario.Usuario = "User1";
            usuario.Password = "Test1";

            bool resultado = usuarioBL.cambiarPassword(usuario, nuevoPassword);
            Assert.IsTrue(resultado);
        }
    }
}
