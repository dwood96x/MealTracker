using System.ComponentModel.DataAnnotations;

namespace MealTracker.Models
{
    public class Meal
    {
        [Key]
        public int mealID { get; set; }

        public int userID { get; set; }

        [Required(ErrorMessage = "Name for the meal is required")]
        [Display(Name = "Meal name: ")]
        public string mealname { get; set; }

        [Display(Name = "Total Cost: ")]
        [DataType(DataType.Currency)]
        public decimal totalcost { get; set; }

        [Display(Name = "Servings: ")]
        public int servings { get; set; }
    }
}