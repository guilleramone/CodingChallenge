using CodingChallenge.Data.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Tests
{
    internal class RectanguloBuilder
    {
        private decimal alto;
        private decimal lado;

        internal RectanguloBuilder()
        {
            lado = 4;
            alto = 2;
        }

        internal RectanguloBuilder ConRectanguloDeLadoYAlto(decimal lado, decimal alto)
        {
            this.lado = lado;
            this.alto = alto;
            return this;
        }

        internal Rectangulo Build()
        {
            return new Rectangulo(lado, alto);
        }

        public static implicit operator Rectangulo(RectanguloBuilder builder)
        {
            return builder.Build();
        }
    }
}
