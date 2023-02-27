using Nancy.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Target_Sistemas.Models;

namespace Target_Sistemas
{
    public class Faturamento
    {
        public void FaturamentoResults()
        {
            using (StreamReader r = new StreamReader("../../../dados.json"))
            {
                var json = r.ReadToEnd();
                JavaScriptSerializer ser = new JavaScriptSerializer();
                List<Dados> dados = ser.Deserialize<List<Dados>>(json);

                float mediaMensal = 0;
                int aux = 0;
                float valoraux = 0;

                for(var i = 0; i < dados.Count; i++) 
                {
                    if (dados[i].valor != 0) 
                    { 
                        valoraux = valoraux + dados[i].valor;
                        aux++;
                    }
                }

                mediaMensal = valoraux / aux;

                float menorFaturamento = dados.Min(d => d.valor );
                float maiorFaturamento = dados.Max(d => d.valor);
                int diasmaioresqueamedia = 0;
                for(var j = 0; j < dados.Count; j++) 
                {
                    if (dados[j].valor > mediaMensal) diasmaioresqueamedia++; 
                }


                Console.WriteLine(mediaMensal);
                Console.WriteLine($"O Menor valor de faturamento no mês:{menorFaturamento}");
                Console.WriteLine($"O Maior valor de faturamento no mês:{maiorFaturamento}");
                Console.WriteLine($"O Faturamento foi maior que a Média em:{diasmaioresqueamedia} dias");







            }
        }
    }
}
