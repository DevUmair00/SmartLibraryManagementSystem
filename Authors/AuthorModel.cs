using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Library_Management_System.Authors
{
    public class AuthorModel
    {
        public int AuthorID { get; set; }
        public string FullName { get; set; }
        public string Nationality { get; set; }

        public AuthorModel() { }

        public AuthorModel(int AuthorID,string FullName,string Nationality)
        {
           this.AuthorID = AuthorID;
            this.FullName = FullName;
            this.Nationality = Nationality;
        }

        public override string ToString()
        {
            return $"{AuthorID},{FullName},{Nationality}";
        }
    }
}
