// file:	Model\PosRestaurantSideModel.cs
//
// summary:	Implements the position restaurant side model class

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace POSOrderingSystem.Model
{
    /// <summary>   A data Model for the position restaurant side. </summary>
    ///
    /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>

    public class PosRestaurantSideModel
    {
        /// <summary>   The selected meal. </summary>
        private Meal _selectedMeal;
        /// <summary>   The selected meal clone. </summary>
        private Meal _selectedMealClone;
        /// <summary>   The selected category. </summary>
        private Category _selectedCategory;
        /// <summary>   The selected category clone. </summary>
        private Category _selectedCategoryClone;
        /// <summary>   The categories. </summary>
        private readonly BindingList<Category> _categories;
        /// <summary>   The meals. </summary>
        private readonly BindingList<Meal> _meals;
        /// <summary>   Category the meals by belongs to. </summary>
        private readonly BindingList<Meal> _mealsByCategory;
        /// <summary>   Event queue for all listeners interested in PropertyChanged events. </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <param name="categories">   The categories. </param>
        /// <param name="meals">        The meals. </param>

        public PosRestaurantSideModel(BindingList<Category> categories, BindingList<Meal> meals)
        {
            _categories = categories;
            _meals = meals;
            _selectedMeal = new Meal();
            _selectedMealClone = new Meal();
            _selectedCategory = new Category();
            _selectedCategoryClone = new Category();
            _mealsByCategory = new BindingList<Meal>();
        }

        /// <summary>   Gets or sets the selected meal clone. </summary>
        ///
        /// <value> The selected meal clone. </value>

        public object SelectedMealClone
        {
            get
            {
                return _selectedMealClone;
            }
            set
            {
                _selectedMealClone = ((Meal)value).Clone();
            }
        }

        /// <summary>   Gets or sets the selected category clone. </summary>
        ///
        /// <value> The selected category clone. </value>

        public object SelectedCategoryClone
        {
            get
            {
                return _selectedCategoryClone;
            }
            set
            {
                _selectedCategoryClone = ((Category)value).Clone();
            }
        }

        /// <summary>   Gets the category the meals by belongs to. </summary>
        ///
        /// <value> The meals by category. </value>

        public BindingList<Meal> MealsByCategory
        {
            get
            {
                var list = from meal in _meals
                           where meal.Category == _selectedCategory
                           select meal;
                BindingList<Meal> meals = new BindingList<Meal>(list.ToList());
                return meals;
            }
        }

        public BindingList<Meal> MealsByCategory1 => _mealsByCategory;

        /// <summary>   Gets a new meal. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <returns>   The new meal. </returns>

        public Meal GetNewMeal()
        {
            return new Meal()
            {
                Price = 0,
                Descript = string.Empty,
                ImagePath = string.Empty,
                Name = string.Empty
            };
        }

        /// <summary>   Gets a new category. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <returns>   The new category. </returns>

        public Category GetNewCategory()
        {
            return new Category()
            {
                Name = string.Empty
            };
        }

        /// <summary>   Gets meal save button enable. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <param name="name">         The name. </param>
        /// <param name="price">        The price. </param>
        /// <param name="imagePath">    Full pathname of the image file. </param>
        /// <param name="description">  The description. </param>
        /// <param name="category">     The category. </param>
        ///
        /// <returns>   True if it succeeds, false if it fails. </returns>

        public bool GetMealSaveButtonEnable(dynamic dynamic, object category)
        {
            string name = dynamic.name;
            string price = dynamic.price;
            string imagePath = dynamic.imagePath;
            string description = dynamic.description;
            if (category == null) return true;
            if (_selectedMeal.Category.Name != ((Category)category).Name)
            {
                return true;
            }
            if (_selectedMeal.Descript != description)
            {
                return true;
            }
            if (_selectedMeal.ImagePath != imagePath)
            {
                return true;
            }
            if (_selectedMeal.Name != name)
            {
                return true;
            }
            if (_selectedMeal.Price != (string.IsNullOrEmpty(price) ? 0 : Int64.Parse(price)))
            {
                return true;
            }
            return false;
        }

        /// <summary>   Gets meal add button enable. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <param name="name">         The name. </param>
        /// <param name="price">        The price. </param>
        /// <param name="imagePath">    Full pathname of the image file. </param>
        /// <param name="description">  The description. </param>
        /// <param name="category">     The category. </param>
        ///
        /// <returns>   True if it succeeds, false if it fails. </returns>

        public bool GetMealAddButtonEnable(dynamic dynamic,object category)
        {
            if (string.IsNullOrEmpty(dynamic.imagePath))
            {
                return false;
            }
            if (string.IsNullOrEmpty(dynamic.name))
            {
                return false;
            }
            if (string.IsNullOrEmpty(dynamic.price))
            {
                return false;
            }
            return true;
        }

        /// <summary>   Gets category save button enable. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <param name="name"> The name. </param>
        ///
        /// <returns>   True if it succeeds, false if it fails. </returns>

        public bool GetCategorySaveButtonEnable(string name)
        {
            if (name == null) return false;
            if (name == _selectedCategory.Name) return false;
            return true;
        }

        /// <summary>   Gets category add button enable. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <param name="name"> The name. </param>
        ///
        /// <returns>   True if it succeeds, false if it fails. </returns>

        public bool GetCategoryAddButtonEnable(string name)
        {
            if (string.IsNullOrEmpty(name)) return false;
            else return true;
        }

        /// <summary>   Adds a meal. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <param name="name">         The name. </param>
        /// <param name="price">        The price. </param>
        /// <param name="imagePath">    Full pathname of the image file. </param>
        /// <param name="description">  The description. </param>
        /// <param name="category">     The category. </param>

        public void AddMeal(dynamic d)
        {
            Meal meal = new Meal()
            {
                Category = (Category)d.category,
                Descript = d.description,
                ImagePath = d.imagePath,
                Name = d.name,
                Price = Int32.Parse(d.price)
            };
            _meals.Add(meal);
        }

        /// <summary>   Saves a meal. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <param name="name">         The name. </param>
        /// <param name="price">        The price. </param>
        /// <param name="imagePath">    Full pathname of the image file. </param>
        /// <param name="description">  The description. </param>
        /// <param name="category">     The category. </param>

        public void SaveMeal(dynamic dynamic,object category)
        {
            _selectedMeal.Name = dynamic.name;
            _selectedMeal.Price = Int32.Parse(dynamic.price);
            _selectedMeal.ImagePath = dynamic.imagePath;
            _selectedMeal.Descript = dynamic.description;
            _selectedMeal.Category = (Category)category;
        }

        /// <summary>   Adds a category. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <param name="name"> The name. </param>

        public void AddCategory(string name)
        {
            Category category = new Category()
            {
                Name = name
            };
            _categories.Add(category);
        }

        /// <summary>   Saves a category. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <param name="name"> The name. </param>

        public void SaveCategory(string name)
        {
            _selectedCategory.Name = name;
        }

        /// <summary>   Sets original meal. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <param name="meal"> The meal. </param>

        public void SetOriginalMeal(object meal)
        {
            _selectedMeal = (Meal)meal;
        }

        /// <summary>   Sets original category. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <param name="category"> The category. </param>

        public void SetOriginalCategory(object category)
        {
            _selectedCategory = (Category)category;
            NotifyPropertyChanged(nameof(MealsByCategory));
        }

        /// <summary>   Notifies a property changed. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <param name="propertyName"> Name of the property. </param>

        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
