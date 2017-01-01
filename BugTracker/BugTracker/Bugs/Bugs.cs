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

    // This form Shows a list of all Issues/bugs asociated with the selected project/repo - Allows the ability to, report new issues/bugs and update/interact with existing bug/issue reports.

    public partial class Bugs : Form
    {
        // Setup variables
        private long repositoryId;
        private string Repository;
        private string newComment;
        private long repoId;
        private int issueId;
        private int sha;
        private string userType;
        private GitHubClient gitClient;
        private Credentials basicAuth;
        private User gitUser;
        private ApiConnection connect;
        private IssuesClient issuesClient;
        private IssueCommentsClient comment;
        private Repository selectedRepo;

        // Assign varaibles, setup clients and connections.
        public Bugs(User gitUser, GitHubClient gitClient, Repository selectedRepo, string userType)
        {
            InitializeComponent();
            this.gitUser = gitUser;
            this.gitClient = gitClient;
            this.userType = userType;
            this.repoId = selectedRepo.Id;
            this.Repository = selectedRepo.Name;
            this.selectedRepo = selectedRepo;
            this.repositoryId = selectedRepo.Id;

            if (userType == "Tester")
            {
                uIssueMethod.ReadOnly = true;
                uIssueLine.ReadOnly = true;
                uStatusValue.Enabled = false;
                repoFiles3.Enabled = false;
                uAssign.Enabled = false;

                newIssueMethod.ReadOnly = true;
                newIssueLine.ReadOnly = true;
                repoFiles2.Enabled = false;


            }

            connect = new ApiConnection(gitClient.Connection);
            issuesClient = new IssuesClient(connect);
            comment = new IssueCommentsClient(connect);

            // Get Repo File structure on load.
            getFiles();
            getBugs();
            getUsers();
        }

        // Get a list of all issues for the cuurent repo.
        private async void getBugs()
        {
            try
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
                RepositoryIssueRequest repoRequest = new RepositoryIssueRequest();
                repoRequest.State = ItemStateFilter.All;

                IReadOnlyList<Issue> userRepos = await gitClient.Issue.GetAllForRepository(repoId, repoRequest);
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
            } catch (Exception error)
            {
                MessageBox.Show("Could Not Get Issues - Check Connection");
            }
        }

        // Get a list of all users assigned to the current repo.
        private async void getUsers()
        {
            try
            {
                RepoCollaboratorsClient colabclient = new RepoCollaboratorsClient(connect);
                IReadOnlyList<User> users = await colabclient.GetAll(repositoryId); ;
                foreach (User a in users)
                {
                    uAssign.Items.Add(a.Login);
                }
            } catch (Exception error)
            {
                MessageBox.Show("Could Not Get Issues - Check Connection");
            }
        }

        //  Update relevent feilds when a issue is selected.
        private async void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                repositoryId = Convert.ToInt64(dataGridView1.SelectedCells[4].Value.ToString());
                issueId = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
                uIssueValue.Text = "";
                uIssueMethod.Text = "";
                uIssueLine.Text = "";
                cbox2.Items.Clear();

                // Get Selected Issue Info
                Issue sIssue = await issuesClient.Get(repositoryId, issueId);
                issueDescValue.Text = sIssue.Body;
                string[] lines = sIssue.Body.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
                foreach (string line in lines) {
                    if (line.Contains("Method:"))
                    {
                        uIssueMethod.Text = line.Replace("Method: ", "");
                    } else if (line.Contains("Line:"))
                    {
                        uIssueLine.Text = line.Replace("Line: ", "");
                    } else
                    {
                        uIssueValue.Text = uIssueValue.Text + line.Replace("Desc: ", "");
                    }
                }

                uIssueTitleValue.Text = sIssue.Title;
                uStatusValue.Text = sIssue.State.ToString();
                uAssign.Text = sIssue.Assignee.Login;

                // Get Selected Issue Comments
                comment = new IssueCommentsClient(connect);
                IReadOnlyList<IssueComment> userComments = await comment.GetAllForIssue(repositoryId, issueId);
                foreach (IssueComment a in userComments)
                {
                    ListViewItem item = new ListViewItem(a.User.Login);
                    item.SubItems.Add(a.Body.ToString());
                    item.SubItems.Add(a.UpdatedAt.ToString());
                    cbox2.Items.Add(item);
                }
            } catch (NullReferenceException noUsersAssigned)
            {
                MessageBox.Show("No User Currently assigned to this Issue - Admin can assign a user on the Update Issue tab");
                uAssign.Text = gitUser.Login;
            } catch (Exception error)
            {
                MessageBox.Show("Could Not Get Issue Info - Check Connection");
            }
            
        }

        // Add a comment to the current issue thread.
        private async void addComment_Click(object sender, EventArgs e)
        {
            try
            {
                // RepoID, IssueNumber, Comment
                repositoryId = Convert.ToInt64(dataGridView1.SelectedCells[4].Value.ToString());
                issueId = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
                newComment = newCommentValue.Text;

                await comment.Create(repositoryId, issueId, newComment);

                cbox2.Items.Clear();
                // Refresh Selected Issue Comments
                comment = new IssueCommentsClient(connect);
                IReadOnlyList<IssueComment> userComments = await comment.GetAllForIssue(repositoryId, issueId);
                foreach (IssueComment a in userComments)
                {
                    ListViewItem item = new ListViewItem(a.User.Login);
                    item.SubItems.Add(a.Body.ToString());
                    item.SubItems.Add(a.UpdatedAt.ToString());
                    cbox2.Items.Add(item);
                }
            } catch (Exception error)
            {
                MessageBox.Show("Could Not Add Comment - Check Connection");
            }
        }

        // Get a list of all files in the repository.
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

        // Get file list recusivily
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

        // Add selected file to the comment
        private void repoFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            newCommentValue.AppendText("\nFile: " + selectedRepo.HtmlUrl + repoFiles.Text.Insert(0, "/tree/master/").Replace("/tree/master/ - ", "/blob/master/"));
        }
        // Add selected file to the Issue
        private void repoFiles2_SelectedIndexChanged(object sender, EventArgs e)
        {
            newIssueValue.AppendText("\nFile: " + selectedRepo.HtmlUrl + repoFiles2.Text.Insert(0, " / tree/master/").Replace("/tree/master/ - ", "/blob/master/"));
        }

        private void repoFiles3_SelectedIndexChanged(object sender, EventArgs e)
        {
            uIssueValue.AppendText("\nFile: " + selectedRepo.HtmlUrl + repoFiles3.Text.Insert(0, " / tree/master/").Replace("/tree/master/ - ", "/blob/master/"));
        }

        // Create new issue
        private async void button1_Click_1(object sender, EventArgs e)
        {
            if (issueTitleValue.Text.Length > 0)
            {
                try
                {
                    NewIssue issue = new NewIssue(issueTitleValue.Text);
                    issue.Body = newIssueValue.Text;
                    issue.Body = "Desc: " + newIssueValue.Text + "\n" + "Method: " + newIssueMethod.Text + "\n" + "Line: " + newIssueLine.Text + "\n";
                    issue.Assignee = gitUser.Login;

                    await issuesClient.Create(repositoryId, issue);
                    refresh();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Could Not Add New Issue - Check Connection");
                }
            } else
            {
                MessageBox.Show("Please enter an Issue Title");
            }

        }

        // Update currently selected issue
        private async void updateIssue_Click_1(object sender, EventArgs e)
        {
            try
            {
                //IssuesClient issueClient = new IssuesClient(connect);
                IssueUpdate uIssue = new IssueUpdate();
                uIssue.Body = "Desc: " + uIssueValue.Text + "\n" + "Method: " + uIssueMethod.Text + "\n" + "Line: " + uIssueLine.Text + "\n";
                if (uStatusValue.Text == "Closed")
                {
                    uIssue.State = ItemState.Closed;
                }
                else
                {
                    uIssue.State = ItemState.Open;
                }
                uIssue.Assignee = uAssign.Text;

                // long repositoryId, int number, IssueUpdate issueUpdate
                await issuesClient.Update(repositoryId, issueId, uIssue);
                refresh();
            } catch (Exception error)
            {
                MessageBox.Show("Could Not Add New Issue - Check Connection");
            }
        }

        // refresh page
        private void refresh()
        {
            Bugs Refresh = new Bugs(gitUser, gitClient, selectedRepo, userType);
            Refresh.MdiParent = this.MdiParent;
            Refresh.WindowState = FormWindowState.Maximized;
            this.Dispose();
            Refresh.Show();
        }

        
    }
}
