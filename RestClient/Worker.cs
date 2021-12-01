using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using TitanicWeather.Models;

namespace RestClient
{
    public class Worker
    {
        public async Task<int> GetCommand()
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await
                    client.GetAsync("https://titanicweatherapi.azurewebsites.net/api/Titanic/Command");
                int _command = await
                    response.Content.ReadFromJsonAsync<int>();
                return _command;
            }
        }
        public async Task<int> PostItem(int _command)
        {
            using (HttpClient client = new HttpClient())
            {
                JsonContent serializedCommand = JsonContent.Create(_command);
                HttpResponseMessage response = await
                    client.PostAsync("https://titanicweatherapi.azurewebsites.net/api/Titanic/SetCommand", serializedCommand);
                return await response.Content.ReadFromJsonAsync<int>();
            }
        }
    }
}