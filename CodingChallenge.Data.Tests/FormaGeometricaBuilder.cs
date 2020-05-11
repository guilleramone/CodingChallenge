using CodingChallenge.Data.Classes;
using System.Collections.Generic;

namespace CodingChallenge.Data.Tests
{
    internal class ResumenListaBuilder
    {
        private IList<FormaGeometrica> _formaGeometrica;

        internal ResumenListaBuilder()
        {
            _formaGeometrica = null;
        }

        internal ResumenListaBuilder FormasGeometricaVacias()
        {
            _formaGeometrica = new List<FormaGeometrica>();
            return this;
        }

        internal ResumenListaBuilder FormasGeometricaConUnCuadrado()
        {
            _formaGeometrica = new List<FormaGeometrica>() { new CuadradoBuilder().Build() };
            return this;
        }

        internal ResumenListaBuilder FormasGeometricaConMasDeUnCuadrado()
        {
            _formaGeometrica = new List<FormaGeometrica>() { new CuadradoBuilder().Build(),
                                                             new CuadradoBuilder().ConCuadradoDeLado(1).Build(),
                                                             new CuadradoBuilder().ConCuadradoDeLado(3).Build() };
            return this;
        }

        internal ResumenListaBuilder FormasGeometricaVarias(IList<FormaGeometrica> formas)
        {
            _formaGeometrica = new List<FormaGeometrica>(formas);
            return this;
        }

        internal List<FormaGeometrica> Build()
        {
            return new List<FormaGeometrica>(_formaGeometrica);
        }

        public static implicit operator List<FormaGeometrica>(ResumenListaBuilder builder)
        {
            return builder.Build();
        }
    }
}