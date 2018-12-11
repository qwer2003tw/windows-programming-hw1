// file:	Model\PosCustomerSideModelTests.cs
//
// summary:	Implements the position customer side model tests class

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel;

namespace POSOrderingSystem.Model.Tests
{
    /// <summary>   (Unit Test Class) a position customer side model tests. </summary>
    ///
    /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

    [TestClass()]
    public class PosCustomerSideModelTests
    {
        /// <summary>   The position customer side model. </summary>
        PosCustomerSideModel posCustomerSideModel;
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
            posCustomerSideModel = new PosCustomerSideModel(categories, meals);
        }

        /// <summary>   (Unit Test Method) tests position customer side model. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void PosCustomerSideModelTest()
        {
            posCustomerSideModel = new PosCustomerSideModel(categories, meals);

            Assert.IsTrue(posCustomerSideModel != null);
        }

        /// <summary>   (Unit Test Method) tests get now button meal description. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void GetNowButtonMealDescriptionTest()
        {
            posCustomerSideModel.SetSelectedCategory(categories[0].Name);
            var actual = posCustomerSideModel.GetNowButtonMealDescription(0);
            Assert.AreEqual(meals[0].Descript, actual);
        }

        /// <summary>   (Unit Test Method) tests get meals count. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void GetMealsCountTest()
        {
            var actual = posCustomerSideModel.GetMealsCount();
            Assert.AreEqual(1, actual);
        }

        /// <summary>   (Unit Test Method) tests get meal by index. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void GetMealByIndexTest()
        {
            posCustomerSideModel.SetSelectedCategory(categories[0].Name);
            var a = posCustomerSideModel.GetMealByIndex(0);
            Assert.AreEqual(a, meals[0]);
        }

        /// <summary>   (Unit Test Method) tests get order. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void GetOrderTest()
        {
            posCustomerSideModel.GetOrder();
            Assert.IsTrue(true);
        }

        /// <summary>   (Unit Test Method) adds now button meal test. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void AddNowButtonMealTest()
        {
            posCustomerSideModel.SetSelectedCategory(categories[0].Name);
            posCustomerSideModel.AddNowButtonMeal(0);
            Assert.IsTrue(true);
        }

        /// <summary>   (Unit Test Method) tests get binding list. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void GetBindingListTest()
        {
            var actual = posCustomerSideModel.GetBindingList();
            Assert.AreEqual(0, actual.Count);
        }

        /// <summary>   (Unit Test Method) deletes the meal by index test. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void DeleteMealByIndexTest()
        {
            posCustomerSideModel.SetSelectedCategory(categories[0].Name);
            posCustomerSideModel.AddNowButtonMeal(0);
            posCustomerSideModel.DeleteMealByIndex(0);
            Assert.AreEqual(0, posCustomerSideModel.GetOrder().OrderItems.Count);
        }

        /// <summary>   (Unit Test Method) tests get meal count by category. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void GetMealCountByCategoryTest()
        {
            posCustomerSideModel.SetSelectedCategory(categories[0].Name);
            var a = posCustomerSideModel.GetMealCountByCategory();
            Assert.AreEqual(1, a);
        }

        /// <summary>   (Unit Test Method) tests get meals by category. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void GetMealsByCategoryTest()
        {
            posCustomerSideModel.SetSelectedCategory(categories[0].Name);
            var a = posCustomerSideModel.GetMealsByCategory();
            Assert.AreEqual(a[0], meals[0]);
        }

        /// <summary>   (Unit Test Method) tests set selected category. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void SetSelectedCategoryTest()
        {
            posCustomerSideModel.SetSelectedCategory("Test");
            Assert.IsTrue(true);
        }
    }
}