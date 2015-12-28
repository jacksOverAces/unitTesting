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

        [TestMethod]
        public void TestCourseConstructor()
        {
            Course course = new Course();
            string courseName = course.Name;
            Assert.AreEqual("", courseName);
            string courseID = course.ID;
            Assert.AreEqual("", courseID);
        }

        [TestMethod]
        public void TestOverloadedCourseConstructor()
        {
            Course course = new Course("Programming in C#", "CS350");
            string courseName = course.Name;
            Assert.AreEqual("Programming in C#", courseName);
            string courseID = course.ID;
            Assert.AreEqual("CS350", courseID);
        }

        [TestMethod]
        public void TestInstructorConstructor()
        {
            Instructor instructor = new Instructor();
            string name = instructor.Name;
            Assert.AreEqual("", name);
            string id = instructor.ID;
            Assert.AreEqual("", id);
        }
    }
}
