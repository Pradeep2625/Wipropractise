using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Borrower
    {
       public string Name { get; set; }
        public string LibraryCardNumber { get; set; }
       public List<Book> BorrowedBooks { get; set; }
        public Borrower(string name, string libraryCardNumber)
        {
          
            Name=name;
            LibraryCardNumber=libraryCardNumber;
            BorrowedBooks= new List<Book>();
        }

        public void BorrowBook(Book book)
        {
            if (!book.IsBorrowed)
            {
                book.Borrow();
                BorrowedBooks.Add(book);
            }
        }
        public void ReturnBook(Book book) 
        {
            if (BorrowedBooks.Contains(book))
            {
                book.Return();
            }

        }
    }
}
