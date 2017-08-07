using System.Collections.Generic;
using System.IO;
using CodingChallenge.Data.Classes;
using Moq;
using Newtonsoft.Json;

namespace CodingChallenge.Data.DataAccess
{
    /// <summary>
    /// Clase repositorio que contiene los accesos a la (mockeada) DB.
    /// </summary>
    public class MockRepository
    {
        private const string JsonTitulos = "\\ListaTitulos.json";

        /// <summary>
        /// Para utilizar los métodos de acceso a Título.
        /// </summary>
        public ITitulosRepository TituloRepository{ get; set; }

        public MockRepository()
        {
            var mockRepository = new Mock<ITitulosRepository>();

            var json = File.ReadAllText(Directory.GetCurrentDirectory() + JsonTitulos);
            var listaTitulos = JsonConvert.DeserializeObject<List<Titulo>>(json);

            mockRepository.Setup(mock => mock.GetTitulos()).Returns(listaTitulos);
            TituloRepository = mockRepository.Object;
        }
    }
}
