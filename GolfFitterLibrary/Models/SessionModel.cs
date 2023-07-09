using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfFitterLibrary.Models
{
    public class SessionModel
    {
        public int SessionID { get; set; }

        public int GolferID { get; set; }



        public SessionModel()
        {

        }

        public SessionModel(int sesID, int gid)
        {
            SessionID = sesID;
            GolferID = gid;

        }

    }

    
}
