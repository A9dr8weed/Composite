using System;
using System.Collections.Generic;

namespace Composite
{
    /// <summary>
    /// The Composite Class Implementation.
    /// </summary>
    public class CompositeGift : GiftBase, IGiftOperation
    {
        /// <summary>
        /// Collection of our Leaf or other Composite objects.
        /// </summary>
        private readonly List<GiftBase> _giftBases;

        public CompositeGift(string name, int price) : base(name, price)
        {
            _giftBases = new List<GiftBase>();
        }

        /// <summary>
        /// Add object to list.
        /// </summary>
        /// <param name="giftBase"> Added object. </param>
        public void Add(GiftBase giftBase)
        {
            _giftBases.Add(giftBase);
        }

        /// <summary>
        /// Remove object from list.
        /// </summary>
        /// <param name="giftBase"> Removed object. </param>
        public void Remove(GiftBase giftBase)
        {
            _giftBases.Remove(giftBase);
        }

        /// <summary>
        /// Calculating the total price of our Gift object with all the sub-gifts inside it.
        /// </summary>
        /// <returns> Total price. </returns>
        public override int CalculateTotalPrice()
        {
            int total = 0;

            Console.WriteLine($"{_name} contains the following products with prices:");
            foreach (GiftBase gift in _giftBases)
            {
                total += gift.CalculateTotalPrice();
            }

            return total;
        }
    }
}