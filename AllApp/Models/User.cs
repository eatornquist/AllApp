using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace AllApp.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [DisplayName("Email Confirmed")]
        public string EmailConfirmed { get; set; }= string.Empty;
        [Required]
        [DisplayName("Password Confirmed")]
        public string PasswordConfirmed { get; set; } = string.Empty;
        
    }
}
