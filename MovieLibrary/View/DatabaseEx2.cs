using MovieLibrary.DAL;
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
    public partial class DatabaseEx2 : Form
    {
        DataAccessLayerDBA dalDB;

        public DatabaseEx2()
        {
            InitializeComponent();
            dalDB = new DataAccessLayerDBA();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dalDB.getMoviesAdapter();
            dataGridView1.Update();
            dataGridView1.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter ds = dalDB.getMoviesAdapter();

            // ändrad

        }
    }
}
