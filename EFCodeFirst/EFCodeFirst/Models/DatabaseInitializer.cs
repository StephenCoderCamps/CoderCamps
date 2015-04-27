using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EFCodeFirst.Models
{
    public class DatabaseInitializer : DropCreateDatabaseAlways<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var movies = new List<Movie>
            {
                new Movie {Title="Star Wars", Director="Lucas"},
                new Movie {Title="King Kong", Director="Jackson"},
                new Movie {Title="Memento", Director="Nolan"}
            };

            movies.ForEach(m => context.Movies.Add(m));
        }
    }
}