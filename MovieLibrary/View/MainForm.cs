using LibrarySystem;
using MovieLibrary.Controll;
using MovieLibrary.DAL;
using MovieLibrary.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieLibrary.View
{
    public partial class MainForm : Form
    {
        private MemberList memberList;
        private MovieList movieList;
        private MovieCopyList movieCopyList;
        private LoanList loanList;
        private DirectorList directorList;
        public MainForm()
        {
            InitializeComponent();
            try
            {
                memberList = ServiceProvider.GetMemberService();
                movieList = ServiceProvider.GetMovieService();
                movieCopyList = ServiceProvider.GetMovieCopyService();
                directorList = ServiceProvider.GetDirectorService();
                //loanList = ServiceProvider.GetLoanService();   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void addNewMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMovie am = new AddMovie();
            am.Show();
        }

        private void addNewCopiesOfAMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMovie addMovie = new AddMovie();
            addMovie.Show();
        }

        private void addANewMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMember addMember = new AddMember();
            addMember.Show();
        }

        private void addANewLoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMember addMember = new AddMember();
            addMember.Show();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
			try
			{
				if (File.Exists("DirectorLista.DAT"))
				{
					if (AskAQuestion("DirectorLista.DAT File exist.\nAre You sure you want to replace it?"))
						ServiceProvider.GetDirectorService().BinarySerialize();
                }
                else
                {
                    ServiceProvider.GetDirectorService().BinarySerialize();
                }


				if (File.Exists("MovieLista.DAT"))
				{
					if (AskAQuestion("MovieLista.DAT File exist.\nAre You sure you want to replace it?"))
						ServiceProvider.GetMovieService().BinarySerialize();
				}
                else
                {
                    ServiceProvider.GetMovieService().BinarySerialize();
                }

                if (File.Exists("MovieCopyLista.DAT"))
                {
                    if (AskAQuestion("MovieCopyLista.DAT File exist.\nAre You sure you want to replace it?"))
                        ServiceProvider.GetMovieCopyService().BinarySerialize();
                }
                else
                {
                    ServiceProvider.GetMovieCopyService().BinarySerialize();
                }

                if (File.Exists("MemberLista.DAT"))
                {
                    if (AskAQuestion("MemberLista.DAT File exist.\nAre You sure you want to replace it?"))
                        ServiceProvider.GetMemberService().BinarySerialize();
                }
                else
                {
                    ServiceProvider.GetMemberService().BinarySerialize();
                }

                if (File.Exists("LoanLista.DAT"))
                {
                    if (AskAQuestion("LoanLista.DAT File exist.\nAre You sure you want to replace it?"))
                        ServiceProvider.GetLoanService().BinarySerialize();
                }
                else
                {
                    ServiceProvider.GetLoanService().BinarySerialize();
                }
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
            
        }


        private bool AskAQuestion(string question)
        {
            DialogResult dialogResult = MessageBox.Show(question, "Important", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void memberToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DatabaseEx2 dba = new DatabaseEx2();
            dba.Show();
        }

        private void saveToADatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
        }

        private void saveAllDirectorsToADatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void saveToDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataAccessLayerDBA dal = null;
            try
            {
                dal = new DataAccessLayerDBA();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            try
            {
                
                dal.SaveDirectorToDatabase();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            try
            {
                dal.SaveMoviesToDatabase();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            try
            {
                dal.SaveMemberToDatabase();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void readFromDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                directorList.ReadFromDatabase();
                movieList.ReadFromDatabase();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
