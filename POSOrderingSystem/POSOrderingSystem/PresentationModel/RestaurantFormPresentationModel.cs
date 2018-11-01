// file:	PresentationModel\RestaurantFormPresentationModel.cs
//
// summary:	Implements the restaurant form presentation model class

using POSOrderingSystem.Model;
using System.ComponentModel;

namespace POSOrderingSystem.PresentationModel
{
    /// <summary>   A data Model for the restaurant form presentation. </summary>
    ///
    /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>

    public class RestaurantFormPresentationModel
    {
        /// <summary>   The position restaurant side model. </summary>
        readonly PosRestaurantSideModel _posRestaurantSideModel;

        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <param name="categories">   The categories. </param>
        /// <param name="meals">        The meals. </param>

        public RestaurantFormPresentationModel(BindingList<Category> categories, BindingList<Meal> meals)
        {
            _posRestaurantSideModel = new PosRestaurantSideModel(categories, meals);
        }

        /// <summary>   Sets selected meal. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <param name="meal"> The meal. </param>

        public void SetSelectedMeal(object meal)
        {
            _posRestaurantSideModel.SelectedMealClone = meal;
            _posRestaurantSideModel.SetOriginalMeal(meal);
        }

        /// <summary>   Gets selected meal. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <returns>   The selected meal. </returns>

        public object GetSelectedMeal()
        {
            return _posRestaurantSideModel.SelectedMealClone;
        }

        /// <summary>   Gets a new meal. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <returns>   The new meal. </returns>

        public object GetNewMeal()
        {
            return _posRestaurantSideModel.GetNewMeal();
        }

        /// <summary>   Gets a new category. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <returns>   The new category. </returns>

        public object GetNewCategory()
        {
            return _posRestaurantSideModel.GetNewCategory();
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

        public bool GetMealSaveButtonEnable(dynamic mealDynamic, object category)
        {
            return _posRestaurantSideModel.GetMealSaveButtonEnable(mealDynamic, category);
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

        public bool GetMealAddButtonEnable(dynamic dynamic, object category)
        {
            return _posRestaurantSideModel.GetMealAddButtonEnable(dynamic, category);
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
            return _posRestaurantSideModel.GetCategorySaveButtonEnable(name);
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
            return _posRestaurantSideModel.GetCategoryAddButtonEnable(name);
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

        public void AddMeal(dynamic mealDynamic)
        {
            _posRestaurantSideModel.AddMeal(mealDynamic);
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

        public void SaveMeal(dynamic mealDynamic, object category)
        {
            _posRestaurantSideModel.SaveMeal(mealDynamic, category);
        }

        /// <summary>   Adds a category. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <param name="name"> The name. </param>

        public void AddCategory(string name)
        {
            _posRestaurantSideModel.AddCategory(name);
        }

        /// <summary>   Saves a category. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <param name="name"> The name. </param>

        public void SaveCategory(string name)
        {
            _posRestaurantSideModel.SaveCategory(name);
        }

        /// <summary>   Gets meals by category. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <returns>   The meals by category. </returns>

        public IBindingList GetMealsByCategory()
        {
            return _posRestaurantSideModel.MealsByCategory;
        }

        /// <summary>   Sets selected category. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <param name="category"> The category. </param>

        public void SetSelectedCategory(object category)
        {
            _posRestaurantSideModel.SelectedCategoryClone = category;
            _posRestaurantSideModel.SetOriginalCategory(category);
        }

        /// <summary>   Gets selected category. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <returns>   The selected category. </returns>

        public object GetSelectedCategory()
        {
            return _posRestaurantSideModel.SelectedCategoryClone;
        }
    }
}
