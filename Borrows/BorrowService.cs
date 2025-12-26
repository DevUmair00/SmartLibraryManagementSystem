using Smart_Library_Management_System.Books;
using Smart_Library_Management_System.Members;
using System;
using System.Data;

namespace Smart_Library_Management_System.Borrowing
{
    public class BorrowService
    {
        private readonly BorrowRepo _borrowRrepo = new BorrowRepo();
        private readonly BookRepo _bookRepo = new BookRepo();
        private readonly MemberRepo _memberRepo = new MemberRepo();

        //Borrow Form
        public string ProcessBorrow(int bookId, int memberId)
        {
            if (bookId <= 0 || memberId <= 0) return "Select valid Book and Member.";

            var borrow = new BorrowModel(bookId, memberId);
            return _borrowRrepo.ProcessBorrow(borrow) ? "Success" : "Database Error";
        }


        // 1. Search only Books that are "Available"
        public DataTable SearchAvailableBooksInInventory(string term)
        {
            if (string.IsNullOrWhiteSpace(term))
                return _bookRepo.GetBooksByStatus("Available");

            return _bookRepo.SearchAvailableBooks(term.Trim());
        }





        //Active Borrow Form

        public DataTable GetActiveList() => _borrowRrepo.GetActiveBorrows();


        public bool ProcessReturn(int borrowId, int bookId)
        {
            // You could add logic here to check if the book was already returned
            // or log the transaction for auditing.
            return _borrowRrepo.ReturnBook(borrowId, bookId);
        }

        public decimal CalculateFine(DateTime dueDate)
        {
            if (DateTime.Now <= dueDate) return 0;

            // Logic: 10.00 per day late
            TimeSpan difference = DateTime.Now - dueDate;
            int daysLate = difference.Days;

            return daysLate > 0 ? (decimal)(daysLate * 10.00) : 0;
        }

        public DataTable SearchBorrowsInInventory(string term)
        {
            if (string.IsNullOrWhiteSpace(term))
                return _borrowRrepo.GetActiveBorrows();

            return _borrowRrepo.SearchActiveBorrows(term.Trim());
        }


        //public bool ReturnBook(int borrowId, int bookId)
        //{
        //    // 1. Mark the Borrow record as returned
        //    bool borrowUpdated = _repo.ReturnBook(borrowId);

        //    // 2. Mark the Book as 'Available' again
        //    // Calling the BookRepo to update the specific BookID
        //    bool bookUpdated = _bookRepo.UpdateBookStatus(bookId, "Available");

        //    // Returns true only if BOTH database updates were successful
        //    return borrowUpdated && bookUpdated;
        //}



    }
}