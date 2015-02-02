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

namespace MovieLibrary.View
{
    public partial class AddMember : Form
    {
		private MemberList memberLista;
        public AddMember()
        {
			try
			{
				memberLista = ServiceProvider.GetMemberService();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
			
            InitializeComponent();
            memberLista.Updated += new EventHandler(memberService_Update);
            initListView();

        }

		public void memberService_Update(object sender,EventArgs e)
        {
            updateListView();
        }

        private void addMemberbtn_Click(object sender, EventArgs e)
        {
            memberLista.Add(new Member(tbxPersonal.Text, tbxname.Text));
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
            
            updateListView();

        }

        private void updateListView()
        {
            lvwMember.Items.Clear();
            string[] columns = new string[3];
            ListViewItem item;
            for (int i = 0; i < memberLista.Count(); i++)
            {
                columns[0] = memberLista.Get(i).ID.ToString();
                columns[1] = memberLista.Get(i).PersonalID;
                columns[2] = memberLista.Get(i).Name;
                item = new ListViewItem(columns);
                lvwMember.Items.Add(item);
            }
        }

        private void lvwMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string memberID = lvwMember.SelectedItems[0].Text;

                Member member = memberLista.Find(memberID);

                tbxPersonal.Text = member.PersonalID;
                tbxname.Text = member.Name;
            }
            catch (Exception)
            {
                //MessageBox.Show("Fel...");
            }
        }

    }
}
