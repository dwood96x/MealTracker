using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MealTracker.Models
{
    public class MealListViewModel
    {
        public IEnumerable<Meal> Meals { get; set; }

    }
}