namespace Smart_Library_Management_System.Authors
{
    public class AuthorModel
    {
        // 1. Properties representing the SQL Columns
        public int AuthorID { get; set; }
        public string FullName { get; set; }
        public string Nationality { get; set; }

        // 2. Empty Constructor
        // Useful for manual initialization in the Form
        public AuthorModel() { }

        // 3. Constructor for creating a NEW Author
        // (No ID because SQL IDENTITY handles it)
        public AuthorModel(string fullName, string nationality)
        {
            FullName = fullName;
            Nationality = nationality;
        }

        // 4. Constructor for FETCHING an Author
        // Includes the ID from the database for Updates/Deletes
        public AuthorModel(int authorId, string fullName, string nationality)
        {
            AuthorID = authorId;
            FullName = fullName;
            Nationality = nationality;
        }

        // 5. ToString Override 
        // Helpful for debugging or potentially displaying in logs
        public override string ToString()
        {
            return $"Author: {FullName} (ID: {AuthorID})";
        }
    }
}