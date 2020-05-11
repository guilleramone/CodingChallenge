using System;

namespace CodingChallenge.Data.Classes
{
    public class Rectangulo : FormaGeometrica
    {
        private readonly decimal alto;
        private readonly decimal lado;

        internal Rectangulo() { }

        public Rectangulo(decimal lado, decimal alto) : base()
        {
            this.alto = alto;
            this.lado = lado;
        }

        internal override decimal CalcularArea()
        {
            return (alto * lado); 
        }

        internal override decimal CalcularPerimetro()
        {
            return (2 * alto) + (2 * lado);
        }        

        public override string TraducirForma(int cantidad, Idioma idioma)
        {
            if (idioma.GetType() == typeof(Castellano))
            {
                return cantidad == 1 ? "Rectangulo" : "Rectangulo";
            }
            else if (idioma.GetType() == typeof(Ingles))
            {
                return cantidad == 1 ? "Rectangle" : "Rectangles";
            }
            else
            {
                return cantidad == 1 ? "Retângulo" : "Retângulos";
            }
        }
    }
}