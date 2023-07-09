using GolfFitterLibrary;
using GolfFitterLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GolfTrackerUI
{
    public partial class MyDataForm : Form
    {
        private StatisticModel avgstats = GlobalConfig.Connection.DriverAverage(Program.GolferUser.GolferID);
        // List<StatisticModel> stats = GlobalConfig.Connection.DriverAverage(Program.GolferUser.GolferID);
        private List<ShotDataModel> previousshots = GlobalConfig.Connection.TotalShotsHit(Program.GolferUser.GolferID);


        public MyDataForm()
        {
            InitializeComponent();
        }



        private void MyDataForm_Load(object sender, EventArgs e)
        {

            avgballspeed.Text = avgstats.AVGBallSpeed.ToString();
            avgclubheadspeed.Text = avgstats.AVGClubHeadSpeed.ToString();
            avglaunchangle.Text = avgstats.LaunchAngle.ToString();
            avgspinrate.Text = avgstats.SpinRate.ToString();

            foreach (ShotDataModel obj in previousshots)
            {
                ListViewItem item = new ListViewItem(obj.BallSpeed.ToString());
                item.SubItems.Add(obj.ClubHeadSpeed.ToString());
                item.SubItems.Add(obj.LaunchAngle.ToString());
                item.SubItems.Add(obj.SpinRate.ToString());

                previousshotsview.Items.Add(item);
            }
        }
    }
}
