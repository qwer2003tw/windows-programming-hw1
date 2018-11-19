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
    [TestClass()]
    public class PosCustomerSideModelTests
    {
        PosCustomerSideModel posCustomerSideModel;
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
            posCustomerSideModel = new PosCustomerSideModel(categories, meals);
        }
        [TestMethod()]
        public void PosCustomerSideModelTest()
        {
            posCustomerSideModel = new PosCustomerSideModel(categories, meals);

            Assert.IsTrue(posCustomerSideModel != null);
        }

        [TestMethod()]
        public void GetNowButtonMealDescriptionTest()
        {
            posCustomerSideModel.SetSelectedCategory(categories[0].Name);
            var actual = posCustomerSideModel.GetNowButtonMealDescription(0);
            Assert.AreEqual(meals[0].Descript, actual);
        }

        [TestMethod()]
        public void GetMealsCountTest()
        {
            var actual = posCustomerSideModel.GetMealsCount();
            Assert.AreEqual(1, actual);
        }

        [TestMethod()]
        public void GetMealByIndexTest()
        {
            posCustomerSideModel.SetSelectedCategory(categories[0].Name);
            var a = posCustomerSideModel.GetMealByIndex(0);
            Assert.AreEqual(a, meals[0]);
        }

        [TestMethod()]
        public void GetOrderTest()
        {
            posCustomerSideModel.GetOrder();
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void AddNowButtonMealTest()
        {
            posCustomerSideModel.SetSelectedCategory(categories[0].Name);
            posCustomerSideModel.AddNowButtonMeal(0);
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void GetBindingListTest()
        {
            var actual = posCustomerSideModel.GetBindingList();
            Assert.AreEqual(0, actual.Count);
        }

        [TestMethod()]
        public void DeleteMealByIndexTest()
        {
            posCustomerSideModel.SetSelectedCategory(categories[0].Name);
            posCustomerSideModel.AddNowButtonMeal(0);
            posCustomerSideModel.DeleteMealByIndex(0);
            Assert.AreEqual(0, posCustomerSideModel.GetOrder().OrderItems.Count);
        }

        [TestMethod()]
        public void GetMealCountByCategoryTest()
        {
            posCustomerSideModel.SetSelectedCategory(categories[0].Name);
            var a = posCustomerSideModel.GetMealCountByCategory();
            Assert.AreEqual(a, 1);
        }

        [TestMethod()]
        public void GetMealsByCategoryTest()
        {
            posCustomerSideModel.SetSelectedCategory(categories[0].Name);
            var a = posCustomerSideModel.GetMealsByCategory();
            Assert.AreEqual(a[0], meals[0]);
        }

        [TestMethod()]
        public void SetSelectedCategoryTest()
        {
            posCustomerSideModel.SetSelectedCategory("Test");
            Assert.IsTrue(true);
        }
    }
}