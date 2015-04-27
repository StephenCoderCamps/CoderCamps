using System;
namespace EFCodeFirst.Infrastructure
{
    public interface IRepository
    {
        void CreateMovie(EFCodeFirst.Models.Movie movie);
        void DeleteMovie(int id);
        void EditMovie(EFCodeFirst.Models.Movie movie);
        EFCodeFirst.Models.Movie FindMovie(int id);
        System.Collections.Generic.IList<EFCodeFirst.Models.Movie> ListMovies();
    }
}
