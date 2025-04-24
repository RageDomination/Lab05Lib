namespace Lab05Lib
{
    public class Airplane
    {
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int Year { get; set; }
        public int Capacity { get; set; }
        public double FuelCapacity { get; set; }
        public double FuelConsumptionPer100Km { get; set; }
        public bool HasAutopilot { get; set; }
        public bool IsMilitary { get; set; }

        public double CalculateMaxDistance()
        {
            return FuelConsumptionPer100Km > 0 ? (FuelCapacity / FuelConsumptionPer100Km) * 100 : 0;
        }
    }
}
