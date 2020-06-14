using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace co2_calculation
{
    class CO2_Data : ICO2_Data
    {
        /// <summary>
        /// key: Transportation method
        /// value: CO2e per passenger per km
        /// </summary>
        public Dictionary<string, short> TM_CO2e_Dic { get; set; }

        public CO2_Data()
        {
            Fill_Trans_Data();
        }

        private void Fill_Trans_Data()
        {
            TM_CO2e_Dic = new Dictionary<string, short>();
            TM_CO2e_Dic.Add("small-diesel-car", 142);
            TM_CO2e_Dic.Add("small-petrol-car", 154);
            TM_CO2e_Dic.Add("small-plugin-hybrid-car", 73);
            TM_CO2e_Dic.Add("small-electric-car", 50);
            TM_CO2e_Dic.Add("medium-diesel-car", 171);
            TM_CO2e_Dic.Add("medium-petrol-car", 192);
            TM_CO2e_Dic.Add("medium-plugin-hybrid-car", 110);
            TM_CO2e_Dic.Add("medium-electric-car", 58);
            TM_CO2e_Dic.Add("large-diesel-car", 209);
            TM_CO2e_Dic.Add("large-petrol-car", 282);
            TM_CO2e_Dic.Add("large-plugin-hybrid-car", 126);
            TM_CO2e_Dic.Add("large-electric-car", 73);
            TM_CO2e_Dic.Add("bus", 27);
            TM_CO2e_Dic.Add("train", 6);

        }

        public short Get_CO2e_Per_Passenger_Per_km(string transMethod)
        {
            var tm = transMethod.ToLower();
            if (!TM_CO2e_Dic.ContainsKey(tm))
                throw new ArgumentOutOfRangeException(MyKeys.__transportation_method);
            return TM_CO2e_Dic[tm];
        }

    }

}
