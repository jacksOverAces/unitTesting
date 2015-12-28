namespace LibraryOne
{
    public class Student
    {

        private string first;
        private string last;

        public string First
        {
            get
            {
                return first;
            }
            set
            {
                first = value;
            }
        }

        public string Last
        {
            get
            {
                return last;
            }
            set
            {
                last = value;
            }
        }

        public Student()
        {
            first = "";
            last = "";
        }

        public Student(string first, string last)
        {
            this.first = first;
            this.last = last;
        }
    }
}
