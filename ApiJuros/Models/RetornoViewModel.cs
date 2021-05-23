using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace ApiJuros.Models
{
    public class RetornoViewModel 
    {

        public decimal Percentual { get; private set; }
        public bool  Sucesso { get; private set; }
        public string Msg { get; private set; }

        internal static RetornoViewModel RetornoErro(string message)
        {
            return new RetornoViewModel
            {
                Msg = message,
                Sucesso = false
            };
        }

        internal static RetornoViewModel RetornoSucesso(decimal percentual)
        {
            var ret= new RetornoViewModel
            {
                Percentual = percentual,
                Sucesso = true
            };         

            return ret;
        }
    }
}
