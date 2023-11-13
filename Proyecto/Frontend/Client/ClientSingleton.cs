using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frontend.Client
{
    class ClientSingleton
    {
        private static ClientSingleton instance;
        private HttpClient client;

        private ClientSingleton()
        {
            // se crea un unico objeto httpClient
            client = new HttpClient();
        }
        public static ClientSingleton GetInstance()
        {
            if (instance == null)
            {
                instance = new ClientSingleton();
            }
            return instance;
        }

        // comportamientos necesarios para ejecutar un GET o POST, PUT, DELETE

        // GET
        public async Task<string> GetAsync(string url)
        {
            var result = await client.GetAsync(url);
            var content = "";
            if (result.IsSuccessStatusCode)
            {
                content = await result.Content.ReadAsStringAsync();
            }
            return content;
        }

        // POST
        public async Task<string> PostAsync(string url, string data)
        {
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            var result = await client.PostAsync(url, content);

            var response = "";
            if (result.IsSuccessStatusCode)
            {
                response = await result.Content.ReadAsStringAsync();
            }
            return response;
        }

        // DELETE
        public async Task<string> DeleteAsync(string url)
        {
            var result = await client.DeleteAsync(url);
            var content = "";
            if (result.IsSuccessStatusCode)
            {
                content = await result.Content.ReadAsStringAsync();
            }
            return content;
        }
    }
}
