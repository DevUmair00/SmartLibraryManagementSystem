using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Library_Management_System.Books
{
    public class BookService
    {
        // 1. Reference the Repo Layer

        private readonly BookRepo _bookRepo;

        public BookService()
        {
            _bookRepo = new BookRepo();
        }

        // 2. Logic for Adding a Book
        public string CreateBook(BookModel book)
        {
            // Business Rule: Title cannot be empty
            if (string.IsNullOrEmpty(book.Title))
                return "Title is required!";

            // Business Rule: Check if ISBN is valid (simplified example)
            if (book.ISBN.Length < 10)
                return "Invalid ISBN format.";

            bool success = _bookRepo.AddBook(book);
            return success ? "Success" : "Database Error occurred.";
        }

        // 3. Logic for Fetching Books
        public DataTable GetInventory()
        {
            // You can add logic here to filter or sort data if needed
            return _bookRepo.GetAllBooks();
        }

        // 4. Logic for Deleting a Book
        public string RemoveBook(int bookId)
        {
            // Business Rule: You might check here if the book is 'Available' 
            // before allowing a delete.
            bool success = _bookRepo.DeleteBook(bookId);
            return success ? "Book removed successfully." : "Failed to remove book.";
        }

        public string UpdateExistingBook(BookModel book)
        {
            // Validation Rules
            if (book.BookID <= 0) return "Selection error: Could not identify the book.";
            if (string.IsNullOrWhiteSpace(book.Title)) return "Title cannot be empty.";

            bool isUpdated = _bookRepo.UpdateBook(book);

            return isUpdated ? "Book updated successfully!" : "Update failed. Database error.";
        }

        public DataTable SearchBooksInInventory(string term)
        {
            if (string.IsNullOrWhiteSpace(term))
            {
                return _bookRepo.GetAllBooks(); // If empty, show everything
            }

            string sanitizedTerm = term.Trim();
            return _bookRepo.SearchBooks(sanitizedTerm);
        }

        public DataTable GetBooksByCategory(string category)
        {
            return _bookRepo.GetBooksByCategory(category);
        }

        public DataTable GetBooksByStatus(string status)
        {
            // You can add business logic here, such as logging or validation
            if (string.IsNullOrEmpty(status))
            {
                return _bookRepo.GetAllBooks(); // Fallback if no status is provided
            }

            return _bookRepo.GetBooksByStatus(status);
        }

    }
}
