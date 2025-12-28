using Smart_Library_Management_System.Authors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Library_Management_System.Books
{
    public partial class BookForm : Form
    {
        private readonly BookService _bookService;
        private readonly AuthorService _authorService = new AuthorService();
        private int _selectedBookId = 0; // Tracks the ID for Update/Delete

        public BookForm()
        {
            InitializeComponent();

            _bookService = new BookService();

            // Initialize UI
            SetupGrid();
            LoadData();
            PopulateCategories();
            LoadAuthors();
            LoadAuthorComboBox();
        }

        // --- Initialization ---

        private void SetupGrid()
        {
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.MultiSelect = false;
            dgvBooks.ReadOnly = true;
        }

        private void LoadData()
        {
            dgvBooks.DataSource = _bookService.GetInventory();

            if (dgvBooks.Columns["AuthorID"] != null) dgvBooks.Columns["AuthorID"].Visible = false;
        }

        private void PopulateCategories()
        {
            cmbCategory.Items.AddRange(new string[] { "Fiction", "Science", "History", "Fantasy", "Biography" });

            cmbCategory1.Items.AddRange(new string[] { "Fiction", "Science", "History", "Fantasy", "Biography" });


            cmbCategory.SelectedIndex = 0;
            cmbCategory1.SelectedIndex = 0;
        }

        private void LoadAuthors()
        {
            AuthorService authorService = new AuthorService();
            DataTable dt = authorService.GetAuthorList();

            cmbAuthor.DataSource = dt;
            cmbAuthor.DisplayMember = "FullName";
            cmbAuthor.ValueMember = "AuthorID"; // This MUST match the SQL column name exactly
        }

        // --- Event Handlers ---

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Debugging Tip: Add a breakpoint here to see what 'authorId' actually is
                int authorId = Convert.ToInt32(cmbAuthor.SelectedValue);

                var newBook = new BookModel
                {
                    Title = txtTitle.Text,
                    ISBN = txtISBN.Text,
                    AuthorID = authorId, // This ID must exist in the dbo.Authors table
                    Category = cmbCategory.Text,
                    CurrentStatus = "Available"
                };

                string result = _bookService.CreateBook(newBook);
                MessageBox.Show(result);
            }catch(Exception ex)
            {
               MessageBox.Show("Book Already Exists with this ISBN.." , "Warning" , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadAuthorComboBox()
        {
            //// 1. Get your data from the Author Service/Repo
            //DataTable dtAuthors = _authorService.GetAllAuthors();

            // 2. Bind to the ComboBox
            cmbAuthor.DataSource = _authorService.GetAuthorList();

            // This is what the user SEES
            cmbAuthor.DisplayMember = "FullName";

            // This is what the code "GRABS" behind the scenes
            cmbAuthor.ValueMember = "AuthorID";
        }
        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (_selectedBookId == 0) { MessageBox.Show("Select a book first!"); return; }

            var book = new BookModel
            {
                BookID = _selectedBookId,
                Title = txtTitle.Text,
                ISBN = txtISBN.Text,
                Category = cmbCategory.Text
            };

            string result = _bookService.UpdateExistingBook(book);
            MessageBox.Show(result);
            RefreshUI();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedBookId == 0) { MessageBox.Show("Select a book which you want to Delete!"); return; }

                var confirm = MessageBox.Show("Delete this record?", "Confirm", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    string result = _bookService.RemoveBook(_selectedBookId);
                    MessageBox.Show(result);
                    RefreshUI();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Unable to Delete the Book.....");
            }
        }

        private void dgvBooks_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBooks.Rows[e.RowIndex];

                // Fill fields for editing
                _selectedBookId = Convert.ToInt32(row.Cells["BookID"].Value);
                txtTitle.Text = row.Cells["Title"].Value.ToString();
                txtISBN.Text = row.Cells["ISBN"].Value.ToString();
                cmbCategory.Text = row.Cells["Category"].Value.ToString();

                // Sync Author ComboBox
                if (row.Cells["AuthorID"].Value != DBNull.Value)
                    cmbAuthor.SelectedValue = row.Cells["AuthorID"].Value;
            }
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            dgvBooks.DataSource = _bookService.SearchBooksInInventory(txtSearch.Text);
        }

        private void RefreshUI()
        {
            LoadData();
            txtTitle.Clear();
            txtISBN.Clear();
            _selectedBookId = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            RefreshUI();
            txtSearch.Text = "";
        }

        private void ViewBook_btn_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void B_Book_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BookForm_Load(object sender, EventArgs e)
        {

        }

        private void BM_lbl_Click(object sender, EventArgs e)
        {

        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbCategory1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategory1.SelectedIndex == -1)
                return;

            try
            {
                string selectedCategory = cmbCategory1.Text;

                DataTable dt = _bookService.GetBooksByCategory(selectedCategory);

                dgvBooks.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering books: " + ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
