using System;

namespace CodingChallenge.Data.Classes
{
    public class Trapecio : FormaGeometrica
    {
        private readonly decimal baseLarga;
        private readonly decimal altura;
        private readonly decimal baseCorta;

        public Trapecio(decimal baseLarga, decimal baseCorta, decimal altura) : base()
        {
            this.baseLarga = baseLarga;
            this.altura = altura;
            this.baseCorta = baseCorta;
        }

        internal override decimal CalcularArea()
        {
            return ((baseCorta * this.baseLarga) / 2) * altura;
        }

        internal override decimal CalcularPerimetro()
        {
            throw new ArgumentOutOfRangeException(@"Forma desconocida");
        }

        public override string TraducirForma(int cantidad, Idioma idioma)
        {
            if (idioma.GetType() == typeof(Castellano))
            {
                return cantidad == 1 ? "Trapecio" : "Trapecios";
            }
            else if (idioma.GetType() == typeof(Ingles))
            {
                return cantidad == 1 ? "Trapeze" : "Trapezoids";
            }
            else
            {
                return cantidad == 1 ? "Trapézio" : "Trapézios";
            }
        }        
    }
}