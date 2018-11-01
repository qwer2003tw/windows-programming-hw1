// file:	POSRestaurantSideForm.cs
//
// summary:	Implements the position restaurant side Windows Form

using POSOrderingSystem.Model;
using POSOrderingSystem.PresentationModel;
using System;
using System.Collections.Generic;
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
            InitializeComponent();
            _listBox1.DataSource = meals;
            _categoryBindingSource.DataSource = categories;
            _mealBindingSource.DataSource = _restaurantFormPresentationModel.GetSelectedMeal();
            _mealBindingSource1.DataSource = _restaurantFormPresentationModel.GetMealsByCategory();
            _categoryBindingSource1.DataSource = _restaurantFormPresentationModel.GetSelectedCategory();
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
                _restaurantFormPresentationModel.SetSelectedMeal(_listBox1.SelectedItem);
                _mealBindingSource.DataSource = _restaurantFormPresentationModel.GetSelectedMeal();
                _mealCategoryComboBox.SelectedItem = ((Meal)_mealBindingSource.DataSource).Category;
                _mealAddButton.Text = SAVE;
            }
            else
            {
                _mealBindingSource.DataSource = _restaurantFormPresentationModel.GetNewMeal();
                _mealCategoryComboBox.SelectedIndex = 0;
                _mealNameTextBox.Text = string.Empty;
                _mealPriceTextBox.Text = string.Empty;
                _mealDescriptionRichTextBox.Text = string.Empty;
                _imagePathTextBox.Text = string.Empty;
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

        /// <summary>   Event handler. Called by textBox3 for text changed events. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>

        private void ChangeMealPriceText(object sender, EventArgs e)
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
            object mealObject = new
            {
                name = _mealNameTextBox.Text,
                price = _mealPriceTextBox.Text,
                imagePath = _imagePathTextBox.Text,
                description = _mealDescriptionRichTextBox.Text
            };
            _mealAddButton.Enabled = _restaurantFormPresentationModel.GetMealSaveButtonEnable(mealObject, _mealCategoryComboBox.SelectedItem);
        }

        /// <summary>   Gets meal add button enable. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>

        private void GetMealAddButtonEnable()
        {
            object mealObject = new
            {
                name = _mealNameTextBox.Text,
                price = _mealPriceTextBox.Text,
                imagePath = _imagePathTextBox.Text,
                description = _mealDescriptionRichTextBox.Text
            };
            _mealAddButton.Enabled = _restaurantFormPresentationModel.GetMealAddButtonEnable(mealObject, _mealCategoryComboBox.SelectedItem);
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
            object mealObject = new
            {
                name = _mealNameTextBox.Text,
                price = _mealPriceTextBox.Text,
                imagePath = _imagePathTextBox.Text,
                description = _mealDescriptionRichTextBox.Text,
                category = _mealCategoryComboBox.SelectedItem
            };
            _restaurantFormPresentationModel.AddMeal(mealObject);
        }

        /// <summary>   Saves the meal. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>

        private void SaveMeal()
        {
            object mealObject = new
            {
                name = _mealNameTextBox.Text,
                price = _mealPriceTextBox.Text,
                imagePath = _imagePathTextBox.Text,
                description = _mealDescriptionRichTextBox.Text,
            };
            _restaurantFormPresentationModel.SaveMeal(mealObject, _mealCategoryComboBox.SelectedItem);
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
                _mealBindingSource1.DataSource = _restaurantFormPresentationModel.GetMealsByCategory();
                _categoryBindingSource1.DataSource = _restaurantFormPresentationModel.GetSelectedCategory();
                _button7.Text = SAVE;
            }
            else if (_listBox2.SelectedItem == null)
            {
                _mealBindingSource1.DataSource = _restaurantFormPresentationModel.GetNewCategory();
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
                string path = _openFileDialog.FileName.Replace(projectPath, string.Empty);
                _imagePathTextBox.Text = path.Replace("\\", "/");
            }
        }
    }
}
