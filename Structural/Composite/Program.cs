using Structural.Composite.Classes;

namespace Structural.Composite
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var app = new App();

            // This way the client code can support the simple leaf
            // components...
            var waterSensor = new WaterSensor();
            app.DisplayWaterConsumption(waterSensor);

            // ...as well as the complex composites.
            var waterSensorTree = new WaterSensorHub();

            var waterSensorBranch01 = new WaterSensorHub()
                .AddNode(new WaterSensor())
                .AddNode(new WaterSensor());

            var waterSensorBranch02 = new WaterSensorHub()
                .AddNode(new WaterSensor())
                .AddNode(new WaterSensor())
                .AddNode(new WaterSensor());

            waterSensorTree
                .AddNode(waterSensorBranch01)
                .AddNode(waterSensorBranch02);

            app.DisplayWaterConsumption(waterSensorTree);
        }
    }
}