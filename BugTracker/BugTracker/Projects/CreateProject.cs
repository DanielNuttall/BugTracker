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
        public CreateProject()
        {
            InitializeComponent();
        }

        private void projectsTitle_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string pName = projectNameValue.Text;
            string pDesc = projectDescValue.Text;
            string gitURL = gitURLValue.Text;
            string aValue = authorValue.Text;

            cProject(pName, pDesc, gitURL, aValue);
        }

        private void cProject(string pName, string pDesc, string gitURL, string aValue)
        {
            string CreatedDate = "10/10/10";
            string UpdatedDate = "10/10/10";
            SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dan30\Source\Repos\BugTracker\BugTracker\Database\Data.mdf;Integrated Security=True;Connect Timeout=30");
            // SqlCommand sda = new SqlCommand("INSERT INTO Project ('" + pName + "','" + pDesc + "','" + gitURL + "','" + aValue + "','" + CreatedDate + "','" + UpdatedDate + "')", connect);

            SqlCommand sda = new SqlCommand("INSERT INTO Project(Name, Description, RepositoryId, AuthorId, CreatedDate, UpdatedDate) VALUES(@Name, @Description, @RepositoryId, @AuthorId, @CreatedDate, @UpdatedDate)", connect);
            sda.Parameters.AddWithValue("@Name", pName);
            sda.Parameters.AddWithValue("@Description", pDesc);
            sda.Parameters.AddWithValue("@RepositoryId", gitURL);
            sda.Parameters.AddWithValue("@AuthorId", aValue);
            sda.Parameters.AddWithValue("@CreatedDate", CreatedDate);
            sda.Parameters.AddWithValue("@UpdatedDate", UpdatedDate);
            
            connect.Open();
            sda.ExecuteNonQuery();
            connect.Close();

            this.Close();
        }

        private void CreateProject_Load(object sender, EventArgs e)
        {
            
        }
    }
}