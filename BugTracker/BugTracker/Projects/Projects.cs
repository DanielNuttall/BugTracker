using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Octokit;

namespace BugTracker.Projects
{

    // This form will load a list off all projects belonging to the logged in user - aswell as allowing a user to create and assign users to projects.

    public partial class Projects : Form
    {
        // setup varaibles.
        private string repositoryId;
        private GitHubClient gitClient;
        private Credentials basicAuth;
        private User gitUser;
        private string userType;

        // Assign variables and call get projects method.
        public Projects(User gitUser, GitHubClient gitClient, string userType)
        {
            InitializeComponent();

            this.gitUser = gitUser;
            this.gitClient = gitClient;
            this.userType = userType;
            getProjects();
        }

        // get a list of all projects assigned to the current user via the GitHub API and list there data in a table.
        private async void getProjects()
        {
            try
            {
                DataTable repoTable = new DataTable();
                repoTable.Columns.Add("Id");
                repoTable.Columns.Add("Name");
                repoTable.Columns.Add("URL");
                repoTable.Columns.Add("IssueCount");
                repoTable.Columns.Add("Owner");

                IReadOnlyList<Repository> userRepos = await gitClient.Repository.GetAllForCurrent();
                foreach (Repository a in userRepos)
                {
                    DataRow b = repoTable.NewRow();
                    b["Id"] = a.Id;
                    b["Name"] = a.Name;
                    b["URL"] = a.Url; ;
                    b["IssueCount"] = a.OpenIssuesCount;
                    b["Owner"] = a.FullName;

                    repoTable.Rows.Add(b);
                }
                dataGridView1.DataSource = repoTable;
            } catch (Exception getProjectsError)
            {
                MessageBox.Show("Could Not Get Projects - Check Connection");
            }
        }

        // Update relevent textboxs when a user single clicks a cell.
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pSelectedValue.Text = dataGridView1.SelectedCells[1].Value.ToString();
            repositoryId = dataGridView1.SelectedCells[0].Value.ToString();
        }

        // Create a new project/repo on Github and refresh the page.
        private async void createProject_Click(object sender, EventArgs e)
        {
            try
            {
                NewRepository a = new NewRepository(projectNameValue.Text);
                a.Description = projectDescValue.Text;
                var u = await gitClient.Repository.Create(a);
                Projects Refresh = new Projects(gitUser, gitClient, userType);
                Refresh.MdiParent = this.MdiParent;
                Refresh.WindowState = FormWindowState.Maximized;
                this.Dispose();
                Refresh.Show();
            } catch (Exception failed)
            {
                MessageBox.Show("Could Not Create Project");
            }
        }

        // Add a user to the selected project.
        private void addUser_Click(object sender, EventArgs e)
        {
            try
            {
                ApiConnection connect = new ApiConnection(gitClient.Connection);
                RepoCollaboratorsClient d = new RepoCollaboratorsClient(connect);
                d.Add(Convert.ToInt64(repositoryId), pSelectedUserValue.Text);
                MessageBox.Show("User Added");
            } catch (Exception a)
            {
                MessageBox.Show("Could Not Add User");
            }
        }

        // Open the bugs form for the selected project on double click.
        private async void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                repositoryId = dataGridView1.SelectedCells[0].Value.ToString();

                ApiConnection connect = new ApiConnection(gitClient.Connection);
                RepositoriesClient repoClient = new RepositoriesClient(connect);
                Repository selectedRepo = await repoClient.Get(Convert.ToInt64(repositoryId));

                Bugs.Bugs Refresh = new Bugs.Bugs(gitUser, gitClient, selectedRepo);
                Refresh.MdiParent = this.MdiParent;
                Refresh.WindowState = FormWindowState.Maximized;
                this.Dispose();
                Refresh.Show();
            } catch (Exception getProjectFailed)
            {
                MessageBox.Show("Could Not Get Project - Check Connection");
            }
        }
    }
}
