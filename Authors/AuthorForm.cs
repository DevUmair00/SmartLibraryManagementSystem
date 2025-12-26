using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Smart_Library_Management_System.Authors; // Ensure this matches your namespace

namespace Smart_Library_Management_System.Authors
{
    public partial class AuthorForm : Form
    {
        private readonly AuthorService _authorService;
        private int _selectedAuthorId = 0; // Tracks the ID for Update/Delete

        public AuthorForm()
        {
            InitializeComponent();
            _authorService = new AuthorService();

            // Initialize UI logic
            SetupGrid();
            LoadData();
        }

        // --- Initialization ---

        private void SetupGrid()
        {
            dgvAuthors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAuthors.MultiSelect = false;
            dgvAuthors.ReadOnly = true;
        }

        private void LoadData()
        {
            // Fetch data from the Service layer
            dgvAuthors.DataSource = _authorService.GetAuthorList();
        }

        // --- Event Handlers ---

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            var author = new AuthorModel
            {
                FullName = txtAuthorName.Text,
                Nationality = txtNationality.Text
            };

            string result = _authorService.CreateAuthor(author);
            MessageBox.Show(result);
            if (result == "Success") RefreshUI();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (_selectedAuthorId == 0)
            {
                MessageBox.Show("Please select an author from the list first!");
                return;
            }

            var author = new AuthorModel
            {
                AuthorID = _selectedAuthorId,
                FullName = txtAuthorName.Text,
                Nationality = txtNationality.Text
            };

            string result = _authorService.UpdateExistingAuthor(author);
            MessageBox.Show(result);
            RefreshUI();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (_selectedAuthorId == 0)
            {
                MessageBox.Show("Select an author to Delete!");
                return;
            }

            var confirm = MessageBox.Show("Are you sure? This may affect books linked to this author.",
                                        "Confirm Delete", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                string result = _authorService.RemoveAuthor(_selectedAuthorId);
                MessageBox.Show(result);
                RefreshUI();
            }
        }

        private void dgvAuthors_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAuthors.Rows[e.RowIndex];

                // Map grid data back to textboxes for editing
                _selectedAuthorId = Convert.ToInt32(row.Cells["AuthorID"].Value);
                txtAuthorName.Text = row.Cells["FullName"].Value.ToString();
                txtNationality.Text = row.Cells["Nationality"].Value.ToString();
            }
        }

        private void RefreshUI()
        {
            LoadData();
            txtAuthorName.Clear();
            txtNationality.Clear();
            _selectedAuthorId = 0;
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            RefreshUI();
            txtSearch.Clear();
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            // Live search functionality
            dgvAuthors.DataSource = _authorService.SearchAuthorsInDatabase(txtSearch.Text);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvAuthors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AuthorForm_Load(object sender, EventArgs e)
        {

        }

        private void ViewMember_btn_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}