using Newtonsoft.Json;
using ProfileSystem.Models;
using System;
using System.Net.Http;
using System.Text;

namespace ProfileUI
{
    /// <summary>
    /// A class that provides a method for sending a PUT request to the server.
    /// </summary>
    class PutWorker
    {
        /// <summary>
        /// A method that generates an object of the Worker type from the required data
        /// and sends a PUT request to the server at the ServerAdress address.Adress
        /// </summary>
        /// <param name="name">Name of Worker</param>
        /// <param name="firstName">firstName of Worekr</param>
        /// <param name="father">father of Worker</param>
        /// <param name="date">Birth date of Worker</param>
        /// <param name="adress">Worker adress</param>
        /// <param name="otdel">otdel</param>
        /// <param name="about">About field</param>
        public bool Put(string name, string firstName, string father, DateTime date,
                        string adress, string otdel, string about)
        {
            using (var client = new HttpClient())
            { 
                client.BaseAddress = new Uri(ServerAdress.Adress);

                string myJson = JsonConvert.SerializeObject(new Worker
                {
                    Name = name,
                    FirstName = firstName,
                    Father = father,
                    BirthDate = date,
                    Adress = adress,
                    Otdel = otdel,
                    About = about
                });

                var result = client.PutAsync($"/api/profile", new StringContent(myJson, Encoding.UTF8, "application/json")).Result;
                return result.IsSuccessStatusCode;
            }
        }
    }
}
