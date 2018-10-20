/// <summary>   The position ordering system. model. </summary>
using POSOrderingSystem.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSOrderingSystem.PresentationModel
{
    public class CustomerFormPresentationModel
    {
        const int PAGE_SIZE = 9;
        const int START_PAGE = 1;
        const int LOCATION_X = 5;
        const int LOCATION_Y = 20;
        const int BUTTON_SPACE = 130;
        const int BUTTON_EACH_LINE = 3;
        readonly PosCustomerSideModel _posCustomerSideModel;
        public CustomerFormPresentationModel()
        {
            _posCustomerSideModel = new PosCustomerSideModel();
        }

        /// <summary>   Gets button enable. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 10/9/2018. </remarks>
        ///
        /// <param name="buttons">      The buttons. </param>
        /// <param name="pageIndex">    Zero-based index of the page. </param>
        /// <param name="mealsSize">    Size of the meals. </param>
        ///
        /// <returns>   True if it succeeds, false if it fails. </returns>

        public bool GetButtonEnable(int index, int pageIndex)
        {
            switch (index)
            {
                case 1:
                    return (pageIndex != ((GetMealsCount() / PAGE_SIZE) + 1));
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

        /// <summary>   Gets a point. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 10/9/2018. </remarks>
        ///
        /// <param name="index">    Zero-based index of the. </param>
        ///
        /// <returns>   The point. </returns>

        public Point GetPoint(int index)
        {
            return new Point(LOCATION_X + BUTTON_SPACE * ((index % PAGE_SIZE) % BUTTON_EACH_LINE), LOCATION_Y + BUTTON_SPACE * ((index % PAGE_SIZE) / BUTTON_EACH_LINE));
        }

        /// <summary>   Gets now button data. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 10/9/2018. </remarks>
        ///
        /// <param name="nowButton">    The now button. </param>
        ///
        /// <returns>   An array of object. </returns>

        public Object[] GetNowButtonData(int nowButton)
        {
            return _posCustomerSideModel.GetNowButtonData(nowButton);
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

        /// <summary>   Adds an order. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 10/9/2018. </remarks>
        ///
        /// <param name="meal"> The meal. </param>

        public void AddOrder(Object meal)
        {
            _posCustomerSideModel.AddTempOrder(meal);
        }

        /// <summary>   Gets the total. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 10/9/2018. </remarks>
        ///
        /// <returns>   The total. </returns>

        public int GetTotal()
        {
            return _posCustomerSideModel.GetTotal();
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
            Object[] result = { GetButtonText(index), GetPoint(index) };
            return result;
        }

    }
}
