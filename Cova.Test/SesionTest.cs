using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cova.Servicios.Sesion;
using Cova.BE;

namespace Cova.Test
{
    [TestClass]
    public class SesionTest
    {
        [TestInitialize]
        public void TestInitializa()
        {

        }

        [TestMethod]
        public void AlHacerLoginDeboTenerSesion()
        {
            Sesion testSesion;
            BEUsuario usuario = new BEUsuario();
            usuario.Usuario = "User1";
            usuario.Password = "test";

            Sesion.Login(usuario);
            testSesion = Sesion.GetInstance;
            Assert.IsNotNull(testSesion);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "No hay sesion inicializada")]
        public void AlHacerLogoutNoDeboTenerSesion()
        {
            Sesion testSesion;
            BEUsuario usuario = new BEUsuario();
            usuario.Usuario = "User1";
            usuario.Password = "test";

            Sesion.Login(usuario);
            Sesion.Logout();
            testSesion = Sesion.GetInstance;

            Assert.IsNull(testSesion);

        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Ya hay una sesion iniciada")]
        public void NoPuedoHacerLoginConSesionActiva()
        {
            BEUsuario usuario1 = new BEUsuario();
            usuario1.Usuario = "User1";
            usuario1.Password = "test";
            BEUsuario usuario2 = new BEUsuario();
            usuario2.Usuario = "User2";
            usuario2.Password = "test";

            Sesion.Login(usuario1);
            Sesion.Login(usuario2);
        }
    }
}
