using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace HelloWorld.Console
{
    public class Program
    {
        static HttpClient client = new HttpClient();

        public static async Task<string> HelloWorld()
        {
            string response = await client.GetStringAsync("http://localhost:4000/api/HelloWorld");

            return response;
        }

        public static void Run()
        {
            client.BaseAddress = new Uri("http://localhost:4000");

            try
            {
                System.Console.WriteLine(HelloWorld().Result);
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
        }

        public static void Main(string[] args)
        {
            Run();
        }
    }
}
