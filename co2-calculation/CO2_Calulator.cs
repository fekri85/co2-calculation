using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace co2_calculation
{
    public class CO2_Calulator : ICO2_Calulator
    {
        private ICO2_Data _cO2_Data = new CO2_Data();
        /// <summary>
        /// CO2 Calculator
        /// </summary>
        /// <param name="tm">transportation method</param>
        /// <param name="d">distance</param>
        /// <param name="u">unit of distance km or m</param>
        /// <returns>CO2e in g</returns>
        public double Calc_CO2e(string tm, int d, string u = "km")
        {
            u = u.ToLower();
            if (u != "km" && u != "m")
                throw new ArgumentOutOfRangeException(MyKeys.__unit_of_distance);
            double d_in_km = u == "m" ? d / 1000 : d;
            return d_in_km * _cO2_Data.Get_CO2e_Per_Passenger_Per_km(tm);
        }
    }
}
