using GolfFitterLibrary.Models.ClubComponents;
using GolfFitterLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using GolfTrackerUI;


namespace GolfFitterUI
{
    
    public partial class ClubBuilderForm : Form
    {

        

        private List<string> clubTypes = new List<string>(new string[] { "Driver", "Wood", "Hybrid", "Iron", "Wedge", "Putter" });

        private List<ClubHeadModel> clubHeads = GlobalConfig.Connection.GetHead();
        private List<ClubShaftModel> clubShafts = GlobalConfig.Connection.GetShaft();

        public ClubBuilderForm()
        {
            InitializeComponent();

            //SampleData();

            ListConnector();
        }



        private void SampleData()
        {

            clubHeads.Add(new ClubHeadModel { Brand = "Taylormade", CHModel = "Stealth", Loft = 10.5 });
            //clubHeads.Add(new ClubHeadModel ("Taylormade","Stealth",10.5 ));
            //clubShafts.Add(new ClubShaftModel ("Fujikura", "Ventus", "Blue", "S", 70.0 ));
            clubShafts.Add(new ClubShaftModel { ShaftModel = "Ventus", ShaftBrand = "Fujikura", Flex = "S", Weight = 60.0, ShaftSpec = "Blue" });
        }

        private void ListConnector()
        {
            //Clearing Combo Box
            HeadComboBox.DataSource = null;

            HeadComboBox.DataSource = clubHeads;
            HeadComboBox.DisplayMember = "GolfHead";

            //Clearing Combo Box
            ShaftComboBox.DataSource = null;

            ShaftComboBox.DataSource = clubShafts;
            ShaftComboBox.DisplayMember = "GolfShaft";

            ClubTypeComboBox.DataSource = null;
            ClubTypeComboBox.DataSource = clubTypes;


        }


        private void AddClubButton_Click(object sender, EventArgs e)
        {


            ClubHeadModel h = (ClubHeadModel)HeadComboBox.SelectedItem;
            ClubShaftModel s = (ClubShaftModel)ShaftComboBox.SelectedItem;
            string c = (string)ClubTypeComboBox.SelectedItem;

            int cid = h.ClubHeadID;
            int sid = s.ShaftID;
            int gid = Program.GolferUser.GolferID;
            
            //Adds ShaftID and ClubHeadID to the database. 
            ClubModel model = new ClubModel(c, cid, sid, gid);
            GlobalConfig.Connection.NewClub(model);

            string clubmodelstr = h.CHModel + s.ShaftModel;
            MyBagForm mbform1 = new MyBagForm();
            mbform1.Show();
            this.Close();



        }

        public string ClubText
        {
            get { return ((ClubHeadModel)HeadComboBox.SelectedItem).CHModel; }
        }

        private void ClubBuilderForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
