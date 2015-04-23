using MyApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Infrastructure.Persistence
{
    internal class DatabaseInitializer:DropCreateDatabaseAlways<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var products = new List<Product> {
                new Product {Name="Milk", Price=2.33m, Description="Yum, milk"},
                new Product {Name="Eggs", Price=1.44m, Description="Yum, eggs"},
                new Product {Name="Cheese", Price=5.20m, Description="Yum, cheese"}
            };
            products.ForEach(p => context.Products.Add(p));
        }

    }
}
