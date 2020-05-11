using CodingChallenge.Data.Classes;

namespace CodingChallenge.Data.Tests
{
    internal class CuadradoBuilder
    {
        private decimal lado;

        internal CuadradoBuilder()
        {
            lado = 5;
        }

        internal CuadradoBuilder ConCuadradoDeLado(decimal lado)
        {
            this.lado = lado;
            return this;
        }

        internal Cuadrado Build()
        {
            return new Cuadrado(lado);
        }

        public static implicit operator Cuadrado(CuadradoBuilder builder)
        {
            return builder.Build();
        }
    }
}