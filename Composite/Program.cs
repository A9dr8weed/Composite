using System;

namespace Composite
{
    public static class Program
    {
        private static void Main()
        {
            GiftBase phone = new SingleGift("Phone", 256);
            phone.CalculateTotalPrice();
            Console.WriteLine();

            Console.WriteLine("Composite gift.");
            // Base box.
            CompositeGift baseBox = new CompositeGift("RootBox", 0);

            // Single gifts.
            GiftBase truckToy = new SingleGift("TruckToy", 289);
            GiftBase plainToy = new SingleGift("PlainToy", 587);

            // Add single gift to base box.
            baseBox.Add(truckToy);
            baseBox.Add(plainToy);

            // Another box.
            CompositeGift childBox = new CompositeGift("ChildBox", 1000);
            // Gift in another box.
            GiftBase soldierToy = new SingleGift("SoldierToy", 200);
            // Add soldier toy into child box.
            childBox.Add(soldierToy);
            // Add another box with gift into base box.
            baseBox.Add(childBox);

            Console.WriteLine($"Total price of this composite present is: {baseBox.CalculateTotalPrice()}");
        }
    }
}