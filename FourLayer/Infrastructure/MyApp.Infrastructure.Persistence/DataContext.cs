using MyApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Infrastructure.Persistence
{
    internal class DataContext:DbContext
    {
        public DataContext()
        {
            Database.SetInitializer(new DatabaseInitializer());
            this.Configuration.LazyLoadingEnabled = false;
        }
        public IDbSet<Product> Products { get; set; }
    }
}
