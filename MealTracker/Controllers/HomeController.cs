using MealTracker.Concrete;
using MealTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MealTracker.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult MealList()
        {
            EFDBContext context = new EFDBContext();

            MealListViewModel model = new MealListViewModel
            {
                Meals = context.Meals
                .OrderBy(m => m.mealID)
            };
            return View(model);

        }
    }
}