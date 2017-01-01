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

    // This form will act as a container for all subforms - Providing the overall UI structure.

    public partial class Main : Form
    {
        //  Variables
        private GitHubClient gitClient;
        private User gitUser;
        private string usertype;

        // assign variables, Open projects form.
        public Main(User gitUser, GitHubClient gitClient, string usertype)
        {
            InitializeComponent();

            this.gitUser = gitUser;
            this.gitClient = gitClient;
            this.usertype = usertype;

            toolStripStatusLabel.Text = gitUser.Login.ToString() + " - " + usertype;

            Projects.Projects a = new Projects.Projects(gitUser, gitClient, usertype);
            a.MdiParent = this;
            a.WindowState = FormWindowState.Maximized;
            a.Show();
        }

         // Open Projects form 
        private void viewProjects_Click(object sender, EventArgs e)
        {
            refreshProjects();
        }

        // Refresh projects form
        public void refreshProjects()
        {
            closeForms();
            userTitle.Text = "Bug Tracker - Projects/Repositorys";

            Projects.Projects a = new Projects.Projects(gitUser, gitClient, usertype);
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
    }
}
