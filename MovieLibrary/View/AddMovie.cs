using LibrarySystem;
using MovieLibrary.Controll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieLibrary.View
{
    public partial class AddMovie : Form
    {
        private MovieList movieList;
        public AddMovie()
        {
            InitializeComponent();
            try
            {
                movieList = ServiceProvider.GetMovieService();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            movieList.Updated += new EventHandler(movieService_Update);
            initListView();
        }

        public void movieService_Update(object sender, EventArgs e)
        {
            updateListView();
        }

        private void initListView()
        {
            //         lvwMovie.View = View.Details;
            lvwMovie.FullRowSelect = true;
            lvwMovie.GridLines = true;
            // Add Columns
            lvwMovie.Columns.Add("ID", -2, HorizontalAlignment.Left);
            lvwMovie.Columns.Add("Title", -2, HorizontalAlignment.Left);
            lvwMovie.Columns.Add("Director", -2, HorizontalAlignment.Left);

            updateListView();

        }

        private void updateListView()
        {
            lvwMovie.Items.Clear();
            string[] columns = new string[3];
            ListViewItem item;
            for (int i = 0; i < movieList.Count(); i++)
            {
                columns[0] = movieList.Get(i).getId().ToString();
                columns[1] = movieList.Get(i).getTitle();
                columns[2] = movieList.Get(i).getDirector();
                item = new ListViewItem(columns);
                lvwMovie.Items.Add(item);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
