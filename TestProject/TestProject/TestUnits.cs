﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryOne;

namespace TestProject
{
    [TestClass]
    public class TestUnits
    {
        [TestMethod]
        public void TestAdd()
        {
            Operations objecto = new Operations();
            int result = objecto.Add(3, 4);
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void TestSubtract()
        {
            Operations execute = new Operations();
            int difference = execute.Subtract(23, 2);
            Assert.AreEqual(21, difference);
        }
    }
}
