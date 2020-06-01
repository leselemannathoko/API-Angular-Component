using Microsoft.EntityFrameworkCore;
using Rest_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Rest_Api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }


            public DbSet<Person> People{ get; set; }
            public DbSet<User> Users { get; set; }

    }
}


