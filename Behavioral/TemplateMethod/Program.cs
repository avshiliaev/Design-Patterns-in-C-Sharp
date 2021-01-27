using Behavioral.TemplateMethod.Templates;

namespace Behavioral.TemplateMethod
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            App.TransformInputData(new CategoricalDataPipeline());
            App.TransformInputData(new NumericalDataPipeline());
        }
    }
}