using LibrarySystem;
using MovieLibrary.Controll;
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
        public MainForm()
        {
            InitializeComponent();
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

            
        }

        private void saveMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("MemberLista.DAT"))
                {
                    if (AskAQuestion("MemberLista.DAT File exist.\nAre You sure you want to replace it?"))
                        ServiceProvider.GetMemberService().BinarySerialize();
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
    }
}
