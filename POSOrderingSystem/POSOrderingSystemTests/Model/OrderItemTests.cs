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
    public class OrderItemTests
    {
        OrderItem orderItem;
        Meal meal;
        [TestInitialize()]
        public void TestInitialize()
        {
            meal = new Meal()
            {
                Category = new Category() { Name = "TestCategory" },
                Descript = "TestDescript",
                ImagePath = "Test/ImagePath.png",
                Name = "TestName",
                Price = 99
            };
            orderItem = new OrderItem(meal);
        }
        [TestMethod()]
        public void OrderItemTest()
        {
            OrderItem order = new OrderItem(meal) { Quantity = orderItem.Quantity };
            var imagePath = orderItem.ImagePath;
            var category = orderItem.Category;
            var delete = orderItem.Delete;
            var description = orderItem.Descript;
            var name = orderItem.Name;
            var price = orderItem.Price;
            var subtotal = orderItem.Subtotal;
            var actual = order;
            var notExpected = orderItem;
            meal.Name += "1";
            Assert.AreNotEqual(notExpected, actual);
        }
    }
}