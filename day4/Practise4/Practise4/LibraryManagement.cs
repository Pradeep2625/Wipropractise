using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise4
{
    class Book
    {
        // Define properties
        // Complete Step 1:............
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

        // Define constructor
        // Complete Step 2:............
        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
        }
    }

    class Library
    {
        // Define collection to store books
        // Complete Step 3:............
        List<Book> books = new List<Book>();

        // Add method to add a book
        // Complete Step 4:............
        public void AddBook()
        {
            // choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter book title");
            string title = Console.ReadLine();
           
            Console.WriteLine("Enter book author");
            string author = Console.ReadLine();
           
            Console.WriteLine("Enter book ISBN");
            string isbn = Console.ReadLine();
            books.Add(new Book(title, author, isbn));

            Console.WriteLine("Book added successfully.");
            
        }

        // Add method to remove a book by ISBN
        // Complete Step 5:............
        public void RemoveBook(string isbn)
        {
            // choice = Convert.ToInt32(Console.ReadLine());
            for (int i = books.Count - 1; i >= 0; i--)
            {
                if (books[i].ISBN == isbn)
                {
                    books.RemoveAt(i); // removes the whole book string
                }
            }

        }

        // Add method to list all books
        // Complete Step 6:............
        public void ShowBooks()
        {
            foreach (Book book in books)
            {
                Console.WriteLine(book);
            }

        }
    }
    internal class LibraryManagement
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Remove Book");
                Console.WriteLine("3. List Books");
                Console.WriteLine("4. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        // Prompt for book details and add book
                        // Complete Step 7:............
                        library.AddBook();


                        break;
                    case 2:
                        // Prompt for ISBN and remove book
                        // Complete Step 8:............
                        Console.WriteLine("Enter book ISBN");
                        string isbn = Console.ReadLine();
                        
                            library.RemoveBook(isbn);
                        

                        break;
                    case 3:
                        // List all books
                        // Complete Step 9:............
                        library.ShowBooks();
                        break;
                    case 4:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
