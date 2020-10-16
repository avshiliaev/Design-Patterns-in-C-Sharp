using System;

namespace ObserverPattern
{
    internal sealed class WeatherMonitor : IObserver<Weather>
    {
        private readonly string _name;
        private IDisposable _cancellation;

        public WeatherMonitor(string name)
        {
            _name = name;
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("Error has occured");
        }

        public void OnNext(Weather value)
        {
            Console.WriteLine(_name);
            if (_name.Contains("T"))
            {
                var op = $"| Temperature : {value.Temperature} Celsius |";
                Console.Write(op);
            }

            if (_name.Contains("P"))
            {
                var op = $"| Pressure : {value.Pressure} atm |";
                Console.Write(op);
            }

            if (_name.Contains("H"))
            {
                var op = $"| Humidity : {value.Humidity * 100} % |";
                Console.Write(op);
            }

            if (!(_name.Contains("T") || _name.Contains("P") || _name.Contains("H"))) OnError(new Exception());
            Console.WriteLine();
        }

        public void Subscribe(WeatherSupplier provider)
        {
            _cancellation = provider.Subscribe(this);
        }

        public void Unsubscribe()
        {
            _cancellation.Dispose();
        }
    }
}