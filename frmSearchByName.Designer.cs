namespace Inventory
{
    partial class frmSearchByName
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lstByName = new System.Windows.Forms.ListBox();
            this.buttonSearchName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Salmon;
            this.buttonClose.Location = new System.Drawing.Point(25, 288);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(434, 35);
            this.buttonClose.TabIndex = 6;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 75;
            this.label3.Text = "Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(159, 15);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(298, 26);
            this.txtName.TabIndex = 74;
            // 
            // lstByName
            // 
            this.lstByName.FormattingEnabled = true;
            this.lstByName.ItemHeight = 20;
            this.lstByName.Location = new System.Drawing.Point(25, 60);
            this.lstByName.Name = "lstByName";
            this.lstByName.Size = new System.Drawing.Size(432, 164);
            this.lstByName.TabIndex = 73;
            // 
            // buttonSearchName
            // 
            this.buttonSearchName.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonSearchName.Location = new System.Drawing.Point(25, 243);
            this.buttonSearchName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSearchName.Name = "buttonSearchName";
            this.buttonSearchName.Size = new System.Drawing.Size(434, 35);
            this.buttonSearchName.TabIndex = 72;
            this.buttonSearchName.Text = "Search By Name";
            this.buttonSearchName.UseVisualStyleBackColor = false;
            this.buttonSearchName.Click += new System.EventHandler(this.buttonSearchName_Click);
            // 
            // frmSearchByName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 338);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lstByName);
            this.Controls.Add(this.buttonSearchName);
            this.Controls.Add(this.buttonClose);
            this.Name = "frmSearchByName";
            this.Text = "Search By Name";
            this.Load += new System.EventHandler(this.frmSearchByName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ListBox lstByName;
        private System.Windows.Forms.Button buttonSearchName;
    }
}