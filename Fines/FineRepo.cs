using Microsoft.Data.SqlClient;
using Smart_Library_Management_System.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Library_Management_System.Fines
{
    internal class FineRepo
    {
        public bool CreateFine(int borrowId, decimal amount)
        {
            using (SqlConnection conn = new SqlConnection(Utlis.GET_DB_Connection_String()))
            {
                string query = @"INSERT INTO Fines (BorrowID, FineAmount, PaymentStatus) 
                         VALUES (@bid, @amount, 'Unpaid')";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@bid", borrowId);
                cmd.Parameters.AddWithValue("@amount", amount);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdateFineStatusToPaid(int fineId)
        {
            using (SqlConnection conn = new SqlConnection(Utlis.GET_DB_Connection_String()))
            {
                string query = "UPDATE Fines SET PaymentStatus = 'Paid' WHERE FineID = @fid";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@fid", fineId);

                try
                {
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public DataTable GetFinesList()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(Utlis.GET_DB_Connection_String()))
            {
                // Join 4 tables to get a complete picture
                string query = @"SELECT 
                            F.FineID, 
                            M.FullName AS [Member Name], 
                            Bk.Title AS [Book Title], 
                            F.FineAmount AS [Amount], 
                            B.ReturnDate, 
                            F.PaymentStatus AS [Status]
                         FROM Fines F
                         INNER JOIN Borrow B ON F.BorrowID = B.BorrowID
                         INNER JOIN Members M ON B.MemberID = M.MemberID
                         INNER JOIN Books Bk ON B.BookID = Bk.BookID
                         ORDER BY F.PaymentStatus DESC, F.FineID DESC"; // Unpaid usually shows at top

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                try
                {
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error loading fines: " + ex.Message);
                }
            }
            return dt;
        }

        public DataTable SearchFinesByMemberName(string memberName)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(Utlis.GET_DB_Connection_String()))
            {
                // Use LIKE with % wildcards to find names that contain the search text
                string query = @"SELECT 
                            F.FineID, 
                            M.FullName AS [Member Name], 
                            Bk.Title AS [Book Title], 
                            F.FineAmount AS [Amount], 
                            B.ReturnDate,
                            F.PaymentStatus AS [Status]
                         FROM Fines F
                         INNER JOIN Borrow B ON F.BorrowID = B.BorrowID
                         INNER JOIN Members M ON B.MemberID = M.MemberID
                         INNER JOIN Books Bk ON B.BookID = Bk.BookID
                         WHERE M.FullName LIKE @name OR Title LIKE @name 
                         ORDER BY F.PaymentStatus DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                // The % allows searching for partial names (e.g., "Jo" finds "John")
                cmd.Parameters.AddWithValue("@name", "%" + memberName + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

    }
}
