using System.ComponentModel.DataAnnotations;

namespace kvolikapi.Model
{
    public class Users
    {
        [Key]
        public int id_User { get; set; }
        public string? Name { get; set; }
        public string? Discription { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public string Role { get; set; }
    }
    public class LoginRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
