using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsExercise1
{
    public partial class ViewCartForm : Form
    {
        DataHolder dh = new DataHolder();

        public ViewCartForm()
        {
            InitializeComponent();
            SetDataViewValues();
        }

        public void SetDataViewValues()
        {
            CartDataGridView.AutoGenerateColumns = true;
            CartDataGridView.DataSource = dh.ShoppingCart;

            //var list = new BindingList<ShoppingCartItem>(dh.ShoppingCart);
            //CartDataGridView.DataSource = list;

            //Console.WriteLine(dh.ShoppingCart[dh.ShoppingCart.Count - 1].ItemName);\
        }

        public void refreshTable()
        {
            //CartDataGridView.DataSource = dh.ShoppingCart;
            //var list = new BindingList<ShoppingCartItem>(dh.ShoppingCart);
            //CartDataGridView.DataSource = list;
            CartDataGridView.Update();
            CartDataGridView.Refresh();
            
            Console.WriteLine("refresh table..");
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            refreshTable();
        }
    }
}
