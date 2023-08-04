using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;


namespace WindowsFormsApp1
{
    public partial class Login_Form : Form
    {
       public static string userEmail;
       public static string userName;
       string path = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=CustomerInfo;Integrated Security=True";
        public Login_Form()
        {
            InitializeComponent();
            loginPanel();
        }

        private void InsertData()
        {
            try
            {
                SqlConnection con = new SqlConnection(path);
                con.Open();
                string query = "insert  into customerData(First_Name,Last_Name,Email,Password_) values  ('" + txt_fname.Text + "','" + txt_lname.Text + "','" + txt_email.Text + "','" + txt_Pass.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                MessageBox.Show("Data save!!");

            }
            catch
            {
                MessageBox.Show("Data not save!!");
            }
        }

        private string ReadName(string query,string n)
        {
            string name = " ";
            SqlConnection con = new SqlConnection(path);
            con.Open();
           // string query = "select First_Name  from  customerData where Email = '" + txtEmail.Text+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
              name = reader[n].ToString();

            }
            cmd.Dispose();
            con.Close();
            return name;
        }

        private void ClearTextBox()
        {
            txt_fname.Text = " ";
            txt_lname.Text = " ";
            txt_email.Text = " ";
            txt_Pass.Text = " ";
            txt_conPass.Text = " ";

            txtPlaceholder_visible(txt_fname,"Enter First Name");
            txtPlaceholder_visible(txt_lname, "Enter Last Name");
            txtPlaceholder_visible(txt_email, "Enter Email");
            txtPlaceholder_visible(txt_Pass, "Enter Password");
            txtPlaceholder_visible(txt_conPass, "Confirm Password");

        }

        private void loginPanel()
        {
            loginBtn.BackColor = Color.SlateBlue;
            signupBtn.BackColor = Color.MediumSlateBlue;
            signup_Pan.Visible = false;
            Login_pan.Visible = true;
        }

        private bool Signupverify()
        {
            string emailPattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            string passPattern = "(?=^.{8,}$)((?=.*\\d)|(?=.*\\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$";
            if (string.IsNullOrEmpty(txt_fname.Text) || txt_fname.Text == "Enter First Name")
            {
                txt_fname.Focus();
                EP_name.SetError(this.txt_fname, "Fill !!");
                return false;
            }
            else
            {
                EP_name.Clear();
                //return true;
            }
            if (string.IsNullOrEmpty(txt_lname.Text) || txt_lname.Text == "Enter Last Name")
            {
                txt_lname.Focus();
                EP_name.SetError(this.txt_lname, "Fill !!");
                return false;
            }
            else
            {
                EP_name.Clear();
                //return true;
            }

            if (string.IsNullOrEmpty(txt_email.Text) || txt_email.Text == "Enter Email")
            {
                txt_email.Focus();
                EP_name.SetError(this.txt_email, "Fill !!");
                return false;
            }
            if (Regex.IsMatch(txt_email.Text, emailPattern) == false)
            {
                txt_email.Focus();
                EP_name.SetError(this.txt_email, "e.g:xyz123@gmail.com");
                return false;
            }

            else
            {
                EP_name.Clear();
                //return true;
            }
            if (string.IsNullOrEmpty(txt_Pass.Text) || txt_Pass.Text == "Enter Password")
            {
                txt_Pass.Focus();
                EP_name.SetError(this.txt_Pass, "Fill !!");
                return false;
            }
            if (Regex.IsMatch(txt_Pass.Text, passPattern) == false)
            {
                txt_Pass.Focus();
                EP_name.SetError(this.txt_Pass, "e.g:Upper Letter,Lower Letter, Numbers,Special char");
                return false;
            }
            else
            {
                EP_name.Clear();
                //return true;
            }
            if (string.IsNullOrEmpty(txt_conPass.Text) || txt_conPass.Text == "Confirm Password")
            {
                txt_conPass.Focus();
                EP_name.SetError(this.txt_conPass, "Fill !!");
                return false;

            }
            if (txt_conPass.Text != txt_Pass.Text)
            {
                txt_conPass.Focus();
                EP_name.SetError(this.txt_conPass, "Confirm password not match");
                return false;

            }
            else
            {
                EP_name.Clear();
                return true;
            }
        }

        private bool Loginverify()
        {
                string path = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=CustomerInfo;Integrated Security=True";
                SqlConnection con = new SqlConnection(path);
                con.Open();
                string query = "select * from customerData where Email = '"+txtEmail.Text+ "' and Password_= '" + txtPass.Text + "'";
                //string query = "insert  into customerData(First_Name,Last_Name,Email,Password_) values  ('" + txt_fname.Text + "','" + txt_lname.Text + "','" + txt_email.Text + "','" + txt_Pass.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rd =  cmd.ExecuteReader();
                if (rd.HasRows == true) { 
                    return true;
                }
                //MessageBox.Show("Data save!!");
                else
                {
                  return false;
                }
                 cmd.Dispose();
                 con.Close();

        }

