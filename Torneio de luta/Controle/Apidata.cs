using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;

namespace Torneio_de_luta.Controle
{
    class Apidata
    {


        public static List<Modelo.Lutadores> Lutadoresget()
        {
            var client = new RestClient("https://apidev-mbb.t-systems.com.br:8443/edgemicro_tsdev/torneioluta/api/competidores")
            {
                Timeout = -1
            };
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-api-key", "29452a07-5ff9-4ad3-b472-c7243f548a33");
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            Console.ReadLine();
            return JsonConvert.DeserializeObject<List<Torneio_de_luta.Modelo.Lutadores>>(response.Content);

        }


    }


}
