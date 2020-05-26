using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace ProfileSystem.Models
{
    class UserContext : DbContext
    {
        public UserContext()
            : base("DbConnection")
        { }

        public DbSet<Worker> Workers { get; set; }
    }
}