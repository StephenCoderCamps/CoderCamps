using PhotoAlbum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhotoAlbum.Services
{
    public class AlbumService : PhotoAlbum.Services.IAlbumService
    {
        private IGenericRepository _repo;
        public AlbumService(IGenericRepository repo)
        {
            _repo = repo;
        }


        public void Create(Album album) { 
            _repo.Add(album);
            _repo.SaveChanges();
        
        }


        public IList<Album> ListAlbums() {
         return _repo.Query<Album>().ToList();        
        }

        public Album ShowAlbum(int id) {
            return (_repo.Query<Album>().Include(i => i.Image).Where(i => i.Id == id)).FirstOrDefault();
        }

        public Image ShowImage(int id) { 
            var currentImage = _repo.Find<Image>(id);
            return (currentImage);
        
        }

        public void ImageAdd(int id, Image image) {
            var currentAlbum = _repo.Find<Album>(id);
            currentAlbum.Image.Add(image);
            _repo.SaveChanges();
        }
    }
}