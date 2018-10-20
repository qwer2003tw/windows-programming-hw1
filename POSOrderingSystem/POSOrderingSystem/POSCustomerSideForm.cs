using POSOrderingSystem.PresentationModel;
using System;
using System.Drawing;
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
        int _pageIndex;
        int _nowButton = NOT_SELECT;
        CustomerFormPresentationModel customerFormPresentationModel;
        public POSCustomerSideForm()
        {
            InitializeComponent();
            customerFormPresentationModel = new CustomerFormPresentationModel();
            _buttons = new Button[customerFormPresentationModel.GetMealsCount()];
            _pageIndex = START_PAGE;
            InitButton();
            LoadPage(_pageIndex, true);
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

            foreach (var btn in showButtons)
            {
                btn.Visible = visible;
            }
            _previousButton.Enabled = customerFormPresentationModel.GetButtonEnable((int)Buttons.Previous, pageIndex);
            _nextButton.Enabled = customerFormPresentationModel.GetButtonEnable((int)Buttons.Next, pageIndex);
            _pageLabel.Text = $"Page : {pageIndex}/{(customerFormPresentationModel.GetMealsCount() / PAGE_SIZE) + 1}";
        }

        /// <summary>   Initializes the button. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 9/25/2018. </remarks>
        ///
        /// <param> The meals. </param>

        private void InitButton()
        {
            _addButton.Enabled = false;
            for (int i = 0; i < _buttons.Length; i++)
            {

                Object[] info = customerFormPresentationModel.GetButtonInfo(i);
                _buttons[i] = new Button();
                _buttons[i].Tag = i;
                _buttons[i].Visible = false;
                _buttons[i].Text = info[0].ToString();
                _buttons[i].Size = new Size(BUTTON_SIZE, BUTTON_SIZE);
                _buttons[i].Location = (Point)info[1];
                _buttons[i].Image = System.Drawing.Image.FromFile(@"..\..\MealButtonImg\" + i + @".png");
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
            var data = customerFormPresentationModel.GetNowButtonData(_nowButton);
            _descriptionTextBox.Text = (string)data[(int)ButtonData.Descript];
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

            if (_nowButton == -1) return;

            var data = customerFormPresentationModel.GetNowButtonData(_nowButton);
            _mealsDataGridView.Rows.Add(data);
            _nowButton = NOT_SELECT;
            _addButton.Enabled = false;


            AddDataGrid();
            _totalLabel.Text = $"Total:{customerFormPresentationModel.GetTotal()}元";
        }

        /// <summary>
        /// Event handler. Called by _mealsDataGridView for cell content click events.
        /// </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 10/9/2018. </remarks>
        ///
        /// <param>             Source of the event. </param>
        /// <param name="e">    . </param>

        private void _mealsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dataGridView = (DataGridView)sender;
            if (dataGridView.Columns[e.ColumnIndex] == _deleteColumn)
            {
                dataGridView.Rows.RemoveAt(e.RowIndex);
                AddDataGrid();
                _totalLabel.Text = $"Total:{customerFormPresentationModel.GetTotal()}元";
            }
        }

        /// <summary>   Adds data grid. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 10/9/2018. </remarks>

        private void AddDataGrid()
        {
            foreach (DataGridViewRow row in _mealsDataGridView.Rows)
            {
                customerFormPresentationModel.AddOrder(row.Cells[3].Value);
            }
        }
        public enum ButtonData
        {
            Delete,
            Name,
            Price,
            Meal,
            Descript
        }
        public enum Buttons
        {
            Previous,
            Next
        };
    }
}
