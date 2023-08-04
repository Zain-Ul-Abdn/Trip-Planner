using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class UserDashboard : Form
    {
        Random r = new Random();
        int[] distances = new int[3];

        List<Panel> panlist = new List<Panel>();
        List<Panel> Graphpanlist = new List<Panel>();
        SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=cityInfo;Integrated Security=True");
        SqlConnection con1 = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=CustomerInfo;Integrated Security=True");

        Stack<TextBox> textboxes = new Stack<TextBox>();
        int i = 0;
        bool visit = false;
        //Class1 obj = new Class1();
        //public static Queue q = new Queue();
       public  Queue<string> q = new Queue<string>();
        Boolean visibility = false;

        public UserDashboard()
        {
            InitializeComponent();
            homeActive();
        }
        void tripHistory()
        {
            con1.Open();
            string query = "select * from tripData where EMAILID = '" +userEmail_lbl.Text+"'";
            SqlCommand cmd = new SqlCommand(query,con1);
            var reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;

            cmd.Dispose();
            con1.Close();
        }
        void SaveData(string query)
        {
            con1.Open();
            SqlCommand cmd = new SqlCommand(query,con1);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con1.Close();
        }

        void createDistances()
        {
            for (int i = 0; i < 3; i++)
            {
                int d = r.Next(500,1500);
                distances[i] = d;
            }
        }

        void CreateConnection()
        {
            con.Open();
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            string query = "Select city from CityTable";
            SqlCommand cmd = new SqlCommand(query,con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                col.Add(reader["city"].ToString());
            }
            cmd.Dispose();
            con.Close();
            Node1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            Node1.AutoCompleteMode = AutoCompleteMode.Suggest;
            Node1.AutoCompleteCustomSource = col;

        }

        void PannelHide()
        {
            panlist.Add(userProfile_pan);
            panlist.Add(city_Pan);
            panlist.Add(graphPanel);
            panlist.Add(dashboardPanel);
            for (int i = 0; i < 4; i++)
            {
                panlist[i].Visible = false;
            }
        }
        void GraphpanHide()
        {
           // Graphpanlist.Add(node2_pan);
            Graphpanlist.Add(node3_pan);
            Graphpanlist.Add(node4_pan);
            Graphpanlist.Add(node5_pan);

            for (int i = 0; i < 3; i++)
            {
                Graphpanlist[i].Visible = false;
            }
        }
         void dashPan()
        {
            PannelHide();
            dashboardPanel.Visible = true;
        }
        private void homeActive()
        {
            Home.BackColor = Color.FromArgb(130,146,227);
            City.BackColor = Color.FromArgb(211, 217, 228);
            Profile.BackColor = Color.FromArgb(211, 217, 228);
            Graph.BackColor = Color.FromArgb(211, 217, 228);
            // Map.BackColor = Color.FromArgb(211, 217, 228);
            dashPan();

        }
        private void cityActive()
        {
            Home.BackColor = Color.FromArgb(211, 217, 228);
            City.BackColor = Color.FromArgb(130, 146, 227);
            Profile.BackColor = Color.FromArgb(211, 217, 228);
            Graph.BackColor = Color.FromArgb(211, 217, 228);
           // Map.BackColor = Color.FromArgb(211, 217, 228);
          

        }
        private void mapActive()
        {
            Home.BackColor = Color.FromArgb(211, 217, 228);
            City.BackColor = Color.FromArgb(211, 217, 228);
            Profile.BackColor = Color.FromArgb(211, 217, 228);
            Graph.BackColor = Color.FromArgb(211, 217, 228);
           // Map.BackColor = Color.FromArgb(130, 146, 227);

        }
        private void graphActive()
        {
            Home.BackColor = Color.FromArgb(211, 217, 228);
            City.BackColor = Color.FromArgb(211, 217, 228);
            Profile.BackColor = Color.FromArgb(211, 217, 228);
            Graph.BackColor = Color.FromArgb(130, 146, 227);
           // Map.BackColor = Color.FromArgb(211, 217, 228);
            graphPan();
        }
        private void profileActive()
        {
            Home.BackColor = Color.FromArgb(211, 217, 228);
            City.BackColor = Color.FromArgb(211, 217, 228);
            Profile.BackColor = Color.FromArgb(130, 146, 227);
            Graph.BackColor = Color.FromArgb(211, 217, 228);
            //Map.BackColor = Color.FromArgb(211, 217, 228);
            
        }

        void profilePan() {
            PannelHide();
            userProfile_pan.Visible = true;
            userEmail_lbl.Text = Login_Form.userEmail;
            userNam_lbl.Text = Login_Form.userName;
            tripHistory();
        }
        void graphPan()
        {
            PannelHide();
            graphPanel.Visible = true;
            //Show();
            queueData.Visible = false;
        }

        void cityPantxt_push()
        {
            textboxes.Push(Node5);
            textboxes.Push(Node4);
            //textboxes.Push(Node3);
            
        }

        private void txtPlaceholder_hidden(TextBox txtBox)
        {
            if (txtBox.Text == "Enter City")
            {
                txtBox.Text = " ";
                txtBox.TextAlign = HorizontalAlignment.Left;
            }
            else if (txtBox.Text == "Enter City")
            {
                txtBox.Text = " ";
                txtBox.TextAlign = HorizontalAlignment.Left;
            }
            else if (txtBox.Text == "Enter City")
            {
                txtBox.Text = " ";
                txtBox.TextAlign = HorizontalAlignment.Left;
            }
            else if (txtBox.Text == "Enter City")
            {
                txtBox.Text = " ";
                txtBox.TextAlign = HorizontalAlignment.Left;
            }
            else if (txtBox.Text == "Enter City")
            {
                txtBox.Text = " ";
                txtBox.TextAlign = HorizontalAlignment.Left;
            }

        }

        private void ClearTextBox()
        {
            Node1.Text = " ";
            Node2.Text = " ";
            Node3.Text = " ";
            Node4.Text = " ";
            Node5.Text = " ";

            txtPlaceholder_visible(Node1, "Enter City");
            txtPlaceholder_visible(Node2, "Enter City");
            txtPlaceholder_visible(Node3, "Enter City");
            txtPlaceholder_visible(Node4, "Enter City");
            txtPlaceholder_visible(Node5, "Enter City");

        }

        private void txtPlaceholder_visible(TextBox txtBox, string text)
        {
            if (txtBox.Text == " ")
            {
                txtBox.Text = text;
                txtBox.TextAlign = HorizontalAlignment.Center;
            }
        }

        void cityPantxt_hide()
        {
            for (int i = textboxes.Count - 1; i >= 0; i--)
            {
                textboxes.ElementAt(i).Visible = false;
            }
        }

        void cityPantxt_show()
        {

            TextBox t = textboxes.Pop();
            t.Visible = true;
        }

        void cityPan()
        {
            PannelHide();
            city_Pan.Visible = true;
            cityPantxt_hide();

        }

        void setPosition_addbtn()
        {
          /*  if (n2_add.Top == Node2.Top)
            {
                n2_add.Location = new Point(300,257);
            }*/
            if (n2_add.Top == Node3.Top)
            {
                n2_add.Location = new Point(583,104);
                n3_crs.Visible = true;
                //n3_crs.Location = new Point(614,104);
            }
            else if (n2_add.Top == Node4.Top)
            {
                n2_add.Visible = false;
                n3_crs.Location = new Point(588, 177);
            }
           
        }

        void setPosition_crossbtn()
        {
            if  (n3_crs.Top == Node5.Top)
            {
               // n2_add.Location = new Point(583, 104);
                n3_crs.Location = new Point(614, 104);
                n2_add.Visible = true;
            }

            else if (n3_crs.Top == Node4.Top)
            {
                n2_add.Location = new Point(300, 257);
                n3_crs.Visible = false;
                //n3_crs.Location = new Point(331, 257);
            }

            /*else if (n3_crs.Top == Node3.Top)
            {
                n2_add.Location = new Point(297,177);
            }*/

        }

        void setforNode3()
        {
            node1_lbl.Text = Node1.Text;
            node2_lbl.Text = Node2.Text;
            node3_lbl.Text = Node3.Text;
        }
        void setforNode4()
        {
            node4_lbl.Text = Node1.Text;
            node5_lbl.Text = Node2.Text;
            node6_lbl.Text = Node3.Text;
            node7_lbl.Text = Node4.Text;

        }
        void setforNode5()
        {
           // node8_lbl.Text = "";
            node8_lbl.Text = Node1.Text;
            node9_lbl.Text = Node2.Text;
            node10_lbl.Text = Node3.Text;
            node11_lbl.Text = Node4.Text;
            node12_lbl.Text = Node5.Text;

        }
        void parent()
        {
            node8_lbl.Parent=node4_pan;
            node9_lbl.Parent =node4_pan;
            node10_lbl.Parent=node4_pan;
            node11_lbl.Parent=node4_pan;
            node12_lbl.Parent = node4_pan;
        }
        void totalNodes(int top)
        {
            graphPanel.Visible = true;
            GraphpanHide();
            //if (top==3)
            //{
            //     queue.Enqueue(Node1.Text);
            //     queue.Enqueue(Node2.Text);
            //    // node2Graph();
            //    SaveData("Insert into tripData(EmailID,City1,City2) values ('login_Form.userEmail','" + Node1.Text + "','" + Node2.Text + "')");

            //    // node2_pan.Visible = true;

            //}
            if (top == 2)
            {
                q.Enqueue(Node1.Text);
                q.Enqueue(Node2.Text);
                q.Enqueue(Node3.Text);
                SaveData("Insert into tripData(EmailID,City1,City2,city3) values ( '"+ userEmail_lbl.Text + "','" + Node1.Text + "','" + Node2.Text + "','"+Node3.Text+"')");
                setforNode3();
                edges3();
                node3_pan.Visible = true;
            }
            else if (top == 1)
            {
                q.Enqueue(Node1.Text);
                q.Enqueue(Node2.Text);
                q.Enqueue(Node3.Text);
                q.Enqueue(Node4.Text);
                SaveData("Insert into tripData(EmailID,City1,City2,city3,city4) values ( '" + userEmail_lbl.Text + "','" + Node1.Text + "','" + Node2.Text + "','" + Node3.Text + "','" + Node4.Text + "')");
                setforNode4();
                parent();
                node4_pan.Visible = true;
            }
           else if (top == 0)
            {
                q.Enqueue(Node1.Text);
                q.Enqueue(Node2.Text);
                q.Enqueue(Node3.Text);
                q.Enqueue(Node4.Text);
                q.Enqueue(Node5.Text);
                SaveData("Insert into tripData(EmailID,City1,City2,city3,city4,city5) values ( '" + userEmail_lbl.Text + "','" + Node1.Text + "','" + Node2.Text + "','" + Node3.Text + "','" + Node4.Text + "','" + Node5.Text + "')");
                setforNode5();

                node5_pan.Visible = true;
            }
        }
        int Total(int [] array)
        {
            int c = 0;
            Array.Sort(array);
            c = distances[0] + distances[1];
            return c;
        }
        void price()
        {
            costlbl.Text = "";
            pricelbl.Text = "";
            int prices=0;
            int c = 0;
             c = Total(distances);
            prices = c * 225;
            costlbl.Text = c.ToString();
           // c = int.Parse();
            pricelbl.Text = prices.ToString();
        }
        //Class1 obj1 = new Class1();
        void edges3()
        {
            //Class1 obj = new Class1();
            createDistances();
            edge1_lbl.Text = distances[0].ToString();
            edge2_lbl.Text = distances[1].ToString();
            edge3_lbl.Text = distances[2].ToString();
            price();

        }
        void Show()
        {
            //while (q.isempty() == false)
            //{obj
            //    string data = o ;
            //}
            //queueData.Text = 
            //queueData.Text = "";
            //for (int i = 0; i < obj1.array.Length; i++)
            //{
            //    queueData.Text += obj1.array[i] + "\r\n";

            //}
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
           
            if (visibility==false)
            {
                Signout_btn.ForeColor = Color.White; ;
              sinoutPan.BackColor = Color.FromArgb(130, 146, 227);
              visibility = true;

            }
           
        }

        private void Signout_btn_Click(object sender, EventArgs e)
        {
            Login_Form lf = new Login_Form();
            lf.Show();
            this.Hide();
        }

        private void sinoutPan_MouseLeave(object sender, EventArgs e)
        {
            if (visibility == true)
            {
                Signout_btn.ForeColor = Color.DimGray; 
                sinoutPan.BackColor = Color.FromArgb(211, 217, 228);
                visibility = false;
            }
        }

        private void Home_Click(object sender, EventArgs e)
        {
            homeActive();
        }

        private void Profile_Click(object sender, EventArgs e)
        {
            profileActive();
            profilePan();
        }

        private void Map_Click(object sender, EventArgs e)
        {
            mapActive();
        }

        private void City_Click(object sender, EventArgs e)
        {
            if (visit == false)
            {
                cityPantxt_push();
                visit = true;
            }
            cityActive();
            cityPan();
        }

        private void Graph_Click(object sender, EventArgs e)
        {
            graphActive();
            graphPan();
        }

        private void n2_add_Click(object sender, EventArgs e)
        {
            cityPantxt_show();
            setPosition_addbtn();
            //txt.Visible = true;
        }

        private void n3_crs_Click(object sender, EventArgs e)
        {
           // setPosition_crossbtn();  
            if (n3_crs.Top == Node3.Top)
            {
                textboxes.Push(Node3);
                cityPantxt_hide();
                setPosition_crossbtn();
            }
           else if (n3_crs.Top == Node4.Top)
            {
                textboxes.Push(Node4);
                cityPantxt_hide();
                setPosition_crossbtn();
            }
            else if (n3_crs.Top == Node5.Top)
            {
                textboxes.Push(Node5);
                cityPantxt_hide();
                setPosition_crossbtn();
            }
        }


        private void Node1_MouseHover(object sender, EventArgs e)
        {
            txtPlaceholder_hidden(Node1);
        }

        private void Node1_MouseLeave(object sender, EventArgs e)
        {
            txtPlaceholder_visible(Node1,"Enter City");
        }

        private void Node2_MouseHover(object sender, EventArgs e)
        {
            txtPlaceholder_hidden(Node2);
        }

        private void Node2_MouseLeave(object sender, EventArgs e)
        {
            txtPlaceholder_visible(Node2, "Enter City");
        }

        private void Node3_MouseHover(object sender, EventArgs e)
        {
            txtPlaceholder_hidden(Node3);
        }

        private void Node3_MouseLeave(object sender, EventArgs e)
        {
            txtPlaceholder_visible(Node3, "Enter City");
        }

        private void Node4_MouseHover(object sender, EventArgs e)
        {
            txtPlaceholder_hidden(Node4);
        }

        private void Node4_MouseLeave(object sender, EventArgs e)
        {
            txtPlaceholder_visible(Node4, "Enter City");
        }

        private void Node5_MouseHover(object sender, EventArgs e)
        {
            txtPlaceholder_hidden(Node5);
        }

        private void Node5_MouseLeave(object sender, EventArgs e)
        {
            txtPlaceholder_visible(Node5, "Enter City");
        }

        private void Createbtn_Click(object sender, EventArgs e)
        {
            totalNodes(textboxes.Count);
            //Show();
           // Class1 obj = new Class1();
           // obj.call();
            graphActive();
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {
            CreateConnection();
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void node3_pan_Paint(object sender, PaintEventArgs e)
        {
           Graphics g = e.Graphics;
           Pen p = new Pen(Brushes.Red, 2);
           p.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
           g.DrawLine(p, 400,200 ,270 , 80);
           g.DrawLine(p, 350, 200, 100, 200);
           g.DrawLine(p, 250, 80, 100, 180);

            //first one firt point x coordinate,second one first point y,third second point x coordinate,4th seconmd point y coordinate;
        }

        private void arrow(PaintEventArgs e, int a, int b, int c, int d)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Brushes.Green, 8);
            p.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            g.DrawLine(p, a, b, c, d);//first one firt point x coordinate,second one first point,third second point x coordinate,4th seconmd point y coordinate

        }

        private void node4_pan_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Brushes.Red, 4);
            p.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
             g.DrawLine(p, 400, 200, 270, 80);
             g.DrawLine(p, 250, 80, 100, 180);
             g.DrawLine(p, 350, 200, 150, 200);
             g.DrawLine(p, 250, 90, 270, 1000);
             g.DrawLine(p, 380, 200,0, 1000);
             g.DrawLine(p, 100, 200, 850, 1000);

        }

        private void node5_pan_Paint(object sender, PaintEventArgs e)
        {
           /* Graphics g = e.Graphics;
            Pen p = new Pen(Brushes.Red, 4);
            p.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            g.DrawLine(p, 400, 200, 270, 80);
            g.DrawLine(p, 250, 80, 100, 180);
            g.DrawLine(p, 350, 200, 150, 200);
            g.DrawLine(p, 250, 90, 270, 1000);
            g.DrawLine(p, 380, 200, 0, 1000);
            g.DrawLine(p, 100, 200, 850, 1000); */
        }
    }
}
