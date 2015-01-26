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
    }
}
