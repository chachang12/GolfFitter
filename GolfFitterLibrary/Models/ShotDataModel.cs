using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfFitterLibrary.Models
{
    public class ShotDataModel
    {
        public int ShotID { get; set; }

        public int GolferID { get; set; }

        public double BallSpeed { get; set; }

        public double ClubHeadSpeed { get; set; }

        public double LaunchAngle { get; set; }

        public double SpinRate { get; set; }

        public int SessionID { get; set; }

        public int ClubID { get; set; }

        public ShotDataModel()
        {

        }
        public ShotDataModel(double bspeed, double chspeed, double langle, double srate, int sesID, int gid, int cID)
        {
            BallSpeed = bspeed;
            ClubHeadSpeed = chspeed;
            LaunchAngle = langle;
            SpinRate = srate;
            SessionID = sesID;
            GolferID = gid;
            ClubID = cID;
        }

    }

    
}
