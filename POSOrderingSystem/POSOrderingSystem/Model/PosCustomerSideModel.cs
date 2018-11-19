/// <summary>   The system. </summary>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;

namespace POSOrderingSystem.Model
{
    /// <summary>   A data Model for the position customer side. </summary>
    ///
    /// <remarks>   Chen-Tai,Peng, 2018/11/12. </remarks>

    public class PosCustomerSideModel
    {
        /// <summary>   Event queue for all listeners interested in _listChanged events. </summary>
        public event ListChangedEventHandler _listChanged;

        /// <summary>   Delegate for handling ListChanged events. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/11/12. </remarks>

        public delegate void ListChangedEventHandler();
        /// <summary>   The meals. </summary>
        readonly BindingList<Meal> _meals;
        /// <summary>   The categories. </summary>
        readonly BindingList<Category> _categories;
        /// <summary>   The order. </summary>
        readonly Order _order;
        /// <summary>   The selected category. </summary>
        readonly Category _selectedCategory;

        /// <summary>   Gets the categories. </summary>
        ///
        /// <value> The categories. </value>

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
            _selectedCategory = new Category();
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
            var meals = new BindingList<Meal>(_meals.Where(meal => meal.Category.Name == _selectedCategory.Name).ToList());
            return meals[index];
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
            _order.AddMeal(GetMealsByCategory()[nowButton]);
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
        /// <returns>   The meal count by category. </returns>
        ///
        /// ### <param name="name"> The name. </param>

        public int GetMealCountByCategory()
        {
            var list = from meal in _meals
                       where meal.Category.Name == _selectedCategory.Name
                       select meal;
            return list.Count();
        }

        /// <summary>   Gets meals by category. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/11/12. </remarks>
        ///
        /// <returns>   The meals by category. </returns>

        public BindingList<Meal> GetMealsByCategory()
        {
            var list = from meal in _meals
                       where meal.Category.Name == _selectedCategory.Name
                       select meal;
            return new BindingList<Meal>(list.ToList());
        }

        /// <summary>   Sets selected category. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/11/12. </remarks>
        ///
        /// <param name="category"> The category. </param>

        public void SetSelectedCategory(string category)
        {
            _selectedCategory.Name = category;
        }
    }
}
