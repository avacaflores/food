using System.Collections.Generic;
using food.Models;

namespace food.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }
}