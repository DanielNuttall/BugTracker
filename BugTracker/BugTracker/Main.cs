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
using BugTracker.Users;

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

            if (userType == "Tester")
            {
                usersToolStripMenuItem.Visible = false;
                createProjectsToolStripMenuItem.Visible = false;
            }

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

            Projects.CreateProject a = new Projects.CreateProject(userId);
            a.MdiParent = this;
            a.WindowState = FormWindowState.Maximized;
            a.Show();
        }

        // Open Project Lists
        public void openProject(string userId)
        {
            Projects.Projects a = new Projects.Projects(userId);
            a.MdiParent = this;
            a.WindowState = FormWindowState.Maximized;
            a.Show();
        }

        public void openUsers()
        {
            Users.Users a = new Users.Users();
            a.MdiParent = this;
            a.WindowState = FormWindowState.Maximized;
            a.Show();
        }

        // Close All open forms
        public void closeForms()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
        }

        private void listUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeForms();

            Users.Users a = new Users.Users();
            a.MdiParent = this;
            a.WindowState = FormWindowState.Maximized;
            a.Show();
        }

        private void createUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeForms();
            Users.CreateUser a = new Users.CreateUser();
            a.MdiParent = this;
            a.WindowState = FormWindowState.Maximized;
            a.Show();
        }
    }
}
