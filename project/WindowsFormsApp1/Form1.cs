using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Authentication : Form
    {
        public Authentication()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login_Form user = new Login_Form();
            user.Show();
            this.Hide();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            
            HoverEffect(button1);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
           
            LeaveEffect(button1);
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            
            HoverEffect(button3);

        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            
            LeaveEffect(button3);
        }

        private void HoverEffect(Button b)
        {
            b.ForeColor = Color.White;
            // b.BackColor = ColorTranslator.FromHtml("#FF6E31");
            b.BackColor = Color.FromArgb(255, 128, 0);
            //b.Width = 145;
            //b.Height = 80;
            b.FlatStyle = FlatStyle.Flat;
        }

        private void LeaveEffect(Button b)
        {
            b.ForeColor = Color.Black;
            b.BackColor = Color.White;
           // b.Width = 138;
            //b.Height = 58;
            b.FlatStyle = FlatStyle.Popup;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }

  }

