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
        /// <summary>   Event queue for all listeners interested in PropertyChanged events. </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>   Delegate for handling PropertyChanged events. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        public delegate void PropertyChangedEventHandler();

        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <param name="categories">   The categories. </param>
        /// <param name="meals">        The meals. </param>

        public RestaurantFormPresentationModel(BindingList<Category> categories, BindingList<Meal> meals)
        {
            _posRestaurantSideModel = new PosRestaurantSideModel(categories, meals);
            _posRestaurantSideModel.PropertyChanged += _posRestaurantSideModel_PropertyChanged;
        }

        /// <summary>
        /// Event handler. Called by _posRestaurantSideModel for property changed events.
        /// </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Property changed event information. </param>

        private void _posRestaurantSideModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged();
        }

        /// <summary>   Sets selected meal. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <param name="meal"> The meal. </param>

        public void SetSelectedMeal(Meal meal)
        {
            _posRestaurantSideModel.SelectedMealClone = meal;
            _posRestaurantSideModel.SetOriginalMeal(meal);
        }

        /// <summary>   Gets selected meal. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <returns>   The selected meal. </returns>

        public Meal GetSelectedMealClone()
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
        /// <returns>   True if it succeeds, false if it fails. </returns>

        public bool GetMealSaveButtonEnable()
        {
            return _posRestaurantSideModel.GetMealSaveButtonEnable();
        }

        /// <summary>   Gets meal add button enable. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <returns>   True if it succeeds, false if it fails. </returns>

        public bool GetMealAddButtonEnable()
        {
            return _posRestaurantSideModel.GetMealAddButtonEnable();
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
        /// ### <param name="name"> The name. </param>
        ///
        /// ### <param name="price">        The price. </param>
        /// ### <param name="imagePath">    Full pathname of the image file. </param>
        /// ### <param name="description">  The description. </param>
        /// ### <param name="category">     The category. </param>

        public void AddMeal()
        {
            _posRestaurantSideModel.AddMeal();
        }

        /// <summary>   Saves a meal. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// ### <param name="name"> The name. </param>
        ///
        /// ### <param name="price">        The price. </param>
        /// ### <param name="imagePath">    Full pathname of the image file. </param>
        /// ### <param name="description">  The description. </param>
        /// ### <param name="category">     The category. </param>

        public void SaveMeal()
        {
            _posRestaurantSideModel.SaveMeal();
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

        /// <summary>   Deletes the select meal. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/11/12. </remarks>

        public void DeleteSelectMeal()
        {
            _posRestaurantSideModel.DeleteSelectMeal();
        }
    }
}
