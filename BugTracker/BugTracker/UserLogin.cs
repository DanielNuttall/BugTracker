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

namespace BugTracker
{

    // This form acts as a login for the Bugtracker application - It uses GitHub to verify an account and provides a modifyed interface depending on if the user selects Admin/Tester.

    public partial class UserLogin : Form
    {
        // Setup variables
        private GitHubClient gitClient;
        private Credentials basicAuth;
        private User gitUser;

        // setup a github API client. + basic form setup.
        public UserLogin()
        {
            InitializeComponent();
            gitClient = new GitHubClient(new ProductHeaderValue("my-cool-app"));
            Pass_Text.UseSystemPasswordChar = true;
            userTypeValue.Text = "Admin";
        }

        // on click - verify account via Github and load Main form, else show incorrect login message.
        private async void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                basicAuth = new Credentials(User_Text.Text, Pass_Text.Text);
                gitClient.Credentials = basicAuth;
                gitUser = await gitClient.User.Current();
                Main main = new Main(gitUser, gitClient, userTypeValue.Text);
                main.Show();
            }
            catch (AuthorizationException loginError)
            {
                MessageBox.Show("Incorrect Login");
            }
        }

        // on click - close application
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // clear User/Password textboxs on mose click
        private void User_Text_Click(object sender, EventArgs e)
        {
            User_Text.Text = "";
        }
        private void Pass_Text_Click(object sender, EventArgs e)
        {
            Pass_Text.Text = "";
        }
    }
}
