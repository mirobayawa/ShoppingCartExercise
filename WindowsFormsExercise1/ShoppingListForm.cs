﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsExercise1
{
    public partial class ShoppingListForm : Form
    {
        DataHolder dh = DataHolder.Instance;

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

        public bool IsEmpty<T>(List<T> list)
        {
            if (list == null)
            {
                return true;
            }

            return list.Count == 0;
        }

        public void addToCart()
        {
            ShoppingCartItem duplicate = dh.ShoppingCart.FirstOrDefault(item => 
                item.ItemNo == itemNoLabel.Text);

            if (IsEmpty(dh.ShoppingCart))
            {
                dh.ShoppingCart.Add(new ShoppingCartItem(itemNoLabel.Text, itemNameLabel.Text,
                    Convert.ToDouble(priceLabel.Text), Convert.ToInt32(quantityUpDown.Value)));
            } else
            {
                if (duplicate != null)
                {
                    duplicate.Quantity += Convert.ToInt32(quantityUpDown.Value);
                }
                else
                {
                    dh.ShoppingCart.Add(new ShoppingCartItem(itemNoLabel.Text, itemNameLabel.Text,
                        Convert.ToDouble(priceLabel.Text), Convert.ToInt32(quantityUpDown.Value)));
                }
            }
        }

        private int itemsInCart()
        {
            DataHolder dh = DataHolder.Instance;
            ShoppingCartItem duplicate = dh.ShoppingCart.FirstOrDefault(item =>
                item.ItemNo == itemNoLabel.Text);
            if (duplicate != null)
            {
                return duplicate.Quantity;
            }
            else
            {
                return 0;
            }
        }

        private void resetValues()
        {
            itemNoLabel.Text = shoppingList.SelectedValue.ToString();
            itemNameLabel.Text = ((Item)shoppingList.SelectedItem).ItemName;
            dateAddedLabel.Text = ((Item)shoppingList.SelectedItem).DateAdded;
            priceLabel.Text = ((Item)shoppingList.SelectedItem).Price.ToString("#,##0.00");
            deliveryFeeLabel.Text = ((Item)shoppingList.SelectedItem).DeliveryFee.ToString("#,##0.00");
            stockLabel.Text = ((Item)shoppingList.SelectedItem).Stock.ToString();
            cartStock.Text = itemsInCart().ToString();
        }

        private void shoppingList_SelectedValueChanged(object sender, EventArgs e)
        {
            if (shoppingList.SelectedIndex != -1)
            {
                resetValues();
            }
        }

        private void addToCartButton_Click(object sender, EventArgs e)
        {
            addToCart();
            resetValues();
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
