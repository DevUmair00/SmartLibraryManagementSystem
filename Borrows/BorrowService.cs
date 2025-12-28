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


        public DataTable SearchBorrowsInInventory(string term)
        {
            if (string.IsNullOrWhiteSpace(term))
                return _borrowRrepo.GetActiveBorrows();

            return _borrowRrepo.SearchActiveBorrows(term.Trim());
        }
    }
}