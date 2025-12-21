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
    public partial class AddRequestForm: Form
    {
        private ManagerRequest managerRequest_;
        public AddRequestForm(ManagerRequest managerRequest)
        {
            InitializeComponent();
            managerRequest_ = managerRequest;
        }
        private void AddRequestForm_Load(object sender, EventArgs e)
        {
            Condition_comboBox.SelectedIndex = 0;
        }
        private void Save_button_Click(object sender, EventArgs e)
        {
            RequestModel requestModel = new RequestModel()
            {
                Customer = Customer_textBox.Text.Trim(),
                RequestDate = dateRequest_dateTimePicker.Value,
                Condition = Condition_comboBox.Text,
                Description = Description_richTextBox.Text
            };
            string res = managerRequest_.AddRequest(requestModel);
            if (res == "Новая заявка успешно добавлена")
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
