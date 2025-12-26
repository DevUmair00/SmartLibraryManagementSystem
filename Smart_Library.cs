using Smart_Library_Management_System.Authors;
using Smart_Library_Management_System.Books;
using Smart_Library_Management_System.Borrows;
using Smart_Library_Management_System.Fines;
using Smart_Library_Management_System.Members;

namespace Smart_Library_Management_System
{
    public partial class Smart_Library : Form
    {
        public Smart_Library()
        {
            InitializeComponent();
        }

        private void BM_btn_Click(object sender, EventArgs e)
        {
            var bookForm = new BookForm();
            bookForm.ShowDialog();
        }

        private void AM_btn_Click(object sender, EventArgs e)
        {
            var authorForm = new AuthorForm();
            authorForm.ShowDialog();
        }

        private void MM_btn_Click(object sender, EventArgs e)
        {
            var memberForm = new Member_Form();
            memberForm.ShowDialog();
        }

        private void Smart_Library_Load(object sender, EventArgs e)
        {

        }

        private void btn_newBorrow_Click(object sender, EventArgs e)
        {
            var newBorrow = new BorrowForm();
            newBorrow.ShowDialog();
        }

        private void btn_activeBorrow_Click(object sender, EventArgs e)
        {
            var activeBorrow = new ActiveBorrow();
            activeBorrow.ShowDialog();
        }

        private void FS_btn_Click(object sender, EventArgs e)
        {
            var fineForm = new Fine_Form();
            fineForm.ShowDialog();
        }
    }
}
