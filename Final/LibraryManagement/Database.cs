using System.ComponentModel;
using System.Xml.Serialization;

namespace LibraryManagement
{
    public static class Database
    {
        // Collection of readers
        public static BindingList<Reader> Readers { get; set; } = new BindingList<Reader>();
        // Collection of books in the library
        public static BindingList<Book> Storage { get; set; } = new BindingList<Book>();


        public static void Borrow(Reader r, Book b)
        {
            r.Borrowed.Add(b);
            Storage.Remove(b);

            // Serialize the data after the change
            Serialize();
        }

        // Return a borrowed book
        public static void Return(Reader r, Book b)
        {
            Storage.Add(b);
            r.Borrowed.Remove(b);


            Console.WriteLine($"Book '{b.Title}' returned by {r.FirstName} {r.LastName}");


            Serialize();
        }

        public static void Serialize()
        {
            Serialize("readers.xml", Readers);
            Serialize("storage.xml", Storage);

            Console.WriteLine("Data serialized.");
        }

        // Generic method to serialize a list of objects to an XML file
        public static void Serialize<T>(string file, BindingList<T> list)
        {
            using (Stream s = File.Open(file, FileMode.Create))
            {
                XmlSerializer x = new XmlSerializer(list.GetType());
                x.Serialize(s, list);
            }
        }
        // Deserialize data from XML files
        public static void Deserialize()
        {
            Readers = Deserialize<Reader>("readers.xml");
            Storage = Deserialize<Book>("storage.xml");
        }

        // Generic method to deserialize a list of objects from an XML file
        public static BindingList<T> Deserialize<T>(string file)
        {
            if (!File.Exists(file))
            {
                return new BindingList<T>();
            }

            using (Stream s = File.Open(file, FileMode.Open))
            {
                XmlSerializer x = new XmlSerializer(typeof(BindingList<T>));
                return x.Deserialize(s) as BindingList<T>;
            }
        }


    }
}
