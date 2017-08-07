using System.Collections.Generic;
using CodingChallenge.Data.Classes;

namespace CodingChallenge.Data.DataAccess
{
    public interface ITitulosRepository
    {
        /// <summary>
        /// Trae un listado con todos los títulos.
        /// </summary>
        /// <returns></returns>
        IEnumerable<Titulo> GetTitulos();

        //Titulo GetTituloById();

        //Titulo GetTituloBySimbolo();
    }
}
