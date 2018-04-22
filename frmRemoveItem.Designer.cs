namespace Inventory
{
    partial class frmRemoveItem
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
            this.lstRemove = new System.Windows.Forms.ListBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstRemove
            // 
            this.lstRemove.FormattingEnabled = true;
            this.lstRemove.ItemHeight = 20;
            this.lstRemove.Location = new System.Drawing.Point(21, 21);
            this.lstRemove.Name = "lstRemove";
            this.lstRemove.Size = new System.Drawing.Size(432, 164);
            this.lstRemove.TabIndex = 66;
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonRemove.Location = new System.Drawing.Point(21, 203);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(434, 35);
            this.buttonRemove.TabIndex = 64;
            this.buttonRemove.Text = "Remove Item";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Salmon;
            this.buttonClose.Location = new System.Drawing.Point(21, 248);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(434, 35);
            this.buttonClose.TabIndex = 65;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // frmRemoveItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 296);
            this.Controls.Add(this.lstRemove);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonClose);
            this.Name = "frmRemoveItem";
            this.Text = "Remove Item";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstRemove;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonClose;
    }
}