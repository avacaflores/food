using System.Collections.Generic;
using System.Linq;
using food.Models;

namespace food.Services
{
    public class InMemoryRestaurantData :IRestaurantData
    {

        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant { Id = 1, Name = "La Taberna" },
                new Restaurant { Id = 2, Name = "Riverview" },
                new Restaurant { Id = 3, Name = "Mio" }
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants.OrderBy(r => r.Name);
        }

        List<Restaurant> _restaurants;
    }
}