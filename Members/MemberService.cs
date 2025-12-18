using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_Desktop_Application.Customer
{
    internal class AuthorService
    {
        BookRepo customerRepo = new BookRepo();

        public AuthorService() { }


        //---------------------------------------------------------------------------------------------------

        public bool SaveCustomer(BookModel customer)
        {
            return customerRepo.Create(customer);
        }

        public bool UpdateCustomer(int id, BookModel customer)
        {
            return customerRepo.Update(customer, id);
        }


        public BookModel SearchCustomerByID(int id)
        {
            return customerRepo.SearchCustomerBy_ID(id);
        }


        public bool DeleteCustomer(int id)
        {
            if (customerRepo.Delete(id))
            {
                return true;
            }
            return false;
        }


        public List<BookModel> GetAllCustomer()
        {
            return customerRepo.GetAll();
        }


        public List<BookModel> SearchById(int id)
        {
            List<BookModel> list = new List<BookModel>();
            foreach (var customer in customerRepo.GetAll())
            {
                if (customer.ID == id)
                {
                    list.Add(customer);
                }
            }
            return list;
        }

        public List<BookModel> SearchByName(string name)
        {
            List<BookModel> list = new List<BookModel>();
            foreach (var customer in customerRepo.GetAll())
            {
                if (customer.Name == name)
                {
                    list.Add(customer);
                }
            }
            return list;
        }

        public List<BookModel> SearchByAge(int age)
        {
            List<BookModel> list = new List<BookModel>();
            foreach (var customer in customerRepo.GetAll())
            {
                if (customer.Age == age)
                {
                    list.Add(customer);
                }
            }
            return list;
        }

        public List<BookModel> SearchByAddress(string address)
        {
            List<BookModel> list = new List<BookModel>();
            foreach (var customer in customerRepo.GetAll())
            {
                if (customer.Address == address)
                {
                    list.Add(customer);
                }
            }
            return list;
        }

    }
}
