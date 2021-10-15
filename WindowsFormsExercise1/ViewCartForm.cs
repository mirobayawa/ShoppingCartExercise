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
        private int rowIndex = 0;

        public ViewCartForm()
        {
            InitializeComponent();
            SetDataViewValues();
        }

        public void SetDataViewValues()
        {
            DataHolder dh = DataHolder.Instance;
            CartDataGridView.AutoGenerateColumns = true;
            BindingList<ShoppingCartItem> bind = new BindingList<ShoppingCartItem>(dh.ShoppingCart);
            CartDataGridView.DataSource = bind;

            //Console.WriteLine(dh.ShoppingCart[dh.ShoppingCart.Count - 1].ItemName);\
        }

        public void refreshTable()
        {
            CartDataGridView.Update();
            CartDataGridView.Refresh();
            totalValueLabel.Text = TotalValue().ToString("#,##0.00");


            Console.WriteLine("refresh table..");
        }

        public double TotalValue() {
            DataHolder dh = DataHolder.Instance;
            double total = 0.0;
            double product = 0.0;

            dh.ShoppingCart.ForEach(item => {
                product += item.Price * item.Quantity;
                total += product;
                product = 0.0;
            });

            return total;
        }

        private void CartDataGridView_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                CartDataGridView.Rows[e.RowIndex].Selected = true;
                rowIndex = e.RowIndex;
                CartDataGridView.CurrentCell = CartDataGridView.Rows[e.RowIndex].Cells[1];
                deleteContextMenuStrip.Show(CartDataGridView, e.Location);
                deleteContextMenuStrip.Show(Cursor.Position);
            }
        }

        private void deleteContextMenuStrip_Click(object sender, EventArgs e)
        {
            if (!CartDataGridView.Rows[rowIndex].IsNewRow)
            {
                CartDataGridView.Rows.RemoveAt(rowIndex);
                totalValueLabel.Text = TotalValue().ToString("#,##0.00");
            }
        }

        private void removeAll_Click(object sender, EventArgs e)
        {
            CartDataGridView.Rows.Clear();
            totalValueLabel.Text = TotalValue().ToString("#,##0.00");
        }
    }
}
