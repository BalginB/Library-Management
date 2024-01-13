namespace LibraryManagement
{
    [Serializable()]

    // The Book class represents a book in the library and is marked as serializable for XML serialization
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int Price { get; set; }

        public Book() { }

        public Book(string title, string author, string genre, int price)
        {
            Title = title;
            Author = author;
            Genre = genre;
            Price = price;
        }
    }
}
