using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_Desktop_Application.Customer
{
    public class BookModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public BookModel() { }

        public BookModel(int id , string name, string phoneNumber, string address)
        {
            ID = id;
            Name = name;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        public BookModel(string name, string phoneNumber, int age, string address)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Age = age;
            Address = address;
        }

        public BookModel(int id, string name, string phoneNumber, int age, string address)
        {
            ID = id;
            Name = name;
            PhoneNumber = phoneNumber;
            Age = age;
            Address = address;
        }

        public override string ToString()
        {
            return $"{ID},{Name},{PhoneNumber},{Age},{Address}";
        }
    }
}
