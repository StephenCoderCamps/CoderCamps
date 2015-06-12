using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PhotoAlbum.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string ImageTitle { get; set; }
        public DateTime DateTaken { get; set; }
        public string ImageOwner { get; set; }

        [DataType(DataType.MultilineText)]
        public string ImageDescription { get; set; }
        public int ImageRating { get; set; }
        public string ImageURL { get; set; }
    }
}