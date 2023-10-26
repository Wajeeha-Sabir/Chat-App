using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http.HttpResults;

namespace API.DTO
{
    public class RegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        
        

    }
}