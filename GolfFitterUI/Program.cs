using GolfFitterLibrary.Models;
using GolfFitterUI;

namespace GolfTrackerUI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 

        public static GolferLoginModel GolferUser;

        [STAThread]


        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            

            // Initialize the database connections
            GolfFitterLibrary.GlobalConfig.InitializeConnections(true);

            //Application.Run(new LoginPageForm());


            LoginPageForm loginPageForm = new LoginPageForm();
            DialogResult result = loginPageForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                Application.Run(new GolfHomePageForm(GolferUser));
            }
            else
            {
                Application.Exit();
            }

           
        }
    }
}