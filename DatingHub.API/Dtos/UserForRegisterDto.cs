using System.ComponentModel.DataAnnotations;

namespace DatingHub.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "The password must be at least between 4 to 8 characters.")]
        public string Password { get; set; }
    }
}