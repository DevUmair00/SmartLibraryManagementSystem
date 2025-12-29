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

namespace Smart_Library_Management_System.Members
{
    public partial class Member_Form : Form
    {
        private readonly MemberService _memberService;
        private int _selectedMemberId = 0;
        public Member_Form()
        {
            InitializeComponent();
            _memberService = new MemberService();

            // Initialize UI logic
            SetupGrid();
            LoadData();
        }

        private void Member_Form_Load(object sender, EventArgs e)
        {
            dgvMembers.DataSource = _memberService.GetMemberList();
        }

        private void SetupGrid()
        {
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.MultiSelect = false;
            dgvMembers.ReadOnly = true;

            //// To make the date look clean in the grid
            //dgvMembers.AutoGenerateColumns = false;
        }
        private void LoadData()
        {
            // Fetch data from Service Layer
            dgvMembers.DataSource = _memberService.GetMemberList();
        }


        // --- Action Buttons ---

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var member = new MemberModel
                {   
                    FullName = txt_name.Text,
                    Email = txt_email.Text
                    // MembershipDate is handled by DateTime.Now in Model/Repo
                };

                string result = _memberService.RegisterMember(member);
                MessageBox.Show(result);

                if (result == "Success")
                {
                    RefreshUI();
                }
            }
            catch {
                MessageBox.Show("Error in Adding Member \nUse Different or Correct Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedMemberId == 0)
            {
                MessageBox.Show("Please select a member from the grid first.");
                return;
            }

            var member = new MemberModel
            {
                MemberID = _selectedMemberId,
                FullName = txt_name.Text,
                Email = txt_email.Text
            };

            string result = _memberService.UpdateMember(member);
            MessageBox.Show(result);
            RefreshUI();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedMemberId == 0)
                {
                    MessageBox.Show("Please select a member to delete.");
                    return;
                }

                var confirm = MessageBox.Show("Are you sure you want to delete this member?", "Confirm", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    string result = _memberService.RemoveMember(_selectedMemberId);
                    MessageBox.Show(result);
                    RefreshUI();
                }
            }
            catch (Exception ex) {
                MessageBox.Show("This Member Currently Borrowed a Book.\nYou Cannot Delete it.");
            }
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            // Live Search Logic
            dgvMembers.DataSource = _memberService.SearchMembersInInventory(txtSearch.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            RefreshUI();
            txtSearch.Clear();
        }

        private void dgvMembers_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMembers.Rows[e.RowIndex];

                // Fill TextBoxes from Grid Data
                _selectedMemberId = Convert.ToInt32(row.Cells["MemberID"].Value);
                txt_name.Text = row.Cells["FullName"].Value.ToString();
                txt_email.Text = row.Cells["Email"].Value.ToString();
            }
        }

        private void RefreshUI()
        {
            LoadData();
            txt_name.Clear();
            txt_email.Clear();
            _selectedMemberId = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewMember_btn_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}