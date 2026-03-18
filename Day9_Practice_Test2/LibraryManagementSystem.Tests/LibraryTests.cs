using NUnit.Framework;
using LibraryManagementSystem;

namespace LibraryManagementSystemTests
{
    public class LibraryTests
    {
        private Library library;

        [SetUp]
        public void Setup()
        {
            library = new Library();
        }

        [Test]
        public void AddBook_ShouldAddBookToLibrary()
        {
            var book = new Book("C# Basics", "Ganesh", "123");

            library.AddBook(book);

            Assert.AreEqual(1, library.Books.Count);
        }

        [Test]
        public void RegisterBorrower_ShouldAddBorrower()
        {
            var borrower = new Borrower("Ganesh", "C001");

            library.RegisterBorrower(borrower);

            Assert.AreEqual(1, library.Borrowers.Count);
        }

        [Test]
        public void BorrowBook_ShouldMarkBookAsBorrowed()
        {
            var book = new Book("C# Basics", "Ganesh", "123");
            var borrower = new Borrower("Ganesh", "C001");

            library.AddBook(book);
            library.RegisterBorrower(borrower);

            library.BorrowBook("123", "C001");

            Assert.IsTrue(book.IsBorrowed);
            Assert.AreEqual(1, borrower.BorrowedBooks.Count);
        }

        [Test]
        public void ReturnBook_ShouldMarkBookAsAvailable()
        {
            var book = new Book("C# Basics", "Ganesh", "123");
            var borrower = new Borrower("Ganesh", "C001");

            library.AddBook(book);
            library.RegisterBorrower(borrower);
            library.BorrowBook("123", "C001");

            library.ReturnBook("123", "C001");

            Assert.IsFalse(book.IsBorrowed);
            Assert.AreEqual(0, borrower.BorrowedBooks.Count);
        }

        [Test]
        public void ViewBooks_ShouldReturnAllBooks()
        {
            var book = new Book("C# Basics", "Ganesh", "123");
            library.AddBook(book);

            var books = library.ViewBooks();

            Assert.AreEqual(1, books.Count);
        }

        [Test]
        public void ViewBorrowers_ShouldReturnAllBorrowers()
        {
            var borrower = new Borrower("Ganesh", "C001");
            library.RegisterBorrower(borrower);

            var borrowers = library.ViewBorrowers();

            Assert.AreEqual(1, borrowers.Count);
        }
    }
}