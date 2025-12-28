using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Smart_Library_Management_System.Common;

namespace Smart_Library_Management_System.Authors
{
    internal class AuthorRepo
    {
        // 1. Add a New Author
        public bool AddAuthor(AuthorModel author)
        {
            using (SqlConnection conn = new SqlConnection(Common.Utlis.GET_DB_Connection_String()))
            {
                string query = "INSERT INTO Authors (FullName, Nationality) VALUES (@name, @nationality)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", author.FullName);
                cmd.Parameters.AddWithValue("@nationality", author.Nationality);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // 2. Fetch All Authors (Used for the Author Management Grid and the Book Form ComboBox)
        public DataTable GetAllAuthors()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(Common.Utlis.GET_DB_Connection_String()))
            {
                string query = "SELECT AuthorID, FullName, Nationality FROM Authors";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }

        // 3. Update Existing Author Details
        public bool UpdateAuthor(AuthorModel author)
        {
            using (SqlConnection conn = new SqlConnection(Common.Utlis.GET_DB_Connection_String()))
            {
                string query = "UPDATE Authors SET FullName = @name, Nationality = @nationality WHERE AuthorID = @id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", author.FullName);
                cmd.Parameters.AddWithValue("@nationality", author.Nationality);
                cmd.Parameters.AddWithValue("@id", author.AuthorID);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // 4. Delete an Author
        public bool DeleteAuthor(int authorId)
        {
            using (SqlConnection conn = new SqlConnection(Common.Utlis.GET_DB_Connection_String()))
            {
                // Note: Due to Foreign Key constraints, this will fail if the author has books 
                // unless you have "ON DELETE CASCADE" set in your SQL table.
                string query = "DELETE FROM Authors WHERE AuthorID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", authorId);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // 5. Search Authors by Name or Nationality
        public DataTable SearchAuthors(string searchTerm)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(Common.Utlis.GET_DB_Connection_String()))
            {
                string query = "SELECT * FROM Authors WHERE FullName LIKE @search OR Nationality LIKE @search";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@search", "%" + searchTerm + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }
    }
}