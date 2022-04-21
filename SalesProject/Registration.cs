using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace SalesProject
{
    public partial class Registration : Form
    {
        string conString;
        int Id;

        SqlConnection con;
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter adapter;

        public Registration()
        {
            InitializeComponent();
            conString = "Data Source=MIN\\SQLEXPRESS;Initial Catalog=registration;Integrated Security=True";
            con = new SqlConnection(conString);
            Display();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string gender = rbtnMale.Checked ? "Male" : "Female";
            try
            {
                con.Open();

                string insertQuery = $"INSERT INTO Employee VALUES ('{txtName.Text}', " +
                    $"'{txtEmail.Text}', '{gender}', '{rhTxtAddress.Text}', '{txtPhone.Text}');";
                cmd = new SqlCommand(insertQuery, con);
                cmd.ExecuteNonQuery();
                Clear();
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            Display();
        }

        public void Display()
        {
            string dataFromEmployeeTable = "SELECT * FROM Employee;";
            try
            {
                con.Open();
                dt = new DataTable();
                adapter = new SqlDataAdapter(dataFromEmployeeTable, con);
                adapter.Fill(dt);
                gVEmployeeData.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
            finally
            {
                con.Close();
            }
        }

        public void Clear()
        {
            txtName.Text = "";
            txtEmail.Text = "";
            rhTxtAddress.Text = "";
            txtPhone.Text = "";
            rbtnMale.Checked = false;
            rbtnFemale.Checked = false;
        }

        private void gVEmployeeData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = int.Parse(gVEmployeeData.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtName.Text = gVEmployeeData.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtEmail.Text = gVEmployeeData.Rows[e.RowIndex].Cells[2].Value.ToString();
            string genderFromTable = gVEmployeeData.Rows[e.RowIndex].Cells[3].Value.ToString();
            rhTxtAddress.Text = gVEmployeeData.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtPhone.Text = gVEmployeeData.Rows[e.RowIndex].Cells[5].Value.ToString();


            if (genderFromTable == "Male")
            {
                rbtnMale.Checked = true;
            }
            else
            {
                rbtnFemale.Checked = true;
            }

            btnUpdate.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string gender = rbtnMale.Checked ? "Male" : "Female";
            string updateQuery = $"UPDATE Employee SET name = '{txtName.Text}', email = '{txtEmail.Text}', " +
                $"gender = '{gender}', address = '{rhTxtAddress.Text}', phone = '{txtPhone.Text}' WHERE id = {Id};";
            try
            {
                con.Open();
                cmd = new SqlCommand(updateQuery, con);
                cmd.ExecuteNonQuery();
                btnUpdate.Enabled = false;
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            Display();
        }
    }
}
