using Newtonsoft.Json;
using ProfileSystem.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace ProfileUI
{
    /// <summary>
    /// A class that provides a method for sending a GET request to the server.
    /// </summary>
    class GetAllWorkers
    {
        /// <summary>
        /// Send a GET request to server.
        /// </summary>
        /// <returns>A list of all employeers.</returns>
        public List<Worker> Get()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ServerAdress.Adress);

                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                var result = client.GetAsync("/api/profile").Result;
                List<Worker> allREsu = JsonConvert.DeserializeObject<List<Worker>>(result.Content.ReadAsStringAsync().Result);
                return allREsu;
            }
        }
    }
}
