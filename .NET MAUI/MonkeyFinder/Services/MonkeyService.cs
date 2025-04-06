using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using MonkeyFinder.Model;


namespace MonkeyFinder.Services
{
    public class MonkeyService
    {
        HttpClient HttpClient;
        public MonkeyService()
        {
            HttpClient = new HttpClient();
        }
        List<Monkey> monkeyList = new();
        public async Task<List<Monkey>>GetMonkeys() // the return type of this is gonna be a task
        {
            if(monkeyList?.Count > 0)
            {
                return monkeyList;
            }
            var url = "https://montemagno.com/monkeys.json";
            var response = await HttpClient.GetAsync(url);
            if(response.IsSuccessStatusCode)
            {
                monkeyList = await response.Content.ReadFromJsonAsync<List<Monkey>>();
            }
            return monkeyList;
        }
    }
}
