using System;
using System.IO;
using System.Configuration;
using System.Data.OleDb;
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
    public partial class Admin : Form
    {   //Connection 1 for Passenger Data and tripData
        SqlConnection connection1 = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=CustomerInfo;Integrated Security=True");
        
        //Connection 2 for cityData
        SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=cityInfo;Integrated Security=True");
        
        int index;
        bool slidebarexpand;
        List<Panel> panellist = new List<Panel>();
        public Admin()
        {
            InitializeComponent();
            //trippanel.Visible = false;
            //passpanel.Visible = false;
            //citiespanel.Visible = false;
        }

        private void sbtimer_tick(object sender, EventArgs e)
        {
            if (slidebarexpand)
            {
                slidebar.Width -= 40;
                if (slidebar.Width == slidebar.MinimumSize.Width)
                {
                    slidebarexpand = false;
                    sbtimer.Stop();
                }
                btn_panel.Visible = true;

            }
            else
            {
                btn_panel.Visible = false;
                slidebar.Width += 40;
                if (slidebar.Width == slidebar.MaximumSize.Width)
                {
                    slidebarexpand = true;
                    sbtimer.Stop();
                }
            }
        }

        private void menubtn_Click(object sender, EventArgs e)
        {
            sbtimer.Start();
        }

        private void btncities_Click_1(object sender, EventArgs e)
        {
            AddcityData();
            passpanel.Visible = false;
            trippanel.Visible = false;
            citiespanel.Visible = true;
        }
        private void btnpass_Click(object sender, EventArgs e)
        {
            AdduserData();
            passpanel.Visible = true;
            trippanel.Visible = false;
            citiespanel.Visible = false;
        }

        private void btntrips_Click(object sender, EventArgs e)
        {
            PassengersAdd();
            passpanel.Visible = false;
            trippanel.Visible = true;
            citiespanel.Visible = false;
        }

        private void btncontrols_Click(object sender, EventArgs e)
        {
            //Controls cs = new Controls();
            //this.Hide();
            //cs.Show();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            //if (citiespanel.Visible == true)
            //{
            //    AddcityData();
            //}
            //else if (passpanel.Visible == true)
            //{
            //    AdduserData();
            //}
            //else
            //{
            //    MessageBox.Show("Nothing present");
            //}
            panellist.Add(citiespanel);
            panellist.Add(trippanel);
            panellist.Add(passpanel);
            panellist[index].BringToFront();


        }

        private void btnpre_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                panellist[--index].BringToFront();
            }
        }

        private void btnnex_Click(object sender, EventArgs e)
        {
            if (index < panellist.Count - 1)
            {
                panellist[++index].BringToFront();
            }
        }

        private void btnadd_city_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtcname.Text == "" || txtlat.Text == "" || txtlong.Text == "" || txtprovince.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    connection.Open();
                    string insertquery = "INSERT INTO CityTable(city,lat,lan,admin_name) VALUES(" + txtcityid.Text + ",'" + txtcname.Text + "','" + txtlat.Text + "','" + txtlong.Text + "','" + txtprovince.Text + "')";
                    SqlCommand cmd = new SqlCommand(insertquery, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category added successfully!");
                    connection.Close();
                    AddcityData();
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
            finally
            {
                connection1.Close(); clearcity();
            }

        }

        private void AddcityData() // method we created to add data to Data grid view.
        {
            connection.Open();
            string newquery = "select city,lat,lng,admin_name from CityTable";
            SqlCommand cmd = new SqlCommand(newquery,connection);
            var reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);
            DGcity.DataSource = dt;

           /* SqlDataAdapter sqladapter = new SqlDataAdapter(newquery, connection);
            SqlCommandBuilder cmdbuild = new SqlCommandBuilder(sqladapter);
            var ds = new DataSet();
            sqladapter.Fill(ds);*/
            cmd.Dispose();
            connection.Close(); 
            clearcity();
        }

        private void btnupdate_city_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtcname.Text == "" || txtlat.Text == "" || txtlong.Text == "" || txtprovince.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    connection.Open();
                    string query = "update tbl_city set Cityname= '" + txtcname.Text + "',latitude='" + txtlat.Text + "',longitude='"+txtlong.Text+"' where Id = " + txtcityid.Text + "";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Updated Successfuly!");
                    connection.Close();
                    AddcityData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close(); clearcity();
            }

        }

        private void DGcity_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcityid.Text = DGcity.SelectedRows[0].Cells[0].Value.ToString();
            txtcname.Text = DGcity.SelectedRows[0].Cells[1].Value.ToString();
            txtprovince.Text = DGcity.SelectedRows[0].Cells[4].Value.ToString();
            txtlat.Text = DGcity.SelectedRows[0].Cells[2].Value.ToString();
            txtlong.Text = DGcity.SelectedRows[0].Cells[3].Value.ToString();

        }

        private void btndelete_city_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtcityid.Text == "")
                {
                    MessageBox.Show("Select Category to Delete");
                }
                else
                {
                    connection.Open();
                    string query = "delete from tbl_city where Id= " + txtcityid.Text + "";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("City Deleted Successfuly!");
                    connection.Close();
                    AddcityData();
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
            finally
            {
                connection.Close(); clearcity();
            }

        }

        private void AdduserData() // method we created to add data to Data grid view.
        {
            connection1.Open();
            string newquery = "select * from customerData";
            SqlCommand cmd = new SqlCommand(newquery,connection1);
            var reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            DGuser.DataSource = dt;

            /*SqlDataAdapter sqladapter = new SqlDataAdapter(newquery, connection3);
            SqlCommandBuilder cmdbuild = new SqlCommandBuilder(sqladapter);
            var ds = new DataSet();
            sqladapter.Fill(ds);
            DGuser.DataSource = ds.Tables[0];*/
            cmd.Dispose();
            connection1.Close();

        }
        
        private void btnuseradd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtuserid.Text == "" || txtufname.Text == "" || txtulname.Text == "" || txtumail.Text == "" || txtupass.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    connection.Open();
                    string insertquery = "INSERT into customerData (First_Name,Last_Name,Email,Password) VALUES ('" + txtufname.Text + "','" + txtulname.Text + "','" + txtumail.Text + "','" + txtupass.Text + "')";
                    SqlCommand cmd = new SqlCommand(insertquery, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("" + txtufname.Text + " " + txtulname.Text + " added successfully!");
                    connection.Close();
                    AddcityData();
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
            finally
            {
                connection.Close(); clearuser();
            }

        }

        private void btnuserdelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtuserid.Text == "")
                {
                    MessageBox.Show("Select user to Delete");
                }
                else
                {

                    connection.Open();
                    string query = "delete from customerData where Email = " + txtumail.Text + "";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("" + txtufname.Text + "" + txtulname.Text +"Deleted Successfuly!");
                    connection.Close();
                    AdduserData();
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
            finally
            {
                connection.Close(); 
                clearuser();
            }

        }

        private void PassengersAdd()
        {
            connection1.Open();
            string newquery = "select * from tripData";
            SqlCommand cmd = new SqlCommand(newquery, connection1);
            var reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            DG_Passenger.DataSource = dt;

            /*SqlDataAdapter sqladapter = new SqlDataAdapter(newquery, connection3);
            SqlCommandBuilder cmdbuild = new SqlCommandBuilder(sqladapter);
            var ds = new DataSet();
            sqladapter.Fill(ds);
            DGuser.DataSource = ds.Tables[0];*/
            cmd.Dispose();
            connection1.Close();



        }

        private void btnuserupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtuserid.Text == "" || txtufname.Text == "" || txtulname.Text == "" || txtumail.Text == "" || txtupass.Text == "" )
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    connection.Open();
                    string query = "update INTO customerData (First_Name,Last_Name,Email,Password) VALUES ('" + txtufname.Text + "','" + txtulname.Text + "','" + txtumail.Text + "','" + txtupass.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Updated Successfuly!");
                    connection.Close();
                    AdduserData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                clearuser();
            }
        }

        private void DGuser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtuserid.Text = DGuser.SelectedRows[0].Cells[0].Value.ToString();
            txtufname.Text = DGuser.SelectedRows[0].Cells[1].Value.ToString();
            txtulname.Text = DGuser.SelectedRows[0].Cells[2].Value.ToString();
            txtumail.Text = DGuser.SelectedRows[0].Cells[3].Value.ToString();
            txtupass.Text = DGuser.SelectedRows[0].Cells[4].Value.ToString();
        }
       
        private void clearcity()
        {
            txtcityid.Text = "";
            txtcname.Text = "";
            txtlat.Text = "";
            txtlong.Text = "";
            txtprovince.Text = "";
        }
        
        private void clearuser()
        {
            txtuserid.Text = "";
            txtulname.Text = "";
            txtufname.Text = "";
            txtumail.Text = "";
            txtupass.Text = "";
        }

        private void btnexit12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnclear1_Click(object sender, EventArgs e)
        {
            clearcity();
        }

        private void btnclear2_Click(object sender, EventArgs e)
        {
            clearuser();
        }
    }
}
