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
        public DateTime? ReturnDate { get; set; } // Nullable: only filled when book is returned

        public BorrowModel() { }

        // Constructor for creating a new borrow record
        public BorrowModel(int bookId, int memberId, int daysToKeep)
        {
            BookID = bookId;
            MemberID = memberId;
            BorrowDate = DateTime.Now;
            DueDate = DateTime.Now.AddDays(daysToKeep);
            ReturnDate = null;
        }
    }
}