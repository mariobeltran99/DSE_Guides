using System;
using System.Data.Entity;

namespace MvcPelicula.Models
{
    public class Movie
    {
        public string id { get; set; }
        public string title { get; set; }
        public DateTime dateLaunch { get; set; }
        public string genre { get; set; }
        public decimal price { get; set; }
    }
    public class MovieDBContext: DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}