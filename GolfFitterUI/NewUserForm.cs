using GolfFitterLibrary.DataBaseAccess;
using GolfFitterLibrary.Models;
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

namespace GolfTrackerUI
{
    public partial class NewUserForm : Form
    {
        public NewUserForm()
        {
            InitializeComponent();
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                GolferLoginModel model = new GolferLoginModel(usernamebox.Text, passwordbox.Text, FirstNameBox.Text, LastNameBox.Text, EmailBox.Text, HandicapBox.Text);

                GlobalConfig.Connection.CreateUser(model);


                usernamebox.Text = "";
                passwordbox.Text = "";
                FirstNameBox.Text = "";
                LastNameBox.Text = "";
                EmailBox.Text = "";
                HandicapBox.Text = "";

                MessageBox.Show("Account creation successful, returning to login.");

                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid fields. Please check entered information and try again.");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;

            if (usernamebox.Text.Length == 0)
            {
                output = false;
            }

            if (passwordbox.Text.Length == 0)
            {
                output = false;
            }

            if (FirstNameBox.Text.Length == 0)
            {
                output = false;
            }

            if (LastNameBox.Text.Length == 0)
            {
                output = false;
            }

            if (EmailBox.Text.Length == 0)
            {
                output = false;
            }

            double handicapVal = 0;
            bool handicapValid = double.TryParse(HandicapBox.Text, out handicapVal);

            if (handicapValid == false)
            {
                output = false;
            }

            if (HandicapBox.Text.Length == 0)
            {
                output = false;
            }
            return output;


        }


    }
}
