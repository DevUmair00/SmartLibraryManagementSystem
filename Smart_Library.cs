using Smart_Library_Management_System.Authors;
using Smart_Library_Management_System.Books;

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
    }
}
