using Microsoft.Data.SqlClient;
using Smart_Library_Management_System.Common;
using System;
using System.Data;
using System.Data.Common;
using System.Net;
using System.Transactions;

namespace Smart_Library_Management_System.Borrowing
{
    internal class BorrowRepo
    {
        // 1. Borrow Book Logic
        public bool ProcessBorrow(BorrowModel borrow)
        {
            using (SqlConnection conn = new SqlConnection(Utlis.GET_DB_Connection_String()))
            {
                // We put both SQL commands in one string, separated by a semicolon
                string sql = @"
            INSERT INTO Borrow (BookID, MemberID, BorrowDate, DueDate) 
            VALUES (@bid, @mid, @bdate, @ddate);

            UPDATE Books 
            SET CurrentStatus = 'Borrowed' 
            WHERE BookID = @bid;";

                SqlCommand cmd = new SqlCommand(sql, conn);

                // Add parameters (Notice we only need @bid once now)
                cmd.Parameters.AddWithValue("@bid", borrow.BookID);
                cmd.Parameters.AddWithValue("@mid", borrow.MemberID);
                cmd.Parameters.AddWithValue("@bdate", borrow.BorrowDate);
                cmd.Parameters.AddWithValue("@ddate", borrow.DueDate);

                try
                {
                    conn.Open();
                    // ExecuteNonQuery returns the total number of rows affected
                    // Since we are inserting 1 row and updating 1 row, we expect 2
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        // 2. Get Active Borrows (For your second form)
       public DataTable GetActiveBorrows(string searchValue = "")
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(Common.Utlis.GET_DB_Connection_String()))
            {
                // SQL CASE logic: If today > DueDate, it's 'Overdue', otherwise 'Active'
                string query = @"SELECT 
                            B.BorrowID, 
                            B.BookID, 
                            Bk.Title  AS [Book Title], 
                            M.FullName  AS [Member Name], 
                            B.BorrowDate, 
                            B.DueDate,
                            CASE 
                                WHEN GETDATE() > B.DueDate THEN 'Overdue'
                                ELSE 'On Time'
                            END AS Status
                         FROM Borrow B
                         INNER JOIN Books Bk ON B.BookID = Bk.BookID
                         INNER JOIN Members M ON B.MemberID = M.MemberID
                         WHERE B.ReturnDate IS NULL 
                         AND (Bk.Title LIKE @search OR M.FullName LIKE @search)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@search", "%" + searchValue + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }


        // 3. Return Book Logic
        public bool ReturnBook(int borrowId, int bookId)
        {
            using (SqlConnection conn = new SqlConnection(Utlis.GET_DB_Connection_String()))
            {
                conn.Open();
                // Use a transaction so both updates succeed or fail together
                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // 1. Update the Borrow Record
                        string updateBorrowSql = "UPDATE Borrow SET ReturnDate = GETDATE() WHERE BorrowID = @bid";

                        SqlCommand cmd1 = new SqlCommand(updateBorrowSql, conn, transaction);
                        cmd1.Parameters.AddWithValue("@bid", borrowId);
                        cmd1.ExecuteNonQuery();

                        // 2. Update the Book Status
                        string updateBookSql = "UPDATE Books SET CurrentStatus = 'Available' WHERE BookID = @bkid";
                        SqlCommand cmd2 = new SqlCommand(updateBookSql, conn, transaction);
                        cmd2.Parameters.AddWithValue("@bkid", bookId);
                        cmd2.ExecuteNonQuery();


                        transaction.Commit();
                        return true;
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }

        public DataTable SearchActiveBorrows(string term)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(Utlis.GET_DB_Connection_String()))
            {
                string query = @"SELECT B.BorrowID, B.BookID, Bk.Title AS [Book Title], M.FullName AS [Member Name], B.BorrowDate, B.DueDate, BK.CurrentStatus  AS Status 
                         FROM Borrow B
                         INNER JOIN Books Bk ON B.BookID = Bk.BookID
                         INNER JOIN Members M ON B.MemberID = M.MemberID
                         WHERE B.ReturnDate IS NULL 
                         AND (B.BorrowID LIKE @term OR B.BookID LIKE @term OR Bk.Title LIKE @term OR M.FullName LIKE @term)";

                SqlCommand cmd = new SqlCommand(query, conn);
                // The % wildcards allow searching for partial names/titles
                cmd.Parameters.AddWithValue("@term", "%" + term + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }


    }
}