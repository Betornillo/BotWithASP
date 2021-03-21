using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterDto
    {

        [Required]
        public string Username { get; set; }

        public int Age { get; set; }

        public double Salary { get; set; }

        public string Rank { get; set; }

        public string Password { get; set; }

    }
}