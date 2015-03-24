using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieLibrary.View
{
    public partial class DatabaseEx1 : Form
    {
        public DatabaseEx1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*SqlConnection sqlConnect = new SqlConnection();
            sqlConnect.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\MovieLibrary.mdf;Integrated Security=True";

            sqlConnect.Open();

            String sqlCmdString = "Select * from Director";

            SqlCommand sqlCmd = new SqlCommand(sqlCmdString, sqlConnect);

            SqlDataReader dataReader = sqlCmd.EndExecuteReader();
            */


            this.directorTableAdapter.Update(this.movieLibraryDataSet.Director);
                

        }

        private void DatabaseEx1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieLibraryDataSet.Director' table. You can move, or remove it, as needed.
            this.directorTableAdapter.Fill(this.movieLibraryDataSet.Director);

        }
    }
}
