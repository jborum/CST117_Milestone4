/*
 * Inventory Form
 * This program was written by Jason Borum
 * Date: April 1, 2018
 * Course: CST117
 * Instructor: Dr. Brandon Bass
 */

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
    public partial class frmInventory : Form
    {
        public static InventoryManager myStore { get; set; }

        public frmInventory()
        {
            InitializeComponent();
            myStore = new InventoryManager();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            frmAddItem launchInventoryForm = new frmAddItem();
            launchInventoryForm.ShowDialog();
        }

        private void btnDriver_Click(object sender, EventArgs e)
        {
            Inventory item1 = new Inventory("Sports Equipment", "Basketball", "Wilson", 84.99m);
            frmInventory.myStore.addItem(item1);
            Inventory item2 = new Inventory("Shoe", "Nike", "Vapormax ", 190.00m);
            frmInventory.myStore.addItem(item2);
            Inventory item3 = new Inventory("Clothing", "Adidas Sweat Suit with Hoodie", "MidnightBlue", 199.99m);
            frmInventory.myStore.addItem(item3);
            Inventory item4 = new Inventory("Hat", "Diamondback Baseball Cap", "2018 Red White Logo", 34.99m);
            frmInventory.myStore.addItem(item4);
            Inventory item5 = new Inventory("Workout Equipment", "Life Time Exercise Bike", "2015 eXtreme", 499.99m);
            frmInventory.myStore.addItem(item5);
            MessageBox.Show("Items Added to the Inventory Manager");
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            frmRemoveItem launchInventoryForm = new frmRemoveItem();
            launchInventoryForm.ShowDialog();
        }

        private void buttonRestock_Click(object sender, EventArgs e)
        {
            frmRestock launchInventoryForm = new frmRestock();
            launchInventoryForm.ShowDialog();
        }

        private void buttonSearchPrice_Click(object sender, EventArgs e)
        {
            frmSearchPrice launchInventoryForm = new frmSearchPrice();
            launchInventoryForm.ShowDialog();
        }

        private void buttonSearchByName_Click(object sender, EventArgs e)
        {
            frmSearchByName launchInventoryForm = new frmSearchByName();
            launchInventoryForm.ShowDialog();
        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            frmDisplay launchInventoryForm = new frmDisplay();
            launchInventoryForm.ShowDialog();
        }
    }
}
