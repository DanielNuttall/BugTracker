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

namespace BugTracker.Projects
{
    public partial class Projects : Form
    {
        private string userId;
        private string projectId;
        private string pName;
        private string pDesc;
        private string gURL;
        private string createdDate;
        private string updatedDate;


        public Projects(String userId)
        {
            InitializeComponent();
            this.userId = userId;
            getProjects();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void getProjects()
        {
            SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dan30\Source\Repos\BugTracker\BugTracker\Database\Data.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select * From Project where AuthorId = '" + userId + "'", connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            projectId = dataGridView1.SelectedCells[0].Value.ToString();
            projectNameValue.Text = dataGridView1.SelectedCells[1].Value.ToString();
            projectDescValue.Text = dataGridView1.SelectedCells[2].Value.ToString();
            gitURLValue.Text = dataGridView1.SelectedCells[3].Value.ToString();
        }

        private void upDate_Click(object sender, EventArgs e)
        {

            pName = projectNameValue.Text.ToString();
            pDesc = projectDescValue.Text.ToString();
            gURL = gitURLValue.Text.ToString();
            updatedDate = DateTime.Today.ToString("d");

            SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dan30\Source\Repos\BugTracker\BugTracker\Database\Data.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand sda = new SqlCommand("UPDATE Project SET Name = @Name, Description = @Description, RepositoryId = @RepositoryId, UpdatedDate = @UpdatedDate WHERE projectId = @projectId", connect);

            sda.Parameters.AddWithValue("@projectId", projectId);
            sda.Parameters.AddWithValue("@Name", pName);
            sda.Parameters.AddWithValue("@Description", pDesc);
            sda.Parameters.AddWithValue("@RepositoryId", gURL);
            sda.Parameters.AddWithValue("@UpdatedDate", updatedDate);

            connect.Open();
            sda.ExecuteNonQuery();
            connect.Close();

            getProjects();
        }

        private void createProject_Click(object sender, EventArgs e)
        {
            pName = projectNameValue.Text;
            pDesc = projectDescValue.Text;
            gURL = gitURLValue.Text;
            createdDate = DateTime.Today.ToString("d");
            updatedDate = DateTime.Today.ToString("d");

            cProject();
        }

        private void cProject()
        {
            SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dan30\Source\Repos\BugTracker\BugTracker\Database\Data.mdf;Integrated Security=True;Connect Timeout=30");

            SqlCommand sda = new SqlCommand("INSERT INTO Project(Name, Description, RepositoryId, AuthorId, CreatedDate, UpdatedDate) VALUES(@Name, @Description, @RepositoryId, @AuthorId, @CreatedDate, @UpdatedDate)", connect);
            sda.Parameters.AddWithValue("@Name", pName);
            sda.Parameters.AddWithValue("@Description", pDesc);
            sda.Parameters.AddWithValue("@RepositoryId", gURL);
            sda.Parameters.AddWithValue("@AuthorId", userId);
            sda.Parameters.AddWithValue("@CreatedDate", createdDate);
            sda.Parameters.AddWithValue("@UpdatedDate", updatedDate);

            connect.Open();
            sda.ExecuteNonQuery();
            connect.Close();

            MessageBox.Show("Project Created");
            getProjects();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
