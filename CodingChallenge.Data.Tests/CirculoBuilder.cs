using CodingChallenge.Data.Classes;

namespace CodingChallenge.Data.Tests
{
    internal class CirculoBuilder 
    {
        private decimal lado;

        internal CirculoBuilder()
        {
            lado = 3;
        }

        internal CirculoBuilder ConCirculoDeLado(decimal lado)
        {
            this.lado = lado;
            return this;
        }

        internal Circulo Build()
        {
            return new Circulo(lado);
        }

        public static implicit operator Circulo(CirculoBuilder builder)
        {
            return builder.Build();
        }
    }
}