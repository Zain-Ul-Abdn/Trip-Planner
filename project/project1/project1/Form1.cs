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
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string adminName = "areeba";
        string adminPass = "12345";
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\dbms.mdf;Integrated Security=True;Connect Timeout=30");

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtname.ResetText();
            txtpass.ResetText();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "")
            {
                MessageBox.Show("Enter Username");
                lblname.Visible = true;
            }
            else if (txtpass.Text == "")
            {
                MessageBox.Show("Enter Password");
                lblpass.Visible = true;
            }

            else if (txtname.Text==adminName  && txtpass.Text==adminPass)
            {
                //MessageBox.Show("Login Successful");
                form();
            }
           /* else
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM tbl_login WHERE Username = '" + txtname.Text + "' AND Password = '" + txtpass.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataAdapter ad = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Login Successful");
                        form();
                    }
                    else
                    {
                        MessageBox.Show("Login failed");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
           */
        }
        private void form()
        {
            Admin fs = new Admin();
            fs.Show();
            this.Hide();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool check = checkBox1.Checked;
            switch (check)
            {
                case true:
                    txtpass.UseSystemPasswordChar = false;
                    break;
                case false:
                    txtpass.UseSystemPasswordChar = true;
                    break;
            }
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
             
        }
    }
}
