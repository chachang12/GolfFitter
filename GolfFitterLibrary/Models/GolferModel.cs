using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using GolfFitterLibrary;

namespace GolfFitterLibrary.Models
{
    public class GolferModel
    {
        /// <summary>
        /// Represents the First Name of the Golfer.
        /// </summary>
        public string First_Name { get; set; }

        /// <summary>
        /// Represents the Last Name of the Golfer.
        /// </summary>
        public string Last_Name { get; set; }

        /// <summary>
        /// Represents a List of other Golfer objects that are associated with the current user. 
        /// </summary>
        public List<GolferModel> Golfer_Friends { get; set; }

        /// <summary>
        /// Represents a List of Equipment that a Golfer currently has in his bag.
        /// </summary>
        public GolfBagModel Golfer_Bag { get; set; }

        /// <summary>
        /// Represents the average metrics that a Golfer has, such as Handicap Score or Ball Speed. 
        /// </summary>
        public List<StatisticModel> Golfer_Stats { get; set; } = new List<StatisticModel>();

        /// <summary>
        /// Represents the email address that may be used to send promotions or other data. Format must include an @ and '.com'.
        /// </summary>
        public string EmailAddress { get; set; }


    }
}
