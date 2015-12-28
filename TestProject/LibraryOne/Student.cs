namespace LibraryOne
{
    public class Student
    {

        private string first;
        private string last;
        private int id;

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

        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public Student()
        {
            first = "";
            last = "";
            id = 0;
        }

        public Student(string first, string last)
        {
            this.first = first;
            this.last = last;
        }

        public Student(string first, string last, int id)
        {
            this.first = first;
            this.last = last;
            this.id = id;
        }
    }
}
