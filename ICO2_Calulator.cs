namespace co2_calculation
{
    public interface ICO2_Calulator
    {
        double Calc_CO2e(string tm, int d, string u = "km");
    }
}