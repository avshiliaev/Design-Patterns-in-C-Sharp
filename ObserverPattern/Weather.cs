namespace ObserverPattern
{
    internal class Weather
    {
        public Weather(double humd, double pres, double temp)
        {
            Temperature = temp;
            Pressure = pres;
            Humidity = humd;
        }

        public double Pressure { get; }

        public double Humidity { get; }

        public double Temperature { get; }
    }
}