using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;

namespace consumoAPIRestConsola
{

    class Program
    {
        
        static void Main(string[] args)
        {
            String url;

            url = "http://api.openweathermap.org/data/2.5/weather?id=6559994&appid=2535fbd1758d2ba73655d6b6dd5ad383";
            var json = new WebClient().DownloadString(url);
            dynamic objetoJson = JsonConvert.DeserializeObject(json);

            Console.WriteLine("Json: " + json);
            Console.ReadLine();

            Console.WriteLine("Nombre: " + objetoJson.name);
            Console.WriteLine("Latitud: " + objetoJson.coord.lon);
            Console.WriteLine("Longitud: "+objetoJson.coord.lon);
            Console.WriteLine("Clima: " + objetoJson.weather[0].description);
            
            Console.ReadLine();
           
        }
    }
}
