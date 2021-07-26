using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WebApplication1.Dominio.ModelView;

namespace WebApplication1.Dominio.Servicos
{
    public class CepServico
    {
        public static async Task<CepView> Get(string cep)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://api.cep.com/");
            //client.DefaultRequestHeaders.Add("Accept","application/vnd.github.v3+json");
            return await client.GetFromJsonAsync<CepView>($"/consulta?cep={cep}");
        }
    }
}
