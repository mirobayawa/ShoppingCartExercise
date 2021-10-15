using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsExercise1
{
    class Item
    {
        public string ItemNo { get; set; }
        public string ItemName { get; set; }
        public string DateAdded { get; set; }
        public double Price { get; set; }
        public double DeliveryFee { get; set; }
        public int Stock { get; set; }

        public Item ()
        {

        }
        public Item(string itemNo, string itemName, string dateAdded, double price, double deliveryFee, int stock)
        {
            this.ItemNo = itemNo;
            this.ItemName = itemName;
            this.DateAdded = dateAdded;
            this.Price = price;
            this.DeliveryFee = deliveryFee;
            this.Stock = stock;
        }
    }
}
