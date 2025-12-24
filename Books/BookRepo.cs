using Smart_Library_Management_System.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Library_Management_System.Authors
{
    internal class BookRepo
    {
        public DataTable GetAllBooks()
        {
            using (SqlConnection conn = new SqlConnection(Common.Utlis.GET_DB_Connection_String))
            {
                // Using JOIN to show Author Name instead of ID (Cheat Sheet Sec. 42)
                string query = @"SELECT B.BookID, B.Title, A.FullName as Author, B.CurrentStatus 
                         FROM Books B 
                         INNER JOIN Authors A ON B.AuthorID = A.AuthorID";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
