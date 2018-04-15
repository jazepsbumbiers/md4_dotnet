namespace md2_dotnet
{
    partial class frmAddItem
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
            this.rtfItemDescription = new System.Windows.Forms.RichTextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtItemNo = new System.Windows.Forms.TextBox();
            this.lblItemNo = new System.Windows.Forms.Label();
            this.mnuMainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileProductsBrowser = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInventory = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInventoryBrowse = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInventorySetNotif = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.mnuMainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtfItemDescription
            // 
            this.rtfItemDescription.Location = new System.Drawing.Point(78, 176);
            this.rtfItemDescription.Name = "rtfItemDescription";
            this.rtfItemDescription.Size = new System.Drawing.Size(325, 66);
            this.rtfItemDescription.TabIndex = 74;
            this.rtfItemDescription.Text = "";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 200);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 73;
            this.lblDescription.Text = "Description";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(283, 345);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(120, 31);
            this.btnAddItem.TabIndex = 70;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(15, 276);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 69;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(69, 273);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(55, 20);
            this.txtQuantity.TabIndex = 68;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(69, 85);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(100, 21);
            this.cmbCategory.TabIndex = 61;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(12, 88);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 60;
            this.lblCategory.Text = "Category";
            // 
            // txtItemNo
            // 
            this.txtItemNo.Location = new System.Drawing.Point(69, 43);
            this.txtItemNo.Name = "txtItemNo";
            this.txtItemNo.Size = new System.Drawing.Size(100, 20);
            this.txtItemNo.TabIndex = 59;
            // 
            // lblItemNo
            // 
            this.lblItemNo.AutoSize = true;
            this.lblItemNo.Location = new System.Drawing.Point(12, 46);
            this.lblItemNo.Name = "lblItemNo";
            this.lblItemNo.Size = new System.Drawing.Size(45, 13);
            this.lblItemNo.TabIndex = 58;
            this.lblItemNo.Text = "Item no.";
            // 
            // mnuMainMenuStrip
            // 
            this.mnuMainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuInventory,
            this.mnuHelp});
            this.mnuMainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenuStrip.Name = "mnuMainMenuStrip";
            this.mnuMainMenuStrip.Size = new System.Drawing.Size(457, 24);
            this.mnuMainMenuStrip.TabIndex = 57;
            this.mnuMainMenuStrip.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileProductsBrowser,
            this.mnuFileSave,
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuFileProductsBrowser
            // 
            this.mnuFileProductsBrowser.Name = "mnuFileProductsBrowser";
            this.mnuFileProductsBrowser.Size = new System.Drawing.Size(161, 22);
            this.mnuFileProductsBrowser.Text = "Product browser";
            // 
            // mnuFileSave
            // 
            this.mnuFileSave.Name = "mnuFileSave";
            this.mnuFileSave.Size = new System.Drawing.Size(161, 22);
            this.mnuFileSave.Text = "Save";
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(161, 22);
            this.mnuFileExit.Text = "Exit";
            // 
            // mnuInventory
            // 
            this.mnuInventory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuInventoryBrowse,
            this.mnuInventorySetNotif});
            this.mnuInventory.Name = "mnuInventory";
            this.mnuInventory.Size = new System.Drawing.Size(69, 20);
            this.mnuInventory.Text = "Inventory";
            // 
            // mnuInventoryBrowse
            // 
            this.mnuInventoryBrowse.Name = "mnuInventoryBrowse";
            this.mnuInventoryBrowse.Size = new System.Drawing.Size(159, 22);
            this.mnuInventoryBrowse.Text = "Browse";
            // 
            // mnuInventorySetNotif
            // 
            this.mnuInventorySetNotif.Name = "mnuInventorySetNotif";
            this.mnuInventorySetNotif.Size = new System.Drawing.Size(159, 22);
            this.mnuInventorySetNotif.Text = "Set notifications";
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelpAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "Help";
            // 
            // mnuHelpAbout
            // 
            this.mnuHelpAbout.Name = "mnuHelpAbout";
            this.mnuHelpAbout.Size = new System.Drawing.Size(107, 22);
            this.mnuHelpAbout.Text = "About";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(69, 128);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(140, 20);
            this.txtTitle.TabIndex = 76;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 131);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 75;
            this.lblTitle.Text = "Title";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(15, 319);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(75, 13);
            this.lblPrice.TabIndex = 78;
            this.lblPrice.Text = "Price (per unit)";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(96, 316);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(55, 20);
            this.txtPrice.TabIndex = 77;
            // 
            // frmAddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 409);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.rtfItemDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtItemNo);
            this.Controls.Add(this.lblItemNo);
            this.Controls.Add(this.mnuMainMenuStrip);
            this.Name = "frmAddItem";
            this.Text = "Add inventory item";
            this.Load += new System.EventHandler(this.frmAddItem_Load);
            this.mnuMainMenuStrip.ResumeLayout(false);
            this.mnuMainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtfItemDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblCategory;
        public System.Windows.Forms.TextBox txtItemNo;
        private System.Windows.Forms.Label lblItemNo;
        private System.Windows.Forms.MenuStrip mnuMainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileProductsBrowser;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSave;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem mnuInventory;
        private System.Windows.Forms.ToolStripMenuItem mnuInventoryBrowse;
        private System.Windows.Forms.ToolStripMenuItem mnuInventorySetNotif;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;
        public System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
    }
}