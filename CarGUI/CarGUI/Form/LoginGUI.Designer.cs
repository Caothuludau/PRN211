namespace CarGUI
{
    partial class LoginGUI
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
            label_User = new Label();
            textBox_User = new TextBox();
            textBox_Password = new TextBox();
            label_Password = new Label();
            button_Login = new Button();
            button_Cancel = new Button();
            SuspendLayout();
            // 
            // label_User
            // 
            label_User.AutoSize = true;
            label_User.Location = new Point(165, 84);
            label_User.Name = "label_User";
            label_User.Size = new Size(51, 25);
            label_User.TabIndex = 0;
            label_User.Text = "User:";
            // 
            // textBox_User
            // 
            textBox_User.Location = new Point(261, 81);
            textBox_User.Name = "textBox_User";
            textBox_User.Size = new Size(150, 31);
            textBox_User.TabIndex = 1;
            textBox_User.Text = " ";
            // 
            // textBox_Password
            // 
            textBox_Password.Location = new Point(261, 154);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(150, 31);
            textBox_Password.TabIndex = 3;
            textBox_Password.TextChanged += textBox_Password_TextChanged;
            // 
            // label_Password
            // 
            label_Password.AutoSize = true;
            label_Password.Location = new Point(125, 160);
            label_Password.Name = "label_Password";
            label_Password.Size = new Size(91, 25);
            label_Password.TabIndex = 2;
            label_Password.Text = "Password:";
            // 
            // button_Login
            // 
            button_Login.Location = new Point(128, 269);
            button_Login.Name = "button_Login";
            button_Login.Size = new Size(112, 34);
            button_Login.TabIndex = 4;
            button_Login.Text = "Login";
            button_Login.UseVisualStyleBackColor = true;
            button_Login.Click += button_Login_Click;
            // 
            // button_Cancel
            // 
            button_Cancel.Location = new Point(326, 269);
            button_Cancel.Name = "button_Cancel";
            button_Cancel.Size = new Size(112, 34);
            button_Cancel.TabIndex = 5;
            button_Cancel.Text = "Cancel";
            button_Cancel.UseVisualStyleBackColor = true;
            // 
            // LoginGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 444);
            Controls.Add(button_Cancel);
            Controls.Add(button_Login);
            Controls.Add(textBox_Password);
            Controls.Add(label_Password);
            Controls.Add(textBox_User);
            Controls.Add(label_User);
            Name = "LoginGUI";
            Text = "LoginGUI";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_User;
        private TextBox textBox_User;
        private TextBox textBox_Password;
        private Label label_Password;
        private Button button_Login;
        private Button button_Cancel;
    }
}