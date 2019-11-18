using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;


namespace Api_övning
{
    class Program
    {
        static void Main(string[] args)
        {
            RestClient client = new RestClient("https://pokeapi.co/api/v2/");

            RestRequest request = new RestRequest("pokemon/electabuzz/");

            IRestResponse response = client.Get(request);

            Pokemon magmar = JsonConvert.DeserializeObject<Pokemon>(response.Content);

            //Console.WriteLine(response.Content);

            Console.WriteLine(magmar.name + "[" + magmar.base_experience + "]");

            Console.ReadLine();


        }
    }
}
