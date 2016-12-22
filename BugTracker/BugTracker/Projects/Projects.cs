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
    public partial class Projects : Form
    {
        private string repositoryId;
        private GitHubClient gitClient;
        private Credentials basicAuth;
        private User gitUser;


        public Projects(User gitUser, GitHubClient gitClient)
        {
            InitializeComponent();

            this.gitUser = gitUser;
            this.gitClient = gitClient;
            getProjects();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void getProjects()
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
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pSelectedValue.Text = dataGridView1.SelectedCells[1].Value.ToString();
            repositoryId = dataGridView1.SelectedCells[0].Value.ToString();
        }

        private async void createProject_Click(object sender, EventArgs e)
        {
            NewRepository a = new NewRepository(projectNameValue.Text);
            a.Description = projectDescValue.Text;
            var u = await gitClient.Repository.Create(a);
            Projects Refresh = new Projects(gitUser, gitClient);
            Refresh.MdiParent = this.MdiParent;
            Refresh.WindowState = FormWindowState.Maximized;
            this.Dispose();
            Refresh.Show();
            

            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

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

        private async void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
        }
    }
}
