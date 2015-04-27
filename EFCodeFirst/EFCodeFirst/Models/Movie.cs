using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// POCO = Plain Old CLR Object

namespace EFCodeFirst.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Director { get; set; }
    }
}