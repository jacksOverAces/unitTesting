namespace LibraryOne
{
    public class Student
    {

        public string First { get; set; }
        public string Last { get; set; }

        public Student()
        {
            First = "";
            Last = "";
        }

        public Student(string first, string last)
        {
            First = first;
            Last = last;
        }
    }
}
