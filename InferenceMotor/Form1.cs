namespace InferenceMotor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form2().Show();
        }
    }
}