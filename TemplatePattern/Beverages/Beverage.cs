using System;

namespace TemplatePattern.Beverages
{
    public abstract class Beverage
    {
        // ReSharper disable once InconsistentNaming
        protected int _sugar;

        public bool WantsCondiments { private get; set; }

        public int AddSugar { get; set; }

        public void Prepare()
        {
            Boil();
            Brew();
            Pour();
            if (WantsCondiments)
                AddCondiments();
        }


        protected abstract void Brew();

        private void Boil()
        {
            Console.WriteLine("Boling Water");
        }

        private void Pour()
        {
            Console.WriteLine("Pouring in Cup");
        }

        protected abstract void AddCondiments();

        protected void Sugar()
        {
        }
    }
}