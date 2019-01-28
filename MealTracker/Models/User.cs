using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MealTracker.Models
{
    public class User
    {
        [Key]
        public int userID { get; set; }

        [Display(Name = "Username: ")]
        [Required(ErrorMessage = "Username is required")]
        public string username { get; set; }

        [Display(Name = "Password: ")]
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [NotMapped]
        public string password { get; set; }

        [Display(Name = "Confirm Password: ")]
        [Required(ErrorMessage = "Please confirm your password")]
        [DataType(DataType.Password)]
        [Compare("password", ErrorMessage = "Password doesn't match.")]
        [NotMapped]
        public string confirmpass { get; set; }

        public string passhash { get; set; }

        [Display(Name = "Email: ")]
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string email { get; set; }
    }
}