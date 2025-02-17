using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kvolikapi.Model
{
    public class Movies
    {
        [Key]
        public int id_Movie { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        [Range(0, 10)]
        public double Rating { get; set; }
        public string ImageUrl { get; set; }
    }
}
