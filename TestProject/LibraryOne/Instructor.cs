namespace LibraryOne
{
    public class Instructor
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
                name = value;
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

        public Instructor()
        {
            name = "";
            id = "";
        }
    }
}
