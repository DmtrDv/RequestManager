namespace WinFormsRequestmanager
{
    partial class AddRequestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Customer_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateRequest_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.Condition_comboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Description_richTextBox = new System.Windows.Forms.RichTextBox();
            this.Save_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Customer_textBox
            // 
            this.Customer_textBox.Location = new System.Drawing.Point(16, 32);
            this.Customer_textBox.Name = "Customer_textBox";
            this.Customer_textBox.Size = new System.Drawing.Size(350, 22);
            this.Customer_textBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Заказчик:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата заявки:";
            // 
            // dateRequest_dateTimePicker
            // 
            this.dateRequest_dateTimePicker.Location = new System.Drawing.Point(16, 89);
            this.dateRequest_dateTimePicker.Name = "dateRequest_dateTimePicker";
            this.dateRequest_dateTimePicker.Size = new System.Drawing.Size(350, 22);
            this.dateRequest_dateTimePicker.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Состояние:";
            // 
            // Condition_comboBox
            // 
            this.Condition_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Condition_comboBox.FormattingEnabled = true;
            this.Condition_comboBox.Items.AddRange(new object[] {
            "Открыта",
            "Закрыта"});
            this.Condition_comboBox.Location = new System.Drawing.Point(16, 146);
            this.Condition_comboBox.Name = "Condition_comboBox";
            this.Condition_comboBox.Size = new System.Drawing.Size(350, 24);
            this.Condition_comboBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Описание требований:";
            // 
            // Description_richTextBox
            // 
            this.Description_richTextBox.Location = new System.Drawing.Point(16, 206);
            this.Description_richTextBox.Name = "Description_richTextBox";
            this.Description_richTextBox.Size = new System.Drawing.Size(350, 200);
            this.Description_richTextBox.TabIndex = 7;
            this.Description_richTextBox.Text = "";
            // 
            // Save_button
            // 
            this.Save_button.Location = new System.Drawing.Point(124, 426);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(100, 30);
            this.Save_button.TabIndex = 8;
            this.Save_button.Text = "Сохранить";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(266, 426);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(100, 30);
            this.Cancel_button.TabIndex = 9;
            this.Cancel_button.Text = "Отмена";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // AddRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 502);
            this.ControlBox = false;
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.Description_richTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Condition_comboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateRequest_dateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Customer_textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddRequestForm";
            this.Text = "Новая заявка";
            this.Load += new System.EventHandler(this.AddRequestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Customer_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateRequest_dateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Condition_comboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox Description_richTextBox;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Button Cancel_button;
    }
}