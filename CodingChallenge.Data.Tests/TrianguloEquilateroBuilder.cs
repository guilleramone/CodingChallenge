using CodingChallenge.Data.Classes;

namespace CodingChallenge.Data.Tests
{
    internal class TrianguloEquilateroBuilder
    {
        private decimal lado;

        internal TrianguloEquilateroBuilder()
        {
            lado = 4;
        }

        internal TrianguloEquilateroBuilder ConTrianguloDeLado(decimal lado)
        {
            this.lado = lado;
            return this;
        }

        internal TrianguloEquilatero Build()
        {
            return new TrianguloEquilatero(lado);
        }

        public static implicit operator TrianguloEquilatero(TrianguloEquilateroBuilder builder)
        {
            return builder.Build();
        }
    }
}