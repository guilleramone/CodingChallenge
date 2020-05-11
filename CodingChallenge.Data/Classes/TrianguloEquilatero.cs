using System;

namespace CodingChallenge.Data.Classes
{
    public class TrianguloEquilatero : FormaGeometrica
    {
        private readonly decimal lado;

        internal TrianguloEquilatero() { }

        public TrianguloEquilatero(decimal lado) : base()
        {
            this.lado = lado;
        }

        internal override decimal CalcularArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * lado * lado;
        }

        internal override decimal CalcularPerimetro()
        {
            return lado * 3;
        }

        public override string TraducirForma(int cantidad, Idioma idioma)
        {
            if (idioma.GetType() == typeof(Castellano))
            {
                return cantidad == 1 ? "Triángulo" : "Triángulos";
            }
            else if (idioma.GetType() == typeof(Ingles))
                return cantidad == 1 ? "Triangle" : "Triangles";
            else
            {
                return cantidad == 1 ? "Triângulo" : "Triângulos";
            }
        }
    }
}