using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfFitterLibrary//.Models.ClubComponents
{
    public class ClubHeadModel
    {
       
        public int ClubHeadID { get; set; }

        public string Brand { get; set; }

        public string CHModel { get; set; }

        public double Loft { get; set; }


        public ClubHeadModel()
        {
            
        }

        public ClubHeadModel(string chBrand, string chName, double chLoft)
        {
            Brand = chBrand;
            CHModel = chName;
            Loft = chLoft;

        }

        public string GolfHead
        {
            get
            {
                return $"{Brand} {CHModel} {Loft}";
            }
        }
    }

}
