using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryOne;

namespace TestProject
{
    [TestClass]
    public class TestUnits
    {
        [TestMethod]
        public void TestAdd()
        {
            Operations execute = new Operations();
            int result = execute.Add(3, 4);
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void TestSubtract()
        {
            Operations execute = new Operations();
            int difference = execute.Subtract(23, 2);
            Assert.AreEqual(21, difference);
        }

        [TestMethod]
        public void TestMultiplication()
        {
            Operations execute = new Operations();
            int product = execute.Multiplication(2, 3);
            Assert.AreEqual(6, product);
        }

        [TestMethod]
        public void TestFirstNameProperty()
        {
            Student student = new Student();
            student.First = "Jimmy";
            Assert.AreEqual("Jimmy", student.First);
        }

        [TestMethod]
        public void TestStudentConstructor()
        {
            Student student = new Student();
            string firstName = student.First;
            Assert.AreEqual("", firstName);
            string lastName = student.Last;
            Assert.AreEqual("", lastName);
        }

        [TestMethod]
        public void TestOverloadedConstructor()
        {
            Student student = new Student("Jane", "Austin");
            string firstName = student.First;
            Assert.AreEqual("Jane", firstName);
            string lastName = student.Last;
            Assert.AreEqual("Austin", lastName);
        }
    }
}
