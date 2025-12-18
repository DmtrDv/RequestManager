namespace WinFormsRequestmanager
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Add_button = new System.Windows.Forms.Button();
            this.Edit_button = new System.Windows.Forms.Button();
            this.toolStripe_panel = new System.Windows.Forms.Panel();
            this.DateFilter_checkBox = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.filter_button = new System.Windows.Forms.Button();
            this.find_textBox = new System.Windows.Forms.TextBox();
            this.find_label = new System.Windows.Forms.Label();
            this.EndDate_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StartDate_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CloseDate_label = new System.Windows.Forms.Label();
            this.OpenDate_label = new System.Windows.Forms.Label();
            this.filtr_condition_comboBox = new System.Windows.Forms.ComboBox();
            this.filtr_condition_label = new System.Windows.Forms.Label();
            this.Request_dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CountCloseRequest_label = new System.Windows.Forms.Label();
            this.CountOpenRequest_label = new System.Windows.Forms.Label();
            this.CountAllRequest_label = new System.Windows.Forms.Label();
            this.toolStripe_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Request_dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(143, 6);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(160, 38);
            this.Add_button.TabIndex = 0;
            this.Add_button.Text = "➕ Добавить заявку";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Edit_button
            // 
            this.Edit_button.Location = new System.Drawing.Point(309, 6);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(109, 38);
            this.Edit_button.TabIndex = 1;
            this.Edit_button.Text = "✏️ Изменить";
            this.Edit_button.UseVisualStyleBackColor = true;
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // toolStripe_panel
            // 
            this.toolStripe_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStripe_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripe_panel.Controls.Add(this.DateFilter_checkBox);
            this.toolStripe_panel.Controls.Add(this.panel2);
            this.toolStripe_panel.Controls.Add(this.filter_button);
            this.toolStripe_panel.Controls.Add(this.find_textBox);
            this.toolStripe_panel.Controls.Add(this.find_label);
            this.toolStripe_panel.Controls.Add(this.EndDate_dateTimePicker);
            this.toolStripe_panel.Controls.Add(this.StartDate_dateTimePicker);
            this.toolStripe_panel.Controls.Add(this.CloseDate_label);
            this.toolStripe_panel.Controls.Add(this.OpenDate_label);
            this.toolStripe_panel.Controls.Add(this.filtr_condition_comboBox);
            this.toolStripe_panel.Controls.Add(this.filtr_condition_label);
            this.toolStripe_panel.Controls.Add(this.Add_button);
            this.toolStripe_panel.Controls.Add(this.Edit_button);
            this.toolStripe_panel.Location = new System.Drawing.Point(0, 0);
            this.toolStripe_panel.Name = "toolStripe_panel";
            this.toolStripe_panel.Size = new System.Drawing.Size(1023, 50);
            this.toolStripe_panel.TabIndex = 1;
            // 
            // DateFilter_checkBox
            // 
            this.DateFilter_checkBox.AutoSize = true;
            this.DateFilter_checkBox.Location = new System.Drawing.Point(615, 23);
            this.DateFilter_checkBox.Name = "DateFilter_checkBox";
            this.DateFilter_checkBox.Size = new System.Drawing.Size(18, 17);
            this.DateFilter_checkBox.TabIndex = 12;
            this.DateFilter_checkBox.Tag = "";
            this.DateFilter_checkBox.UseVisualStyleBackColor = true;
            this.DateFilter_checkBox.CheckedChanged += new System.EventHandler(this.DateFilter_checkBox_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(439, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 50);
            this.panel2.TabIndex = 11;
            // 
            // filter_button
            // 
            this.filter_button.Location = new System.Drawing.Point(893, 5);
            this.filter_button.Name = "filter_button";
            this.filter_button.Size = new System.Drawing.Size(120, 38);
            this.filter_button.TabIndex = 10;
            this.filter_button.Text = "Фильтровать";
            this.filter_button.UseVisualStyleBackColor = true;
            // 
            // find_textBox
            // 
            this.find_textBox.Location = new System.Drawing.Point(8, 20);
            this.find_textBox.Name = "find_textBox";
            this.find_textBox.Size = new System.Drawing.Size(120, 22);
            this.find_textBox.TabIndex = 3;
            this.find_textBox.TextChanged += new System.EventHandler(this.find_textBox_TextChanged);
            // 
            // find_label
            // 
            this.find_label.AutoSize = true;
            this.find_label.Location = new System.Drawing.Point(5, 3);
            this.find_label.Name = "find_label";
            this.find_label.Size = new System.Drawing.Size(62, 16);
            this.find_label.TabIndex = 2;
            this.find_label.Text = "Поиск 🔍";
            // 
            // EndDate_dateTimePicker
            // 
            this.EndDate_dateTimePicker.CustomFormat = "";
            this.EndDate_dateTimePicker.Enabled = false;
            this.EndDate_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EndDate_dateTimePicker.Location = new System.Drawing.Point(759, 20);
            this.EndDate_dateTimePicker.Name = "EndDate_dateTimePicker";
            this.EndDate_dateTimePicker.Size = new System.Drawing.Size(114, 22);
            this.EndDate_dateTimePicker.TabIndex = 9;
            // 
            // StartDate_dateTimePicker
            // 
            this.StartDate_dateTimePicker.CustomFormat = "";
            this.StartDate_dateTimePicker.Enabled = false;
            this.StartDate_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartDate_dateTimePicker.Location = new System.Drawing.Point(639, 20);
            this.StartDate_dateTimePicker.Name = "StartDate_dateTimePicker";
            this.StartDate_dateTimePicker.Size = new System.Drawing.Size(114, 22);
            this.StartDate_dateTimePicker.TabIndex = 8;
            // 
            // CloseDate_label
            // 
            this.CloseDate_label.AutoSize = true;
            this.CloseDate_label.Location = new System.Drawing.Point(756, 3);
            this.CloseDate_label.Name = "CloseDate_label";
            this.CloseDate_label.Size = new System.Drawing.Size(24, 16);
            this.CloseDate_label.TabIndex = 7;
            this.CloseDate_label.Text = "До";
            // 
            // OpenDate_label
            // 
            this.OpenDate_label.AutoSize = true;
            this.OpenDate_label.Location = new System.Drawing.Point(636, 3);
            this.OpenDate_label.Name = "OpenDate_label";
            this.OpenDate_label.Size = new System.Drawing.Size(24, 16);
            this.OpenDate_label.TabIndex = 6;
            this.OpenDate_label.Text = "От";
            // 
            // filtr_condition_comboBox
            // 
            this.filtr_condition_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filtr_condition_comboBox.FormattingEnabled = true;
            this.filtr_condition_comboBox.Items.AddRange(new object[] {
            "",
            "Открыта",
            "Закрыта"});
            this.filtr_condition_comboBox.Location = new System.Drawing.Point(459, 19);
            this.filtr_condition_comboBox.Name = "filtr_condition_comboBox";
            this.filtr_condition_comboBox.Size = new System.Drawing.Size(126, 24);
            this.filtr_condition_comboBox.TabIndex = 5;
            // 
            // filtr_condition_label
            // 
            this.filtr_condition_label.AutoSize = true;
            this.filtr_condition_label.Location = new System.Drawing.Point(453, 3);
            this.filtr_condition_label.Name = "filtr_condition_label";
            this.filtr_condition_label.Size = new System.Drawing.Size(126, 16);
            this.filtr_condition_label.TabIndex = 4;
            this.filtr_condition_label.Text = "Фильтр состояния";
            // 
            // Request_dataGridView
            // 
            this.Request_dataGridView.AllowUserToAddRows = false;
            this.Request_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Request_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Request_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Request_dataGridView.Location = new System.Drawing.Point(9, 57);
            this.Request_dataGridView.Name = "Request_dataGridView";
            this.Request_dataGridView.RowHeadersWidth = 51;
            this.Request_dataGridView.RowTemplate.Height = 24;
            this.Request_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Request_dataGridView.Size = new System.Drawing.Size(1005, 450);
            this.Request_dataGridView.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.CountCloseRequest_label);
            this.panel1.Controls.Add(this.CountOpenRequest_label);
            this.panel1.Controls.Add(this.CountAllRequest_label);
            this.panel1.Location = new System.Drawing.Point(0, 513);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1023, 35);
            this.panel1.TabIndex = 3;
            // 
            // CountCloseRequest_label
            // 
            this.CountCloseRequest_label.AutoSize = true;
            this.CountCloseRequest_label.Location = new System.Drawing.Point(467, 8);
            this.CountCloseRequest_label.Name = "CountCloseRequest_label";
            this.CountCloseRequest_label.Size = new System.Drawing.Size(124, 16);
            this.CountCloseRequest_label.TabIndex = 2;
            this.CountCloseRequest_label.Text = "Закрытые заявки:";
            // 
            // CountOpenRequest_label
            // 
            this.CountOpenRequest_label.AutoSize = true;
            this.CountOpenRequest_label.Location = new System.Drawing.Point(220, 8);
            this.CountOpenRequest_label.Name = "CountOpenRequest_label";
            this.CountOpenRequest_label.Size = new System.Drawing.Size(124, 16);
            this.CountOpenRequest_label.TabIndex = 1;
            this.CountOpenRequest_label.Text = "Открытые заявки:";
            // 
            // CountAllRequest_label
            // 
            this.CountAllRequest_label.AutoSize = true;
            this.CountAllRequest_label.Location = new System.Drawing.Point(5, 8);
            this.CountAllRequest_label.Name = "CountAllRequest_label";
            this.CountAllRequest_label.Size = new System.Drawing.Size(97, 16);
            this.CountAllRequest_label.TabIndex = 0;
            this.CountAllRequest_label.Text = "Всего заявок:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 549);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Request_dataGridView);
            this.Controls.Add(this.toolStripe_panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1040, 270);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заявки";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStripe_panel.ResumeLayout(false);
            this.toolStripe_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Request_dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.Panel toolStripe_panel;
        private System.Windows.Forms.Label find_label;
        private System.Windows.Forms.TextBox find_textBox;
        private System.Windows.Forms.Label filtr_condition_label;
        private System.Windows.Forms.ComboBox filtr_condition_comboBox;
        private System.Windows.Forms.DateTimePicker StartDate_dateTimePicker;
        private System.Windows.Forms.Label CloseDate_label;
        private System.Windows.Forms.Label OpenDate_label;
        private System.Windows.Forms.DateTimePicker EndDate_dateTimePicker;
        private System.Windows.Forms.Button filter_button;
        private System.Windows.Forms.DataGridView Request_dataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CountAllRequest_label;
        private System.Windows.Forms.Label CountCloseRequest_label;
        private System.Windows.Forms.Label CountOpenRequest_label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox DateFilter_checkBox;
    }
}

