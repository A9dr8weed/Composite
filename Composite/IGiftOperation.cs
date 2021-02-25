namespace Composite
{
    /// <summary>
    /// In many examples, we can see additional operations like add and remove inside the abstract class,
    /// but we are not going to add them in 'Component' class, because our Leaf class doesn’t need them.
    /// Only our composite object will implement this interface, but the leaf object won’t.
    /// This is much better because our leaf object doesn’t need to implement the methods it won’t use.
    /// </summary>
    public interface IGiftOperation
    {
        void Add(GiftBase giftBase);
        void Remove(GiftBase giftBase);
    }
}