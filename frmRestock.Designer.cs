namespace Inventory
{
    partial class frmRestock
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
            this.buttonRestockItem = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstRestockItems = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonRestockItem
            // 
            this.buttonRestockItem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonRestockItem.Location = new System.Drawing.Point(29, 261);
            this.buttonRestockItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRestockItem.Name = "buttonRestockItem";
            this.buttonRestockItem.Size = new System.Drawing.Size(434, 35);
            this.buttonRestockItem.TabIndex = 58;
            this.buttonRestockItem.Text = "Restock Item";
            this.buttonRestockItem.UseVisualStyleBackColor = false;
            this.buttonRestockItem.Click += new System.EventHandler(this.buttonRestockItem_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Salmon;
            this.buttonClose.Location = new System.Drawing.Point(29, 306);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(434, 35);
            this.buttonClose.TabIndex = 59;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(165, 205);
            this.txtQty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(298, 26);
            this.txtQty.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 210);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 56;
            this.label3.Text = "Quantity";
            // 
            // lstRestockItems
            // 
            this.lstRestockItems.FormattingEnabled = true;
            this.lstRestockItems.ItemHeight = 20;
            this.lstRestockItems.Location = new System.Drawing.Point(31, 19);
            this.lstRestockItems.Name = "lstRestockItems";
            this.lstRestockItems.Size = new System.Drawing.Size(430, 164);
            this.lstRestockItems.TabIndex = 60;
            // 
            // frmRestock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 360);
            this.Controls.Add(this.lstRestockItems);
            this.Controls.Add(this.buttonRestockItem);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQty);
            this.Name = "frmRestock";
            this.Text = "Restock Items";
            this.Load += new System.EventHandler(this.frmRestock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRestockItem;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstRestockItems;
    }
}