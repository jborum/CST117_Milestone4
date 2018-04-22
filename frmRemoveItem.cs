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
    public partial class frmRemoveItem : Form
    {
        public frmRemoveItem()
        {
            InitializeComponent();
            frmInventory.myStore.displayInventory(lstRemove);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            frmInventory.myStore.removeItem(lstRemove.SelectedIndex);
            frmInventory.myStore.displayInventory(lstRemove);
        }
    }
}
