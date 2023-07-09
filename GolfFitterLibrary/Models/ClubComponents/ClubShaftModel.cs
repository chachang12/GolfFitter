using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfFitterLibrary.Models.ClubComponents
{
    public class ClubShaftModel
    {
        public int ShaftID { get; set; }

        public string ShaftModel { get; set; }

        public string ShaftBrand { get; set; }

        public string Flex { get; set; }

        // TODO - Potentially Add ENUM to Shaft Flex for A, R, S, X instead of just strings, less room for error. 
        public double Weight { get; set; }

        public string ShaftSpec { get; set; }


        //Overloaded Constructor for Dapper
        public ClubShaftModel()
        {
            
        }

        public ClubShaftModel(string csBrand, string csName, string csSpec, string csFlex, double csWeight)
        {
            ShaftBrand = csBrand;
            ShaftModel = csName;
            ShaftSpec = csSpec;
            Flex = csFlex;
            Weight = csWeight;
            
            

        }

        public string GolfShaft
        {
            get
            {
                return $"{ShaftBrand} {ShaftModel} {ShaftSpec} {Flex} {Weight}";
            }
        }
    }
}
