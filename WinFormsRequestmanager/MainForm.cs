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
    }
}
