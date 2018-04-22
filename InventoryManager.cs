/*
 * Inventory Manager class
 * This program was written by Jason Borum
 * Date: April 15, 2018
 * Course: CST117
 * Instructor: Dr. Brandon Bass
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public class InventoryManager
    {
        // Initilize inventoryManagerList
        private List<Inventory> inventoryManagerList = new List<Inventory>();

        // Start additem method
        public void addItem(Inventory item)
        {
            this.inventoryManagerList.Add(item);
        } // end of add item method

        //Start removeItem method
        public void removeItem(int index)
        {
            if (index >= 0)
            this.inventoryManagerList.RemoveAt(index);
        } // end of remove item method

        // starte restockItem method
        public void restockItem(Inventory item, int quantity)
        {
            int index = 0;
            // if quantity is greater than 0 then enter the loop
            if (quantity > 0)
            {
                // start while loop to add the number of items determined by the quantity
                while (index < quantity)
                {
                    this.inventoryManagerList.Add(item);
                    index++;
                } // end of while loop
            } // end of iff statement
        } // End of restock item method

        // Item Quantity Property
        public int Quantity
        {
            get { return this.inventoryManagerList.Count; }
        }

        public List <Inventory> Inventories
        {
            get { return this.inventoryManagerList; }
        }

        public void displayInventory(ListBox lstbox)
        {
            //Clear List box
            lstbox.Items.Clear();

            //Cycle through each product in the list and add to the listbox
            foreach(Inventory product in this.inventoryManagerList)
            {
                lstbox.Items.Add(product.Category + ", " + product.Name + ", " + product.Number + ", " + product.Price);

            } // end of foreach statement
        } //end of display Inventory Method

        //Method to search for by item name
        public void searchName(string objectName, ListBox lstbox)
        {
            //Clear lstbox
            lstbox.Items.Clear();

            //cycle through each item in the inventory manager list
            foreach(Inventory product in this.inventoryManagerList)
            {
                //test to see if strings are equal and ignore case
                if (String.Equals(product.Name, objectName, StringComparison.OrdinalIgnoreCase))
                {
                    //if strings are equal add the item position to the list
                    //itemPosition.Add(this.inventoryManagerList.IndexOf(item));
                    lstbox.Items.Add(product.Category + ", " + product.Name + ", " + product.Number + ", " + product.Price);
                } //end of if
            } // end of foreach
        } // End of search name

        //Method to search by item price
        public void searchPrice(decimal objectPrice, ListBox lstbox)
        {

            // Clear Listbox
            lstbox.Items.Clear();

            //cycle through each item in the inventory manager list
            foreach (Inventory product in this.inventoryManagerList)
            {
                //Test if prices match
                if (product.Price == objectPrice)
                {
                    //if prices match then add item position to list
                    //itemPosition.Add(this.inventoryManagerList.IndexOf(item));
                    lstbox.Items.Add(product.Category + ", " + product.Name + ", " + product.Number + ", " + product.Price);
                } // end of if
            } // end of foreach statement
        } // End of search name

    } // End of InventoryManager Class
} // End of namespace
