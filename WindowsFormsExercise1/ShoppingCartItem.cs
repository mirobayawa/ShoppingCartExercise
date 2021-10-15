using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsExercise1
{
    class ShoppingCartItem : Item
    {
        public int Quantity { get; set; }

        public ShoppingCartItem(string itemNo, string itemName, double price, int quantity)
        {
            this.ItemNo = itemNo;
            this.ItemName = itemName;
            this.Price = price;
            this.Quantity = quantity;
        }
    }
}
