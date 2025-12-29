using Smart_Library_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Library_Management_System.Fines
{
    internal class FineService
    {
        private readonly FineRepo _fineRepo;

        public FineService()
        {
            _fineRepo = new FineRepo();
        }

        public decimal CalculateFineAmount(DateTime dueDate)
        {

            int daysLate = (DateTime.Today - dueDate).Days;
            return daysLate > 0 ? (decimal)(daysLate * 10.00) : 0;

        }


        public bool AddFine(FineModel fine)
        {
            if (fine.FineAmount <= 0)
            {
                return false;
            }
            if (string.IsNullOrEmpty(fine.PaymentStatus))
            {
                fine.PaymentStatus = "Unpaid";
            }
            return _fineRepo.CreateFine(fine.BorrowID , fine.FineAmount);
        }

        public bool MarkAsPaid(int fineId)
        {
            return _fineRepo.UpdateFineStatusToPaid(fineId);
        }
    
        public DataTable GetAllFines()
        {
            return _fineRepo.GetFinesList();
        }

        public DataTable GetFinesByName(string name)
        {
            // Basic validation: if search is empty, just return all data
            if (string.IsNullOrWhiteSpace(name))
            {
                return GetAllFines();
            }
            return _fineRepo.SearchFinesByMemberName(name);
        }
    }
}
