using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            GetOrderWithCount(5);
        }

        public static void GetOrderWithCount(int count)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:44310/");
            // Add an Accept header for JSON format.    
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            // List all Names.    
            HttpResponseMessage response = client.GetAsync("api/order/GetOrderWithCount/4").Result;  // Blocking call!    
            if (response.IsSuccessStatusCode)
            {
                var orders = response.Content.ReadAsStringAsync().Result;
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
        }

    }
}
