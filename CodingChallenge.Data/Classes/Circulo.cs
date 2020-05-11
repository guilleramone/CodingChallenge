using System;

namespace CodingChallenge.Data.Classes
{
    public class Circulo : FormaGeometrica
    {
        private static decimal PI = (decimal)Math.PI;
        private readonly decimal lado;        

        internal Circulo() { }

        public Circulo(decimal lado) : base()
        {
            this.lado = lado;
        }

        internal override decimal CalcularArea()
        {
            return PI * (lado / 2) * (lado / 2);
        }

        internal override decimal CalcularPerimetro()
        {
            return PI * lado;
        }        

        public override string TraducirForma(int cantidad, Idioma idioma)
        {
            if (idioma.GetType() == typeof(Castellano))
            {
                return cantidad == 1 ? "Círculo" : "Círculos";
            }
            else if (idioma.GetType() == typeof(Ingles))
            {
                return cantidad == 1 ? "Circle" : "Circles";
            }
            else
            {
                return cantidad == 1 ? "Círculo" : "círculos";
            }
        }
    }
}