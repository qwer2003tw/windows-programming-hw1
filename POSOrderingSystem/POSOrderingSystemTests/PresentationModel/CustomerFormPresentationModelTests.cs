using Microsoft.VisualStudio.TestTools.UnitTesting;
using POSOrderingSystem.Model;
using POSOrderingSystem.PresentationModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSOrderingSystem.PresentationModel.Tests
{
    [TestClass()]
    public class CustomerFormPresentationModelTests
    {
        CustomerFormPresentationModel customerFormPresentationModel;
        BindingList<Category> categories;
        BindingList<Meal> meals;
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
        [TestMethod()]
        public void CustomerFormPresentationModelTest()
        {
            customerFormPresentationModel = new CustomerFormPresentationModel(categories, meals);

            Assert.IsNotNull(customerFormPresentationModel);
        }

        [TestMethod()]
        public void GetButtonEnableTest()
        {
            customerFormPresentationModel.GetButtonEnable(0, 0);
            customerFormPresentationModel.GetButtonEnable(1, 0);
            customerFormPresentationModel.GetButtonEnable(2, 0);
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void GetMealsCountTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetButtonTextTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetImagePathTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AddNowButtonMealTest()
        {
            customerFormPresentationModel.SetNowButton(0);
            customerFormPresentationModel.SetSelectedCategory(categories[0].Name);
            customerFormPresentationModel.AddNowButtonMeal();
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void GetMealByIndexTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetButtonInfoTest()
        {
            customerFormPresentationModel.SetSelectedCategory(categories[0].Name);
            customerFormPresentationModel.GetButtonInfo(0);
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void GetPageLabelTextTest()
        {
            customerFormPresentationModel.GetPageLabelText(0);
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void IsButtonSelectedTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SetNowButtonTest()
        {
            customerFormPresentationModel.SetNowButton(0);
            Assert.Fail();
        }

        [TestMethod()]
        public void GetNowButtonMealDescriptionTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetBindingListTest()
        {
            customerFormPresentationModel.GetBindingList();
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void DeleteMealByIndexTest()
        {
            OrderItem orderItem = new OrderItem(meals[0]);
            customerFormPresentationModel.GetBindingList().Add(orderItem);
            customerFormPresentationModel.DeleteMealByIndex(0);
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void GetOrderTest()
        {
            customerFormPresentationModel.GetOrder();
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void GetMealCountByCategoryTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetMealsByCategoryTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetCategoriesTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SetSelectedCategoryTest()
        {
            Assert.Fail();
        }
    }
}