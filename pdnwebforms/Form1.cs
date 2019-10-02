namespace pdnwebforms
{
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "Hey";
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            textBox1.Text += " yo!";
        }
    }
}
