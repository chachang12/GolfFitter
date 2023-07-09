using GolfFitterLibrary;
using GolfFitterUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GolfFitterLibrary.Models.ClubComponents;

namespace GolfTrackerUI
{
    public partial class MyBagForm : Form
    {

        private List<ExtendedClubModel> clubs = GlobalConfig.Connection.GetExtendedClub(Program.GolferUser.GolferID);


        public MyBagForm()
        {
            InitializeComponent();
            WireUpLists();
        }

        private void WireUpLists()
        {
            myclubslistbox.DataSource = clubs;
            myclubslistbox.DisplayMember = "ExtClub";

        }

        private void MyBagForm_Load(object sender, EventArgs e)
        {

        }

        private void createclubbuttoon_Click(object sender, EventArgs e)
        {
            ClubBuilderForm clubBuilderForm = new ClubBuilderForm();
            this.Close();
            clubBuilderForm.ShowDialog();
            
        }
    }
}
