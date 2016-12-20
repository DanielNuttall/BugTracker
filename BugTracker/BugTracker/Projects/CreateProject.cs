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
    public partial class CreateProject : Form
    {
        private string userId;
        private string pName;
        private string pDesc;
        private string gURL;
        private string createdDate;
        private string updatedDate;

        public CreateProject(string userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void Submit_Click(object sender, EventArgs e)
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
            ((Main)this.MdiParent).openProject(userId);
            this.Close();
        }

    }
}