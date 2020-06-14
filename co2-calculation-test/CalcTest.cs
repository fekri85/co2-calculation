using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace co2_calculation_test
{
    [TestClass]
    public class CalcTest
    {
        co2_calculation.ICO2_Calulator _co2_Calulator = new co2_calculation.CO2_Calulator();
        [TestMethod]
        public void Test_CO2_Calulator_small_petrol_car_Distance_1500()
        {
            string transportation_method = "small-petrol-car";
            int distance = 1500;
            string unit_Of_distance = "km";

            var actual = _co2_Calulator.Calc_CO2e(transportation_method, distance, unit_Of_distance);
            Assert.AreEqual(231000, actual, $"{actual} Calc_CO2e is not correct!");
        }
    }
}
