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

namespace BugTracker.Bugs
{
    public partial class Bugs : Form
    {
        private long repositoryId;
        private string Repository;
        private long repoId;
        private int issueId;
        private GitHubClient gitClient;
        private Credentials basicAuth;
        private User gitUser;

        public Bugs(User gitUser, GitHubClient gitClient, Repository selectedRepo)
        {
            InitializeComponent();
            this.gitUser = gitUser;
            this.gitClient = gitClient;
            this.repoId = selectedRepo.Id;
            this.Repository = selectedRepo.Name;

            this.repositoryId = selectedRepo.Id;

            getBugs();
        }

        private async void getBugs()
        {
            DataTable bugTable = new DataTable();
            bugTable.Columns.Add("Id");
            bugTable.Columns.Add("Title");
            bugTable.Columns.Add("URL");
            bugTable.Columns.Add("Repository");
            bugTable.Columns.Add("RepositoryId");
            bugTable.Columns.Add("UpdatedAt");
            bugTable.Columns.Add("State");

            // ADJUST THIS SO THAT IT OPENS ISSUES FOR A SPECIFIC REPOSITORY
            IReadOnlyList<Issue> userRepos = await gitClient.Issue.GetAllForRepository(repoId);
            // IReadOnlyList<Issue> userRepos = await gitClient.Issue.GetAllForCurrent();
            foreach (Issue a in userRepos)
            {
                DataRow b = bugTable.NewRow();
                b["Id"] = a.Number;
                b["Title"] = a.Title;
                b["URL"] = a.Url;
                b["Repository"] = Repository;
                b["RepositoryId"] = repositoryId;
                b["UpdatedAt"] = a.UpdatedAt;
                b["State"] = a.State;

                bugTable.Rows.Add(b);
            }
            dataGridView1.DataSource = bugTable;
        }

        private async void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            repositoryId = Convert.ToInt64(dataGridView1.SelectedCells[4].Value.ToString());
            issueId = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());

            cBox.Items.Clear();

            ApiConnection connect = new ApiConnection(gitClient.Connection);

            IssuesClient issuesClient = new IssuesClient(connect);
            Issue sIssue = await issuesClient.Get(repositoryId, issueId);

            issueDesc.Text = sIssue.Body;


            IssueCommentsClient comment = new IssueCommentsClient(connect);

            IReadOnlyList<IssueComment> userCooments = await comment.GetAllForIssue(repositoryId, issueId);
            foreach (IssueComment a in userCooments)
            {

                cBox.Items.Add("User: " + a.User.Login + " Text: " + a.Body.ToString() + " UpdatedAt: " + a.UpdatedAt.ToString());
            }
        }
    }
}
