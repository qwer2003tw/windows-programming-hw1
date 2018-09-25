using POSOrderingSystem.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace POSOrderingSystem
{
    public partial class POSCustomerSideForm : Form
    {

        const int PAGE_SIZE = 9;
        const int START_PAGE = 1;
        const int BUTTON_SIZE = 100;
        const int NOT_SELECT = -1;
        Button[] _buttons;
        List<Meal> _meals;
        int _pageIndex;
        int _nowButton = NOT_SELECT;
        Order _order;
        public POSCustomerSideForm()
        {
            InitializeComponent();
            PosCustomerSideModel posCustomerSideModel = new PosCustomerSideModel();
            _meals = posCustomerSideModel.GetMealData();
            _buttons = new Button[_meals.Count];
            _pageIndex = START_PAGE;
            InitButton(_meals);
            LoadPage(_pageIndex, true);
            _order = new Order();
        }

        /// <summary>   Loads a page. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 9/25/2018. </remarks>
        ///
        /// <param> Zero-based index of the page. </param>
        /// <param> The meals. </param>

        protected void LoadPage(int pageIndex, bool visible)
        {
            var showButtons = _buttons.Skip((pageIndex - 1) * PAGE_SIZE).Take(PAGE_SIZE);
            PosCustomerSideModel posCustomerSideModel = new PosCustomerSideModel();

            foreach (var btn in showButtons)
            {
                btn.Visible = visible;
            }
            _previousButton.Enabled = posCustomerSideModel.GetButtonEnable(PosCustomerSideModel.Buttons.Previous, pageIndex, _meals.Count);
            _nextButton.Enabled = posCustomerSideModel.GetButtonEnable(PosCustomerSideModel.Buttons.Next, pageIndex, _meals.Count);
            _pageLabel.Text = $"Page : {pageIndex}/{(_meals.Count / PAGE_SIZE) + 1}";
        }

        /// <summary>   Initializes the button. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 9/25/2018. </remarks>
        ///
        /// <param> The meals. </param>

        private void InitButton(List<Meal> meals)
        {
            PosCustomerSideModel posCustomerSideModel = new PosCustomerSideModel();
            _addButton.Enabled = false;
            for (int i = 0; i < _buttons.Length; i++)
            {
                _buttons[i] = new Button
                {
                    Tag = i,
                    Visible = false,
                    Text = meals[i].GetButtonText(),
                    Size = new Size(BUTTON_SIZE, BUTTON_SIZE),
                    Location = posCustomerSideModel.GetPoint(i)
                };
                _buttons[i].Click += new EventHandler(MealButton_Click);
                _mealGroupBox.Controls.Add(_buttons[i]);
            }
        }

        /// <summary>   Event handler. Called by _nextButton for click events. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 9/25/2018. </remarks>
        ///
        /// <param> Source of the event. </param>
        /// <param> Event information. </param>

        private void NextButton_Click(object sender, EventArgs e)
        {
            LoadPage(_pageIndex++, false);
            LoadPage(_pageIndex, true);
        }

        /// <summary>   Event handler. Called by _previousButton for click events. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 9/25/2018. </remarks>
        ///
        /// <param> Source of the event. </param>
        /// <param> Event information. </param>

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            LoadPage(_pageIndex--, false);
            LoadPage(_pageIndex, true);
        }

        /// <summary>   Event handler. Called by MealButton for click events. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 9/25/2018. </remarks>
        ///
        /// <param> Source of the event. </param>
        /// <param> Event information. </param>

        private void MealButton_Click(object sender, EventArgs e)
        {
            _nowButton = Int32.Parse(((Button)sender).Tag.ToString());
            _addButton.Enabled = true;
        }

        /// <summary>   Event handler. Called by _addButton for click events. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 9/25/2018. </remarks>
        ///
        /// <param> Source of the event. </param>
        /// <param> Event information. </param>

        private void _addButton_Click(object sender, EventArgs e)
        {
            PosCustomerSideModel posCustomerSideModel = new PosCustomerSideModel();

            if (_nowButton == -1) return;
            DataGridViewRowCollection rows = _mealsDataGridView.Rows;
            Meal meal = _meals[_nowButton];
            rows.Add(meal.Name, meal.Price + "元");
            _order.Meals.Add(meal);
            _nowButton = NOT_SELECT;
            _addButton.Enabled = false;
            _totalLabel.Text = $"Total:{posCustomerSideModel.GetTotal(_order)}元";
        }
    }
}
