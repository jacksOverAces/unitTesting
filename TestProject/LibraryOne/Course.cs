namespace LibraryOne
{
    public class Course
    {
        private string name;
        private string id;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                id = value;
            }
        }

        public string ID
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

        public Course()
        {
            name = "";
            id = "";
        }

    }
}
