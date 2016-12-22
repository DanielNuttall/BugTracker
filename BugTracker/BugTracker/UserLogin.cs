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
    public partial class UserLogin : Form
    {

        private GitHubClient gitClient;
        private Credentials basicAuth;
        private User gitUser;

        public UserLogin()
        {
            InitializeComponent();
            gitClient = new GitHubClient(new ProductHeaderValue("my-cool-app"));
        }

        private async void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                basicAuth = new Credentials(User_Text.Text, Pass_Text.Text);
                gitClient.Credentials = basicAuth;
                gitUser = await gitClient.User.Current();

                Main main = new Main(gitUser, gitClient);
                main.Show();
            }
            catch (AuthorizationException loginError)
            {
                MessageBox.Show("Incorrect Login");
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void User_Text_Click(object sender, EventArgs e)
        {
            User_Text.Text = "";
        }

        private void Pass_Text_Click(object sender, EventArgs e)
        {
            Pass_Text.UseSystemPasswordChar = true;
            Pass_Text.Text = "";
        }
    }
}
