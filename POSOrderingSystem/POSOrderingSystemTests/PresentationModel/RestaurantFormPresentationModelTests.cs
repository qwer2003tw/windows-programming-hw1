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
    public class RestaurantFormPresentationModelTests
    {
        RestaurantFormPresentationModel restaurantFormPresentationModel;
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
            restaurantFormPresentationModel = new RestaurantFormPresentationModel(categories, meals);
        }
        [TestMethod()]
        public void RestaurantFormPresentationModelTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SetSelectedMealTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetSelectedMealCloneTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetNewMealTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetNewCategoryTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetMealSaveButtonEnableTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetMealAddButtonEnableTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetCategorySaveButtonEnableTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetCategoryAddButtonEnableTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AddMealTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SaveMealTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AddCategoryTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SaveCategoryTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetMealsByCategoryTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SetSelectedCategoryTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetSelectedCategoryTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteSelectMealTest()
        {
            Assert.Fail();
        }
    }
}