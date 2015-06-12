using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhotoAlbum.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string AlbumName { get; set; }
        public string AlbumOwner { get; set; }
        public ICollection<Image> Image { get; set; }
        public Album()
        {
            this.Image = new List<Image>();
        }
    }
}