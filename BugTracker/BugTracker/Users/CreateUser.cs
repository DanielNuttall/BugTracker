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

namespace BugTracker.Users
{
    public partial class CreateUser : Form
    {
        private string userId;
        private string uName;
        private string uPass;
        private string uType;

        public CreateUser()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            uName = userNameValue.Text;
            uPass = passwordValue.Text;
            uType = userTypeValue.Text;

            cUser();
        }

        private void cUser()
        {
            SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dan30\Source\Repos\BugTracker\BugTracker\Database\Data.mdf;Integrated Security=True;Connect Timeout=30");

            SqlCommand sda = new SqlCommand("INSERT INTO Users(UserName, Password, UserType) VALUES(@UserName, @Password, @UserType)", connect);
            sda.Parameters.AddWithValue("@UserName", uName);
            sda.Parameters.AddWithValue("@Password", uPass);
            sda.Parameters.AddWithValue("@UserType", uType);

            connect.Open();
            sda.ExecuteNonQuery();
            connect.Close();

            MessageBox.Show("User Created");
            ((Main)this.MdiParent).openUsers();
            this.Close();
        }
    }
}
