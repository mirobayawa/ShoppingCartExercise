using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsExercise1
{
    public partial class ShoppingListForm : Form
    {
        //instantiate dh for list and cart
        DataHolder dh = new DataHolder();

        public ShoppingListForm()
        {
            InitializeComponent();
            SetShoppingList();
        }

        public void SetShoppingList()
        {
            shoppingList.ValueMember = "ItemNo";
            shoppingList.DisplayMember = "ItemName";
            shoppingList.DataSource = dh.ShoppingList;
        }

        public void addToCart()
        {
            dh.ShoppingCart.Add(new ShoppingCartItem(itemNoLabel.Text,
                itemNameLabel.Text, Convert.ToDouble(priceLabel.Text), 
                Convert.ToInt32(quantityUpDown.Value)));

            dh.ShoppingCart.ForEach(item => {
                Console.WriteLine(item.ItemNo + item.ItemName + item.Price + item.Quantity);
            });
        }

        private void shoppingList_SelectedValueChanged(object sender, EventArgs e)
        {
            if (shoppingList.SelectedIndex != -1)
            {
                itemNoLabel.Text = shoppingList.SelectedValue.ToString();
                itemNameLabel.Text = ((Item)shoppingList.SelectedItem).ItemName;
                dateAddedLabel.Text = ((Item)shoppingList.SelectedItem).DateAdded;
                priceLabel.Text = ((Item)shoppingList.SelectedItem).Price.ToString();
                deliveryFeeLabel.Text = ((Item)shoppingList.SelectedItem).DeliveryFee.ToString();
                stockLabel.Text = ((Item)shoppingList.SelectedItem).Stock.ToString();
            }
        }

        private void addToCartButton_Click(object sender, EventArgs e)
        {
            addToCart();
            MessageBox.Show("Added to cart!");
        }

        private void viewCart_Click(object sender, EventArgs e)
        {
            ViewCartForm viewCartForm = new ViewCartForm();
            viewCartForm.refreshTable();
            viewCartForm.ShowDialog();
        }

    }
}
