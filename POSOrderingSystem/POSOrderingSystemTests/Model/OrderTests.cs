using Microsoft.VisualStudio.TestTools.UnitTesting;
using POSOrderingSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSOrderingSystem.Model.Tests
{
    [TestClass()]
    public class OrderTests
    {
        Order order;
        [TestInitialize()]
        public void TestInitialize()
        {
            order = new Order();
        }
        [TestMethod()]
        public void OrderTest()
        {
            order = new Order();
            var a = order.TotalPrice;
            Assert.IsTrue(order != null);
        }

        [TestMethod()]
        public void DeleteMealTest()
        {
            var meal = new Meal()
            {
                Category = new Category() { Name = "TestCategory" },
                Descript = "TestDescript",
                ImagePath = "Test/ImagePath.png",
                Name = "TestName",
                Price = 99
            };
            order.AddMeal(meal);
            order.DeleteMeal(0);
            Assert.IsTrue(order.OrderItems.Count == 0);
        }

        [TestMethod()]
        public void AddMealTest()
        {
            var meal = new Meal()
            {
                Category = new Category() { Name = "TestCategory" },
                Descript = "TestDescript",
                ImagePath = "Test/ImagePath.png",
                Name = "TestName",
                Price = 99
            };
            order.AddMeal(meal);
            order.AddMeal(meal);
            Assert.IsTrue(order.OrderItems[0].Quantity == 2);
        }
    }
}