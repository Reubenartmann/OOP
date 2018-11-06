using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace getpost_API
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.Run(DoStuff).Wait();
        }
        public static async Task DoStuff()
        {
            Console.WriteLine("Hello World!");

            using (HttpClient client = new HttpClient())
            {
                //Send Get Request:
                var response = await client.GetAsync("http://todoapiswin.azurewebsites.net/api/Todo?apiKey=poo");
                var stringResponse = await response.Content.ReadAsStringAsync();
                var responseObject = JsonConvert.DeserializeObject<List<TodoItem>>(stringResponse);

                Console.WriteLine(responseObject);
                // Send Post Request:
                var dataString = JsonConvert.SerializeObject(new TodoItem { Task = "Josh. I'm coming for you." },
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore, 
                        Formatting = Formatting.None,
                        ContractResolver = new CamelCasePropertyNamesContractResolver()
                    });
                var sendData = new StringContent(dataString, System.Text.Encoding.UTF8, "application/json");


                var postResponse = await client.PostAsync("http://todoapiswin.azurewebsites.net/api/Todo?apiKey=poo", sendData);
            }

            Console.ReadLine();
        }
    }

    public class TodoItem
    {
        public string Task { get; set; }
        public string Id { get; set; }
    }
}

