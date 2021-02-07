using System;
using Behavioral.TemplateMethod.Abstractions;

namespace Behavioral.TemplateMethod.Templates
{
    // Concrete classes have to implement all abstract operations of the base
    // class. They can also override some operations with a default
    // implementation.
    internal class CategoricalDataPipeline : AbstractPipeline
    {
        protected override void StageOne()
        {
            Console.WriteLine("CategoricalDataPipeline: Implemented StageOne");
        }

        protected override void StageTwo()
        {
            Console.WriteLine("CategoricalDataPipeline: Implemented StageTwo");
        }
    }
}