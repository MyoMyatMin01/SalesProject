using System.Data;
using System.Windows.Forms;

namespace SalesProject
{
    public partial class Form1 : Form
    {
        string strName;
        string strJob;
        string strGender;
        string strReview;

        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] cmbData = { "English", "Japanese", "French" };
            foreach (string language in cmbData)
            {
                cmbLanguages.Items.Add(language);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            strName = txtName.Text;
            strJob = txtJob.Text;

            if (strName.Length != 0 && strJob.Length != 0)
            {
                txtMessage.Text = $"{strName} is a {strJob}";
            }

            strGender = rbtnMale.Checked ? "Male" : "Female";

            if (chkGood.Checked)
            {
                strReview = "Good";
            }

            if (chkVGood.Checked)
            {
                strReview = "Very Good";
            }

            Display();
        }

        public void Display()
        {
            string[] columnNames = { "Name", "Job", "Gender", "Review" };
            string[] rowData = { strName, strJob, strGender, strReview };

            foreach (string columnName in columnNames)
            {
                dt.Columns.Add(columnName);
            }

            DataRow dr = dt.NewRow();
            for (int i = 0; i < rowData.Length; i++)
            {
                dr[i] = rowData[i];
            }

            dt.Rows.Add(dr);
            gVDataTable.DataSource = dt;

        }

        private void cmbLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = cmbLanguages.SelectedItem.ToString();
            MessageBox.Show(selectedItem);

        }
    }
}