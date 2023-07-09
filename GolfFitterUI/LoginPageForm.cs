using GolfFitterLibrary;
using GolfFitterLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GolfTrackerUI
{
    public partial class LoginPageForm : Form
    {

        private List<GolferLoginModel> golferLogins = GlobalConfig.Connection.GetLogins();

        public LoginPageForm()
        {
            InitializeComponent();
        }
        

        public void loginbutton_Click(object sender, EventArgs e)
        {
            string username = usernamebox.Text;
            string password = passwordbox.Text;

            foreach (GolferLoginModel user in golferLogins)
            {
                if (username == user.UserName && password == user.Password)
                {
                    Program.GolferUser = user;

                    DialogResult = DialogResult.OK;
                    
                    this.Close();
                }
            }
        }



        private void newUserButton_Click(object sender, EventArgs e)
        {
            NewUserForm newUserForm = new NewUserForm();
            newUserForm.ShowDialog();
            this.Refresh();
        }

    }
}
