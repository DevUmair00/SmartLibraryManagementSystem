using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Library_Management_System.Authors
{
    public class AuthorService
    {
        // 1. Reference the Repo Layer
        private readonly AuthorRepo _authorRepo;

        public AuthorService()
        {
            _authorRepo = new AuthorRepo();
        }

        // 2. Logic for Adding an Author
        public string CreateAuthor(AuthorModel author)
        {
            // Business Rule: FullName cannot be empty
            if (string.IsNullOrWhiteSpace(author.FullName))
                return "Author name is required!";

            // Business Rule: Nationality cannot be empty
            if (string.IsNullOrWhiteSpace(author.Nationality))
                return "Nationality is required!";

            bool success = _authorRepo.AddAuthor(author);
            return success ? "Success" : "Database Error occurred.";
        }

        // 3. Logic for Fetching Authors
        public DataTable GetAuthorList()
        {
            // Fetches all authors for the DataGridView or ComboBoxes
            return _authorRepo.GetAllAuthors();
        }

        // 4. Logic for Deleting an Author
        public string RemoveAuthor(int authorId)
        {
            // Business Rule: Check if ID is valid
            if (authorId <= 0)
                return "Invalid Author selection.";

            bool success = _authorRepo.DeleteAuthor(authorId);
            return success ? "Author removed successfully." : "Failed to remove author.";
        }

        // 5. Logic for Updating an Author
        public string UpdateExistingAuthor(AuthorModel author)
        {
            // Validation Rules
            if (author.AuthorID <= 0)
                return "Selection error: Could not identify the author.";

            if (string.IsNullOrWhiteSpace(author.FullName))
                return "Author name cannot be empty.";

            bool isUpdated = _authorRepo.UpdateAuthor(author);

            return isUpdated ? "Author updated successfully!" : "Update failed. Database error.";
        }

        // 6. Logic for Searching Authors
        public DataTable SearchAuthorsInDatabase(string term)
        {
            if (string.IsNullOrWhiteSpace(term))
            {
                return _authorRepo.GetAllAuthors(); // If empty, show everything
            }

            string sanitizedTerm = term.Trim();
            return _authorRepo.SearchAuthors(sanitizedTerm);
        }
    }
}