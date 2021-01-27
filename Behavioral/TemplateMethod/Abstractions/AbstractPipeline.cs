using System;

namespace Behavioral.TemplateMethod.Abstractions
{
    // The Abstract Class defines a template method that contains a skeleton of
    // some algorithm, composed of calls to (usually) abstract primitive
    // operations.
    //
    // Concrete subclasses should implement these operations, but leave the
    // template method itself intact.
    internal abstract class AbstractPipeline
    {
        // The template method defines the skeleton of an algorithm.
        public void Transform()
        {
            PrepareTransformation();

            StageOne();
            BackupStageOne();

            StageTwo();
            BackupStageTwo();
        }

        // These operations already have implementations.
        private void PrepareTransformation()
        {
            Console.WriteLine("AbstractPipeline: GenericDataTransformation");
        }

        // These operations have to be implemented in subclasses.
        protected abstract void StageOne();

        protected abstract void StageTwo();

        // These are "hooks." Subclasses may override them, but it's not
        // mandatory since the hooks already have default (but empty)
        // implementation. Hooks provide additional extension points in some
        // crucial places of the algorithm.
        protected virtual void BackupStageOne()
        {
        }

        protected virtual void BackupStageTwo()
        {
        }
    }
}