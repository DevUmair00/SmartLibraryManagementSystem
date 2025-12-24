using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Library_Management_System.Books
{
    public class BookModel
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public int AuthorID { get; set; }
        public string CurrentStatus { get; set; }
        public string Category { get; set; }
    }
}
