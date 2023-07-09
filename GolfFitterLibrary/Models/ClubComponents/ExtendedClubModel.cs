using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfFitterLibrary.Models.ClubComponents
{
    public class ExtendedClubModel
    {
        public int ClubID { get; set; }

        public int ClubHeadID { get; set; }

        public int ShaftID { get; set; }

        public string ShaftModel { get; set; }

        public string ShaftBrand { get; set; }

        public string Flex { get; set; }

        public double Weight { get; set; }

        public string ShaftSpec { get; set; }

        public string Brand { get; set; }

        public string CHModel { get; set; }

        public double Loft { get; set; }


        public string ExtClub
        {
            get
            {
                return $"{CHModel} {Loft} {ShaftModel} {Flex}";
            }
        }

    }


}
