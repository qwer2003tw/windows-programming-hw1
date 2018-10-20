using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSOrderingSystem.Model
{
    public class Order
    {
        List<Meal> _meals = new List<Meal>();
        public List<Meal> Meals
        {
            get
            {
                return _meals;
            }
            set
            {
                _meals = value;
            }
        }

        /// <summary>   Creates the meals. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 10/9/2018. </remarks>
        ///
        /// <param name="meals">    The meals. </param>

        public void CreateMeals(Order order)
        {
            List<Meal> meals = order.Meals;
            _meals.Clear();
            _meals.AddRange(meals);
        }

    }
}
