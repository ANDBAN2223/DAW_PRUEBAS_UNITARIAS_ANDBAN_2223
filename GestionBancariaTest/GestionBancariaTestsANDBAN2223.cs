﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    }
}
