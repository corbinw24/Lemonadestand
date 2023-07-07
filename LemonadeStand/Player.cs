using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        // member variables (HAS A)
        public Inventory inventory;
        public Wallet wallet;
        public Recipe recipe;

        // constructor (SPAWNER)
        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet();
            recipe = new Recipe();
        }

        // member methods (CAN DO)

        public void BuyLemons(Store store)
        {
            int lemonsToPurchase = UserInterface.GetNumberOfItems("lemons");
            store.SellLemons(this);
        }
        public void Makelemonade(Recipe recipe)
        {
            Console.WriteLine("Put items togther in a pitcher to make lemonade");
        }

    }
}
