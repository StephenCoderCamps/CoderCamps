using EFCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFCodeFirst.Infrastructure
{
    public class EFRepository : EFCodeFirst.Infrastructure.IRepository
    {

        private DataContext _dc = new DataContext();


        public IList<Movie> ListMovies() 
        {
            return (from m in _dc.Movies select m).ToList();
        }

        public Movie FindMovie(int id)
        {
            return _dc.Movies.Find(id);
        }


        public void CreateMovie(Movie movie)
        {
            _dc.Movies.Add(movie);
            _dc.SaveChanges();
        }

        public void EditMovie(Movie movie)
        {
            var original = this.FindMovie(movie.Id);
            original.Title = movie.Title;
            original.Director = movie.Director;
            _dc.SaveChanges();
        }


        public void DeleteMovie(int id)
        {
            var original = this.FindMovie(id);
            _dc.Movies.Remove(original);
            _dc.SaveChanges();
        }

    }
}