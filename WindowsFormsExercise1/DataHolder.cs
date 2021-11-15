using System;
using System.Collections.Generic;
using System.Linq;

namespace WindowsFormsExercise1
{
    class DataHolder
    {
        // todo: make another class for shopping cart item and inherit Item Class except stock and date
        // -> add quantity property 
        public List<ShoppingCartItem> ShoppingCart = new List<ShoppingCartItem>();
        public List<Item> ShoppingList = new List<Item>();
        
        private static DataHolder instance = null;
        public static DataHolder Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataHolder();
                }
                return instance;
            }
        }

        private DataHolder()
        {
            // provide default data of items to shopping list
            ShoppingList.Add(new Item("A0001", "Laptop", "Jan 23, 2018", 20700.00, 69.00, 56));
            ShoppingList.Add(new Item("A0201", "Cell Phone", "April 29, 2018", 11000.00, 69.00, 76));
            ShoppingList.Add(new Item("A4521", "Airpods", "Feb 11, 2018", 3700.00, 69.00, 16));
            ShoppingList.Add(new Item("A1231", "Keyboard", "Aug 31, 2018", 500.00, 69.00, 36));
            ShoppingList.Add(new Item("A1021", "Mouse", "Dec 28, 2018", 500.00, 69.00, 54));
            ShoppingList.Add(new Item("A0221", "Monitor", "Mar 26, 2018", 1000.00, 69.00, 22));
            ShoppingList.Add(new Item("A3471", "Shoes", "Sep 10, 2018", 1999.00, 69.00, 71));
            ShoppingList.Add(new Item("A3477", "Shirt", "Nov 23, 2018", 700.00, 69.00, 99));
        }

        public int getCartItems(string itemNo)
        {
            ShoppingCartItem selectedCart = ShoppingCart.FirstOrDefault(item =>
                item.ItemNo == itemNo);
            return selectedCart != null ? selectedCart.Quantity : 0;
        }
    }
}
