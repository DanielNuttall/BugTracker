using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BugTracker.Projects;

namespace BugTracker
{
    public partial class Main : Form
    {
        private string userId;
        private string userType;

        public Main(String userType, String userId)
        {
            InitializeComponent();
            this.userId = userId;
            this.userType = userType;

            toolStripStatusLabel.Text = userType + " - " + userId;

            openProject(userId);
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

        // Open Projects form
        private void viewProjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeForms();
            openProject(userId);
        }

        // Open Create Project form
        private void createProjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeForms();

            Projects.CreateProject a = new Projects.CreateProject();
            a.MdiParent = this;
            a.WindowState = FormWindowState.Maximized;
            a.Show();
        }

        // Custom methods
        private void openProject(string userId)
        {
            if (toolStripStatusLabel.Text == "Tester")
            {
                usersToolStripMenuItem.Visible = false;
                createProjectsToolStripMenuItem.Visible = false;
            }
            Projects.Projects a = new Projects.Projects(userId);
            a.MdiParent = this;
            a.WindowState = FormWindowState.Maximized;
            a.Show();
        }

        private void closeForms()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
        }
    }
}
