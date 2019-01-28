using System.ComponentModel.DataAnnotations;

namespace MealTracker.Models
{
    public class Ingredient
    {
        [Key]
        public int ingredID { get; set; }

        public int mealID { get; set; }

        [Display(Name = "Ingredient Name: ")]
        [Required(ErrorMessage = "Ingredient name required")]
        public string ingredname { get; set; }

        [Display(Name = "Cost: ")]
        [Required(ErrorMessage = "Cost required")]
        public short cost { get; set; }
    }
}