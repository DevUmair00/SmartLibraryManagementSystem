using Smart_Library_Management_System.Books;
using Smart_Library_Management_System.Borrowing;
using Smart_Library_Management_System.Members;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Library_Management_System.Borrows
{
    public partial class BorrowForm : Form
    {
        private readonly BorrowService _borrowService;
        private readonly BookService _bookService;
        private readonly MemberService _memberService;
        public BorrowForm()
        {
            InitializeComponent();
            _borrowService = new BorrowService();
            _bookService = new BookService();
            _memberService = new MemberService();
            LoadMembers();
            LoadAvailableBooks();
            SetupGrid();
        }

        private void SetupGrid()
        {
            dgvAvailableBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAvailableBooks.MultiSelect = false;
            dgvMembers.MultiSelect = false;
            dgvAvailableBooks.ReadOnly = true;
            dgvMembers.ReadOnly = true;
        }

        private void LoadAvailableBooks()
        {
            // We only want to show books that are not currently borrowed
            // Assuming your BookService has a method to filter by status
            DataTable dtAvailable = _bookService.GetBooksByStatus("Available");

            dgvAvailableBooks.DataSource = dtAvailable;

            // Optional: Clean up the grid appearance
            if (dgvAvailableBooks.Columns["BookID"] != null)
                dgvAvailableBooks.Columns["BookID"].Visible = false;

            if (dgvAvailableBooks.Columns["CurrentStatus"] != null)
                dgvAvailableBooks.Columns["CurrentStatus"].Visible = true;
        }

        private void LoadMembers()
        {
            // Fetch all members so the librarian can pick one
            DataTable dtMembers = _memberService.GetMemberList();

            dgvMembers.DataSource = dtMembers;

            // Optional: Hide internal ID column
            if (dgvMembers.Columns["MemberID"] != null)
                dgvMembers.Columns["MemberID"].Visible = false;
        }

        private void btnBorrow_Click(object sender, EventArgs e)

        {
            // Getting selected row IDs from both DataGridViews
            if (dgvAvailableBooks.CurrentRow != null && dgvMembers.CurrentRow != null)
            {
                int bookId = Convert.ToInt32(dgvAvailableBooks.CurrentRow.Cells["BookID"].Value);
                int memberId = Convert.ToInt32(dgvMembers.CurrentRow.Cells["MemberID"].Value);

                string result = _borrowService.ProcessBorrow(bookId, memberId);
                MessageBox.Show(result);

                // Refresh grids
                LoadAvailableBooks();
                LoadMembers();
            }
            else
            {
                MessageBox.Show("Please select both a Book and a Member.");
            }
        }

        private void txtSearchBook_TextChanged(object sender, EventArgs e)
        {
            dgvAvailableBooks.DataSource = _borrowService.SearchAvailableBooksInInventory(txtSearchBook.Text);
        }

        private void txtSeachMember_TextChanged(object sender, EventArgs e)
        {
            dgvMembers.DataSource = _memberService.SearchMembersInInventory(txtSeachMember.Text);
        }

        private void B_Book_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
