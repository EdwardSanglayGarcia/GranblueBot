namespace AutoClicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClicker_Click(object sender, EventArgs e)
        {
            //Point position = PointToScreen(checkBox1.Location) + new Size(checkBox1.Width / 2, checkBox1.Height / 2);
            //SendKeys.SendWait("{RIGHT}");
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Point mouseObject = Cursor.Position;


            lblMousePosition.Text = $"{mouseObject.X},{mouseObject.Y}";
            SendKeys.Send("{RIGHT}");

        }
    }
}
