namespace Inventory
{
    partial class frmInventory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.btnDriver = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonRestock = new System.Windows.Forms.Button();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.buttonSearchPrice = new System.Windows.Forms.Button();
            this.buttonSearchByName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonAdd.Location = new System.Drawing.Point(33, 59);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(434, 35);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add Item";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Salmon;
            this.buttonClose.Location = new System.Drawing.Point(33, 334);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(434, 35);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // btnDriver
            // 
            this.btnDriver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDriver.Location = new System.Drawing.Point(33, 14);
            this.btnDriver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDriver.Name = "btnDriver";
            this.btnDriver.Size = new System.Drawing.Size(434, 35);
            this.btnDriver.TabIndex = 40;
            this.btnDriver.Text = "Add Random Items";
            this.btnDriver.UseVisualStyleBackColor = false;
            this.btnDriver.Click += new System.EventHandler(this.btnDriver_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonRemove.Location = new System.Drawing.Point(31, 104);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(434, 35);
            this.buttonRemove.TabIndex = 41;
            this.buttonRemove.Text = "Remove Item";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonRestock
            // 
            this.buttonRestock.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonRestock.Location = new System.Drawing.Point(31, 149);
            this.buttonRestock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRestock.Name = "buttonRestock";
            this.buttonRestock.Size = new System.Drawing.Size(434, 35);
            this.buttonRestock.TabIndex = 42;
            this.buttonRestock.Text = "Restock";
            this.buttonRestock.UseVisualStyleBackColor = false;
            this.buttonRestock.Click += new System.EventHandler(this.buttonRestock_Click);
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonDisplay.Location = new System.Drawing.Point(31, 289);
            this.buttonDisplay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(434, 35);
            this.buttonDisplay.TabIndex = 43;
            this.buttonDisplay.Text = "Display Inventory";
            this.buttonDisplay.UseVisualStyleBackColor = false;
            this.buttonDisplay.Click += new System.EventHandler(this.buttonDisplay_Click);
            // 
            // buttonSearchPrice
            // 
            this.buttonSearchPrice.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonSearchPrice.Location = new System.Drawing.Point(33, 194);
            this.buttonSearchPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSearchPrice.Name = "buttonSearchPrice";
            this.buttonSearchPrice.Size = new System.Drawing.Size(434, 35);
            this.buttonSearchPrice.TabIndex = 44;
            this.buttonSearchPrice.Text = "Search By Price";
            this.buttonSearchPrice.UseVisualStyleBackColor = false;
            this.buttonSearchPrice.Click += new System.EventHandler(this.buttonSearchPrice_Click);
            // 
            // buttonSearchByName
            // 
            this.buttonSearchByName.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonSearchByName.Location = new System.Drawing.Point(33, 239);
            this.buttonSearchByName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSearchByName.Name = "buttonSearchByName";
            this.buttonSearchByName.Size = new System.Drawing.Size(434, 35);
            this.buttonSearchByName.TabIndex = 45;
            this.buttonSearchByName.Text = "Search By Name";
            this.buttonSearchByName.UseVisualStyleBackColor = false;
            this.buttonSearchByName.Click += new System.EventHandler(this.buttonSearchByName_Click);
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 381);
            this.Controls.Add(this.buttonSearchByName);
            this.Controls.Add(this.buttonSearchPrice);
            this.Controls.Add(this.buttonDisplay);
            this.Controls.Add(this.buttonRestock);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.btnDriver);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonClose);
            this.Name = "frmInventory";
            this.Text = "Inventory Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button btnDriver;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonRestock;
        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.Button buttonSearchPrice;
        private System.Windows.Forms.Button buttonSearchByName;
    }
}

