using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GolfFitterLibrary.Models;
using GolfFitterLibrary;
using GolfFitterLibrary.Models.ClubComponents;

namespace GolfFitterLibrary.DataBaseAccess
{
    public interface IDataConnection
    {
        GolferLoginModel CreateUser(GolferLoginModel model);

        ShotDataModel NewShot(ShotDataModel model);

        List<ClubShaftModel> GetShaft();

        List<ClubHeadModel> GetHead();

        ClubModel NewClub(ClubModel model);

        List<GolferLoginModel> GetLogins();

        List<ClubModel> ClubInBag(int num);

        List<ExtendedClubModel> GetExtendedClub(int num);

        int GetSessionID();

        SessionModel NewSession(SessionModel ns);

        List<ShotDataModel> ShotsHit(int sid, int gid);

        StatisticModel DriverAverage(int gid);

        List<ShotDataModel> TotalShotsHit(int gid);

        GolferLoginModel GetUserInformation(int gid);

        List<ClubShaftModel> ShaftRecomendation(double chspeed, double launch);

        List<ClubHeadModel> HeadRecomendation(double avgspin);
    }
}