            private void signupPanel()
        {
            signupBtn.BackColor = Color.SlateBlue;
            loginBtn.BackColor = Color.MediumSlateBlue;
            signup_Pan.Visible = true;
            Login_pan.Visible = false;
        }

        private void mouseHover(Button b)
        {
            b.BackColor = Color.MediumSlateBlue;
            b.ForeColor = Color.White;
        }

        private void mouseLeave(Button b)
        {
            b.BackColor = Color.Gainsboro;
            b.ForeColor = Color.DimGray;
        }

        private void txtPlaceholder_hidden(TextBox txtBox)
        {
            if (txtBox.Text=="Enter First Name")
            {
              txtBox.Text = " ";
              txtBox.TextAlign = HorizontalAlignment.Left;
            }
           else if (txtBox.Text == "Enter Last Name")
            {
                txtBox.Text = " ";
                txtBox.TextAlign = HorizontalAlignment.Left;
            }
           else if (txtBox.Text == "Enter Email")
            {
                txtBox.Text = " ";
                txtBox.TextAlign = HorizontalAlignment.Left;
            }
            else if (txtBox.Text == "Enter Password")
            {
                txtBox.Text = " ";
                txtBox.TextAlign = HorizontalAlignment.Left;
            }
            else if (txtBox.Text == "Confirm Password")
            {
                txtBox.Text = " ";
                txtBox.TextAlign = HorizontalAlignment.Left;
            }
           
        }

        private void onlyAcceptLetter(TextBox tb,KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch) == true)
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtPlaceholder_visible(TextBox txtBox, string text)
        {
            if (txtBox.Text==" ")
            {
                txtBox.Text = text;
                txtBox.TextAlign = HorizontalAlignment.Center;
            }
        }



        private void login_btn_MouseHover(object sender, EventArgs e)
        {
            //MouseHover(login_btn);
            //mouseHover(login_btn);
            mouseHover(login_btn);
        }

        private void login_btn_MouseLeave(object sender, EventArgs e)
        {
            mouseLeave(login_btn);
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            loginPanel();
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {

            signupPanel();
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            if (Signupverify()==true)
            {
                InsertData();
                ClearTextBox();
                loginPanel();
            }
        }

        private void signup_btn_MouseHover(object sender, EventArgs e)
        {
            mouseHover(signup_btn);
        }

        private void signup_btn_MouseLeave(object sender, EventArgs e)
        {
            mouseLeave(signup_btn);
        }

        private void txt_fname_MouseLeave(object sender, EventArgs e)
        {
            txtPlaceholder_visible(txt_fname,"Enter First Name");
        }
      
        private void txt_lname_MouseLeave(object sender, EventArgs e)
        {
            txtPlaceholder_visible(txt_lname, "Enter Last Name");
        }

        private void txt_email_MouseLeave(object sender, EventArgs e)
        {
            txtPlaceholder_visible(txt_email, "Enter Email");
        }

        private void txt_Pass_MouseLeave(object sender, EventArgs e)
        {
            txtPlaceholder_visible(txt_Pass, "Enter Password");
        }

        private void txt_conPass_MouseLeave(object sender, EventArgs e)
        {
            txtPlaceholder_visible(txt_conPass, "Confirm Password");
        }

        private void txt_conPass_MouseEnter(object sender, EventArgs e)
        {
            txtPlaceholder_hidden(txt_conPass);
        }

        private void txt_fname_MouseEnter(object sender, EventArgs e)
        {
            txtPlaceholder_hidden(txt_fname);
            
        }

        private void txt_lname_MouseEnter(object sender, EventArgs e)
        {
            txtPlaceholder_hidden(txt_lname);
        }

        private void txt_email_MouseEnter(object sender, EventArgs e)
        {
            txtPlaceholder_hidden(txt_email);
        }

        private void txt_Pass_MouseEnter(object sender, EventArgs e)
        {
            txtPlaceholder_hidden(txt_Pass);
        }

        private void txt_fname_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyAcceptLetter(txt_fname,e);
        }

        private void txt_lname_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyAcceptLetter(txt_lname, e);
        }

        private void login_btn_Click(object sender, EventArgs e)
        {

            if (Loginverify()==true)
            {
              userEmail = txtEmail.Text;
              string fname =  ReadName("select First_Name  from  customerData where Email = '" + txtEmail.Text + "'","First_Name");
              string lname = ReadName("select Last_Name  from  customerData where Email = '" + txtEmail.Text + "'", "Last_Name");
               userName = fname + " " +lname;
                UserDashboard db = new UserDashboard();
              db.Show();
              this.Hide();
            }

        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            Authentication at = new Authentication();
            at.Show();
            this.Hide();
        }
    }
}
