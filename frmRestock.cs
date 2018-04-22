using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class frmRestock : Form
    {
        public frmRestock()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRestock_Load(object sender, EventArgs e)
        {
            frmInventory.myStore.displayInventory(lstRestockItems);
        }

        private void buttonRestockItem_Click(object sender, EventArgs e)
        {
            int qty;
            if (int.TryParse(txtQty.Text, out qty))
            {
                Inventory item = frmInventory.myStore.Inventories[lstRestockItems.SelectedIndex];
                frmInventory.myStore.restockItem(item, qty);
                frmInventory.myStore.displayInventory(lstRestockItems);
            }
            else
            {
                MessageBox.Show("You must enter a valid integer.");
                txtQty.Text = "";
                this.ActiveControl = txtQty;
            }
        }
    }
}
