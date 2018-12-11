// file:	Model\PosRestaurantSideModelTests.cs
//
// summary:	Implements the position restaurant side model tests class

using Microsoft.VisualStudio.TestTools.UnitTesting;
using POSOrderingSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSOrderingSystem.Model.Tests
{
    /// <summary>   (Unit Test Class) a position restaurant side model tests. </summary>
    ///
    /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

    [TestClass()]
    public class PosRestaurantSideModelTests
    {
        /// <summary>   The position restaurant side model. </summary>
        PosRestaurantSideModel posRestaurantSideModel;
        /// <summary>   The categories. </summary>
        BindingList<Category> categories;
        /// <summary>   The meals. </summary>
        BindingList<Meal> meals;

        /// <summary>   Tests initialize. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestInitialize()]
        public void TestInitialize()
        {
            Category category = new Category() { Name = "TestCategory" };
            categories = new BindingList<Category>();
            categories.Add(category);
            Meal meal = new Meal()
            {
                Category = category,
                Descript = "TestDescript",
                ImagePath = "Test/ImagePath.png",
                Name = "TestName",
                Price = 99
            };
            meals = new BindingList<Meal>();
            meals.Add(meal);
            posRestaurantSideModel = new PosRestaurantSideModel(categories, meals);
        }

        /// <summary>   (Unit Test Method) tests position restaurant side model. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void PosRestaurantSideModelTest()
        {
            posRestaurantSideModel = new PosRestaurantSideModel(categories, meals);
            Assert.IsTrue(posRestaurantSideModel != null);
        }

        /// <summary>   (Unit Test Method) tests get new meal. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void GetNewMealTest()
        {
            var actual = posRestaurantSideModel.GetNewMeal();
            Assert.IsTrue(actual != null);
        }

        /// <summary>   (Unit Test Method) tests get new category. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void GetNewCategoryTest()
        {
            var actual = posRestaurantSideModel.GetNewCategory();
            Assert.IsTrue(actual != null);
        }

        /// <summary>   (Unit Test Method) tests get meal save button enable. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void GetMealSaveButtonEnableTest()
        {
            Meal meal = meals[0].Clone();
            posRestaurantSideModel.SetOriginalMeal(meals[0]);
            posRestaurantSideModel.SelectedMealClone = meal;
            var actual = posRestaurantSideModel.GetMealSaveButtonEnable();
            meal.Name += "T";
            posRestaurantSideModel.SelectedMealClone = meal;
            posRestaurantSideModel.GetMealSaveButtonEnable();
            meal = meals[0].Clone();
            meal.Price += 1;
            posRestaurantSideModel.SelectedMealClone = meal;
            posRestaurantSideModel.GetMealSaveButtonEnable();
            meal = meals[0].Clone();
            meal.ImagePath += "T";
            posRestaurantSideModel.SelectedMealClone = meal;
            posRestaurantSideModel.GetMealSaveButtonEnable();
            meal = meals[0].Clone();
            meal.Descript += "T";
            posRestaurantSideModel.SelectedMealClone = meal;
            posRestaurantSideModel.GetMealSaveButtonEnable();
            meal = meals[0].Clone();
            meal.Category.Name += "T";
            posRestaurantSideModel.SelectedMealClone = meal;
            posRestaurantSideModel.GetMealSaveButtonEnable();

            Assert.IsTrue(!actual);
        }

        /// <summary>   (Unit Test Method) tests get meal add button enable. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void GetMealAddButtonEnableTest()
        {
            var obj = posRestaurantSideModel.GetNewMeal();
            posRestaurantSideModel.GetMealAddButtonEnable();
            obj.ImagePath = "T";
            posRestaurantSideModel.GetMealAddButtonEnable();
            obj.Name = "T";
            var actual = posRestaurantSideModel.GetMealAddButtonEnable();
            Assert.IsTrue(actual);
        }

        /// <summary>   (Unit Test Method) tests get category save button enable. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void GetCategorySaveButtonEnableTest()
        {
            posRestaurantSideModel.GetCategorySaveButtonEnable(null);
            posRestaurantSideModel.SetOriginalCategory(categories[0]);
            posRestaurantSideModel.GetCategorySaveButtonEnable(categories[0].Name);
            var a = posRestaurantSideModel.MealsByCategory;
            var actual = posRestaurantSideModel.GetCategorySaveButtonEnable("Test");
            Assert.IsTrue(actual);
        }

        /// <summary>   (Unit Test Method) tests get category add button enable. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void GetCategoryAddButtonEnableTest()
        {
            posRestaurantSideModel.GetCategoryAddButtonEnable(null);
            var actual = posRestaurantSideModel.GetCategoryAddButtonEnable("Test");

            Assert.IsTrue(actual);
        }

        /// <summary>   (Unit Test Method) adds meal test. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void AddMealTest()
        {
            var obj = posRestaurantSideModel.GetNewMeal();
            posRestaurantSideModel.AddMeal();
            Assert.IsTrue(obj != null);
        }

        /// <summary>   (Unit Test Method) saves the meal test. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void SaveMealTest()
        {
            var obj = posRestaurantSideModel.GetNewMeal();
            posRestaurantSideModel.SaveMeal();
            Assert.IsTrue(obj != null);
        }

        /// <summary>   (Unit Test Method) adds category test. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void AddCategoryTest()
        {
            posRestaurantSideModel.AddCategory("Test");
            Assert.IsTrue(true);
        }

        /// <summary>   (Unit Test Method) saves the category test. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void SaveCategoryTest()
        {
            posRestaurantSideModel.SaveCategory("Test");
            Assert.IsTrue(true);
        }

        /// <summary>   (Unit Test Method) tests set original meal. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void SetOriginalMealTest()
        {
            posRestaurantSideModel.SetOriginalMeal(meals[0]);
            posRestaurantSideModel.SelectedMealClone = meals[0];
            var a = posRestaurantSideModel.SelectedMeal;
            Assert.AreNotEqual(posRestaurantSideModel.SelectedMealClone, meals[0]);
        }

        /// <summary>   (Unit Test Method) tests set original category. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void SetOriginalCategoryTest()
        {
            posRestaurantSideModel.SetOriginalCategory(categories[0]);
            posRestaurantSideModel.SelectedCategoryClone = categories[0];

            Assert.AreNotEqual(posRestaurantSideModel.SelectedCategoryClone, categories[0]);
        }

        /// <summary>   (Unit Test Method) deletes the select meal test. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void DeleteSelectMealTest()
        {
            posRestaurantSideModel.SetOriginalMeal(meals[0]);
            posRestaurantSideModel.DeleteSelectMeal();
            Assert.IsTrue(true);
        }
    }
}