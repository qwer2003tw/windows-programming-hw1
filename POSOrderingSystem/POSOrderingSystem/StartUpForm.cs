using POSOrderingSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSOrderingSystem
{
    public partial class StartUpForm : Form
    {
        const string MEALS = @"Resource/Meals.xml";
        const string CATEGORYS = @"Resource/Categorys.xml";
        const string MEALS_PRICE = "price";
        const string MEALS_CATEGORY = "category";
        const string NAME = "name";
        const string MEALS_DESCRIPTION = "description";
        const string MEALS_IMAGE_PATH = "imagePath";
        POSCustomerSideForm _customerSideForm;
        POSRestaurantSideForm _restaurantSideForm;

        BindingList<Meal> _meals;
        BindingList<Category> _categories;
        public StartUpForm()
        {
            GetMealData();
            _customerSideForm = new POSCustomerSideForm(_categories, _meals);
            _restaurantSideForm = new POSRestaurantSideForm(_categories, _meals);
            InitializeComponent();
        }

        /// <summary>   Event handler. Called by _customerButton for click events. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 10/9/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>

        private void ClickCustomerButton(object sender, EventArgs e)
        {
            _customerSideForm.Show();
            ((Button)sender).Enabled = false;
            _customerSideForm.FormClosing += this.EnableCustomerButton;
        }

        /// <summary>   Enables the customer button. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 10/9/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="args">     Form closing event information. </param>

        private void EnableCustomerButton(object sender, FormClosingEventArgs args)
        {
            args.Cancel = true;
            _customerSideForm.Hide();
            _customerButton.Enabled = true;
        }

        /// <summary>   Event handler. Called by _restaurantButton for click events. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 10/9/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>

        private void ClickRestaurantButton(object sender, EventArgs e)
        {
            _restaurantSideForm.Show();
            _restaurantButton.Enabled = false;
            _restaurantSideForm.FormClosing += this.EnableRestaurantButton;
        }

        /// <summary>   Enables the restaurant button. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 10/9/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="args">     Form closing event information. </param>

        private void EnableRestaurantButton(Object sender, FormClosingEventArgs args)
        {
            args.Cancel = true;
            _restaurantSideForm.Hide();
            _restaurantButton.Enabled = true;
        }

        /// <summary>   Event handler. Called by _exitButton for click events. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 10/9/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>

        private void ClickExitButton(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>   Gets meal data. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 9/30/2018. </remarks>

        private void GetMealData()
        {
            _meals = new BindingList<Meal>();
            string currentPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string categoryFilePath = Path.Combine(currentPath, CATEGORYS);
            DataSet categoryDataSet = new DataSet();
            categoryDataSet.ReadXml(categoryFilePath);
            _categories = new BindingList<Category>();
            foreach (DataRow row in categoryDataSet.Tables[0].Rows)
            {
                _categories.Add(new Category()
                {
                    Name = row[NAME].ToString()
                });
            }
            string mealFilePath = Path.Combine(currentPath, MEALS);
            DataSet mealDataSet = new DataSet();
            mealDataSet.ReadXml(mealFilePath);
            AddMeal(mealDataSet);
        }

        /// <summary>   Adds a meal. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <param name="mealDataSet">  Set the meal data belongs to. </param>

        private void AddMeal(DataSet mealDataSet)
        {
            foreach (DataRow row in mealDataSet.Tables[0].Rows)
            {
                Category category = _categories.SingleOrDefault(x => x.Name == row[MEALS_CATEGORY].ToString());
                _meals.Add(new Meal()
                {
                    Name = row[NAME].ToString(),
                    Category = category,
                    Price = Int32.Parse(row[MEALS_PRICE].ToString()),
                    Descript = row[MEALS_DESCRIPTION].ToString(),
                    ImagePath = row[MEALS_IMAGE_PATH].ToString()
                });
            }
        }
    }
}
