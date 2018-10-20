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
        string _descript;
        const string DELETE_TEXT = "X";
        const string DOLLAR = "元";

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
        public string Descript
        {
            get
            {
                return _descript;
            }
            set
            {
                _descript = value;
            }
        }

        /// <summary>   Gets button text. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 9/25/2018. </remarks>
        ///
        /// <returns>   The button text. </returns>

        public string GetButtonText()
        {
            return $"{_name}{Environment.NewLine}${_price}{DOLLAR}";
        }

        /// <summary>   Gets button data. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 10/9/2018. </remarks>
        ///
        /// <returns>   An array of object. </returns>

        public Object[] GetButtonData()
        {
            Object[] result = { DELETE_TEXT, _name, _price + DOLLAR, this, _descript };
            return result;
        }
    }
}
