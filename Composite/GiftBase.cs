namespace Composite
{
    /// <summary>
    /// 'Component'
    /// A component is an interface that describes operations that are common to either simple or complex elements of the tree.
    /// </summary>
    public abstract class GiftBase
    {
        /// <summary>
        /// The name of the gift.
        /// </summary>
        protected string _name;

        /// <summary>
        /// The price of the gift.
        /// </summary>
        protected int _price;

        protected GiftBase(string name, int price)
        {
            _name = name;
            _price = price;
        }

        /// <summary>
        /// Calculate total price of all products.
        /// </summary>
        public abstract int CalculateTotalPrice();
    }
}