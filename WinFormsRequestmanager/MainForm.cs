using RequestManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsRequestmanager
{
    public partial class MainForm: Form
    {
        SqlRequestManager sqlRequestManager = new SqlRequestManager();
        SearchAndFilter searchAndFilter = new SearchAndFilter();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                Request_dataGridView.DataSource = sqlRequestManager.GetAllRequests();
                Request_dataGridView.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            ManagerRequest managerRequest = new ManagerRequest(sqlRequestManager);
            AddRequestForm addRequestForm = new AddRequestForm(managerRequest);
            if (addRequestForm.ShowDialog() == DialogResult.OK)
            {
                Request_dataGridView.DataSource = sqlRequestManager.GetAllRequests();
            }
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            if (Request_dataGridView.SelectedRows.Count > 0)
            {
                RequestModel selectedRequest = Request_dataGridView.SelectedRows[0].DataBoundItem as RequestModel;

                RequestModel cloneRequest = selectedRequest.Clone();
                ManagerRequest managerRequest = new ManagerRequest(sqlRequestManager);
                EditRequestForm editRequestForm = new EditRequestForm(managerRequest, cloneRequest);
                if (editRequestForm.ShowDialog() == DialogResult.OK)
                {
                    selectedRequest.Customer = cloneRequest.Customer;
                    selectedRequest.RequestDate = cloneRequest.RequestDate;
                    selectedRequest.Condition = cloneRequest.Condition;
                    selectedRequest.Description = cloneRequest.Description;

                    Request_dataGridView.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Выберите заявку для редактирования", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DateFilter_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DateFilter_checkBox.Checked == true)
            {
                StartDate_dateTimePicker.Enabled = true;
                EndDate_dateTimePicker.Enabled = true;
            }
            else
            {
                StartDate_dateTimePicker.Enabled = false;
                EndDate_dateTimePicker.Enabled = false;
            }       
        }

        private void find_textBox_TextChanged(object sender, EventArgs e)
        {
            Request_dataGridView.CurrentCell = null;
            Request_dataGridView.DataSource = searchAndFilter.SearchByCustomer(sqlRequestManager.GetAllRequests(), find_textBox.Text);
        }
    }
}
