using Microsoft.AspNetCore.Mvc;
using food.Models;
using food.Services;

namespace food.Controllers
{
    public class HomeController : Controller
    {
        private IRestaurantData _restaurantData;

        public HomeController(IRestaurantData restaurantData)
        {
            _restaurantData = restaurantData;
        }

        public IActionResult Index()
        {
            var model = _restaurantData.GetAll();

            //return new ObjectResult(model);
            return View(model);
        }
    }
}