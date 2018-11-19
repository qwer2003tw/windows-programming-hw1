// file:	POSCustomerSideForm.cs
//
// summary:	Implements the position customer side Windows Form

using POSOrderingSystem.Model;
using POSOrderingSystem.PresentationModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace POSOrderingSystem
{
    /// <summary>   Form for viewing the position customer side. </summary>
    ///
    /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>

    public partial class POSCustomerSideForm : Form
    {

        /// <summary>   Size of the page. </summary>
        const int PAGE_SIZE = 9;
        /// <summary>   The start page. </summary>
        const int START_PAGE = 1;
        /// <summary>   Size of the button. </summary>
        const int BUTTON_SIZE = 100;
        /// <summary>   Zero-based index of the page. </summary>
        int _pageIndex;
        /// <summary>   The customer form presentation model. </summary>
        CustomerFormPresentationModel _customerFormPresentationModel;

        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <param name="categories">   The categories. </param>
        /// <param name="meals">        The meals. </param>

        public POSCustomerSideForm(BindingList<Category> categories, BindingList<Meal> meals)
        {
            InitializeComponent();
            _customerFormPresentationModel = new CustomerFormPresentationModel(categories, meals);
            _pageIndex = START_PAGE;
            _mealsDataGridView.DataSource = _customerFormPresentationModel.GetBindingList();
            _customerFormPresentationModel._listChanged += _customerFormPresentationModel__listChanged;
            _orderBindingSource.DataSource = _customerFormPresentationModel.GetOrder();
        }

        /// <summary>   Customer form presentation model list changed. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>

        private void _customerFormPresentationModel__listChanged()
        {
            _mealsDataGridView.Update();
            _mealsDataGridView.Refresh();
            _totalLabel.Update();
            _totalLabel.Refresh();
            var buttons = _tabControl1.SelectedTab.Controls.OfType<Button>();
            foreach (var btn in buttons)
            {
                Object[] info = _customerFormPresentationModel.GetButtonInfo(Array.IndexOf(buttons.ToArray(), btn));
                btn.Text = info[0].ToString();
                btn.Image = Image.FromFile($@"..\..\{info[2]}");
            }
        }

        /// <summary>   Loads a page. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 9/25/2018. </remarks>
        ///
        /// <param> Zero-based index of the page. </param>
        /// <param> The meals. </param>

        protected void LoadPage(int pageIndex)
        {
            string projectPath = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));
            _tabControl1.SelectedTab.Controls.Clear();
            var meals = _customerFormPresentationModel.GetMealsByCategory().Skip((pageIndex - 1) * PAGE_SIZE).Take(PAGE_SIZE);
            foreach (var meal in meals)
            {
                Object[] info = _customerFormPresentationModel.GetButtonInfo(Array.IndexOf(meals.ToArray(), meal) + (pageIndex - 1) * PAGE_SIZE);
                Button button = new Button
                {
                    Tag = Array.IndexOf(meals.ToArray(), meal),
                    Visible = true,
                    Text = info[0].ToString(),
                    Size = new Size(BUTTON_SIZE, BUTTON_SIZE),
                    Location = (Point)info[1],
                    Image = Image.FromFile(Path.Combine(projectPath, (string)(info[2])))
                };
                button.Click += new EventHandler(ClickMealButton);
                _tabControl1.SelectedTab.Controls.Add(button);
            }
            _previousButton.Enabled = _customerFormPresentationModel.GetButtonEnable((int)Buttons.Previous, pageIndex);
            _nextButton.Enabled = _customerFormPresentationModel.GetButtonEnable((int)Buttons.Next, pageIndex);
            _pageLabel.Text = _customerFormPresentationModel.GetPageLabelText(pageIndex);

        }

        /// <summary>   Event handler. Called by _nextButton for click events. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 9/25/2018. </remarks>
        ///
        /// <param> Source of the event. </param>
        /// <param> Event information. </param>

        private void ClickNextPageButton(object sender, EventArgs e)
        {
            LoadPage(++_pageIndex);
        }

        /// <summary>   Event handler. Called by _previousButton for click events. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 9/25/2018. </remarks>
        ///
        /// <param> Source of the event. </param>
        /// <param> Event information. </param>

        private void ClickPreviousPageButton(object sender, EventArgs e)
        {
            LoadPage(--_pageIndex);
        }

        /// <summary>   Event handler. Called by MealButton for click events. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 9/25/2018. </remarks>
        ///
        /// <param> Source of the event. </param>
        /// <param> Event information. </param>

        private void ClickMealButton(object sender, EventArgs e)
        {
            _customerFormPresentationModel.SetNowButton(Int32.Parse(((Button)sender).Tag.ToString()) + ((_pageIndex - 1) * PAGE_SIZE));
            _descriptionTextBox.Text = _customerFormPresentationModel.GetNowButtonMealDescription();
            _addButton.Enabled = true;
        }

        /// <summary>   Event handler. Called by _addButton for click events. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 9/25/2018. </remarks>
        ///
        /// <param> Source of the event. </param>
        /// <param> Event information. </param>

        private void ClickAddButton(object sender, EventArgs e)
        {
            if (!_customerFormPresentationModel.IsButtonSelected())
            {
                return;
            }
            _customerFormPresentationModel.AddNowButtonMeal();
            _descriptionTextBox.Text = string.Empty;
            _addButton.Enabled = false;
        }

        /// <summary>   Event handler. Called by _mealsDataGridView for cell content click events. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 10/9/2018. </remarks>
        ///
        /// <param>             Source of the event. </param>
        /// <param name="e">    . </param>

        private void ClickMealsDataGridViewCellContent(object sender, DataGridViewCellEventArgs e)
        {
            var dataGridView = (DataGridView)sender;
            if (dataGridView.Columns[e.ColumnIndex] == _dataGridViewTextBoxColumn1)
            {
                _customerFormPresentationModel.DeleteMealByIndex(e.RowIndex);
            }
        }

        /// <summary>   Values that represent button data. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>

        public enum ButtonData
        {
            /// <summary>   An enum constant representing the delete option. </summary>
            Delete,
            /// <summary>   An enum constant representing the name option. </summary>
            Name,
            /// <summary>   An enum constant representing the price option. </summary>
            Price,
            /// <summary>   An enum constant representing the meal option. </summary>
            Meal,
            /// <summary>   An enum constant representing the description option. </summary>
            Description
        }

        /// <summary>   Values that represent buttons. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>

        public enum Buttons
        {
            /// <summary>   An enum constant representing the previous option. </summary>
            Previous,
            /// <summary>   An enum constant representing the next option. </summary>
            Next
        };

        /// <summary>   Changed tab control selected index. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <param>             Source of the event. </param>
        /// <param name="e">    . </param>

        private void ChangedTabControlSelectedIndex(object sender, EventArgs e)
        {
            _customerFormPresentationModel.SetSelectedCategory(_tabControl1.SelectedTab.Text);
            _pageIndex = START_PAGE;
            LoadPage(_pageIndex);
        }

        /// <summary>   Event handler. Called by POSCustomerSideForm for shown events. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/11/12. </remarks>
        ///
        /// <param>             Source of the event. </param>
        /// <param name="e">    . </param>

        private void POSCustomerSideForm_Shown(object sender, EventArgs e)
        {
            _customerFormPresentationModel.SetSelectedCategory(_tabControl1.SelectedTab.Text);
            LoadPage(_pageIndex);
        }
    }
}
