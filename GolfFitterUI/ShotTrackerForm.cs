using GolfFitterLibrary.Models;
using GolfFitterLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GolfFitterLibrary.Models.ClubComponents;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GolfTrackerUI
{
    public partial class ShotTrackerForm : Form
    {

        private List<ExtendedClubModel> myClubs = GlobalConfig.Connection.GetExtendedClub(Program.GolferUser.GolferID);

        


        //public static int sesID = GlobalConfig.Connection.GetSessionID();
        int newsesID = GolfHomePageForm.sesID;


        private List<ShotDataModel> previousshots = GlobalConfig.Connection.ShotsHit(GolfHomePageForm.sesID, Program.GolferUser.GolferID);

        public ShotTrackerForm()
        {
            InitializeComponent();
            ListConnector();


        }


        private void UpdateBox()
        {
            foreach (ShotDataModel obj in previousshots)
            {
                ListViewItem item = new ListViewItem(obj.BallSpeed.ToString());
                item.SubItems.Add(obj.ClubHeadSpeed.ToString());
                item.SubItems.Add(obj.LaunchAngle.ToString());
                item.SubItems.Add(obj.SpinRate.ToString());

                previousshotsview.Items.Add(item);
            }
        }

        private void ListConnector()
        {
            ClubSelectComboBox.DataSource = myClubs;
            ClubSelectComboBox.DisplayMember = "ExtClub";

        }

        private void SaveShotButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                //ShotDataModel s = new ShotDataModel();

                //int newsesID = sesID += 1;


                double bsval;
                double.TryParse(BallSpeedBox.Text, out bsval);


                double csval;
                double.TryParse(ClubSpeedBox.Text, out csval);


                double laval;
                double.TryParse(LaunchBox.Text, out laval);


                double srval;
                double.TryParse(SpinBox.Text, out srval);

                int gid = Program.GolferUser.GolferID;

                ExtendedClubModel s2 = (ExtendedClubModel)ClubSelectComboBox.SelectedItem;
                int ecmID = s2.ClubID;

                ShotDataModel newShot = new ShotDataModel(bsval, csval, laval, srval, newsesID, gid, ecmID);
                GlobalConfig.Connection.NewShot(newShot);



                BallSpeedBox.Text = "";
                ClubSpeedBox.Text = "";
                LaunchBox.Text = "";
                SpinBox.Text = "";

                ListViewItem item = new ListViewItem(newShot.BallSpeed.ToString());
                item.SubItems.Add(newShot.ClubHeadSpeed.ToString());
                item.SubItems.Add(newShot.LaunchAngle.ToString());
                item.SubItems.Add(newShot.SpinRate.ToString());

                previousshotsview.Items.Add(item);
                previousshotsview.Refresh();


            }
            else
            {
                MessageBox.Show("Please enter valid numbers for all fields.");
            }
        }

        private bool ValidateForm()
        {

            

            bool output = true;
            double ballspeedvalue = 0;
            bool ballspeedValid = double.TryParse(BallSpeedBox.Text, out ballspeedvalue);

            if (myClubs.Count < 1)
            {
                output = false;
                MessageBox.Show("Please add a club to your bag first.");
            }

            if (ballspeedValid == false)
            {
                output = false;
            }

            if (BallSpeedBox.Text.Length == 0)
            {
                output = false;
            }

            double clubheadspeedvalue = 0;
            bool clubspeedValid = double.TryParse(BallSpeedBox.Text, out clubheadspeedvalue);

            if (clubspeedValid == false)
            {
                output = false;
            }

            if (ClubSpeedBox.Text.Length == 0)
            {
                output = false;
            }

            double launchanglevalue = 0;
            bool launchangleValid = double.TryParse(BallSpeedBox.Text, out launchanglevalue);

            if (launchangleValid == false)
            {
                output = false;
            }

            if (LaunchBox.Text.Length == 0)
            {
                output = false;
            }

            double spinratevalue = 0;
            bool spinrateValid = double.TryParse(BallSpeedBox.Text, out spinratevalue);

            if (spinrateValid == false)
            {
                output = false;
            }

            if (SpinBox.Text.Length == 0)
            {
                output = false;
            }
            return output;
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
