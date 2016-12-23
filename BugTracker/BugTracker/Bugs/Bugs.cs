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
        private string newComment;
        private long repoId;
        private int issueId;
        private int sha;
        private GitHubClient gitClient;
        private Credentials basicAuth;
        private User gitUser;
        private ApiConnection connect;
        private IssuesClient issuesClient;
        private IssueCommentsClient comment;
        private Repository selectedRepo;

        public Bugs(User gitUser, GitHubClient gitClient, Repository selectedRepo)
        {
            InitializeComponent();
            this.gitUser = gitUser;
            this.gitClient = gitClient;
            this.repoId = selectedRepo.Id;
            this.Repository = selectedRepo.Name;
            this.selectedRepo = selectedRepo;

            this.repositoryId = selectedRepo.Id;

            connect = new ApiConnection(gitClient.Connection);
            issuesClient = new IssuesClient(connect);
            comment = new IssueCommentsClient(connect);

            // Get Repo File structure on load.
            getFiles();

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

            // Get Selected Issue Info
            Issue sIssue = await issuesClient.Get(repositoryId, issueId);
            issueDescValue.Text = sIssue.Body;

            uIssueTitleValue.Text = sIssue.Title;
            uIssueValue.Text = sIssue.Body;

            // Get Selected Issue Comments
            comment = new IssueCommentsClient(connect);
            IReadOnlyList<IssueComment> userComments = await comment.GetAllForIssue(repositoryId, issueId);
            foreach (IssueComment a in userComments)
            {

                cBox.Items.Add("User: " + a.User.Login + " Text: " + a.Body.ToString() + " UpdatedAt: " + a.UpdatedAt.ToString());
            }
        }

        private async void addComment_Click(object sender, EventArgs e)
        {
            // RepoID, IssueNumber, Comment
            repositoryId = Convert.ToInt64(dataGridView1.SelectedCells[4].Value.ToString());
            issueId = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            newComment = newCommentValue.Text;

            await comment.Create(repositoryId, issueId, newComment);

            cBox.Items.Clear();
            // Refresh Selected Issue Comments
            comment = new IssueCommentsClient(connect);
            IReadOnlyList<IssueComment> userComments = await comment.GetAllForIssue(repositoryId, issueId);
            foreach (IssueComment a in userComments)
            {
                cBox.Items.Add("User: " + a.User.Login + " Text: " + a.Body.ToString() + " UpdatedAt: " + a.UpdatedAt.ToString());
            }
        }

        // TEST METHOD for getting the file structure of a repository.  File or Dir
        private async void getFiles()
        {
            try
            {
                List<string> dirPile = new List<string>();

                RepositoryContentsClient repoContentsClient = new RepositoryContentsClient(connect);
                IReadOnlyList<RepositoryContent> repoContent = await repoContentsClient.GetAllContents(repositoryId);
                foreach (RepositoryContent a in repoContent)
                {
                    if (a.Type.ToString() == "Dir")
                    {
                        dirPile.Add(a.Path);
                    } else
                    {
                        repoFiles.Items.Add(a.Path);
                        repoFiles2.Items.Add(a.Path);
                        repoFiles3.Items.Add(a.Path);
                    }

                    addFiles(dirPile);

                }
            } catch (Exception e)
            {
                repoFiles.Items.Add("Repository is Empty");
                repoFiles2.Items.Add("Repository is Empty");
                repoFiles3.Items.Add("Repository is Empty");
            }

        }

        private async void addFiles(List<string> dirPile)
        {
            List<string> dirPile2 = new List<string>();

            RepositoryContentsClient repoContentsClient = new RepositoryContentsClient(connect);

            //foreach (string dir in dirPile)
            for (var i = 0; i < dirPile.Count; i++)
            {
                repoFiles.Items.Add(dirPile[i]);
                repoFiles2.Items.Add(dirPile[i]);
                repoFiles3.Items.Add(dirPile[i]);
                IReadOnlyList<RepositoryContent> repoContent2 = await repoContentsClient.GetAllContents(repositoryId, dirPile[i]);
                foreach (RepositoryContent b in repoContent2)
                {
                    if (b.Type.ToString() == "Dir")
                    {
                        dirPile.Add(b.Path);
                    }
                    else
                    {
                        repoFiles.Items.Add(" - " + b.Path);
                        repoFiles2.Items.Add(" - " + b.Path);
                        repoFiles3.Items.Add(" - " + b.Path);
                    }

                    addFiles(dirPile2);
                }
            }
        }

        private void repoFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            newCommentValue.AppendText(selectedRepo.HtmlUrl + repoFiles.Text.Insert(0, "/tree/master/").Replace("/tree/master/ - ", "/blob/master/"));
        }

        private void repoFiles2_SelectedIndexChanged(object sender, EventArgs e)
        {
            newIssueValue.AppendText(selectedRepo.HtmlUrl + repoFiles2.Text.Insert(0, "/tree/master/").Replace("/tree/master/ - ", "/blob/master/"));
        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            IssuesClient issueClient = new IssuesClient(connect);

            NewIssue issue = new NewIssue(issueTitleValue.Text);
            issue.Body = newIssueValue.Text;
            issue.Assignee = gitUser.Login;

            await issueClient.Create(repositoryId, issue);

            Bugs Refresh = new Bugs(gitUser, gitClient, selectedRepo);
            Refresh.MdiParent = this.MdiParent;
            Refresh.WindowState = FormWindowState.Maximized;
            this.Dispose();
            Refresh.Show();
        }

        private async void updateIssue_Click(object sender, EventArgs e)
        {
            IssuesClient issueClient = new IssuesClient(connect);
            IssueUpdate uIssue = new IssueUpdate();
            uIssue.Body = uIssueValue.Text;

            // long repositoryId, int number, IssueUpdate issueUpdate
            await issueClient.Update(repositoryId, issueId, uIssue);

            Bugs Refresh = new Bugs(gitUser, gitClient, selectedRepo);
            Refresh.MdiParent = this.MdiParent;
            Refresh.WindowState = FormWindowState.Maximized;
            this.Dispose();
            Refresh.Show();
        }
    }
}
