using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GestionBancariaAppNS;

namespace GestionBancariaTest
{
    [TestClass]
    public class GestionBancariaTestsANDBAN2223
    {
        [TestMethod]
        public void ValidarReintegro()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double reintegro = 250;
            double saldoEsperado = 750;

            GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);
            // Método a probar
            miApp.RealizarReintegro(reintegro);
            Assert.AreEqual(saldoEsperado, miApp.ObtenerSaldo(), 0.001,
            "Se produjo un error al realizar el reintegro, saldo" +
            "incorrecto.");
        }

        [TestMethod]
        public void ValidarIngreso()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double ingreso = 250;
            double saldoEsperado = 1250;

            GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);
            // Método a probar
            miApp.RealizarIngreso(ingreso);
            Assert.AreEqual(saldoEsperado, miApp.ObtenerSaldo(), 0.001,
            "Se produjo un error al realizar el ingreso, saldo" +
            "incorrecto.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void validarReintegroCantidadNoValida()
        {
            double saldoInicial = 1000;
            double reintegro = -1;

            GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);
            miApp.RealizarReintegro(reintegro);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void validarReintegroCantidad2NoValida()
        {
            double saldoInicial = 1000;
            double reintegro = 1001;

            GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);
            miApp.RealizarReintegro(reintegro);
        }
        // ANDBAN2223 Metodo probar reintegrar 0
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void validarReintegroCantidad3NoValida()
        {
            double saldoInicial = 1000;
            double reintegro = 0;

            GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);
            miApp.RealizarReintegro(reintegro);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void validarIngresoCantidadNoValida()
        {
            double saldoInicial = 1000;
            double ingreso = -1;

            GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);
            miApp.RealizarIngreso(ingreso);
        }

    }
}
