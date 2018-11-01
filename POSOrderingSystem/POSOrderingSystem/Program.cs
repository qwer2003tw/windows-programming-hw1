using POSOrderingSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSOrderingSystem
{
    static public class Program
    {
        const string MEALS = @"Resource/Meals.xml";
        const string CATEGORYS = @"Resource/Categorys.xml";
        const string MEALS_PRICE = "price";
        const string MEALS_CATEGORY = "category";
        const string NAME = "name";
        const string MEALS_DESCRIPTION = "description";
        const string MEALS_IMAGE_PATH = "imagePath";
        static BindingList<Meal> _meals;
        static BindingList<Category> _categories;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            GetMealData();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartUpForm(_categories, _meals));
        }
        /// <summary>   Gets meal data. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 9/30/2018. </remarks>

        static void GetMealData()
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

        static void AddMeal(DataSet mealDataSet)
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
