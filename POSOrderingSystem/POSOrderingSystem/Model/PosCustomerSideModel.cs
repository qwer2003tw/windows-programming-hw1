using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSOrderingSystem.Model
{
    public class PosCustomerSideModel
    {
        const string MEALS = @"meals.xml";
        const string MEALS_NAME = "name";
        const string MEALS_PRICE = "price";
        const int PAGE_SIZE = 9;
        const int START_PAGE = 1;
        const int LOCATION_X = 5;
        const int LOCATION_Y = 20;
        const int BUTTON_SPACE = 130;
        const int BUTTON_EACH_LINE = 3;

        /// <summary>   Gets meal data. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 9/25/2018. </remarks>
        ///
        /// <returns>   An array of meal. </returns>

        public List<Meal> GetMealData()
        {
            var meals = new List<Meal>();
            string currentPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string filePath = Path.Combine(currentPath, MEALS);
            DataSet dataSet = new DataSet();

            dataSet.ReadXml(filePath);
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                meals.Add(new Meal()
                {
                    Name = row[MEALS_NAME].ToString(),
                    Price = Int32.Parse(row[MEALS_PRICE].ToString())
                });
            }
            return meals;
        }

        /// <summary>   Initializes the button. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 9/25/2018. </remarks>
        ///
        /// <param> The meals. </param>
        ///
        /// <returns>   The point. </returns>

        public Point GetPoint(int index)
        {
            return new Point(LOCATION_X + BUTTON_SPACE * ((index % PAGE_SIZE) % BUTTON_EACH_LINE), LOCATION_Y + BUTTON_SPACE * ((index % PAGE_SIZE) / BUTTON_EACH_LINE));
        }

        /// <summary>   Gets an enable. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 9/26/2018. </remarks>
        ///
        /// <param name="buttons">      The buttons. </param>
        /// <param name="pageIndex">    Zero-based index of the page. </param>
        /// <param name="mealsSize">    Size of the meals. </param>
        ///
        /// <returns>   True if it succeeds, false if it fails. </returns>

        public bool GetButtonEnable(Buttons buttons, int pageIndex, int mealsSize)
        {
            switch (buttons)
            {
                case Buttons.Next:
                    return (pageIndex != ((mealsSize / PAGE_SIZE) + 1));
                case Buttons.Previous:
                    return (pageIndex != START_PAGE);
                default:
                    return false;
            }
        }

        /// <summary>   Gets a total. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 9/26/2018. </remarks>
        ///
        /// <param name="order">    The _order. </param>
        ///
        /// <returns>   The total. </returns>

        public int GetTotal(Order order)
        {
            int total = 0;
            foreach (var meal in order.Meals)
            {
                total += meal.Price;
            }
            return total;
        }
        public enum Buttons
        {
            Previous,
            Next
        };
    }
}
