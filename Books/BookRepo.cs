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
                string query = "SELECT * FROM Books WHERE Title LIKE @search OR ISBN LIKE @search";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@search", "%" + searchTerm + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }
    }
}
