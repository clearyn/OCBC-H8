using System.ComponentModel.DataAnnotations;

namespace TodoAppWithJWT.Models.DTOs.Requests
{
    public class UserLoginRequestDto
    {
        [Required]
        public string Username { get; set;}
        [Required] 
        [EmailAddress] 
        public string Email { get; set; }  

        [Required]
        public string Password { get; set; }  
    }
}