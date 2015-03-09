using LibrarySystem;
using MovieGenerator.Model;
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
        private DirectorList directorList;

        public AddMovie()
        {
            InitializeComponent();
            try
            {
                movieList = ServiceProvider.GetMovieService();
                directorList = ServiceProvider.GetDirectorService();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            movieList.Updated += new EventHandler(movieService_Update);
            directorList.Updated += new EventHandler(movieService_Update);
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

            lvwDirector.FullRowSelect = true;
            lvwDirector.GridLines = true;
            // Add Columns
            lvwDirector.Columns.Add("ID", -2, HorizontalAlignment.Left);
            lvwDirector.Columns.Add("Name", -2, HorizontalAlignment.Left);
            

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

            lvwDirector.Items.Clear();
            columns = new string[2];

            for (int i = 0; i < directorList.Count(); i++)
            {
                columns[0] = directorList.Get(i).ID.ToString();
                columns[1] = directorList.Get(i).Name;
                item = new ListViewItem(columns);
                lvwDirector.Items.Add(item);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
			movieList.Add(new Movie(tbxTitle.Text, Convert.ToInt32(tbxRuntime.Text), tbxGenre.Text, tbxDirector.Text, Convert.ToInt32(tbxAge.Text)));
		}


        private void btnAddDirector_Click(object sender, EventArgs e)
        {
            directorList.Add(new Director(tbxDirector.Text));
        }

		private void lvwDirector_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				string memberID = lvwDirector.SelectedItems[0].Text;

				Director director = directorList.Find(memberID);

				tbxDirector.Text = director.Name;
			}
			catch (Exception)
			{
				//MessageBox.Show("Fel...");
			}
		}
    }
}
