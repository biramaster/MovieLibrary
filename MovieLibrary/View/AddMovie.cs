using LibrarySystem;
using MovieGenerator.Model;
using MovieLibrary.Controll;
using MovieLibrary.Model;
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
        private MovieCopyList movieCopyList;

        public AddMovie()
        {
            InitializeComponent();
            try
            {
                movieList = ServiceProvider.GetMovieService();
                directorList = ServiceProvider.GetDirectorService();
                movieCopyList = ServiceProvider.GetMovieCopyService();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            movieList.Updated += new EventHandler(movieService_Update);
            directorList.Updated += new EventHandler(movieService_Update);
            movieCopyList.Updated += new EventHandler(MoviCopyService_Update);

            initListView();
        }

        private void MoviCopyService_Update(object sender, EventArgs e)
        {
            updateListViewMoviCopy();
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

            lvwMovieCopy.FullRowSelect = true;
            lvwMovieCopy.GridLines = true;
            // Add Columns
            lvwMovieCopy.Columns.Add("ID", -2, HorizontalAlignment.Left);
            lvwMovieCopy.Columns.Add("Title", -2, HorizontalAlignment.Left);
            lvwMovieCopy.Columns.Add("Director", -2, HorizontalAlignment.Left);

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
            movieList.Add(new Movie(tbxTitle.Text, Convert.ToInt32(tbxRuntime.Text), tbxGenre.Text, lvwDirector.SelectedItems., Convert.ToInt32(tbxAge.Text)));
		}


        private void btnAddDirector_Click(object sender, EventArgs e)
        {
            directorList.Add(new Director(tbxDirector.Text));
        }

		private void lvwDirector_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				string directorID = lvwDirector.SelectedItems[0].Text;

                Director director = directorList.Find(directorID);

				tbxDirector.Text = director.Name;
			}
			catch (Exception)
			{
				//MessageBox.Show("Fel...");
			}
		}

        private void lvwMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string movieID = lvwMovie.SelectedItems[0].Text;

                Movie movie = movieList.Find(movieID);

                tbxTitle.Text = movie.getTitle();
                tbxGenre.Text = movie.getGenre();
                tbxRuntime.Text = movie.getTime().ToString();
                tbxDirector.Text = movie.getDirector();
                tbxAge.Text = movie.getAge().ToString();

                lblMovieCopy.Text = "Movie Copies ID:" + movieID;

                updateListViewMoviCopy();
            }
            catch (Exception)
            {
                //MessageBox.Show("Fel...");
            }

        }

        private void updateListViewMoviCopy()
        {
            string[] movieID = lblMovieCopy.Text.Split(':');
            Movie movie;
            lvwMovieCopy.Items.Clear();
            string[] columns = new string[3];
            ListViewItem item;
            for (int i = 0; i < movieCopyList.Count(); i++)
            {
                if (movieCopyList.Get(i).ID.ToString() == movieID[1])
                {
                    movie = movieList.Find(movieCopyList.Get(i).ID.ToString());
                    columns[0] = movieCopyList.Get(i).FilmId.ToString();
                    columns[1] = movie.getTitle();
                    columns[2] = movie.getDirector();
                    item = new ListViewItem(columns);
                    lvwMovieCopy.Items.Add(item);
                }
            }
            
        }

        private void btnAddCopy_Click(object sender, EventArgs e)
        {
            string[] movieID = lblMovieCopy.Text.Split(':');

            Movie movie = movieList.Find(movieID[1]);

            if (movie == null)
            {
                throw new CustomException("Can't Find movie. You need to select a movie to create a copy.");
            }

            movieCopyList.Add(new MovieCopy(Convert.ToInt32(movieID[1])));
        }
    }
}
