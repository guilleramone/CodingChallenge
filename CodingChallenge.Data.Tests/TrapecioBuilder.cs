using CodingChallenge.Data.Classes;

namespace CodingChallenge.Data.Tests
{
    internal class TrapecioBuilder
    {
        private decimal baseLarga;
        private decimal altura;
        private decimal baseCorta;

        internal TrapecioBuilder()
        {
            baseLarga = 4;
            altura = 3;
            baseCorta = 2;
        }

        internal TrapecioBuilder ConTrapecioDeBaseLargaBaseCortaYAltura(decimal baseLarga, decimal baseCorta, decimal altura)
        {
            this.baseLarga = baseLarga;
            this.baseCorta = baseCorta;
            this.altura = altura;
            return this;
        }

        internal Trapecio Build()
        {
            return new Trapecio(baseLarga,baseCorta, altura);
        }

        public static implicit operator Trapecio(TrapecioBuilder builder)
        {
            return builder.Build();
        }
    }
}