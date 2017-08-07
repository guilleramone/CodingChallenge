using System;
using System.Collections.Generic;
using CodingChallenge.Data.Classes;
using NUnit.Framework;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVaciaTitulos()
        {
            Assert.AreEqual("<h1>¡Lista vacía de títulos!</h1>",
                Titulo.ImprimirResumen(new List<Titulo>(), Idioma.Castellano));
        }

        [TestCase]
        public void TestResumenListaVaciaTitulosEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of securities!</h1>",
                Titulo.ImprimirResumen(new List<Titulo>(), Idioma.Ingles));
        }

        [TestCase]
        public void TestResumenListaConUnaAccion()
        {
            var acciones = new List<Titulo> { new Titulo { Tipo = TipoTitulo.Accion, Simbolo = "PRUEBA" } };

            Assert.AreEqual("<h1>Resumen de títulos</h1>Detalle de 1 Acción<br/><span>Símbolo Acción: PRUEBA</span><br/>",
                Titulo.ImprimirResumen(acciones, Idioma.Castellano));
        }

        [TestCase]
        public void TestResumenListaConMasAcciones()
        {
            var acciones = new List<Titulo>
            {
                new Titulo {Tipo = TipoTitulo.Accion, Simbolo = "PRUEBA"},
                new Titulo {Tipo = TipoTitulo.Accion, Simbolo = "PRUEBA_2"}
            };

            Assert.AreEqual("<h1>Resumen de títulos</h1>Detalle de 2 Acciones<br/><span>Símbolo Acción: PRUEBA</span>" +
                            "<span>Símbolo Acción: PRUEBA_2</span><br/>",
                Titulo.ImprimirResumen(acciones, Idioma.Castellano));
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var titulos = new List<Titulo>
            {
                new Titulo {Tipo = TipoTitulo.Accion, Simbolo = "PRUEBA"},
                new Titulo {Tipo = TipoTitulo.Accion, Simbolo = "PRUEBA_2"},
                new Titulo {Tipo = TipoTitulo.Bono, Simbolo = "BONO_PRUEBA"},
                new Titulo {Tipo = TipoTitulo.Bono, Simbolo = "BONO_PRUEBA_2"}
            };

            Assert.AreEqual("<h1>Resumen de títulos</h1>" +
                            "Detalle de 2 Acciones<br/><span>Símbolo Acción: PRUEBA</span><span>Símbolo Acción: PRUEBA_2</span><br/>" +
                            "Detalle de 2 Bonos<br/><span>Símbolo Bono: BONO_PRUEBA</span><span>Símbolo Bono: BONO_PRUEBA_2</span><br/>",
                Titulo.ImprimirResumen(titulos, Idioma.Castellano));
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnIngles()
        {
            var titulos = new List<Titulo>
            {
                new Titulo {Tipo = TipoTitulo.Accion, Simbolo = "PRUEBA"},
                new Titulo {Tipo = TipoTitulo.Accion, Simbolo = "PRUEBA_2"},
                new Titulo {Tipo = TipoTitulo.Bono, Simbolo = "BONO_PRUEBA"},
                new Titulo {Tipo = TipoTitulo.Bono, Simbolo = "BONO_PRUEBA_2"}
            };

            Assert.AreEqual("<h1>Securities report</h1>" +
                            "Detail of 2 Stocks<br/><span>Stock Symbol: PRUEBA</span><span>Stock Symbol: PRUEBA_2</span><br/>" +
                            "Detail of 2 Bonds<br/><span>Bond Symbol: BONO_PRUEBA</span><span>Bond Symbol: BONO_PRUEBA_2</span><br/>",
                Titulo.ImprimirResumen(titulos, Idioma.Ingles));
        }
    }
}
