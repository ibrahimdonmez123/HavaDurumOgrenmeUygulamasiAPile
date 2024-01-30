using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

namespace HavaDurumOgrenmeUygulamasiAPile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string api = "6b719d0cbd224a423049ac17807f36a4";
            string connection = "http://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid=" + api;

            XDocument weather= XDocument.Load(connection);
            var temp = weather.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            var weatherstate = weather.Descendants("weather").ElementAt(0).Attribute("value").Value;
            Console.Write("İstanbul için sıcaklık: " + temp + "---Hava Durumu : " + weatherstate);
            Console.ReadLine();


        }
    }
}
