using System;

namespace Smart_Library_Management_System.Models
{
    public class FineModel
    {
        // Properties
        public int FineID { get; set; }
        public int BorrowID { get; set; }
        public decimal FineAmount { get; set; }
        public string PaymentStatus { get; set; }

        public FineModel()
        {
            PaymentStatus = "Unpaid"; // Default value as per your SQL schema
        }
        
        public FineModel(int borrowId, decimal amount)
        {
            this.BorrowID = borrowId;
            this.FineAmount = amount;
            this.PaymentStatus = "Unpaid";
        }

        public FineModel(int fineId, int borrowId, decimal amount, string status)
        {
            this.FineID = fineId;
            this.BorrowID = borrowId;
            this.FineAmount = amount;
            this.PaymentStatus = status;
        }
    }
}