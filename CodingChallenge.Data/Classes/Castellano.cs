using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Castellano : Idioma
    {
        public override string getListaVaciaFormas()
        {
            return "Lista vacía de formas!";
        }

        public override string getListaFormasHeader()
        {
            return "Reporte de Formas";
        }

        public override string getLinea(int cantidad, string traduccion, decimal area, decimal perimetro)
        {
            return $"{cantidad} {traduccion} | Area {area:#.##} | Perimetro {perimetro:#.##} <br/>";
        }

        public override string getTotal()
        {
            return "TOTAL";
        }

        public override string getFormas()
        {
            return "formas";
        }

        public override string getPerimetro()
        {
            return "Perimetro ";
        }
    }
}