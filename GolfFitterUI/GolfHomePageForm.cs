using GolfFitterLibrary;
using GolfFitterLibrary.Models;
using GolfFitterUI;

namespace GolfTrackerUI
{
    public partial class GolfHomePageForm : Form
    {
        public GolferLoginModel LoginModel { get; set; }

        public GolfHomePageForm(GolferLoginModel GolferUserName)
        {
            LoginModel = GolferUserName;
            InitializeComponent();
        }

        private void GolfHomePageForm_Load(object sender, EventArgs e)
        {

            usernamelabel.Text = LoginModel.UserName;

        }

        private void mybagbutton_Click(object sender, EventArgs e)
        {
            MyBagForm myBagForm = new MyBagForm();
            myBagForm.ShowDialog();
        }
        public static int sesID = GlobalConfig.Connection.GetSessionID();
        private void newsessionbutton_Click(object sender, EventArgs e)
        {
            ShotTrackerForm newShotTracker = new ShotTrackerForm();
            newShotTracker.ShowDialog();

            sesID = sesID + 1;
            SessionModel sesmodel = new SessionModel(sesID, Program.GolferUser.GolferID);
            GlobalConfig.Connection.NewSession(sesmodel);

        }

        private void mystatsbutton_Click(object sender, EventArgs e)
        {
            MyDataForm myDataForm = new MyDataForm();
            myDataForm.ShowDialog();
        }

        private void getfittedbutton_Click(object sender, EventArgs e)
        {
            ClubFitterForm clubFitterForm = new ClubFitterForm();
            clubFitterForm.ShowDialog();
        }
    }
}