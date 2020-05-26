using Newtonsoft.Json;
using ProfileSystem.Models;
using System;
using System.Net.Http;
using System.Text;

namespace ProfileUI
{
    /// <summary>
    /// A class that provides a method for sending a DELETE request to the server.
    /// </summary>
    class DeleteWorker
    {
        /// <summary>
        /// The method accepts the employee's first and last name.
        /// Sends a DELETE request to the server at ServerAdress.Adress
        /// </summary>
        /// <param name="name"></param>
        /// <param name="firstName"></param>
        /// <param name="father"></param>
        public bool Delete(string name, string firstName, string father)
        {
            using (var client = new HttpClient())
            { 
                string myJson = JsonConvert.SerializeObject(new Worker
                {
                    Name = name,
                    FirstName = firstName,
                    Father = father
                });

               
                HttpRequestMessage request = new HttpRequestMessage
                {
                    Content = new StringContent(myJson, Encoding.UTF8, "application/json"),
                    Method = HttpMethod.Delete,
                    RequestUri = new Uri(ServerAdress.Adress + "/api/profile")
                };
                var result = client.SendAsync(request).Result;
                return result.IsSuccessStatusCode;
            }
        }
    }
}
