using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProfileSystem.Models
{
    public class Worker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string Father { get; set; }
        public DateTime BirthDate { get; set; }
        public string Adress { get; set; }
        public string Otdel { get; set; }
        public string About { get; set; }
    }
}