using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Library_Management_System.Books
{
    public class BookModel
    {
        // 1. Properties representing the SQL Columns
        public int BookID { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public int AuthorID { get; set; }
        public string AuthorName { get; set; }
        public string CurrentStatus { get; set; }
        public string Category { get; set; }

        // 2. Empty Constructor (Used by many libraries and for manual initialization)
        public BookModel() { }

        // 3. Constructor for creating a NEW book (No ID because SQL IDENTITY handles it)
        public BookModel(string title, string isbn, int authorId, string category, string status = "Available")
        {
            Title = title;
            ISBN = isbn;
            AuthorID = authorId;
            Category = category;
            CurrentStatus = status;
        }

        // 4. Constructor for FETCHING a book (Includes the ID from the database)
        public BookModel(int id, string title, string isbn, int authorId, string status, string category)
        {
            BookID = id;
            Title = title;
            ISBN = isbn;
            AuthorID = authorId;
            CurrentStatus = status;
            Category = category;
        }

        // 5. ToString Override - Useful for debugging or logging
        public override string ToString()
        {
            return $"[{BookID}] {Title} - ISBN: {ISBN} (Status: {CurrentStatus})";
        }
    }
}