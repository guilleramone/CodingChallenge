/*
 * Refactorear la clase para respetar principios de programación orientada a objetos. Qué pasa si debemos soportar un nuevo idioma para los reportes, o
 * agregar más formas geométricas?
 *
 * Se puede hacer cualquier cambio que se crea necesario tanto en el código como en los tests. La única condición es que los tests pasen OK.
 *
 * TODO: Implementar Trapecio/Rectangulo, agregar otro idioma a reporting.
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenge.Data.Classes
{
    public abstract class FormaGeometrica : ITraducirForma
    {
        public FormaGeometrica()
        {            
        }

        public static string Imprimir(IList<FormaGeometrica> formas, Idioma idioma)
        {
            var sb = new StringBuilder();

            if (!formas.Any())
            {
                sb.Append($"<h1>{idioma.getListaVaciaFormas()}</h1>");
            }
            else
            {
                // Hay por lo menos una forma
                // HEADER
                sb.Append($"<h1>{idioma.getListaFormasHeader()}</h1>");               

                var numeroCuadrados = 0;
                var numeroCirculos = 0;
                var numeroTriangulos = 0;

                var areaCuadrados = 0m;
                var areaCirculos = 0m;
                var areaTriangulos = 0m;

                var perimetroCuadrados = 0m;
                var perimetroCirculos = 0m;
                var perimetroTriangulos = 0m;

                foreach (var forma in formas)
                {
                    if (forma.GetType() == typeof(Cuadrado))
                    {
                        numeroCuadrados++;
                        areaCuadrados += forma.CalcularArea();
                        perimetroCuadrados += forma.CalcularPerimetro();                        
                    }
                    if (forma.GetType() == typeof(Circulo))
                    {
                        numeroCirculos++;
                        areaCirculos += forma.CalcularArea();
                        perimetroCirculos += forma.CalcularPerimetro();                        
                    }
                    if (forma.GetType() == typeof(TrianguloEquilatero))
                    {
                        numeroTriangulos++;
                        areaTriangulos += forma.CalcularArea();
                        perimetroTriangulos += forma.CalcularPerimetro();                        
                    }
                }

                sb.Append(ObtenerLinea(numeroCuadrados, areaCuadrados, perimetroCuadrados, idioma, new Cuadrado()));
                sb.Append(ObtenerLinea(numeroCirculos, areaCirculos, perimetroCirculos, idioma, new Circulo()));
                sb.Append(ObtenerLinea(numeroTriangulos, areaTriangulos, perimetroTriangulos, idioma, new TrianguloEquilatero()));
              
                // FOOTER
                sb.Append($"{idioma.getTotal()}:<br/>");
                sb.Append(numeroCuadrados + numeroCirculos + numeroTriangulos + " " + idioma.getFormas() + " ");
                sb.Append(idioma.getPerimetro() + (perimetroCuadrados + perimetroTriangulos + perimetroCirculos).ToString("#.##") + " ");
                sb.Append("Area " + (areaCuadrados + areaCirculos + areaTriangulos).ToString("#.##"));
            }

            return sb.ToString();
        }

        internal static string ObtenerLinea(int cantidad, decimal area, decimal perimetro, Idioma idioma, ITraducirForma ITraducirForma)
        {
            if (cantidad > 0)
            {
                var traduccion = String.Empty;
                traduccion = ITraducirForma.TraducirForma(cantidad, idioma);

                return idioma.getLinea(cantidad, traduccion, area, perimetro);
            }
            return string.Empty;
        }
        
        internal abstract decimal CalcularArea();

        internal abstract decimal CalcularPerimetro();

        public abstract string TraducirForma(int cantidad, Idioma idioma);
    }
}
