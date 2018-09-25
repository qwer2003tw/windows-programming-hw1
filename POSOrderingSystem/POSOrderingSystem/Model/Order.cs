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

    }
}
