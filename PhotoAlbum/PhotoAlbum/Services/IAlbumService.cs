using PhotoAlbum.Models;
using System;
using System.Collections.Generic;
namespace PhotoAlbum.Services
{
    public interface IAlbumService
    {
        void Create(PhotoAlbum.Models.Album album);
        void ImageAdd(int id, PhotoAlbum.Models.Image image);

        IList<Album> ListAlbums();

        Album ShowAlbum(int id);

        Image ShowImage(int id);
    }
}
