using System;

namespace Smart_Library_Management_System.Borrowing
{
    public class BorrowModel
    {
        public int BorrowID { get; set; }
        public int BookID { get; set; }
        public int MemberID { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; } // Nullable

        // Constructor for New Borrow (Default 14 days)
        public BorrowModel(int bookId, int memberId)
        {
            BookID = bookId;
            MemberID = memberId;
            BorrowDate = DateTime.Now;
            DueDate = DateTime.Now.AddDays(14);
        }

        public BorrowModel() { }
    }
}