using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Library_Management_System.Fines
{
    public partial class Fine_Form : Form
    {
        private readonly FineService _fineService;
        public Fine_Form()
        {
            InitializeComponent();
            _fineService = new FineService();
            LoadFineData();
            SetupGrid();
        }

        private void FPaid_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Ensure a row is selected
                if (dgvFines.CurrentRow == null)
                {
                    MessageBox.Show("Please select a fine record from the list.");
                    return;
                }

                // 2. Get the FineID and current status from the selected row
                int fineId = Convert.ToInt32(dgvFines.CurrentRow.Cells["FineID"].Value);
                string currentStatus = dgvFines.CurrentRow.Cells["Status"].Value.ToString();

                // 3. Validation: Don't process if already paid
                if (currentStatus == "Paid")
                {
                    MessageBox.Show("This fine has already been settled.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // 4. Confirm payment
                var confirm = MessageBox.Show("Confirm payment received?", "Payment Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    bool success = _fineService.MarkAsPaid(fineId);

                    if (success)
                    {
                        MessageBox.Show("Payment recorded successfully!");
                        LoadFineData(); // Refresh the grid to show updated status
                    }
                    else
                    {
                        MessageBox.Show("Error updating payment status.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadFineData()
        {
            try
            {
                DataTable dt = _fineService.GetAllFines();

                dgvFines.DataSource = dt;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupGrid()
        {
            if (dgvFines.Columns.Contains("FineID"))
                dgvFines.Columns["FineID"].Visible = false; // Hide ID from user


            dgvFines.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFines.MultiSelect = false;
            dgvFines.ReadOnly = true;
        }



        private void ViewAuthors_btn_Click(object sender, EventArgs e)
        {
            LoadFineData();
        }

        private void Back_A_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void dgvFines_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvFines.Rows)
            {
                // 1. Get the specific "Status" cell
                var statusCell = row.Cells["Status"];

                if (statusCell.Value?.ToString() == "Unpaid")
                {
                    // 2. Change the background color of just this cell
                    statusCell.Style.BackColor = Color.MistyRose; // Light red background
                    statusCell.Style.ForeColor = Color.Red;       // Red text
                }
                else if (statusCell.Value?.ToString() == "Paid")
                {
                    statusCell.Style.BackColor = Color.Honeydew;  // Light green background
                    statusCell.Style.ForeColor = Color.Green;     // Green text
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchText = txtSearch.Text.Trim();

                // Fetch filtered data
                DataTable dt = _fineService.GetFinesByName(searchText);

                // Update Grid
                dgvFines.DataSource = dt;

                // Re-apply column hiding logic
                if (dgvFines.Columns.Contains("FineID"))
                    dgvFines.Columns["FineID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search Error: " + ex.Message);
            }
        }
    }
}
