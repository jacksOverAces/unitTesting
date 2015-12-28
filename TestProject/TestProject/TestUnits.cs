using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryOne;

namespace TestProject
{
    [TestClass]
    public class TestUnits
    {

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

        [TestMethod]
        public void TestStudentID()
        {
            Student student = new Student("Jim", "Stone", 12345);
            int studentID = student.ID;
            Assert.AreEqual(12345, studentID);
        }
    }
}
