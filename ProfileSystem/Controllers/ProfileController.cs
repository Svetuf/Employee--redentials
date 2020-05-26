using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using ProfileSystem.Models;

namespace ProfileSystem.Controllers
{
    /// <summary>
    /// Main controller. Accepts api requests of the following types:
    /// post, put, delete, and get. Organizes interaction with the employee database.
    /// </summary>
    public class ProfileController : ApiController
    {
        /// <summary>
        /// Accept empty GET request and return list of all employers in database.
        /// </summary>
        /// <returns>
        /// List of all employers in database.
        /// </returns>
        public List<Worker> Get()
        {
            using (UserContext db = new UserContext())
            {
                var users = db.Workers;
                return users.ToList();
            }
        }
        
        /// <summary>
        /// Accepts a Worker object from the request body and adds it to the database.
        /// </summary>
        /// <param name="givenWorker">A Worker object passed in the request body.</param>
        public void Post([FromBody]Worker givenWorker)
        {
            using (UserContext db = new UserContext())
            {
                db.Workers.Add(givenWorker);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Accepts a Worker object. Finds a match by first name, last name, and patronymic. 
        /// Updates employee data in the database.
        /// </summary>
        /// <param name="worker">A Worker object passed in the request body.</param>
        public void Put([FromBody]Worker worker)
        {
            using (UserContext db = new UserContext())
            {
                var allWorkers = db.Workers.AsEnumerable();
                var findWorker = allWorkers.Where(t => (t.FirstName == worker.FirstName) 
                                              && (t.Name == worker.Name)
                                              && (t.Father == worker.Father)).FirstOrDefault();
                findWorker.Name = worker.Name;
                findWorker.FirstName = worker.FirstName;
                findWorker.Father = worker.Father;
                findWorker.BirthDate = worker.BirthDate;
                findWorker.Adress = worker.Adress;
                findWorker.Otdel = worker.Otdel;
                findWorker.About = worker.About;
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Accepts a Worker object. Finds a match by first name, last name, and patronymic. 
        /// Delete employee data from the database.
        /// </summary>
        /// <param name="worker">A Worker object passed in the request body.</param>
        public void Delete([FromBody]Worker worker)
        {
            using (UserContext db = new UserContext())
            {
                var allWorkers = db.Workers.AsEnumerable();
                var findWorker = allWorkers.Where(t => (t.FirstName == worker.FirstName)
                                              && (t.Name == worker.Name)
                                              && (t.Father == worker.Father)).FirstOrDefault();
                db.Workers.Remove(findWorker);
                db.SaveChanges();
            }
        }
    }
}
