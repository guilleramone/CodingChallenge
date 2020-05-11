namespace CodingChallenge.Data.Classes
{
    public abstract class Idioma
    {
        public abstract string getListaVaciaFormas();

        public abstract string getListaFormasHeader();

        public abstract string getLinea(int cantidad, string traduccion, decimal area, decimal perimetro);

        public abstract string getTotal();

        public abstract string getFormas();

        public abstract string getPerimetro();

    }
}
