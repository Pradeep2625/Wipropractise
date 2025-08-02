using NUnit.Framework;
using System.Linq;
using Assignment2;
namespace TestLMS
{

    [TestFixture]
    public class LibraryTests
    {
        private Library library;

        [SetUp]
        public void Setup()
        {
            library = new Library();
        }

        [Test]
        public void TestAddBook_ToLibrary()
        {
            var book = new Book("Book1", "Author1", "ISBN123");
            library.AddBook(book);
            Assert.Contains(book, library.Books);
        }

        [Test]
        public void TestRegisterBorrower_ToLibrary()
        {
            var borrower = new Borrower("John", "CARD001");
            library.RegisterBorrower(borrower);
            Assert.Contains(borrower, library.Borrowers);
        }

        [Test]
        public void TestBorrowBook()
        {
            var book = new Book("Book2", "Author2", "ISBN456");
            var borrower = new Borrower("Alice", "CARD002");
            library.AddBook(book);
            library.RegisterBorrower(borrower);

            library.BorrowBook("ISBN456", "CARD002");

            Assert.IsTrue(book.IsBorrowed);
            Assert.Contains(book, borrower.BorrowedBooks);
        }

        [Test]
        public void TestReturnBook()
        {
            var book = new Book("Book3", "Author3", "ISBN789");
            var borrower = new Borrower("Bob", "CARD003");
            library.AddBook(book);
            library.RegisterBorrower(borrower);
            borrower.BorrowBook(book); // manually borrow

            library.ReturnBook("ISBN789", "CARD003");

            Assert.IsFalse(book.IsBorrowed);
            Assert.IsFalse(borrower.BorrowedBooks.Contains(book));
        }

        [Test]
        public void TestViewBooks()
        {
            library.AddBook(new Book("Book1", "Author1", "ISBN001"));
            library.AddBook(new Book("Book2", "Author2", "ISBN002"));

            var books = library.ViewBooks();

            Assert.AreEqual(2, books.Count);
        }

        [Test]
        public void TestViewBorrowers()
        {
            library.RegisterBorrower(new Borrower("User1", "CARD1"));
            library.RegisterBorrower(new Borrower("User2", "CARD2"));

            var borrowers = library.ViewBorrowers();

            Assert.AreEqual(2, borrowers.Count);
        }
    }

}