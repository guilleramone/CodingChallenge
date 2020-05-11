using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Ingles : Idioma
    {
        public override string getListaVaciaFormas()
        {
            return "Empty list of shapes!";
             
        }

        public override string getListaFormasHeader()
        {
            return "Shapes report";
        }

        public override string getLinea(int cantidad, string traduccion, decimal area, decimal perimetro)
        {
            return $"{cantidad} {traduccion} | Area {area:#.##} | Perimeter {perimetro:#.##} <br/>";
        }

        public override string getFormas()
        {
            return "shapes";
        }

        public override string getTotal()
        {
            return "TOTAL";
        }

        public override string getPerimetro()
        {
            return "Perimeter ";
        }
    }
}
