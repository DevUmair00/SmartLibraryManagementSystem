using SMS_Desktop_Application.Common;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_Desktop_Application.Customer
{
    internal class BookRepo
    {

        // Customer Repo Table;;;

        //CustomerTable         ID   |  Customer_Name  |  PhoneNumber  |  Age    |   Address
        //Place Holder          @id  |  @name          |    @phoneNo   |  @age   |   @address 
         
        public bool Create(BookModel customer)
        {
            using (SqlConnection connection = new SqlConnection(Utlis.GET_DB_Connection_String()))
            {
                connection.Open();

                string CreateQuery = "INSERT INTO CustomerTable " +
                    "(Customer_Name , PhoneNumber , Age , Address) " +
                    "VALUES(@name , @phoneNo , @age , @address) ";

                SqlCommand cmd = new SqlCommand(CreateQuery, connection);

                cmd.Parameters.AddWithValue("@name", customer.Name);
                cmd.Parameters.AddWithValue("@phoneNo", customer.PhoneNumber);
                cmd.Parameters.AddWithValue("@age", customer.Age);
                cmd.Parameters.AddWithValue("@address", customer.Address);

                int RowAffected = cmd.ExecuteNonQuery();

                if (RowAffected > 0) return true;

                return false;
            }
        }

        public bool Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(Utlis.GET_DB_Connection_String()))
            {
                connection.Open();

                string DeleteQuery = "DELETE FROM CustomerTable WHERE ID = @id";

                SqlCommand cmd = new SqlCommand(DeleteQuery, connection);

                cmd.Parameters.AddWithValue("@id", id);

                int RowAffected = cmd.ExecuteNonQuery();

                return RowAffected > 0;
            }
        }

        public bool Update(BookModel customer, int id)
        {
            using (SqlConnection connection = new SqlConnection(Utlis.GET_DB_Connection_String()))
            {
                connection.Open();
                string UpdateQuery = "UPDATE CustomerTable " +
                                        "SET " +
                                        "Customer_Name = @name , " +
                                        "PhoneNumber = @phoneNo , " +
                                        "Age = @age , " +
                                        "Address = @address " +
                                      "WHERE ID = @id";


                SqlCommand cmd = new SqlCommand(UpdateQuery, connection);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", customer.Name);
                cmd.Parameters.AddWithValue("@phoneNo", customer.PhoneNumber);
                cmd.Parameters.AddWithValue("@age", customer.Age);
                cmd.Parameters.AddWithValue("@address", customer.Address);

                int RowAffected = cmd.ExecuteNonQuery();

                return RowAffected > 0;
            }
        }

        public List<BookModel> GetAll()
        {
            List<BookModel> Customers = new List<BookModel>();

            using (SqlConnection connection = new SqlConnection(Utlis.GET_DB_Connection_String()))
            {
                connection.Open();
                string GetAllQuery = "SELECT * FROM CustomerTable";

                SqlCommand cmd = new SqlCommand(GetAllQuery, connection);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    int ID = Convert.ToInt32(reader["ID"]);
                    string Name = reader["Customer_Name"].ToString();
                    string PhoneNO = reader["PhoneNumber"].ToString();
                    int Age = Convert.ToInt32(reader["Age"]);
                    string Address = reader["Address"].ToString();

                    BookModel customer = new CustomerModel(ID, Name, PhoneNO, Age, Address);
                    Customers.Add(customer);
                }
            }
            return Customers;
        }

        public BookModel SearchCustomerBy_ID(int id)
        {
            BookModel customer = null;

            using (SqlConnection connection = new SqlConnection(Utlis.GET_DB_Connection_String()))
            {
                connection.Open();
                string GetAllQuery = "SELECT " +
                    "ID, Customer_Name, PhoneNumber, Age, Address " +
                    "FROM CustomerTable WHERE ID = @id";

                SqlCommand cmd = new SqlCommand(GetAllQuery, connection);


                cmd.Parameters.AddWithValue("@id", id);


                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    int Id = Convert.ToInt32(reader["ID"]);
                    string Name = reader["Customer_Name"].ToString();
                    string PhoneNO = reader["PhoneNumber"].ToString();
                    int Age = Convert.ToInt32(reader["Age"]);
                    string Address = reader["Address"].ToString();

                    customer = new CustomerModel(Id, Name, PhoneNO, Age, Address);
                }
            }
            return customer;
        }
    }
}
