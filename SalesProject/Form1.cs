namespace SalesProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string job = txtJob.Text;

            if (name.Length != 0 && job.Length != 0)
            {
                txtMessage.Text = $"{name} is a {job}";
            }
        }
    }
}