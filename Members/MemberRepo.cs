using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Smart_Library_Management_System.Common;

namespace Smart_Library_Management_System.Members
{
    internal class MemberRepo
    {
        public bool AddMember(MemberModel member)
        {
            using (SqlConnection conn = new SqlConnection(Common.Utlis.GET_DB_Connection_String()))
            {
                string query = "INSERT INTO Members (FullName, Email, MembershipDate) VALUES (@name, @email, @date)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", member.FullName);
                cmd.Parameters.AddWithValue("@email", member.Email);
                cmd.Parameters.AddWithValue("@date", DateTime.Now);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public DataTable GetAllMembers()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(Common.Utlis.GET_DB_Connection_String()))
            {
                string query = "SELECT MemberID, FullName, Email, MembershipDate FROM Members";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }

        public bool UpdateMember(MemberModel member)
        {
            using (SqlConnection conn = new SqlConnection(Common.Utlis.GET_DB_Connection_String()))
            {
                string query = "UPDATE Members SET FullName=@name, Email=@email WHERE MemberID=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", member.FullName);
                cmd.Parameters.AddWithValue("@email", member.Email);
                cmd.Parameters.AddWithValue("@id", member.MemberID);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool DeleteMember(int memberId)
        {
            using (SqlConnection conn = new SqlConnection(Common.Utlis.GET_DB_Connection_String()))
            {
                string query = "DELETE FROM Members WHERE MemberID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", memberId);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public DataTable SearchMembers(string searchTerm)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(Common.Utlis.GET_DB_Connection_String()))
            {
                // We search in FullName OR Email
                string query = "SELECT MemberID, FullName, Email, MembershipDate " +
                               "FROM Members " +
                               "WHERE FullName LIKE @search OR Email LIKE @search";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@search", "%" + searchTerm + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }
    }
}