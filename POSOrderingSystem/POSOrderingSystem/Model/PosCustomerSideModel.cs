/// <summary>   The system. </summary>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;

namespace POSOrderingSystem.Model
{
    public class PosCustomerSideModel
    {
        public event ListChangedEventHandler _listChanged;
        public delegate void ListChangedEventHandler();
        readonly BindingList<Meal> _meals;
        readonly BindingList<Category> _categories;
        readonly Order _order;

        public BindingList<Category> Categories => _categories;

        /// <summary>   Gets meal data. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 9/25/2018. </remarks>
        ///
        /// <param name="categories">   The categories. </param>
        /// <param name="meals">        The meals. </param>

        public PosCustomerSideModel(BindingList<Category> categories, BindingList<Meal> meals)
        {
            _categories = categories;
            _meals = meals;
            _order = new Order();
            _meals.ListChanged += ListChanged;
            _categories.ListChanged += ListChanged;
        }

        /// <summary>   List changed. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        List changed event information. </param>

        private void ListChanged(object sender, ListChangedEventArgs e)
        {
            _listChanged();
        }

        /// <summary>   Gets now button data. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 9/30/2018. </remarks>
        ///
        /// <param name="nowButton">    The now button. </param>
        ///
        /// <returns>   An array of string. </returns>

        public string GetNowButtonMealDescription(int nowButton)
        {
            Meal meal = _meals[nowButton];
            return meal.Descript;
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

        /// <summary>   Gets the order. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 10/2/2018. </remarks>
        ///
        /// <returns>   The order. </returns>

        public Order GetOrder()
        {
            return _order;
        }

        /// <summary>   Adds a now button meal. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <param name="nowButton">    The now button. </param>

        public void AddNowButtonMeal(int nowButton)
        {
            _order.AddMeal(_meals[nowButton]);
        }

        /// <summary>   Gets total of price. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/29. </remarks>
        ///
        /// <returns>   The total of price. </returns>

        public BindingList<OrderItem> GetBindingList()
        {
            return _order.OrderItems;
        }

        /// <summary>   Deletes the meal by index described by index. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <param> The meals. </param>

        public void DeleteMealByIndex(int index)
        {
            _order.DeleteMeal(index);
        }

        /// <summary>   Gets meal count by category. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <param name="name"> The name. </param>
        ///
        /// <returns>   The meal count by category. </returns>

        public int GetMealCountByCategory(string name)
        {
            var list = from meal in _meals
                       where meal.Category.Name == name
                       select meal;
            return list.Count();
        }
    }
}
