namespace Lab2
{
    partial class Form2
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            textBox_ID = new TextBox();
            textBox_Name = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            radioButton_Male = new RadioButton();
            radioButton_Female = new RadioButton();
            dateTimePicker_DOB = new DateTimePicker();
            comboBox_MajorInTable = new ComboBox();
            listBox_Scholarship = new ListBox();
            checkBox_Active = new CheckBox();
            panel1 = new Panel();
            button_Add = new Button();
            button_Reset = new Button();
            label3 = new Label();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.8928566F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.10714F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(label5, 0, 3);
            tableLayoutPanel1.Controls.Add(label6, 0, 4);
            tableLayoutPanel1.Controls.Add(label8, 0, 5);
            tableLayoutPanel1.Controls.Add(label9, 0, 6);
            tableLayoutPanel1.Controls.Add(label10, 0, 7);
            tableLayoutPanel1.Controls.Add(textBox_ID, 1, 0);
            tableLayoutPanel1.Controls.Add(textBox_Name, 1, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 2);
            tableLayoutPanel1.Controls.Add(dateTimePicker_DOB, 1, 3);
            tableLayoutPanel1.Controls.Add(comboBox_MajorInTable, 1, 4);
            tableLayoutPanel1.Controls.Add(listBox_Scholarship, 1, 5);
            tableLayoutPanel1.Controls.Add(checkBox_Active, 1, 6);
            tableLayoutPanel1.Controls.Add(panel1, 1, 7);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Location = new Point(12, 16);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.60334F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.4821806F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0628929F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5786161F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.9496851F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.2243185F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.9496851F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24.1090145F));
            tableLayoutPanel1.Size = new Size(448, 479);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(44, 11);
            label1.Name = "label1";
            label1.Size = new Size(30, 25);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(24, 108);
            label4.Name = "label4";
            label4.Size = new Size(69, 25);
            label4.TabIndex = 3;
            label4.Text = "Gender";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(22, 162);
            label5.Name = "label5";
            label5.Size = new Size(74, 25);
            label5.TabIndex = 4;
            label5.Text = "Date Of";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(30, 221);
            label6.Name = "label6";
            label6.Size = new Size(58, 25);
            label6.TabIndex = 5;
            label6.Text = "Major";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Location = new Point(7, 271);
            label8.Name = "label8";
            label8.Size = new Size(103, 25);
            label8.TabIndex = 7;
            label8.Text = "Scholarship";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Location = new Point(22, 322);
            label9.Name = "label9";
            label9.Size = new Size(73, 25);
            label9.TabIndex = 8;
            label9.Text = "IsActive";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Location = new Point(27, 408);
            label10.Name = "label10";
            label10.Size = new Size(63, 25);
            label10.TabIndex = 9;
            label10.Text = "Action";
            // 
            // textBox_ID
            // 
            textBox_ID.Anchor = AnchorStyles.None;
            textBox_ID.Location = new Point(121, 8);
            textBox_ID.Name = "textBox_ID";
            textBox_ID.Size = new Size(322, 31);
            textBox_ID.TabIndex = 10;
            textBox_ID.Text = "   ";
            // 
            // textBox_Name
            // 
            textBox_Name.Anchor = AnchorStyles.None;
            textBox_Name.Location = new Point(121, 56);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(322, 31);
            textBox_Name.TabIndex = 11;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.None;
            flowLayoutPanel1.Controls.Add(radioButton_Male);
            flowLayoutPanel1.Controls.Add(radioButton_Female);
            flowLayoutPanel1.Location = new Point(121, 101);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(322, 40);
            flowLayoutPanel1.TabIndex = 14;
            // 
            // radioButton_Male
            // 
            radioButton_Male.Anchor = AnchorStyles.None;
            radioButton_Male.Location = new Point(3, 3);
            radioButton_Male.Name = "radioButton_Male";
            radioButton_Male.Size = new Size(142, 35);
            radioButton_Male.TabIndex = 12;
            radioButton_Male.TabStop = true;
            radioButton_Male.Text = "Male";
            radioButton_Male.UseVisualStyleBackColor = true;
            // 
            // radioButton_Female
            // 
            radioButton_Female.Anchor = AnchorStyles.None;
            radioButton_Female.Location = new Point(151, 3);
            radioButton_Female.Name = "radioButton_Female";
            radioButton_Female.Size = new Size(151, 34);
            radioButton_Female.TabIndex = 4;
            radioButton_Female.TabStop = true;
            radioButton_Female.Text = "Female";
            radioButton_Female.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_DOB
            // 
            dateTimePicker_DOB.Anchor = AnchorStyles.None;
            dateTimePicker_DOB.Format = DateTimePickerFormat.Short;
            dateTimePicker_DOB.Location = new Point(132, 159);
            dateTimePicker_DOB.Name = "dateTimePicker_DOB";
            dateTimePicker_DOB.Size = new Size(300, 31);
            dateTimePicker_DOB.TabIndex = 15;
            // 
            // comboBox_MajorInTable
            // 
            comboBox_MajorInTable.Anchor = AnchorStyles.None;
            comboBox_MajorInTable.FormattingEnabled = true;
            comboBox_MajorInTable.Location = new Point(131, 217);
            comboBox_MajorInTable.Name = "comboBox_MajorInTable";
            comboBox_MajorInTable.Size = new Size(302, 33);
            comboBox_MajorInTable.TabIndex = 16;
            // 
            // listBox_Scholarship
            // 
            listBox_Scholarship.Anchor = AnchorStyles.None;
            listBox_Scholarship.FormattingEnabled = true;
            listBox_Scholarship.ItemHeight = 25;
            listBox_Scholarship.Location = new Point(138, 269);
            listBox_Scholarship.Name = "listBox_Scholarship";
            listBox_Scholarship.ScrollAlwaysVisible = true;
            listBox_Scholarship.Size = new Size(288, 29);
            listBox_Scholarship.TabIndex = 17;
            // 
            // checkBox_Active
            // 
            checkBox_Active.Anchor = AnchorStyles.Left;
            checkBox_Active.AutoSize = true;
            checkBox_Active.Location = new Point(121, 320);
            checkBox_Active.Name = "checkBox_Active";
            checkBox_Active.Size = new Size(86, 29);
            checkBox_Active.TabIndex = 18;
            checkBox_Active.Text = "Active";
            checkBox_Active.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(button_Add);
            panel1.Controls.Add(button_Reset);
            panel1.Location = new Point(121, 367);
            panel1.Name = "panel1";
            panel1.Size = new Size(322, 107);
            panel1.TabIndex = 23;
            // 
            // button_Add
            // 
            button_Add.Location = new Point(17, 16);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(113, 76);
            button_Add.TabIndex = 19;
            button_Add.Text = "Add";
            button_Add.UseVisualStyleBackColor = true;
            button_Add.Click += button_Add_Click;
            // 
            // button_Reset
            // 
            button_Reset.Location = new Point(174, 16);
            button_Reset.Name = "button_Reset";
            button_Reset.Size = new Size(113, 76);
            button_Reset.TabIndex = 21;
            button_Reset.Text = "Reset";
            button_Reset.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(29, 59);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 507);
            Controls.Add(tableLayoutPanel1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox textBox_ID;
        private TextBox textBox_Name;
        private FlowLayoutPanel flowLayoutPanel1;
        private RadioButton radioButton_Male;
        private RadioButton radioButton_Female;
        private DateTimePicker dateTimePicker_DOB;
        private ComboBox comboBox_MajorInTable;
        private ListBox listBox_Scholarship;
        private CheckBox checkBox_Active;
        private Panel panel1;
        private Button button_Add;
        private Button button_Reset;
        private Label label3;
    }
}