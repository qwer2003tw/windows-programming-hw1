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
    public class CategoryTests
    {
        Category category;
        [TestInitialize()]
        public void TestInitialize()
        {
            category = new Category() { Name = "TestCategory" };
        }
        [TestMethod()]
        public void CloneTest()
        {
            var actual = category.Clone();
            var notExpected = category;
            Assert.AreNotEqual(notExpected, actual);
        }
    }
}