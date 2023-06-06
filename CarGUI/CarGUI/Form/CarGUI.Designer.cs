namespace CarGUI
{
    partial class CarGUI
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
            menuStrip1 = new MenuStrip();
            loginToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label_TotalCarText = new Label();
            dataGridView_Car = new DataGridView();
            label_TotalCar = new Label();
            colorDialog1 = new ColorDialog();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Car).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { loginToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(840, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(72, 29);
            loginToolStripMenuItem.Text = "Login";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(152, 86);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 2;
            // 
            // label_TotalCarText
            // 
            label_TotalCarText.AutoSize = true;
            label_TotalCarText.Location = new Point(12, 74);
            label_TotalCarText.Name = "label_TotalCarText";
            label_TotalCarText.Size = new Size(161, 25);
            label_TotalCarText.TabIndex = 3;
            label_TotalCarText.Text = "The number of car:";
            // 
            // dataGridView_Car
            // 
            dataGridView_Car.AllowUserToOrderColumns = true;
            dataGridView_Car.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Car.Location = new Point(12, 114);
            dataGridView_Car.Name = "dataGridView_Car";
            dataGridView_Car.RowHeadersWidth = 62;
            dataGridView_Car.RowTemplate.Height = 33;
            dataGridView_Car.Size = new Size(767, 324);
            dataGridView_Car.TabIndex = 4;
            dataGridView_Car.CellMouseClick += dataGridView_Car_CellMouseClick;
            // 
            // label_TotalCar
            // 
            label_TotalCar.AutoSize = true;
            label_TotalCar.Location = new Point(179, 74);
            label_TotalCar.Name = "label_TotalCar";
            label_TotalCar.Size = new Size(55, 25);
            label_TotalCar.TabIndex = 5;
            label_TotalCar.Text = "None";
            // 
            // CarGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 450);
            Controls.Add(label_TotalCar);
            Controls.Add(dataGridView_Car);
            Controls.Add(label_TotalCarText);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "CarGUI";
            Text = "CarGUI";
            Load += CarGUI_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Car).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem loginToolStripMenuItem;
        private Label label1;
        private Label label_TotalCarText;
        private DataGridView dataGridView_Car;
        private Label label_TotalCar;
        private ColorDialog colorDialog1;
    }
}