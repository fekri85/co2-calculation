using Mono.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace co2_calculation
{
    partial class Program
    {
        static ICO2_Calulator _co2_Calulator = new CO2_Calulator();
        static ICO2ePresenter _co2ePresenter = new CO2ePresenter();

        static void Main(string[] args)
        {
            try
            {

                bool show_help = false;
                string transportation_method = "";
                int distance = 0;
                string unit_Of_distance = "km";
                string output = "kg";

                var p = new OptionSet() {
                { $"t|{MyKeys.__transportation_method}=", "the transportation method.",
                   v => transportation_method = v },
                { $"d|{MyKeys.__distance}=",
                   "the distance of trip.",
                    (int v) => distance = v },
                { $"u|{MyKeys.__unit_of_distance}=", "the unit of distance",
                   v => unit_Of_distance = v },
                { $"o|{MyKeys.__output}=",  "the output type.",
                   v => output = v },
                { "h|help", "show this message and exit", v=> show_help = true }
            };

                List<string> extra;
                try
                {
                    extra = p.Parse(args);
                }
                catch (OptionException e)
                {
                    Console.Write("CO2-calc: ");
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Try `CO2-calc --help' for more information.");
                    return;
                }
                if (show_help)
                {
                    Console.WriteLine($@"Example: CO2-calc --{MyKeys.__transportation_method} small-petrol-car --{MyKeys.__distance} 1500 --{MyKeys.__unit_of_distance} km --{MyKeys.__output} kg ");

                }
                else
                {
                    _co2ePresenter.Show(_co2_Calulator.Calc_CO2e(transportation_method, distance, unit_Of_distance), output);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }

    }
}
