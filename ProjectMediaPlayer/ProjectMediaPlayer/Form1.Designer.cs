namespace ProjectMediaPlayer
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            panel_SideBar = new Panel();
            panel_Indicator = new Panel();
            button6 = new Button();
            button5 = new Button();
            button_Playlists = new Button();
            button_Albums = new Button();
            button_Explore = new Button();
            button_NowPlaying = new Button();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel_Header = new Panel();
            tabControl = new TabControl();
            tab_NowPlaying = new TabPage();
            tab_Explore = new TabPage();
            progressBar1 = new ProgressBar();
            panel_SideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl.SuspendLayout();
            SuspendLayout();
            // 
            // panel_SideBar
            // 
            panel_SideBar.BackColor = Color.Gainsboro;
            panel_SideBar.Controls.Add(panel_Indicator);
            panel_SideBar.Controls.Add(button6);
            panel_SideBar.Controls.Add(button5);
            panel_SideBar.Controls.Add(button_Playlists);
            panel_SideBar.Controls.Add(button_Albums);
            panel_SideBar.Controls.Add(button_Explore);
            panel_SideBar.Controls.Add(button_NowPlaying);
            panel_SideBar.Controls.Add(label2);
            panel_SideBar.Controls.Add(label1);
            panel_SideBar.Controls.Add(pictureBox1);
            panel_SideBar.Controls.Add(panel2);
            panel_SideBar.Dock = DockStyle.Left;
            panel_SideBar.Location = new Point(0, 0);
            panel_SideBar.Name = "panel_SideBar";
            panel_SideBar.Size = new Size(270, 696);
            panel_SideBar.TabIndex = 0;
            // 
            // panel_Indicator
            // 
            panel_Indicator.Location = new Point(38, 274);
            panel_Indicator.Name = "panel_Indicator";
            panel_Indicator.Size = new Size(10, 11);
            panel_Indicator.TabIndex = 2;
            panel_Indicator.Paint += panel1_Paint;
            // 
            // button6
            // 
            button6.BackColor = Color.Gainsboro;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.FromArgb(103, 107, 121);
            button6.Location = new Point(51, 609);
            button6.Margin = new Padding(0);
            button6.Name = "button6";
            button6.Size = new Size(166, 40);
            button6.TabIndex = 8;
            button6.Text = "Settings";
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Gainsboro;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.FromArgb(103, 107, 121);
            button5.Location = new Point(51, 650);
            button5.Margin = new Padding(0);
            button5.Name = "button5";
            button5.Size = new Size(166, 40);
            button5.TabIndex = 7;
            button5.Text = "Help";
            button5.UseVisualStyleBackColor = false;
            // 
            // button_Playlists
            // 
            button_Playlists.BackColor = Color.Gainsboro;
            button_Playlists.FlatAppearance.BorderSize = 0;
            button_Playlists.FlatStyle = FlatStyle.Flat;
            button_Playlists.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_Playlists.ForeColor = Color.FromArgb(103, 107, 121);
            button_Playlists.Location = new Point(51, 380);
            button_Playlists.Margin = new Padding(0);
            button_Playlists.Name = "button_Playlists";
            button_Playlists.Size = new Size(166, 40);
            button_Playlists.TabIndex = 6;
            button_Playlists.Text = "Playlists";
            button_Playlists.TextAlign = ContentAlignment.MiddleLeft;
            button_Playlists.UseVisualStyleBackColor = false;
            // 
            // button_Albums
            // 
            button_Albums.BackColor = Color.Gainsboro;
            button_Albums.FlatAppearance.BorderSize = 0;
            button_Albums.FlatStyle = FlatStyle.Flat;
            button_Albums.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_Albums.ForeColor = Color.FromArgb(103, 107, 121);
            button_Albums.Location = new Point(51, 340);
            button_Albums.Margin = new Padding(0);
            button_Albums.Name = "button_Albums";
            button_Albums.Size = new Size(166, 40);
            button_Albums.TabIndex = 5;
            button_Albums.Text = "Albums";
            button_Albums.TextAlign = ContentAlignment.MiddleLeft;
            button_Albums.UseVisualStyleBackColor = false;
            // 
            // button_Explore
            // 
            button_Explore.BackColor = Color.Gainsboro;
            button_Explore.FlatAppearance.BorderSize = 0;
            button_Explore.FlatStyle = FlatStyle.Flat;
            button_Explore.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_Explore.ForeColor = Color.FromArgb(103, 107, 121);
            button_Explore.Location = new Point(51, 300);
            button_Explore.Margin = new Padding(0);
            button_Explore.Name = "button_Explore";
            button_Explore.Size = new Size(166, 40);
            button_Explore.TabIndex = 4;
            button_Explore.Text = "Explore";
            button_Explore.TextAlign = ContentAlignment.MiddleLeft;
            button_Explore.UseVisualStyleBackColor = false;
            button_Explore.Click += button_Explore_Click;
            // 
            // button_NowPlaying
            // 
            button_NowPlaying.BackColor = Color.Gainsboro;
            button_NowPlaying.FlatAppearance.BorderSize = 0;
            button_NowPlaying.FlatStyle = FlatStyle.Flat;
            button_NowPlaying.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_NowPlaying.ForeColor = Color.FromArgb(103, 107, 121);
            button_NowPlaying.Location = new Point(51, 260);
            button_NowPlaying.Margin = new Padding(0);
            button_NowPlaying.Name = "button_NowPlaying";
            button_NowPlaying.Size = new Size(166, 40);
            button_NowPlaying.TabIndex = 3;
            button_NowPlaying.Text = "Now Playing...";
            button_NowPlaying.TextAlign = ContentAlignment.MiddleLeft;
            button_NowPlaying.UseVisualStyleBackColor = false;
            button_NowPlaying.Click += button_NowPlaying_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.BackColor = Color.Purple;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Cursor = Cursors.No;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.ImageAlign = ContentAlignment.TopLeft;
            label2.Location = new Point(69, 194);
            label2.Name = "label2";
            label2.Size = new Size(127, 32);
            label2.TabIndex = 2;
            label2.Text = "Premium";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(51, 152);
            label1.Name = "label1";
            label1.Size = new Size(166, 32);
            label1.TabIndex = 1;
            label1.Text = "Hunger Music";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(69, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(127, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Location = new Point(38, 257);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 170);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // panel_Header
            // 
            panel_Header.Dock = DockStyle.Top;
            panel_Header.Location = new Point(270, 0);
            panel_Header.Name = "panel_Header";
            panel_Header.Size = new Size(859, 60);
            panel_Header.TabIndex = 1;
            // 
            // tabControl
            // 
            tabControl.Alignment = TabAlignment.Bottom;
            tabControl.Controls.Add(tab_NowPlaying);
            tabControl.Controls.Add(tab_Explore);
            tabControl.Location = new Point(276, 66);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(853, 555);
            tabControl.TabIndex = 2;
            // 
            // tab_NowPlaying
            // 
            tab_NowPlaying.Location = new Point(4, 4);
            tab_NowPlaying.Name = "tab_NowPlaying";
            tab_NowPlaying.Padding = new Padding(3);
            tab_NowPlaying.Size = new Size(845, 517);
            tab_NowPlaying.TabIndex = 0;
            tab_NowPlaying.Text = "Playing";
            tab_NowPlaying.UseVisualStyleBackColor = true;
            // 
            // tab_Explore
            // 
            tab_Explore.Location = new Point(4, 4);
            tab_Explore.Name = "tab_Explore";
            tab_Explore.Padding = new Padding(3);
            tab_Explore.Size = new Size(845, 592);
            tab_Explore.TabIndex = 1;
            tab_Explore.Text = "Explore";
            tab_Explore.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(463, 639);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(502, 32);
            progressBar1.TabIndex = 4;
            // 
            // Form_Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1129, 696);
            Controls.Add(progressBar1);
            Controls.Add(tabControl);
            Controls.Add(panel_Header);
            Controls.Add(panel_SideBar);
            Name = "Form_Main";
            Text = "Hunger Media Player";
            panel_SideBar.ResumeLayout(false);
            panel_SideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_SideBar;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button_Playlists;
        private Button button_Albums;
        private Button button_Explore;
        private Button button_NowPlaying;
        private Button button6;
        private Button button5;
        private Panel panel_Header;
        private Panel panel_Indicator;
        private Panel panel2;
        private TabControl tabControl;
        private TabPage tab_NowPlaying;
        private TabPage tab_Explore;
        private ProgressBar progressBar1;
    }
}