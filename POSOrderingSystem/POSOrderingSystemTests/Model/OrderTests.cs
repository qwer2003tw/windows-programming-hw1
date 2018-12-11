// file:	Model\OrderTests.cs
//
// summary:	Implements the order tests class

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace POSOrderingSystem.Model.Tests
{
    /// <summary>   (Unit Test Class) an order tests. </summary>
    ///
    /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

    [TestClass()]
    public class OrderTests
    {
        /// <summary>   The order. </summary>
        Order order;

        /// <summary>   Tests initialize. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestInitialize()]
        public void TestInitialize()
        {
            order = new Order();
        }

        /// <summary>   (Unit Test Method) tests order. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

        [TestMethod()]
        public void OrderTest()
        {
            order = new Order();
            var actual = order.TotalPrice;
            Assert.AreEqual("Total:0元", actual);
        }

        /// <summary>   (Unit Test Method) deletes the meal test. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

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

        /// <summary>   (Unit Test Method) adds meal test. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 11/25/2018. </remarks>

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