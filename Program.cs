using System;
namespace bookStoreRecord
{
    class Program
    {
        public record Bookstore(int ID, string Title, string Author, double Price);

        public static void Main()
        {
            Bookstore book1 = new(10, "Stardust", "Neil Gaiman", 19.95);
            Console.WriteLine($"Object 1: {book1}");
            Bookstore book2 = new(20, "Good Omens", "Neil Gaiman & Terry Pratchett", 16.50);
            Console.WriteLine($"Object 2: {book2}");
            Bookstore book3 = new(30, "American Gods", "Neil Gaiman", 18.40);
            Console.WriteLine($"Object 3: {book3}");

        }
    }
}