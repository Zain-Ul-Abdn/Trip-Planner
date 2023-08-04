using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project1
{
    public partial class Controls : Form
    {
        List<Panel> panellist = new List<Panel>();
        int index;
        public Controls()
        {
            InitializeComponent();
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                panellist[--index].BringToFront();
            }
        }

        private void btnban_Click(object sender, EventArgs e)
        {
            if (index < panellist.Count - 1)
            {
                panellist[++index].BringToFront();
            }
        }

        private void Controls_Load(object sender, EventArgs e)
        {
            panellist.Add(Adminpanel);
            panellist.Add(banpanel);
            
            panellist[index].BringToFront();
        }

    }
}
