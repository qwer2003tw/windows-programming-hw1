// file:	PresentationModel\CustomerFormPresentationModel.cs
//
// summary:	Implements the customer form presentation model class

using POSOrderingSystem.Model;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace POSOrderingSystem.PresentationModel
{
    /// <summary>   A data Model for the customer form presentation. </summary>
    ///
    /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>

    public class CustomerFormPresentationModel
    {
        /// <summary>   Size of the page. </summary>
        const int PAGE_SIZE = 9;
        /// <summary>   The start page. </summary>
        const int START_PAGE = 1;
        /// <summary>   The location x coordinate. </summary>
        const int LOCATION_X = 5;
        /// <summary>   The location y coordinate. </summary>
        const int LOCATION_Y = 20;
        /// <summary>   The button space. </summary>
        const int BUTTON_SPACE = 110;
        /// <summary>   The button each line. </summary>
        const int BUTTON_EACH_LINE = 3;
        /// <summary>   The not select. </summary>
        const int NOT_SELECT = -1;
        /// <summary>   The now button. </summary>
        int _nowButton = NOT_SELECT;

        /// <summary>   The position customer side model. </summary>
        readonly PosCustomerSideModel _posCustomerSideModel;
        /// <summary>   Event queue for all listeners interested in _listChanged events. </summary>
        public event ListChangedEventHandler _listChanged;

        /// <summary>   Delegate for handling ListChanged events. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>

        public delegate void ListChangedEventHandler();

        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <param name="categories">   The categories. </param>
        /// <param name="meals">        The meals. </param>

        public CustomerFormPresentationModel(BindingList<Category> categories, BindingList<Meal> meals)
        {
            _posCustomerSideModel = new PosCustomerSideModel(categories, meals);
            _posCustomerSideModel._listChanged += _posCustomerSideModel__listChanged;
        }

        /// <summary>   Position customer side model list changed. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>

        private void _posCustomerSideModel__listChanged()
        {
            _listChanged();
        }

        /// <summary>   Gets button enable. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 10/9/2018. </remarks>
        ///
        /// <param name="index">        Zero-based index of the. </param>
        /// <param name="pageIndex">    Zero-based index of the page. </param>
        ///
        /// <returns>   True if it succeeds, false if it fails. </returns>

        public bool GetButtonEnable(int index, int pageIndex)
        {

            switch (index)
            {
                case 1:
                    return (pageIndex != (GetMealCountByCategory() / PAGE_SIZE) + 1);
                case 0:
                    return (pageIndex != START_PAGE);
                default:
                    return false;
            }
        }

        /// <summary>   Gets meals count. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 10/9/2018. </remarks>
        ///
        /// <returns>   The meals count. </returns>

        public int GetMealsCount()
        {
            return _posCustomerSideModel.GetMealsCount();
        }

        /// <summary>   Gets button text. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 10/9/2018. </remarks>
        ///
        /// <param name="index">    Zero-based index of the. </param>
        ///
        /// <returns>   The button text. </returns>

        public string GetButtonText(int index)
        {
            return GetMealByIndex(index).GetButtonText();
        }

        /// <summary>   Gets image path. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <param name="index">    Zero-based index of the. </param>
        ///
        /// <returns>   The image path. </returns>

        public string GetImagePath(int index)
        {
            return GetMealByIndex(index).ImagePath;
        }

        /// <summary>   Gets now button data. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 10/9/2018. </remarks>

        public void AddNowButtonMeal()
        {
            _posCustomerSideModel.AddNowButtonMeal(_nowButton);
            SetNowButton(NOT_SELECT);
        }

        /// <summary>   Gets meal by index. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 10/9/2018. </remarks>
        ///
        /// <param name="index">    Zero-based index of the. </param>
        ///
        /// <returns>   The meal by index. </returns>

        public Meal GetMealByIndex(int index)
        {
            return _posCustomerSideModel.GetMealByIndex(index);
        }

        /// <summary>   Gets button information. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 10/9/2018. </remarks>
        ///
        /// <param name="index">    Zero-based index of the. </param>
        ///
        /// <returns>   An array of object. </returns>

        public object[] GetButtonInfo(int index)
        {
            Object[] result = { GetButtonText(index), GetPoint(index), GetImagePath(index) };
            return result;
        }

        /// <summary>   Gets page label text. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/22. </remarks>
        ///
        /// <param name="pageIndex">    Zero-based index of the page. </param>
        ///
        /// <returns>   The page label text. </returns>

        public string GetPageLabelText(int pageIndex)
        {
            return $"Page : {pageIndex}/{(GetMealCountByCategory() / PAGE_SIZE) + 1}";
        }

        /// <summary>   Query if this object is button selected. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/22. </remarks>
        ///
        /// <returns>   True if button selected, false if not. </returns>

        public bool IsButtonSelected()
        {
            return (_nowButton != NOT_SELECT);
        }

        /// <summary>   Sets now button. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/22. </remarks>
        ///
        /// <param name="nowButton">    The now button. </param>

        public void SetNowButton(int nowButton)
        {
            _nowButton = nowButton;
        }

        /// <summary>   Gets now button meal description. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/29. </remarks>
        ///
        /// <returns>   The now button meal description. </returns>

        public string GetNowButtonMealDescription()
        {
            return _posCustomerSideModel.GetNowButtonMealDescription(_nowButton);
        }

        /// <summary>   Gets binding list. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <returns>   The binding list. </returns>

        public IList GetBindingList()
        {
            return _posCustomerSideModel.GetBindingList();
        }

        /// <summary>   Deletes the meal by index described by index. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <param name="index">    Zero-based index of the. </param>

        public void DeleteMealByIndex(int index)
        {
            _posCustomerSideModel.DeleteMealByIndex(index);
        }

        /// <summary>   Gets the order. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <returns>   The order. </returns>

        public Order GetOrder()
        {
            return _posCustomerSideModel.GetOrder();
        }

        /// <summary>   Gets a point. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 10/9/2018. </remarks>
        ///
        /// <param name="index">    Zero-based index of the. </param>
        ///
        /// <returns>   The point. </returns>

        private Point GetPoint(int index)
        {
            return new Point(LOCATION_X + BUTTON_SPACE * ((index % PAGE_SIZE) % BUTTON_EACH_LINE), LOCATION_Y + BUTTON_SPACE * ((index % PAGE_SIZE) / BUTTON_EACH_LINE));
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
            return _posCustomerSideModel.GetMealCountByCategory();
        }

        /// <summary>   Gets meals by category. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/11/12. </remarks>
        ///
        /// <returns>   The meals by category. </returns>

        public BindingList<Meal> GetMealsByCategory()
        {
            return _posCustomerSideModel.GetMealsByCategory();
        }

        /// <summary>   Gets the categories. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/11/12. </remarks>
        ///
        /// <returns>   The categories. </returns>

        public BindingList<Category> GetCategories()
        {
            return _posCustomerSideModel.Categories;
        }

        /// <summary>   Sets selected category. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/11/12. </remarks>
        ///
        /// <param name="category"> The category. </param>

        public void SetSelectedCategory(string category)
        {
            _posCustomerSideModel.SetSelectedCategory(category);
        }
    }
}
