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
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                FormaGeometrica.Imprimir(
                    new ResumenListaBuilder().FormasGeometricaVacias().Build(), new Castellano()));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                FormaGeometrica.Imprimir(new ResumenListaBuilder().FormasGeometricaVacias().Build(), new Ingles()));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var resumen = FormaGeometrica.Imprimir(new ResumenListaBuilder().FormasGeometricaConUnCuadrado().Build(), new Castellano());

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var resumen = FormaGeometrica.Imprimir(new ResumenListaBuilder().FormasGeometricaConMasDeUnCuadrado().Build(), new Ingles());

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new ResumenListaBuilder().FormasGeometricaVarias(new List<FormaGeometrica>
            {
                new CuadradoBuilder().Build(),
                new CirculoBuilder().Build(),
                new TrianguloEquilateroBuilder().Build(),
                new CuadradoBuilder().ConCuadradoDeLado(2).Build(),
                new TrianguloEquilateroBuilder().ConTrianguloDeLado(9).Build(),
                new CirculoBuilder().ConCirculoDeLado(2.75m).Build(),
                new TrianguloEquilateroBuilder().ConTrianguloDeLado(4.2m).Build()
            }).Build();

            var resumen = FormaGeometrica.Imprimir(formas, new Ingles());

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new ResumenListaBuilder().FormasGeometricaVarias(new List<FormaGeometrica>
            {
                new CuadradoBuilder().Build(),
                new CirculoBuilder().Build(),
                new TrianguloEquilateroBuilder().Build(),
                new CuadradoBuilder().ConCuadradoDeLado(2).Build(),
                new TrianguloEquilateroBuilder().ConTrianguloDeLado(9).Build(),
                new CirculoBuilder().ConCirculoDeLado(2.75m).Build(),
                new TrianguloEquilateroBuilder().ConTrianguloDeLado(4.2m).Build()
            }).Build();

            var resumen = FormaGeometrica.Imprimir(formas, new Castellano());

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65",
                resumen);
        }
    }
}