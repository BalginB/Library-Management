namespace LibraryManagement
{
    [Serializable()]
    public class Reader
    {
        // Properties representing reader details
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public List<Book> Borrowed { get; set; }

        public Reader() { }

        // Parameterized constructor to initialize reader details
        public Reader(string firstName, string lastName, string address, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Age = age;
            Borrowed = new List<Book>();
        }
    }
}
