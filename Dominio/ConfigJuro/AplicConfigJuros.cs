using System;
using Microsoft.Extensions.Configuration;

namespace Aplicacao.ConfigJuro
{
    public class AplicConfigJuros : IAplicConfigJuros
    {
        private readonly IConfiguration _configuration;

        public AplicConfigJuros(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public decimal ObterTaxaJuros()
        {
            try
            {
                var taxa = _configuration.GetSection("MinhasConfis")["TaxaJuros"];
                return decimal.Parse(taxa);
            }
            catch (Exception e )
            {
                throw new Exception(string.Format("Não foi possível obter a taxa de juros. ERRO {0}",e.Message));
            }          
        }
    }
}
