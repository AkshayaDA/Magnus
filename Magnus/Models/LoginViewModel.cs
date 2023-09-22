using System.ComponentModel.DataAnnotations;

namespace Magnus.Models
{
    public class LoginViewModel
    {
        [Key]
        [Required(ErrorMessage = "Username is required")]

        
           // public int Id { get; set; }
            public string Username { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
        

    }
}
