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
using GolfFitterLibrary.Models;

namespace GolfFitterUI
{
    public partial class ClubFitterForm : Form
    {

        private List<string> clubTypes = new List<string>(new string[] { "Driver", "Wood", "Hybrid", "Iron", "Wedge", "Putter" });

        private GolferLoginModel golfer = GlobalConfig.Connection.GetUserInformation(Program.GolferUser.GolferID);

        private static StatisticModel stats = GlobalConfig.Connection.DriverAverage(Program.GolferUser.GolferID);

        private List<ClubShaftModel> recshafts = GlobalConfig.Connection.ShaftRecomendation(stats.AVGClubHeadSpeed, stats.LaunchAngle);

        private List<ClubHeadModel> recheads = GlobalConfig.Connection.HeadRecomendation(stats.SpinRate);
        public ClubFitterForm()
        {
            InitializeComponent();
        }

        

        private void ClubFitterForm_Load(object sender, EventArgs e)
        {
            usernamelabel.Text = golfer.UserName;
            handicaplabel.Text = golfer.Handicap.ToString();
            avgballspeedlabel.Text = stats.AVGClubHeadSpeed.ToString();
            avgspinlabel.Text = stats.SpinRate.ToString();



        }



        private void fitmebutton_Click(object sender, EventArgs e)
        {
            foreach (ClubShaftModel obj in recshafts)
            {
                ListViewItem item = new ListViewItem(obj.ShaftModel.ToString());
                item.SubItems.Add(obj.ShaftBrand.ToString());
                item.SubItems.Add(obj.Flex.ToString());
                item.SubItems.Add(obj.Weight.ToString());
                item.SubItems.Add(obj.ShaftSpec.ToString());

                listView2.Items.Add(item);
            }

            foreach (ClubHeadModel obj in recheads)
            {
                ListViewItem item = new ListViewItem(obj.Brand.ToString());
                item.SubItems.Add(obj.CHModel.ToString());
                item.SubItems.Add(obj.Loft.ToString());

                listView1.Items.Add(item);
            }

        }
    }
}
