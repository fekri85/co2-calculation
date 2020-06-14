using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace co2_calculation
{
    public class CO2ePresenter : ICO2ePresenter
    {
        public void Show(double co2e_in_g, string output)
        {
            output = output.ToLower();
            if (output != "kg" && output != "g")
                throw new ArgumentOutOfRangeException(MyKeys.__output);
            string co2e = $"{(output == "kg" ? co2e_in_g / 1000 : co2e_in_g)}{output}";
            Console.WriteLine($"your trip caused {co2e} of CO2-equivalent.");
        }
    }
}
