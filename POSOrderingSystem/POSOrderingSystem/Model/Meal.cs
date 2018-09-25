using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSOrderingSystem.Model
{
    public class Meal
    {
        string _name;
        int _price;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public int Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }

        /// <summary>   Gets button text. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 9/25/2018. </remarks>
        ///
        /// <returns>   The button text. </returns>

        public string GetButtonText()
        {
            return $"{_name}{Environment.NewLine}${_price}元";
        }
    }
}
