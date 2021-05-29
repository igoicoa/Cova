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
        public void usuarioPuedeLoguearse()
        {
            BEUsuario usuario = new BEUsuario();
            BLUsuario usuarioBL = new BLUsuario();

            usuario.Usuario = "TestUser";
            usuario.Password = "TestPwd";

            bool resultado = usuarioBL.Login(usuario);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void usuarioNoPuedeLoguearseConPasswordIncorrecto()
        {
            BEUsuario usuario = new BEUsuario();
            BLUsuario usuarioBL = new BLUsuario();

            usuario.Usuario = "TestUser";
            usuario.Password = "PwdIncorrecto";

            bool resultado = usuarioBL.Login(usuario);
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void usuarioNoPuedeLoguearseSiNoExiste()
        {
            BEUsuario usuario = new BEUsuario();
            BLUsuario usuarioBL = new BLUsuario();

            usuario.Usuario = "UserInexistente";
            usuario.Password = "PwdInexistente";

            bool resultado = usuarioBL.Login(usuario);
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void UsuarioPuedeCambiarPassword()
        {
            BEUsuario usuario = new BEUsuario();
            BLUsuario usuarioBL = new BLUsuario();
            string nuevoPassword = "Test2";

            usuario.Usuario = "User1";
            usuario.Password = "Test1";

            bool resultado = usuarioBL.CambiarPassword(usuario, nuevoPassword);
            Assert.IsTrue(resultado);
        }
    }
}
