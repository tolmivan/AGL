using AGL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AGL.Repository.Json
{
    public static class JsonConsumer
    {
        public static List<Person> GetPeopleFromJson()
        {
            List<Person> people = null;

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://agl-developer-test.azurewebsites.net/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("people.json").Result;
            
            if (response.IsSuccessStatusCode)
            {
                people = response.Content.ReadAsAsync<List<Person>>().Result;
            }

            return people;
        }
    }
}
