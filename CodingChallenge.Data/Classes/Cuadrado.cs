namespace CodingChallenge.Data.Classes
{
    public class Cuadrado : FormaGeometrica
    {
        private readonly decimal lado;

        internal Cuadrado() { }

        public Cuadrado(decimal lado) : base()
        {
            this.lado = lado;
        }

        internal override decimal CalcularArea()
        {
            return lado * lado;
        }

        internal override decimal CalcularPerimetro()
        {
            return lado * 4;
        }
        
        public override string TraducirForma(int cantidad, Idioma idioma)
        {
            if (idioma.GetType() == typeof(Castellano))
            {
                return cantidad == 1 ? "Cuadrado" : "Cuadrados";
            }
            else if (idioma.GetType() == typeof(Ingles))
            {
                return cantidad == 1 ? "Square" : "Squares";
            }
            else
            {
                return cantidad == 1 ? "Square" : "Praças";
            }
        }
    }
}