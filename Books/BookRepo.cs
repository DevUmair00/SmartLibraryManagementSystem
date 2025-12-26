using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using Smart_Library_Management_System.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Library_Management_System.Books
{
    internal class BookRepo
    {
        public bool AddBook(BookModel book)
        {
            using (SqlConnection conn = new SqlConnection(Common.Utlis.GET_DB_Connection_String()))
            {

                string query = "INSERT INTO Books (Title, ISBN, AuthorID, CurrentStatus, Category) " +
               "VALUES (@title, @isbn, @authorId, @status, @category)";


                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@title", book.Title);
                cmd.Parameters.AddWithValue("@isbn", book.ISBN);
                cmd.Parameters.AddWithValue("@authorId", book.AuthorID);
                cmd.Parameters.AddWithValue("@status", book.CurrentStatus);
                cmd.Parameters.AddWithValue("@category", book.Category);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public DataTable GetAllBooks()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(Common.Utlis.GET_DB_Connection_String()))
            {
                // Join Books and Authors to get the Author's FullName

                string query = @"SELECT B.BookID, B.Title, B.ISBN,
                 B.AuthorID,
                 A.FullName AS [Author Name],
                 B.Category, B.CurrentStatus
                 FROM Books B 
                 INNER JOIN Authors A ON B.AuthorID = A.AuthorID";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }

        public bool UpdateBook(BookModel book)
        {
            using (SqlConnection conn = new SqlConnection(Common.Utlis.GET_DB_Connection_String()))
            {
                string query = "UPDATE Books SET Title = @title, Category = @category, ISBN = @isbn " +
                               "WHERE BookID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@title", book.Title);
                cmd.Parameters.AddWithValue("@category", book.Category);
                cmd.Parameters.AddWithValue("@isbn", book.ISBN);
                cmd.Parameters.AddWithValue("@id", book.BookID);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool DeleteBook(int bookId)
        {
            using (SqlConnection conn = new SqlConnection(Common.Utlis.GET_DB_Connection_String()))
            {
                string query = "DELETE FROM Books WHERE BookID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", bookId);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public DataTable SearchBooks(string searchTerm) 
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(Common.Utlis.GET_DB_Connection_String()))
            {


                string query = @"SELECT B.BookID, B.Title, B.ISBN,
                 B.AuthorID,
                 A.FullName AS [Author Name],
                 B.Category, B.CurrentStatus 
                 FROM Books B  
                 INNER JOIN Authors A ON B.AuthorID = A.AuthorID
                 WHERE Title LIKE @search OR ISBN LIKE @search OR FullName LIKE @search"; 

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@search", "%" + searchTerm + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }





        public DataTable GetBooksByStatus(string status)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(Utlis.GET_DB_Connection_String()))
            {
                // We JOIN with Authors to get FullName
                // Note: Check your Books table to see if 'Genre' is spelled differently (like 'Category')
                string query = @"SELECT 
                            B.BookID, 
                            B.Title, 
                            A.FullName AS AuthorName, 
                            B.ISBN,
                            B.Category
                         FROM Books B
                         INNER JOIN Authors A ON B.AuthorID = A.AuthorID
                         WHERE B.CurrentStatus = @status";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@status", status);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        public DataTable SearchAvailableBooks(string term)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(Utlis.GET_DB_Connection_String()))
            {
                // We join the two tables on the AuthorID column
                string query = @"SELECT 
                    B.BookID, 
                    B.Title, 
                    A.FullName AS AuthorName, 
                    B.Category, 
                    B.ISBN 
                 FROM Books B
                 INNER JOIN Authors A ON B.AuthorID = A.AuthorID
                 WHERE B.CurrentStatus = 'Available' 
                 AND (B.Title LIKE @term 
                      OR A.FullName LIKE @term 
                      OR B.Category LIKE @term OR B.ISBN Like @term)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@term", "%" + term + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        public bool UpdateBookStatus(int bookId, string status)
        {
            using (SqlConnection conn = new SqlConnection(Common.Utlis.GET_DB_Connection_String()))
            {
                string query = "UPDATE Books SET CurrentStatus = @status WHERE BookID = @bid";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@bid", bookId);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool HasBooksByAuthor(int authorId)
        {
            using (SqlConnection conn = new SqlConnection(Utlis.GET_DB_Connection_String()))
            {
                // We use COUNT(1) because it is faster than selecting all data
                string query = "SELECT COUNT(1) FROM Books WHERE AuthorID = @aid";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@aid", authorId);

                conn.Open();
                // ExecuteScalar returns the first column of the first row (the count)
                int count = (int)cmd.ExecuteScalar();

                // If count is greater than 0, the author has books and shouldn't be deleted
                return count > 0;
            }
        }

    }
}


