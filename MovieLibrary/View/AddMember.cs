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
using MovieLibrary.DAL;
using MovieGenerator.Model;

namespace MovieLibrary.View
{
    public partial class AddMember : Form
    {
		private MemberList memberList;
        private MovieList movieList;
        private MovieCopyList movieCopyList;

        public AddMember()
        {
			try
			{
				memberList = ServiceProvider.GetMemberService();
                movieList = ServiceProvider.GetMovieService();
                movieCopyList = ServiceProvider.GetMovieCopyService();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
			
            InitializeComponent();
            memberList.Updated += new EventHandler(memberService_Update);
            movieList.Updated += new EventHandler(memberService_Update);
            movieCopyList.Updated += new EventHandler(movieCopyService_Update);
            initListView();

        }

        public void movieCopyService_Update(object sender, EventArgs e)
        {
            updateListViewMoviCopy();
        }
        public void memberService_Update(object sender, EventArgs e)
        {
            updateListView();
        }

        private void addMemberbtn_Click(object sender, EventArgs e)
        {
            memberList.Add(new Member(tbxPersonal.Text, tbxname.Text));
        }

       

        private void initListView()
        {
            //         lvwMovie.View = View.Details;
            lvwMember.FullRowSelect = true;
            lvwMember.GridLines = true;
            // Add Columns
            lvwMember.Columns.Add("ID", -2, HorizontalAlignment.Left);
            lvwMember.Columns.Add("Personal nr", -2, HorizontalAlignment.Left);
            lvwMember.Columns.Add("Name", -2, HorizontalAlignment.Left);

            lvwMovie.FullRowSelect = true;
            lvwMovie.GridLines = true;
            // Add Columns
            lvwMovie.Columns.Add("ID", -2, HorizontalAlignment.Left);
            lvwMovie.Columns.Add("Title", -2, HorizontalAlignment.Left);
            lvwMovie.Columns.Add("Director", -2, HorizontalAlignment.Left);

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
            lvwMember.Items.Clear();
            string[] columns = new string[3];
            ListViewItem item;
            for (int i = 0; i < memberList.Count(); i++)
            {
                columns[0] = memberList.Get(i).ID.ToString();
                columns[1] = memberList.Get(i).PersonalID;
                columns[2] = memberList.Get(i).Name;
                item = new ListViewItem(columns);
                lvwMember.Items.Add(item);
            }

            lvwMovie.Items.Clear();
            for (int i = 0; i < movieList.Count(); i++)
            {
                columns[0] = movieList.Get(i).getId().ToString();
                columns[1] = movieList.Get(i).getTitle();
                Director director = ServiceProvider.GetDirectorService().Find(movieList.Get(i).getDirector());
                columns[2] = director.Name;
                item = new ListViewItem(columns);
                lvwMovie.Items.Add(item);
            }
        }

        private void lvwMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string memberID = lvwMember.SelectedItems[0].Text;

                Member member = memberList.Find(memberID);

                tbxPersonal.Text = member.PersonalID;
                tbxname.Text = member.Name;
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
                    // if not on loan
                    columns[0] = movieCopyList.Get(i).FilmId.ToString();
                    columns[1] = movie.getTitle();
                    Director director = ServiceProvider.GetDirectorService().Find(movie.getDirector());
                    columns[2] = director.Name;
                    item = new ListViewItem(columns);
                    lvwMovieCopy.Items.Add(item);
                }
            }

        }

        private void lvwMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string movieID = lvwMovie.SelectedItems[0].Text;

                lblMovieCopy.Text = "Available Movie Copies ID:" + movieID;

                updateListViewMoviCopy();
            }
            catch (Exception)
            {
                //MessageBox.Show("Fel...");
            }

        }

        private void btnAddLoan_Click(object sender, EventArgs e)
        {
           /* string[] movieID = lblSelectedMovieCopyID.Text.Split(':');
            Loan loan = LoanList.Find(movieID[0]);
            if(loan.isOnLoan())
            {
                throw new CustomException("This movie is on Loan");
            }
            else
            {

            }

            */
        }

        private void lvwMovieCopy_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string movieCopyID = lvwMovieCopy.SelectedItems[0].Text;
                lblSelectedMovieCopyID.Text = "Selected Copy ID:" + movieCopyID;
            }
            catch (Exception)
            {
                
                //throw;
            }
            
        }


    }
}
