using System;
using Behavioral.TemplateMethod.Abstractions;

namespace Behavioral.TemplateMethod.Templates
{
    // Usually, concrete classes override only a fraction of base class'
    // operations.
    internal class NumericalDataPipeline : AbstractPipeline
    {
        protected override void StageOne()
        {
            Console.WriteLine("NumericalDataPipeline: Implemented StageOne");
        }

        protected override void StageTwo()
        {
            Console.WriteLine("NumericalDataPipeline: Implemented StageTwo");
        }

        protected override void BackupStageOne()
        {
            Console.WriteLine("NumericalDataPipeline: Overridden BackupStageOne");
        }
    }
}