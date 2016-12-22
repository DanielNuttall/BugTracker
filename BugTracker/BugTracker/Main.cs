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
using Octokit;

namespace BugTracker
{
    public partial class Main : Form
    {
        private GitHubClient gitClient;
        private User gitUser;

        public Main(User gitUser, GitHubClient gitClient)
        {
            InitializeComponent();

            this.gitUser = gitUser;
            this.gitClient = gitClient;

            toolStripStatusLabel.Text = gitUser.Login.ToString();

            Projects.Projects a = new Projects.Projects(gitUser, gitClient);
            a.MdiParent = this;
            a.WindowState = FormWindowState.Maximized;
            a.Show();
        }

         // Open Projects form 
        private void viewProjects_Click(object sender, EventArgs e)
        {
            closeForms();
            userTitle.Text = "Bug Tracker - Projects";

            Projects.Projects a = new Projects.Projects(gitUser, gitClient);
            a.MdiParent = this;
            a.WindowState = FormWindowState.Maximized;
            a.Show();
        }

        public void refreshProjects()
        {
            closeForms();
            userTitle.Text = "Bug Tracker - Projects";

            Projects.Projects a = new Projects.Projects(gitUser, gitClient);
            a.MdiParent = this;
            a.WindowState = FormWindowState.Maximized;
            a.Show();
        }

        private void viewBugs_Click(object sender, EventArgs e)
        {

        }

        private void createBugReport_Click(object sender, EventArgs e)
        {

        }

        // Close All open forms
        public void closeForms()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
        }
    }
}
