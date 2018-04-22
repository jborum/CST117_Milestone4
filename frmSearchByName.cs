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
    public partial class frmSearchByName : Form
    {
        public frmSearchByName()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSearchByName_Load(object sender, EventArgs e)
        {
            frmInventory.myStore.displayInventory(lstByName);
        }

        private void buttonSearchName_Click(object sender, EventArgs e)
        {
            frmInventory.myStore.searchName(txtName.Text, lstByName);
        }
    }
}
