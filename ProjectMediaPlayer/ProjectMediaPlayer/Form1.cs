namespace ProjectMediaPlayer
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            // Create a pen for drawing the shape border
            Pen pen = new Pen(Color.Purple, 3);

            // Create a brush for filling the shape
            Brush brush = new SolidBrush(Color.White);

            // Calculate the circle's properties
            int diameter = (int)(Math.Min(panel_Indicator.Width, panel_Indicator.Height) - pen.Width); // Calculate the maximum diameter that fits the panel
            int x = (panel_Indicator.Width - diameter) / 2; // Calculate the X coordinate of the top-left corner of the bounding rectangle
            int y = (panel_Indicator.Height - diameter) / 2; // Calculate the Y coordinate of the top-left corner of the bounding rectangle

            // Draw the circle
            graphics.FillEllipse(brush, x, y, diameter, diameter);
            graphics.DrawEllipse(pen, x, y, diameter, diameter);

            // Dispose the pen
            pen.Dispose();
            brush.Dispose();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            // Create a pen for drawing the line
            Pen pen = new Pen(Color.Black, 2);

            // Define the start and end points of the line
            Point startPoint = new Point(panel_Indicator.Width / 2, panel_Indicator.Location.Y);
            Point endPoint = new Point(panel_Indicator.Width / 2, panel_Indicator.Height);

            // Draw the line
            graphics.DrawLine(pen, startPoint, endPoint);

            // Dispose the pen
            pen.Dispose();
        }

        private void button_NowPlaying_Click(object sender, EventArgs e)
        {
            panel_Indicator.Top = button_NowPlaying.Top + 15;
            tabControl.SelectTab(0);
        }

        private void button_Explore_Click(object sender, EventArgs e)
        {
            panel_Indicator.Top = button_Explore.Top + 15;
            tabControl.SelectTab(1);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }
    }
}