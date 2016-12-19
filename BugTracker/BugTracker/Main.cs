using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTracker
{
    public partial class Main : Form
    {
        private int childFormNumber = 0;

        public Main(String Usertype)
        {
            InitializeComponent();
            toolStripStatusLabel.Text = Usertype;

            if (Usertype == "Tester")
            {
                usersToolStripMenuItem.Visible = false;
                createProjectsToolStripMenuItem.Visible = false;
                TesterMain a = new TesterMain();
                a.MdiParent = this;
                a.Show();
            } else
            {
                StaffMain a = new StaffMain();
                a.MdiParent = this;
                a.Show();
            }
        }

        private void projectsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openBugsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel_Click(object sender, EventArgs e)
        {

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
