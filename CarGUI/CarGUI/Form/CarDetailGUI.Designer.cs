namespace CarGUI
{
    partial class CarDetailGUI
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
            label_CarID = new Label();
            textBox_CarID = new TextBox();
            textBox_Make = new TextBox();
            label_Make = new Label();
            textBox_Color = new TextBox();
            label_Color = new Label();
            textBox_Petname = new TextBox();
            label_Petname = new Label();
            button_Back = new Button();
            colorDialog_Car = new ColorDialog();
            SuspendLayout();
            // 
            // label_CarID
            // 
            label_CarID.AutoSize = true;
            label_CarID.Location = new Point(89, 82);
            label_CarID.Name = "label_CarID";
            label_CarID.Size = new Size(56, 25);
            label_CarID.TabIndex = 0;
            label_CarID.Text = "CarID";
            // 
            // textBox_CarID
            // 
            textBox_CarID.BackColor = SystemColors.Control;
            textBox_CarID.BorderStyle = BorderStyle.FixedSingle;
            textBox_CarID.Location = new Point(168, 79);
            textBox_CarID.Name = "textBox_CarID";
            textBox_CarID.ReadOnly = true;
            textBox_CarID.Size = new Size(150, 31);
            textBox_CarID.TabIndex = 1;
            // 
            // textBox_Make
            // 
            textBox_Make.BorderStyle = BorderStyle.FixedSingle;
            textBox_Make.Location = new Point(168, 179);
            textBox_Make.Name = "textBox_Make";
            textBox_Make.ReadOnly = true;
            textBox_Make.Size = new Size(150, 31);
            textBox_Make.TabIndex = 3;
            // 
            // label_Make
            // 
            label_Make.AutoSize = true;
            label_Make.Location = new Point(89, 182);
            label_Make.Name = "label_Make";
            label_Make.Size = new Size(55, 25);
            label_Make.TabIndex = 2;
            label_Make.Text = "Make";
            // 
            // textBox_Color
            // 
            textBox_Color.BorderStyle = BorderStyle.FixedSingle;
            textBox_Color.Location = new Point(497, 82);
            textBox_Color.Name = "textBox_Color";
            textBox_Color.ReadOnly = true;
            textBox_Color.Size = new Size(150, 31);
            textBox_Color.TabIndex = 5;
            // 
            // label_Color
            // 
            label_Color.AutoSize = true;
            label_Color.Location = new Point(418, 85);
            label_Color.Name = "label_Color";
            label_Color.Size = new Size(55, 25);
            label_Color.TabIndex = 4;
            label_Color.Text = "Color";
            // 
            // textBox_Petname
            // 
            textBox_Petname.BorderStyle = BorderStyle.FixedSingle;
            textBox_Petname.Location = new Point(497, 176);
            textBox_Petname.Name = "textBox_Petname";
            textBox_Petname.ReadOnly = true;
            textBox_Petname.Size = new Size(150, 31);
            textBox_Petname.TabIndex = 7;
            // 
            // label_Petname
            // 
            label_Petname.AutoSize = true;
            label_Petname.Location = new Point(385, 179);
            label_Petname.Name = "label_Petname";
            label_Petname.Size = new Size(88, 25);
            label_Petname.TabIndex = 6;
            label_Petname.Text = "Pet Name";
            // 
            // button_Back
            // 
            button_Back.Location = new Point(305, 313);
            button_Back.Name = "button_Back";
            button_Back.Size = new Size(112, 34);
            button_Back.TabIndex = 8;
            button_Back.Text = "Back";
            button_Back.UseVisualStyleBackColor = true;
            button_Back.Click += button_Back_Click;
            // 
            // CarDetailGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 450);
            Controls.Add(button_Back);
            Controls.Add(textBox_Petname);
            Controls.Add(label_Petname);
            Controls.Add(textBox_Color);
            Controls.Add(label_Color);
            Controls.Add(textBox_Make);
            Controls.Add(label_Make);
            Controls.Add(textBox_CarID);
            Controls.Add(label_CarID);
            Name = "CarDetailGUI";
            Text = "CarDetailGUI";
            Load += CarDetailGUI_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_CarID;
        private TextBox textBox_CarID;
        private TextBox textBox_Make;
        private Label label_Make;
        private TextBox textBox_Color;
        private Label label_Color;
        private TextBox textBox_Petname;
        private Label label_Petname;
        private Button button_Back;
        private ColorDialog colorDialog_Car;
    }
}