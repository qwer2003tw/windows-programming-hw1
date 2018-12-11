// file:	PresentationModel\RestaurantFormPresentationModelTests.cs
//
// summary:	Implements the restaurant form presentation model tests class

using Microsoft.VisualStudio.TestTools.UnitTesting;
using POSOrderingSystem.Model;
using System.ComponentModel;

namespace POSOrderingSystem.PresentationModel.Tests
{
    /// <summary>   (Unit Test Class) a restaurant form presentation model tests. </summary>
    ///
    /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

    [TestClass()]
    public class RestaurantFormPresentationModelTests
    {
        /// <summary>   The restaurant form presentation model. </summary>
        RestaurantFormPresentationModel restaurantFormPresentationModel;
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
            restaurantFormPresentationModel = new RestaurantFormPresentationModel(categories, meals);
        }

        /// <summary>   (Unit Test Method) tests restaurant form presentation model. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void RestaurantFormPresentationModelTest()
        {
            Assert.Fail();
        }

        /// <summary>   (Unit Test Method) tests set selected meal. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void SetSelectedMealTest()
        {
            Assert.Fail();
        }

        /// <summary>   (Unit Test Method) tests get selected meal clone. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void GetSelectedMealCloneTest()
        {
            Assert.Fail();
        }

        /// <summary>   (Unit Test Method) tests get new meal. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void GetNewMealTest()
        {
            Assert.Fail();
        }

        /// <summary>   (Unit Test Method) tests get new category. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void GetNewCategoryTest()
        {
            Assert.Fail();
        }

        /// <summary>   (Unit Test Method) tests get meal save button enable. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void GetMealSaveButtonEnableTest()
        {
            Assert.Fail();
        }

        /// <summary>   (Unit Test Method) tests get meal add button enable. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void GetMealAddButtonEnableTest()
        {
            Assert.Fail();
        }

        /// <summary>   (Unit Test Method) tests get category save button enable. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void GetCategorySaveButtonEnableTest()
        {
            Assert.Fail();
        }

        /// <summary>   (Unit Test Method) tests get category add button enable. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void GetCategoryAddButtonEnableTest()
        {
            var actual = restaurantFormPresentationModel.GetCategoryAddButtonEnable("Test");
            Assert.AreEqual(true, actual);
        }

        /// <summary>   (Unit Test Method) adds meal test. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void AddMealTest()
        {
            Assert.Fail();
        }

        /// <summary>   (Unit Test Method) saves the meal test. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void SaveMealTest()
        {
            Assert.Fail();
        }

        /// <summary>   (Unit Test Method) adds category test. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void AddCategoryTest()
        {
            Assert.Fail();
        }

        /// <summary>   (Unit Test Method) saves the category test. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void SaveCategoryTest()
        {
            Assert.Fail();
        }

        /// <summary>   (Unit Test Method) tests get meals by category. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void GetMealsByCategoryTest()
        {
            Assert.Fail();
        }

        /// <summary>   (Unit Test Method) tests set selected category. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void SetSelectedCategoryTest()
        {
            Assert.Fail();
        }

        /// <summary>   (Unit Test Method) tests get selected category. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void GetSelectedCategoryTest()
        {
            Assert.Fail();
        }

        /// <summary>   (Unit Test Method) deletes the select meal test. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void DeleteSelectMealTest()
        {
            Assert.Fail();
        }
    }
}