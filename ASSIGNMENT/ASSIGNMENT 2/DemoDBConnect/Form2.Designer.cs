namespace DemoBDConnect
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
            comboBox_Course = new ComboBox();
            comboBox_CourseDate = new ComboBox();
            dataGridView_StudentCourse = new DataGridView();
            column_IsAbsent = new DataGridViewCheckBoxColumn();
            button_Save = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_StudentCourse).BeginInit();
            SuspendLayout();
            // 
            // comboBox_Course
            // 
            comboBox_Course.FormattingEnabled = true;
            comboBox_Course.Location = new Point(66, 12);
            comboBox_Course.Name = "comboBox_Course";
            comboBox_Course.Size = new Size(182, 33);
            comboBox_Course.TabIndex = 0;
            comboBox_Course.Text = "Course";
            comboBox_Course.SelectedIndexChanged += comboBox_Course_SelectedIndexChanged;
            // 
            // comboBox_CourseDate
            // 
            comboBox_CourseDate.FormattingEnabled = true;
            comboBox_CourseDate.Location = new Point(427, 12);
            comboBox_CourseDate.Name = "comboBox_CourseDate";
            comboBox_CourseDate.Size = new Size(182, 33);
            comboBox_CourseDate.TabIndex = 1;
            comboBox_CourseDate.Text = "Date of course";
            comboBox_CourseDate.SelectedIndexChanged += comboBox_CourseDate_SelectedIndexChanged;
            // 
            // dataGridView_StudentCourse
            // 
            dataGridView_StudentCourse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_StudentCourse.Columns.AddRange(new DataGridViewColumn[] { column_IsAbsent });
            dataGridView_StudentCourse.Location = new Point(36, 85);
            dataGridView_StudentCourse.Name = "dataGridView_StudentCourse";
            dataGridView_StudentCourse.RowHeadersWidth = 62;
            dataGridView_StudentCourse.RowTemplate.Height = 33;
            dataGridView_StudentCourse.Size = new Size(922, 434);
            dataGridView_StudentCourse.TabIndex = 2;
            // 
            // column_IsAbsent
            // 
            column_IsAbsent.HeaderText = "IsAbsent";
            column_IsAbsent.MinimumWidth = 8;
            column_IsAbsent.Name = "column_IsAbsent";
            column_IsAbsent.Resizable = DataGridViewTriState.True;
            column_IsAbsent.Width = 150;
            // 
            // button_Save
            // 
            button_Save.Location = new Point(810, 12);
            button_Save.Name = "button_Save";
            button_Save.Size = new Size(112, 34);
            button_Save.TabIndex = 3;
            button_Save.Text = "Save";
            button_Save.UseVisualStyleBackColor = true;
            button_Save.Click += button_Save_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 680);
            Controls.Add(button_Save);
            Controls.Add(dataGridView_StudentCourse);
            Controls.Add(comboBox_CourseDate);
            Controls.Add(comboBox_Course);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_StudentCourse).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox_Course;
        private ComboBox comboBox_CourseDate;
        private DataGridView dataGridView_StudentCourse;
        private Button button_Save;
        private DataGridViewCheckBoxColumn column_IsAbsent;
    }
}