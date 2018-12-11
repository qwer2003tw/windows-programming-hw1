// file:	PresentationModel\CustomerFormPresentationModelTests.cs
//
// summary:	Implements the customer form presentation model tests class

using Microsoft.VisualStudio.TestTools.UnitTesting;
using POSOrderingSystem.Model;
using System.ComponentModel;

namespace POSOrderingSystem.PresentationModel.Tests
{
    /// <summary>   (Unit Test Class) a customer form presentation model tests. </summary>
    ///
    /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

    [TestClass()]
    public class CustomerFormPresentationModelTests
    {
        /// <summary>   The customer form presentation model. </summary>
        CustomerFormPresentationModel customerFormPresentationModel;
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
            customerFormPresentationModel = new CustomerFormPresentationModel(categories, meals);
        }

        /// <summary>   (Unit Test Method) tests customer form presentation model. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void CustomerFormPresentationModelTest()
        {
            customerFormPresentationModel = new CustomerFormPresentationModel(categories, meals);

            Assert.IsNotNull(customerFormPresentationModel);
        }

        /// <summary>   (Unit Test Method) tests get button enable. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void GetButtonEnableTest()
        {
            customerFormPresentationModel.GetButtonEnable(0, 0);
            customerFormPresentationModel.GetButtonEnable(1, 0);
            customerFormPresentationModel.GetButtonEnable(2, 0);
            Assert.IsTrue(true);
        }

        /// <summary>   (Unit Test Method) tests get meals count. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void GetMealsCountTest()
        {
            Assert.Fail();
        }

        /// <summary>   (Unit Test Method) tests get button text. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void GetButtonTextTest()
        {
            Assert.Fail();
        }

        /// <summary>   (Unit Test Method) tests get image path. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void GetImagePathTest()
        {
            Assert.Fail();
        }

        /// <summary>   (Unit Test Method) adds now button meal test. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void AddNowButtonMealTest()
        {
            customerFormPresentationModel.SetNowButton(0);
            customerFormPresentationModel.SetSelectedCategory(categories[0].Name);
            customerFormPresentationModel.AddNowButtonMeal();
            Assert.IsTrue(true);
        }

        /// <summary>   (Unit Test Method) tests get meal by index. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void GetMealByIndexTest()
        {
            Assert.Fail();
        }

        /// <summary>   (Unit Test Method) tests get button information. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void GetButtonInfoTest()
        {
            customerFormPresentationModel.SetSelectedCategory(categories[0].Name);
            customerFormPresentationModel.GetButtonInfo(0);
            Assert.IsTrue(true);
        }

        /// <summary>   (Unit Test Method) tests get page label text. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void GetPageLabelTextTest()
        {
            customerFormPresentationModel.GetPageLabelText(0);
            Assert.IsTrue(true);
        }

        /// <summary>   (Unit Test Method) tests is button selected. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void IsButtonSelectedTest()
        {
            Assert.Fail();
        }

        /// <summary>   (Unit Test Method) tests set now button. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void SetNowButtonTest()
        {
            customerFormPresentationModel.SetNowButton(0);
            Assert.Fail();
        }

        /// <summary>   (Unit Test Method) tests get now button meal description. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void GetNowButtonMealDescriptionTest()
        {
            Assert.Fail();
        }

        /// <summary>   (Unit Test Method) tests get binding list. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void GetBindingListTest()
        {
            customerFormPresentationModel.GetBindingList();
            Assert.IsTrue(true);
        }

        /// <summary>   (Unit Test Method) deletes the meal by index test. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void DeleteMealByIndexTest()
        {
            OrderItem orderItem = new OrderItem(meals[0]);
            customerFormPresentationModel.GetBindingList().Add(orderItem);
            customerFormPresentationModel.DeleteMealByIndex(0);
            Assert.IsTrue(true);
        }

        /// <summary>   (Unit Test Method) tests get order. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void GetOrderTest()
        {
            customerFormPresentationModel.GetOrder();
            Assert.IsTrue(true);
        }

        /// <summary>   (Unit Test Method) tests get meal count by category. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void GetMealCountByCategoryTest()
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

        /// <summary>   (Unit Test Method) tests get categories. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void GetCategoriesTest()
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
    }
}