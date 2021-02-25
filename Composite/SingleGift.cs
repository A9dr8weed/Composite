using System;

namespace Composite
{
    /// <summary>
    /// The Leaf Class Implementation.
    /// </summary>
    public class SingleGift : GiftBase
    {
        public SingleGift(string name, int price) : base(name, price) { }

        public override int CalculateTotalPrice()
        {
            Console.WriteLine($"{_name} with the price {_price}");

            return _price;
        }
    }
}