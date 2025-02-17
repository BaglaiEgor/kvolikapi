using System.ComponentModel.DataAnnotations;

namespace kvolikapi.Model
{
    public class Genres
    {
        [Key]
        public int Id_Genres { get; set; }
        public string Title { get; set; }
    }
}
