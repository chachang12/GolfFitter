using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using GolfFitterLibrary.Models;
using GolfFitterLibrary;
using GolfFitterLibrary.Models.ClubComponents;
using System.Reflection;
using System.Net.Http.Headers;
using System.Xml;

//@FirstName varchar(100),
//@LastName varchar(100),
//@Handicap numeric(3, 1),
//@UserName nvarchar(50),
//@Password nvarchar(50),
//@EmailAddress nvarchar(2000),
//@GolderID int = 0 output


namespace GolfFitterLibrary.DataBaseAccess
{
    public class SQLConnector : IDataConnection
    {
        // String that denotes the name of the database used for each IDBConnection.
        public const string DB = "ComputerCaddy";

        // TODO - Make the CreateUser method actually save user information to the database
        /// <summary>
        /// Saves a new user to the databse
        /// </summary>
        /// <param name="model">A user's username and password</param>
        /// <returns></returns>
        public GolferLoginModel CreateUser(GolferLoginModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(DB)))
            {
                var p = new DynamicParameters();
                p.Add("@FirstName", model.FirstName);
                p.Add("@LastName", model.LastName);
                p.Add("@Handicap", model.Handicap);
                p.Add("@UserName", model.UserName);
                p.Add("@Password", model.Password);
                p.Add("@EmailAddress", model.EmailAddress);
                p.Add("@GolferID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spUserGolfer_Insert", p, commandType: CommandType.StoredProcedure);

                model.GolferID = p.Get<int>("@GolferID");

                return model;

            }
        }

        public List<GolferLoginModel> GetLogins()
        {
            List<GolferLoginModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(DB)))
            {
                output = connection.Query<GolferLoginModel>("dbo.spGetLoginInfo").ToList();
            }

            return output;
        }

        // TODO - Get SQL Connection set up for pulling clubs
        /// <summary>
        /// Gets Shaft data from the database and imports it into a list. 
        /// </summary>
        /// <returns>The Shaft Brand, Model</returns>
        public List<ClubShaftModel> GetShaft()
        {
            List<ClubShaftModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(DB)))
            {
                output = connection.Query<ClubShaftModel>("dbo.spGetClubShaft").ToList();
            }

            return output;
        }

        /// <summary>
        /// Gets Head data from the database and imports it into a list. 
        /// </summary>
        /// <returns></returns>
        public List<ClubHeadModel> GetHead()
        {
            List<ClubHeadModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(DB)))
            {
                output = connection.Query<ClubHeadModel>("dbo.spGetClubHead").ToList();
            }

            return output;
        }

        


        /// <summary>
        /// Saves user inputed shot data into the database in the form of doubles(numerics) and an int(int).
        /// </summary>
        /// <param name="model">The ballspeed, clubspeed, launch angle, and spin rate of a given shot.</param>
        /// <returns></returns>
        public ShotDataModel NewShot(ShotDataModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(DB)))
            {
                var p = new DynamicParameters();
                p.Add("@BallSpeed", model.BallSpeed);
                p.Add("@ClubHeadSpeed", model.ClubHeadSpeed);
                p.Add("@LaunchAngle", model.LaunchAngle);
                p.Add("@SpinRate", model.SpinRate);
                p.Add("@SessionID", model.SessionID);
                p.Add("@ClubID", model.ClubID);
                p.Add("@GolferID", model.GolferID);
                p.Add("@ShotID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spShot_Insert", p, commandType: CommandType.StoredProcedure);

                model.ShotID = p.Get<int>("@ShotID");

                return model;

            }
        }


        /// <summary>
        /// Creates a club model in the Database that passes in the type of club, clubheadID, and clubshaftID.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ClubModel NewClub(ClubModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(DB)))
            {
                var p = new DynamicParameters();
                p.Add("@ClubType", model.Club_Type);
                p.Add("@ShaftID", model.ShaftID);
                p.Add("@ClubHeadID", model.ClubHeadID);
                p.Add("@GolferID", model.GolferID);
                //p.Add("@ClubID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spInsertShaftHeadID", p, commandType: CommandType.StoredProcedure);

                //model.ClubID = p.Get<int>("@ClubID");

                return model;

            }
        }





        
        public List<ClubModel> ClubInBag(int num)
        {
            List<ClubModel> output;
            int gid = num;
            var ids = new[] { gid };
            var sql = "SELECT * FROM dbo.Club WHERE dbo.Club.GolferID = @Ids";
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(DB)))
            {

                output = connection.Query<ClubModel>(sql, new {Ids = ids}).ToList();
            }

            return output;
        }

        public List<ExtendedClubModel> GetExtendedClub(int num)
        {
            List<ExtendedClubModel> output;
            int gid = num;
            var ids = new[] { gid };
            var sql = "select GolferID,dbo.Club.ClubID, dbo.ClubHead.ClubHeadID, dbo.Shaft.ShaftID, ShaftModel, ShaftBrand, Flex, Weight, ShaftSpec, Brand, CHModel, Loft\r\nfrom dbo.Club join dbo.Shaft  on dbo.Club.ShaftID = dbo.Shaft.ShaftID\r\njoin dbo.ClubHead on dbo.Club.ClubHeadID = dbo.ClubHead.ClubHeadID\r\nWHERE GolferID = @Ids;";
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(DB)))
            {

                output = connection.Query<ExtendedClubModel>(sql, new { Ids = ids }).ToList();
            }

            return output;
        }

        public int GetSessionID()
        {
            int output;
            var sql = "Select SessionID\r\nfrom dbo.Session\r\nWhere SessionID =(Select max(SessionID) from dbo.Session);";
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(DB)))
            {
                output = connection.QuerySingle<int>(sql);
            }

            return output;
        }

        public SessionModel NewSession(SessionModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(DB)))
            {
                var p = new DynamicParameters();
                p.Add("@SessionID", model.SessionID);
                p.Add("@GolferID", model.GolferID);
                

                connection.Execute("dbo.spNewSession", p, commandType: CommandType.StoredProcedure);

                return model;

            }
        }

        public List<ShotDataModel> ShotsHit(int sid, int gid)
        {
            List<ShotDataModel> output;
            int SID = sid;
            int GID = gid;
            var parameters = new { GID, SID };
            var sql = "SELECT * FROM dbo.Shot WHERE dbo.Shot.SessionID = @SID and dbo.Shot.GolferID = @GID";
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(DB)))
            {
                output = connection.Query<ShotDataModel>(sql, parameters).ToList();
            }

            return output;
        }

        public StatisticModel DriverAverage(int gid)
        {
            StatisticModel output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(DB)))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@GolferID", gid);

                output = connection.QuerySingle<StatisticModel>("dbo.spGetAverageData", parameters, commandType: CommandType.StoredProcedure);
            }

            return output;
        }

        public List<ShotDataModel> TotalShotsHit(int gid)
        {
            List<ShotDataModel> output;
            int GID = gid;
            var parameters = new { GID };
            var sql = "SELECT * FROM dbo.Shot WHERE dbo.Shot.GolferID = @GID";
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(DB)))
            {
                output = connection.Query<ShotDataModel>(sql, parameters).ToList();
            }

            return output;
        }

        public GolferLoginModel GetUserInformation(int gid)
        {
            GolferLoginModel output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(DB)))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@GolferID", gid);

                output = connection.QuerySingle<GolferLoginModel>("dbo.spGetUserInformation", parameters, commandType: CommandType.StoredProcedure);
            }

            return output;
        }

        public List<ClubShaftModel> ShaftRecomendation(double chspeed, double launch)
        {
            List<ClubShaftModel> output;
            string flex = "" ;
            if (chspeed < 70) 
            {
                flex = "A";
            }
            else if (chspeed < 80)
            {
                flex = "R";
            }
            else if (chspeed < 100)
            {
                flex = "S";
            }
            else if (chspeed > 100)
            {
                flex = "X";
            }

            string model = "";
            if (launch <12)
            {
                model = "Red";
            }
            if (launch < 18)
            {
                model = "Blue";
            }
            if (launch > 18)
            {
                model = "Black";
            }
            var parameters = new { flex, model };
            var sql = "SELECT * FROM dbo.Shaft WHERE dbo.Shaft.Flex = @flex and dbo.Shaft.ShaftSpec = @model";
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(DB)))
            {
                output = connection.Query<ClubShaftModel>(sql, parameters).ToList();
            }

            return output;
        }

        public List<ClubHeadModel> HeadRecomendation(double avgspin)
        {
            List<ClubHeadModel> output;
            double loft = 0.0;
            if (avgspin < 1600)
            {
                loft = 12.0;
            }
            else if (avgspin < 2000)
            {
                loft = 10.5;
            }
            else if (avgspin < 2500)
            {
                loft = 9.0;
            }
            else if (avgspin > 3000)
            {
                loft = 8.0;
            }

            var parameters = new { loft };
            var sql = "SELECT * FROM dbo.ClubHead WHERE dbo.ClubHead.Loft = @loft";
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(DB)))
            {
                output = connection.Query<ClubHeadModel>(sql, parameters).ToList();
            }

            return output;
        }

    }
}
