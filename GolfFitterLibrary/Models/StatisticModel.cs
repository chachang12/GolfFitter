using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfFitterLibrary.Models
{
    public class StatisticModel
    {

        /// <summary>
        /// Average Ball Speed represents the average of all of a users tracked shots ball speed. 
        /// </summary>
        public double AVGBallSpeed { get; set; }

        public double AVGClubHeadSpeed { get; set; }

        public double LaunchAngle { get; set; }

        public int SpinRate { get; set; }

        public StatisticModel()
        {
            
        }

        public StatisticModel(double avgbs, double avgcs, double avgla, int avgsr)
        {
            AVGBallSpeed = avgbs;
            AVGClubHeadSpeed = avgcs;
            LaunchAngle = avgla;
            SpinRate = avgsr;
        }

        public string averageNumbers
        {
            get
            {
                return $"{AVGBallSpeed} {AVGClubHeadSpeed} {LaunchAngle} {SpinRate}";
            }
        
        }

    }


}
