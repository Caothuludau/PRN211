namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Button btnNewButton;//1. Khai bao control
        public Form1()
        {
            InitializeComponent();
            CreateNewButton();
        }
        void CreateNewButton()
        {
            btnNewButton = new Button();//2. Khoi tao control
            btnNewButton.Text = "New Button";//3. Gan gia tri cac public properties
            btnNewButton.Size = new Size(ClickMe.Size.Width, ClickMe.Size.Height);
            btnNewButton.Location = new Point(ClickMe.Location.X, ClickMe.Location.Y + ClickMe.Size.Height + 10);
            Controls.Add(btnNewButton);//4. Add control vao Form

            btnNewButton.Click += btnNewButton_Click;
        }

        private void ClickMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ban vua bam nut!");
        }

        private void btnNewButton_Click(object sender, EventArgs e)
        {
            btnNewButton = (Button)sender;
            MessageBox.Show("Ban vua bam " + btnNewButton.Text);
        }
    }
}