namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ClickMe = new Button();
            SuspendLayout();
            // 
            // ClickMe
            // 
            ClickMe.Location = new Point(82, 70);
            ClickMe.Name = "ClickMe";
            ClickMe.Size = new Size(117, 45);
            ClickMe.TabIndex = 0;
            ClickMe.Text = "Click Me";
            ClickMe.UseVisualStyleBackColor = true;
            ClickMe.Click += btnNewButton_Click;
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 345);
            Controls.Add(ClickMe);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Main";
            ResumeLayout(false);
        }

        #endregion

        private Button ClickMe;//1. Khai bao bien
    }
}