using Smart_Library_Management_System.Borrowing;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Smart_Library_Management_System.Borrows
{
    public partial class ActiveBorrow : Form
    {
        private readonly BorrowService _borrowService;

        public ActiveBorrow()
        {
            InitializeComponent();
            _borrowService = new BorrowService();
            LoadActiveData();
            SetupGrid();
        }

        private void SetupGrid()
        {
            dgvActiveBorrows.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvActiveBorrows.MultiSelect = false;
            dgvActiveBorrows.ReadOnly = true;
        }

        private void LoadActiveData()
        {
            try
            {
                // 1. Fetch the data from the service
                DataTable activeBorrows = _borrowService.GetActiveList();

                // 2. Bind to the Grid
                dgvActiveBorrows.DataSource = activeBorrows;

                // 3. Optional: Show a message if no books are currently borrowed
                if (activeBorrows.Rows.Count == 0)
                {
                    MessageBox.Show("No active borrows found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (dgvActiveBorrows.CurrentRow == null) return;

            // Pull hidden IDs from the grid
            int borrowId = Convert.ToInt32(dgvActiveBorrows.CurrentRow.Cells["BorrowID"].Value);
            int bookId = Convert.ToInt32(dgvActiveBorrows.CurrentRow.Cells["BookID"].Value);

            DateTime dueDate = Convert.ToDateTime(dgvActiveBorrows.CurrentRow.Cells["DueDate"].Value);


            // 1. Check for Fines
            decimal fine = _borrowService.CalculateFine(dueDate);
            if (fine > 0)
            {
                MessageBox.Show($"This book is overdue! Fine: {fine:C}", "Overdue Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // 2. Execute Return
            var confirm = MessageBox.Show("Confirm book return?", "Confirm", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                bool success = _borrowService.ProcessReturn(borrowId, bookId);
                if (success)
                {
                    MessageBox.Show("Book returned successfully.");
                    LoadActiveData(); // Refresh the list to remove the returned book
                }
                else
                {
                    MessageBox.Show("An error occurred while processing the return.");
                }
            }
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            // If the box is empty, load the full active list
            if (string.IsNullOrWhiteSpace(SearchBox.Text))
            {
                LoadActiveData();
            }
            else
            {
                // Otherwise, call the search method
                dgvActiveBorrows.DataSource = _borrowService.SearchBorrowsInInventory(SearchBox.Text);
            }
        }

        private void B_Book_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SearchBox.Clear();

            LoadActiveData();
        }
    }
}