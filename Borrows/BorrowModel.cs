using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Library_Management_System.Borrows
{
    public class BorrowModel
    {
        public int BorrowID { get; set; }
        public int BookID { get; set; }
        public int MemberID { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime ReturnDate { get; set; }

        public BorrowModel() { }
        public BorrowModel(int BorrowID, int BookID, int MemberID, DateTime BorrowDate, DateTime DueDate, DateTime ReturnDate)
        {
            BorrowID = BorrowID;
            BookID = BookID;
            MemberID = MemberID;
            BorrowDate = BorrowDate;
            DueDate = DueDate;
            ReturnDate = ReturnDate;
        }

        public override string ToString()
        {
            return $"{BorrowID},{BookID},{MemberID},{BorrowDate;yyyy-MM-dd},{DueDate;yyyy-MM-dd},{ReturnDate}";
        }

    }
}