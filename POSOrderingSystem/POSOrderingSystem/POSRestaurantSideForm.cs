// file:	POSRestaurantSideForm.cs
//
// summary:	Implements the position restaurant side Windows Form

using POSOrderingSystem.Model;
using POSOrderingSystem.PresentationModel;
using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace POSOrderingSystem
{
    /// <summary>   Form for viewing the position restaurant side. </summary>
    ///
    /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>

    public partial class POSRestaurantSideForm : Form
    {
        /// <summary>   The add. </summary>
        const string ADD = "Add";
        /// <summary>   The save. </summary>
        const string SAVE = "Save";
        /// <summary>   The restaurant form presentation model. </summary>
        RestaurantFormPresentationModel _restaurantFormPresentationModel;

        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <param name="categories">   The categories. </param>
        /// <param name="meals">        The meals. </param>

        public POSRestaurantSideForm(BindingList<Category> categories, BindingList<Meal> meals)
        {
            _restaurantFormPresentationModel = new RestaurantFormPresentationModel(categories, meals);
            _restaurantFormPresentationModel.PropertyChanged += _restaurantFormPresentationModel_PropertyChanged;
            InitializeComponent();
            _categoryBindingSource.DataSource = categories;
            mealBindingSource.DataSource = meals;
            _selectedMealBindingSource.DataSource = _restaurantFormPresentationModel.GetSelectedMealClone();
            _mealsByCategoryBindingSource.DataSource = _restaurantFormPresentationModel.GetMealsByCategory();
            _selectedCategoryBindingSource.DataSource = _restaurantFormPresentationModel.GetSelectedCategory();
            categoryBindingSource.DataSource = _restaurantFormPresentationModel.GetSelectedMealClone().Category;
        }

        /// <summary>   Restaurant form presentation model property changed. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/11/13. </remarks>

        private void _restaurantFormPresentationModel_PropertyChanged()
        {
            _mealsByCategoryBindingSource.DataSource = _restaurantFormPresentationModel.GetMealsByCategory();
            _selectedCategoryBindingSource.DataSource = _restaurantFormPresentationModel.GetSelectedCategory();
        }

        /// <summary>   Event handler. Called by _okButton for click events. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 10/9/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>

        private void ClickOkButton(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>   Event handler. Called by listBox1 for selected index changed events. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>

        private void ChangeSelectedIndex(object sender, EventArgs e)
        {
            if (_listBox1.SelectedItem != null)
            {
                _restaurantFormPresentationModel.SetSelectedMeal((Meal)_listBox1.SelectedItem);
                _selectedMealBindingSource.DataSource = _restaurantFormPresentationModel.GetSelectedMealClone();
                categoryBindingSource.DataSource = _restaurantFormPresentationModel.GetSelectedMealClone().Category;
                _mealAddButton.Text = SAVE;
                _groupBox1.Text = "Edit Meal";
            }
            else
            {
                _selectedMealBindingSource.DataSource = _restaurantFormPresentationModel.GetNewMeal();
            }
        }

        /// <summary>   Event handler. Called by button1 for click events. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>

        private void ClickMealAddButton(object sender, EventArgs e)
        {
            _listBox1.ClearSelected();
            _mealAddButton.Text = ADD;
            _groupBox1.Text = "Add Meal";
            _mealAddButton.Enabled = false;
        }

        /// <summary>   Event handler. Called by textBox1 for text changed events. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>

        private void ChangeMealNameText(object sender, EventArgs e)
        {
            GetMealAddOrSaveButtonEnable();
        }

        /// <summary>   Event handler. Called by textBox3 for key press events. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Key press event information. </param>

        private void PressPriceText(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>   Event handler. Called by textBox4 for text changed events. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>

        private void ChangeImagePathText(object sender, EventArgs e)
        {
            GetMealAddOrSaveButtonEnable();
        }

        /// <summary>   Gets meal save button enable. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>

        private void GetMealSaveButtonEnable()
        {
            _mealAddButton.Enabled = _restaurantFormPresentationModel.GetMealSaveButtonEnable();
        }

        /// <summary>   Gets meal add button enable. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        private void GetMealAddButtonEnable()
        {
            _mealAddButton.Enabled = _restaurantFormPresentationModel.GetMealAddButtonEnable();
        }

        /// <summary>   Gets category save button enable. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>

        private void GetCategorySaveButtonEnable()
        {
            _button7.Enabled = _restaurantFormPresentationModel.GetCategorySaveButtonEnable(_textBox2.Text);
        }

        /// <summary>   Gets category add button enable. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>

        private void GetCategoryAddButtonEnable()
        {
            _button7.Enabled = _restaurantFormPresentationModel.GetCategoryAddButtonEnable(_textBox2.Text);
        }

        /// <summary>   Event handler. Called by richTextBox1 for text changed events. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>

        private void ChangeRichTextBoxText(object sender, EventArgs e)
        {
            GetMealAddOrSaveButtonEnable();
        }

        /// <summary>   Event handler. Called by comboBox1 for selected index changed events. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>

        private void ChangeComboBoxSelectedIndex(object sender, EventArgs e)
        {
            if (_mealCategoryComboBox.SelectedValue == null) return;
            if (_mealAddButton.Text == ADD)
            {
                ((Meal)_selectedMealBindingSource.DataSource).Category = (Category)_mealCategoryComboBox.SelectedValue;
            }
            else if (_mealAddButton.Text == SAVE)
            {
                _restaurantFormPresentationModel.GetSelectedMealClone().Category = (Category)_mealCategoryComboBox.SelectedValue;
            }
            GetMealAddOrSaveButtonEnable();
        }

        /// <summary>   Gets meal add or save button enable. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>

        private void GetMealAddOrSaveButtonEnable()
        {
            if (_mealAddButton.Text == ADD)
            {
                GetMealAddButtonEnable();
            }
            else if (_mealAddButton.Text == SAVE)
            {
                GetMealSaveButtonEnable();
            }
        }

        /// <summary>   Gets category add or save button enable. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>

        private void GetCategoryAddOrSaveButtonEnable()
        {
            if (_button7.Text == ADD)
            {
                GetCategoryAddButtonEnable();
            }
            else if (_button7.Text == SAVE)
            {
                GetCategorySaveButtonEnable();
            }
        }

        /// <summary>   Event handler. Called by button5 for click events. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>

        private void ClickAddMeal(object sender, EventArgs e)
        {
            if (_mealAddButton.Text == ADD)
            {
                AddMeal();
            }
            else if (_mealAddButton.Text == SAVE)
            {
                SaveMeal();
            }
        }

        /// <summary>   Adds meal. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>

        private void AddMeal()
        {
            _restaurantFormPresentationModel.AddMeal();
        }

        /// <summary>   Saves the meal. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>

        private void SaveMeal()
        {
            _restaurantFormPresentationModel.SaveMeal();
        }

        /// <summary>   Event handler. Called by listBox2 for selected index changed events. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>

        private void ChangeListBoxSelectedIndex(object sender, EventArgs e)
        {
            if (_listBox2.SelectedItem != null)
            {
                _restaurantFormPresentationModel.SetSelectedCategory(_listBox2.SelectedItem);
                _mealsByCategoryBindingSource.DataSource = _restaurantFormPresentationModel.GetMealsByCategory();
                _selectedCategoryBindingSource.DataSource = _restaurantFormPresentationModel.GetSelectedCategory();
                _button7.Text = SAVE;
                _groupBox1.Text = "Edit Meal";
            }
            else if (_listBox2.SelectedItem == null)
            {
                _mealsByCategoryBindingSource.DataSource = _restaurantFormPresentationModel.GetNewCategory();
                _textBox2.Text = string.Empty;
            }
        }

        /// <summary>   Event handler. Called by button3 for click events. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>

        private void ClickClearSelected(object sender, EventArgs e)
        {
            _listBox2.ClearSelected();
            _button7.Text = ADD;
        }

        /// <summary>   Event handler. Called by textBox2 for text changed events. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>

        private void ChangeTextBoxTextEnable(object sender, EventArgs e)
        {
            GetCategoryAddOrSaveButtonEnable();
        }

        /// <summary>   Event handler. Called by button7 for click events. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>

        private void ClickAddCategory(object sender, EventArgs e)
        {
            if (_button7.Text == ADD)
            {
                _restaurantFormPresentationModel.AddCategory(_textBox2.Text);
            }
            else if (_button7.Text == SAVE)
            {
                _restaurantFormPresentationModel.SaveCategory(_textBox2.Text);
            }
        }

        /// <summary>   Event handler. Called by _browserButton for click events. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>

        private void ClickBrowserButton(object sender, EventArgs e)
        {
            string projectPath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            _openFileDialog.InitialDirectory = projectPath;
            _openFileDialog.Multiselect = false;
            _openFileDialog.Filter = "Image|*.png;*.jpg;*.jpeg";
            DialogResult result = _openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string path = _openFileDialog.FileName.Replace(projectPath, string.Empty).Trim('\\');
                _imagePathTextBox.Text = path.Replace("\\", "/");
            }
        }

        /// <summary>   Event handler. Called by _deleteSelectedMealButton for click events. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/11/12. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>

        private void _deleteSelectedMealButton_Click(object sender, EventArgs e)
        {
            _restaurantFormPresentationModel.DeleteSelectMeal();
        }
    }
}
