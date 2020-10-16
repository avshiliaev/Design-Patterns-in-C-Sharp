using System.Text;

namespace Creational.Builder
{
    internal class Burger
    {
        private readonly int _mSize;
        private bool _mCheese;
        private bool _mLettuce;
        private bool _mPepperoni;
        private bool _mTomato;

        public Burger(BurgerBuilder builder)
        {
            _mSize = builder.Size;
            _mCheese = builder.Cheese;
            _mPepperoni = builder.Pepperoni;
            _mLettuce = builder.Lettuce;
            _mTomato = builder.Tomato;
        }

        public string GetDescription()
        {
            var sb = new StringBuilder();
            sb.Append($"This is {_mSize} inch Burger. ");
            return sb.ToString();
        }
    }
}