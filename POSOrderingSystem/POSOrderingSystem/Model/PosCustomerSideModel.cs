/// <summary>   The system. </summary>
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
        const string MEALS_DESCRIPTION = "description";

        List<Meal> _meals;
        readonly Order _order;
        readonly Order _tempOrder;

        /// <summary>   Gets meal data. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 9/25/2018. </remarks>
        ///
        /// ### <returns>   An array of meal. </returns>

        public PosCustomerSideModel()
        {
            GetMealData();
            _order = new Order();
            _tempOrder = new Order();
        }

        /// <summary>   Gets meal data. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 9/30/2018. </remarks>

        private void GetMealData()
        {
            _meals = new List<Meal>();
            string currentPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string filePath = Path.Combine(currentPath, MEALS);
            DataSet dataSet = new DataSet();

            dataSet.ReadXml(filePath);
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                _meals.Add(new Meal()
                {
                    Name = row[MEALS_NAME].ToString(),
                    Price = Int32.Parse(row[MEALS_PRICE].ToString()),
                    Descript = row[MEALS_DESCRIPTION].ToString()
                });
            }
        }

        /// <summary>   Gets the total. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 10/9/2018. </remarks>
        ///
        /// <returns>   The total. </returns>

        public int GetTotal()
        {
            CreateOrderByMeals();
            int total = 0;
            foreach (var meal in _order.Meals)
            {
                total += meal.Price;
            }
            return total;
        }

        /// <summary>   Gets now button data. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 9/30/2018. </remarks>
        ///
        /// <param name="nowButton">    The now button. </param>
        ///
        /// <returns>   An array of string. </returns>

        public Object[] GetNowButtonData(int nowButton)
        {
            Meal meal = _meals[nowButton];
            Object[] result = meal.GetButtonData();
            return result;
        }

        /// <summary>   Gets meals count. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 10/2/2018. </remarks>
        ///
        /// <returns>   The meals count. </returns>

        public int GetMealsCount()
        {
            return _meals.Count;
        }

        /// <summary>   Gets meal by index. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 10/2/2018. </remarks>
        ///
        /// <param> The meals. </param>
        ///
        /// <returns>   The meal by index. </returns>

        public Meal GetMealByIndex(int index)
        {
            return _meals[index];
        }

        /// <summary>   Adds an order by meal. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 10/2/2018. </remarks>
        ///
        /// ### <param name="meal"> The meal. </param>

        public void CreateOrderByMeals()
        {
            _order.CreateMeals(_tempOrder);
            ClearOrder();

        }

        /// <summary>   Clears the order. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 10/9/2018. </remarks>

        public void ClearOrder()
        {
            _tempOrder.Meals.Clear();
        }

        /// <summary>   Adds a temporary order. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 10/9/2018. </remarks>
        ///
        /// <param name="meal"> The meal. </param>

        public void AddTempOrder(Object meal)
        {
            _tempOrder.Meals.Add((Meal)meal);
        }
        /// <summary>   Gets the order. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 10/2/2018. </remarks>
        ///
        /// <returns>   The order. </returns>

        public Order GetOrder()
        {
            return _order;
        }

    }
}
