using ApiJuros.Controllers;
using Aplicacao.ConfigJuro;
using Castle.Core.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace TesteUnitario
{
    [TestClass]
    public class TesteRetornoTaxaJuros
    {
        [TestMethod]
        public void Teste_RetornoDeveSerOMesmoDoAppSettings()
        {
            //arrange
            IConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
            configurationBuilder.AddJsonFile("AppSettings.json");
            var configuration = configurationBuilder.Build();

            var _aplicConfigJuros = new AplicConfigJuros(configuration);
            var _jurosController = new JurosController(_aplicConfigJuros);

            //action
            var retorno = _jurosController.ObterTaxaJuros();

            //assert
            Assert.AreEqual(0.67m, retorno, "Percentual esperado difere do configurado no appsettings");
        }
    }
}
