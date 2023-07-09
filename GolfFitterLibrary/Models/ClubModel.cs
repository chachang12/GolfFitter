using GolfFitterLibrary.Models.ClubComponents;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfFitterLibrary
{
    public class ClubModel
    {
        // TODO - POssible Enum for Driver, Wood, Hybrid, Iron, Wedge, Putter
        public int ClubID { get; set; }
        public string Club_Type { get; set; }
        public int ShaftID { get; set; }
        public int ClubHeadID { get; set; }
        public int GolferID { get; set; }

        // Overloaded Contructor
        public ClubModel()
        {
            
        }

        public ClubModel(string ctype, int chid, int csid, int gid)
        {
            Club_Type = ctype;
            ClubHeadID = chid;
            ShaftID = csid;
            GolferID = gid;

        }
        
         
        

        public string CompleteClub
        {
            get
            {
                return $"{ClubHeadID} with {ShaftID}";
            }
        }

    }
}
