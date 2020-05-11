namespace CodingChallenge.Data.Classes
{
    public class Portugues : Idioma
    {
        public override string getFormas()
        {
            return "formas";
        }

        public override string getLinea(int cantidad, string traduccion, decimal area, decimal perimetro)
        {
            return $"{cantidad} {traduccion} | Area {area:#.##} | Perímetro {perimetro:#.##} <br/>";
        }

        public override string getListaFormasHeader()
        {
            return "Relatório de Formulário";
        }

        public override string getListaVaciaFormas()
        {
            return "Lista vazia de formas!";
        }

        public override string getPerimetro()
        {
            return "Perímetro";
        }

        public override string getTotal()
        {
            return "TOTAL";
        }
    }
}