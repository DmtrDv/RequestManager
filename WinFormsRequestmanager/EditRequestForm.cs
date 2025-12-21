using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RequestManager;

namespace WinFormsRequestmanager
{
    public partial class EditRequestForm: Form
    {
        private ManagerRequest managerRequest_;
        private RequestModel requestModel_;
        public EditRequestForm(ManagerRequest manager, RequestModel request)
        {
            InitializeComponent();
            managerRequest_ = manager;
            requestModel_ = request;

            Customer_textBox.Text = requestModel_.Customer;
            dateRequest_dateTimePicker.Value = requestModel_.RequestDate;
            Condition_comboBox.Text = requestModel_.Condition;
            Description_richTextBox.Text = requestModel_.Description;
        }
        private void Save_button_Click(object sender, EventArgs e)
        {
            requestModel_.Customer = Customer_textBox.Text.Trim();
            requestModel_.RequestDate = dateRequest_dateTimePicker.Value;
            requestModel_.Condition = Condition_comboBox.Text;
            requestModel_.Description = Description_richTextBox.Text;

            string res = managerRequest_.UpdateRequests(requestModel_);
            if (res == "Заявка успешно обновлена")
            {
                MessageBox.Show(res, "Сообщение",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show(res, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
