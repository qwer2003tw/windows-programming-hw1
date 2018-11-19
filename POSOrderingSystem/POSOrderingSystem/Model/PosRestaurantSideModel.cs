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

    public class PosRestaurantSideModel : INotifyPropertyChanged
    {
        /// <summary>   The selected meal. </summary>
        private Meal _selectedMeal;
        /// <summary>   The selected meal clone. </summary>
        private Meal _selectedMealClone;
        private Meal _newMeal;
        /// <summary>   The selected category. </summary>
        private Category _selectedCategory;
        /// <summary>   The selected category clone. </summary>
        private Category _selectedCategoryClone;
        /// <summary>   The categories. </summary>
        private readonly BindingList<Category> _categories;
        /// <summary>   The meals. </summary>
        private readonly BindingList<Meal> _meals;
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
        }

        /// <summary>   Gets or sets the selected meal clone. </summary>
        ///
        /// <value> The selected meal clone. </value>

        public Meal SelectedMealClone
        {
            get
            {
                return _selectedMealClone;
            }
            set
            {
                _selectedMealClone = value.Clone();
                NotifyPropertyChanged(nameof(SelectedMealClone));
            }
        }
        public object SelectedMeal
        {
            get
            {
                return _selectedMeal;
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
                NotifyPropertyChanged(nameof(SelectedCategoryClone));
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

        /// <summary>   Gets a new meal. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <returns>   The new meal. </returns>

        public Meal GetNewMeal()
        {
            _newMeal = new Meal()
            {
                Price = 0,
                Descript = string.Empty,
                ImagePath = string.Empty,
                Name = string.Empty,
                Category = _categories[0]
            };
            return _newMeal;
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
        /// <returns>   True if it succeeds, false if it fails. </returns>

        public bool GetMealSaveButtonEnable()
        {
            if (_selectedMeal.Category.Name != _selectedMealClone.Category.Name)
            {
                return true;
            }
            if (_selectedMeal.Descript != _selectedMealClone.Descript)
            {
                return true;
            }
            if (_selectedMeal.ImagePath != _selectedMealClone.ImagePath)
            {
                return true;
            }
            if (_selectedMeal.Name != _selectedMealClone.Name)
            {
                return true;
            }
            if (_selectedMeal.Price != _selectedMealClone.Price)
            {
                return true;
            }
            return false;
        }

        /// <summary>   Gets meal add button enable. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <returns>   True if it succeeds, false if it fails. </returns>

        public bool GetMealAddButtonEnable()
        {
            if (string.IsNullOrEmpty(_newMeal.ImagePath))
            {
                return false;
            }
            if (string.IsNullOrEmpty(_newMeal.Name))
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
        /// <param name="d">    The name. </param>
        ///
        /// ### <param name="price">    The price. </param>
        ///
        /// ### <param name="imagePath">    Full pathname of the image file. </param>
        /// ### <param name="description">  The description. </param>
        /// ### <param name="category">     The category. </param>

        public void AddMeal()
        {
            _meals.Add(_newMeal);
        }

        /// <summary>   Saves a meal. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <param name="dynamic">  The name. </param>
        /// <param name="category"> The category. </param>
        ///
        /// ### <param name="price">    The price. </param>
        ///
        /// ### <param name="imagePath">    Full pathname of the image file. </param>
        /// ### <param name="description">  The description. </param>

        public void SaveMeal()
        {
            _selectedMeal.Category = _selectedMealClone.Category;
            _selectedMeal.Name = _selectedMealClone.Name;
            _selectedMeal.Price = _selectedMealClone.Price;
            _selectedMeal.ImagePath = _selectedMealClone.ImagePath;
            _selectedMeal.Descript = _selectedMealClone.Descript;
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

        /// <summary>   Deletes the select meal. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/11/12. </remarks>

        public void DeleteSelectMeal()
        {
            _meals.Remove(_selectedMeal);
        }
    }
}
