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
    public partial class Users : Form
    {
        private string userId;
        private string uName;
        private string uPass;
        private string uType;

        public Users()
        {
            InitializeComponent();
            getUsers();
        }

        private void getUsers()
        {
            SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dan30\Source\Repos\BugTracker\BugTracker\Database\Data.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select * From Users", connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            userId = dataGridView1.SelectedCells[0].Value.ToString();
            userNameValue.Text = dataGridView1.SelectedCells[1].Value.ToString();
            passwordValue.Text = dataGridView1.SelectedCells[2].Value.ToString();
            userTypeValue.Text = dataGridView1.SelectedCells[3].Value.ToString();
        }

        private void upDate_Click(object sender, EventArgs e)
        {
            userId = userId;
            uName = userNameValue.Text.ToString();
            uPass = passwordValue.Text.ToString();
            uType = userTypeValue.Text.ToString();

            SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dan30\Source\Repos\BugTracker\BugTracker\Database\Data.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand sda = new SqlCommand("UPDATE Users SET userName = @uName, Password = @uPass, UserType = @uType WHERE Id = @userId", connect);

            sda.Parameters.AddWithValue("@userId", userId);
            sda.Parameters.AddWithValue("@uName", uName);
            sda.Parameters.AddWithValue("@uPass", uPass);
            sda.Parameters.AddWithValue("@uType", uType);

            connect.Open();
            sda.ExecuteNonQuery();
            connect.Close();

            getUsers();
        }

        private void createProject_Click(object sender, EventArgs e)
        {
            uName = userNameValue.Text.ToString();
            uPass = passwordValue.Text.ToString();
            uType = userTypeValue.Text.ToString();

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
            getUsers();
        }

    }
}
