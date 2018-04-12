namespace md2_dotnet
{
    partial class frmAddOrder
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
            this.lblOrderNo = new System.Windows.Forms.Label();
            this.txtOrderNo = new System.Windows.Forms.TextBox();
            this.lblPizzaType = new System.Windows.Forms.Label();
            this.cmbPizzaType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDrinks = new System.Windows.Forms.ComboBox();
            this.numPizzas = new System.Windows.Forms.NumericUpDown();
            this.numDrinks = new System.Windows.Forms.NumericUpDown();
            this.cmbPizzaSize = new System.Windows.Forms.ComboBox();
            this.cmbDrinkSize = new System.Windows.Forms.ComboBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.lblPizzaSize = new System.Windows.Forms.Label();
            this.lblDrinkVolume = new System.Windows.Forms.Label();
            this.lblnewOrdDescr = new System.Windows.Forms.Label();
            this.rtfDescription = new System.Windows.Forms.RichTextBox();
            this.mnuMainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPizzas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDrinks)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMainMenuStrip
            // 
            this.mnuMainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuInventory,
            this.mnuHelp});
            this.mnuMainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenuStrip.Name = "mnuMainMenuStrip";
            this.mnuMainMenuStrip.Size = new System.Drawing.Size(437, 24);
            this.mnuMainMenuStrip.TabIndex = 32;
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
            // lblOrderNo
            // 
            this.lblOrderNo.AutoSize = true;
            this.lblOrderNo.Location = new System.Drawing.Point(12, 45);
            this.lblOrderNo.Name = "lblOrderNo";
            this.lblOrderNo.Size = new System.Drawing.Size(51, 13);
            this.lblOrderNo.TabIndex = 33;
            this.lblOrderNo.Text = "Order no.";
            // 
            // txtOrderNo
            // 
            this.txtOrderNo.Location = new System.Drawing.Point(69, 42);
            this.txtOrderNo.Name = "txtOrderNo";
            this.txtOrderNo.Size = new System.Drawing.Size(100, 20);
            this.txtOrderNo.TabIndex = 34;
            // 
            // lblPizzaType
            // 
            this.lblPizzaType.AutoSize = true;
            this.lblPizzaType.Location = new System.Drawing.Point(12, 87);
            this.lblPizzaType.Name = "lblPizzaType";
            this.lblPizzaType.Size = new System.Drawing.Size(32, 13);
            this.lblPizzaType.TabIndex = 35;
            this.lblPizzaType.Text = "Pizza";
            // 
            // cmbPizzaType
            // 
            this.cmbPizzaType.FormattingEnabled = true;
            this.cmbPizzaType.Location = new System.Drawing.Point(69, 84);
            this.cmbPizzaType.Name = "cmbPizzaType";
            this.cmbPizzaType.Size = new System.Drawing.Size(100, 21);
            this.cmbPizzaType.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Drinks";
            // 
            // cmbDrinks
            // 
            this.cmbDrinks.FormattingEnabled = true;
            this.cmbDrinks.Location = new System.Drawing.Point(69, 132);
            this.cmbDrinks.Name = "cmbDrinks";
            this.cmbDrinks.Size = new System.Drawing.Size(100, 21);
            this.cmbDrinks.TabIndex = 39;
            // 
            // numPizzas
            // 
            this.numPizzas.Location = new System.Drawing.Point(267, 85);
            this.numPizzas.Name = "numPizzas";
            this.numPizzas.Size = new System.Drawing.Size(46, 20);
            this.numPizzas.TabIndex = 41;
            // 
            // numDrinks
            // 
            this.numDrinks.Location = new System.Drawing.Point(267, 132);
            this.numDrinks.Name = "numDrinks";
            this.numDrinks.Size = new System.Drawing.Size(46, 20);
            this.numDrinks.TabIndex = 42;
            // 
            // cmbPizzaSize
            // 
            this.cmbPizzaSize.FormattingEnabled = true;
            this.cmbPizzaSize.Location = new System.Drawing.Point(184, 84);
            this.cmbPizzaSize.Name = "cmbPizzaSize";
            this.cmbPizzaSize.Size = new System.Drawing.Size(62, 21);
            this.cmbPizzaSize.TabIndex = 45;
            // 
            // cmbDrinkSize
            // 
            this.cmbDrinkSize.FormattingEnabled = true;
            this.cmbDrinkSize.Location = new System.Drawing.Point(184, 132);
            this.cmbDrinkSize.Name = "cmbDrinkSize";
            this.cmbDrinkSize.Size = new System.Drawing.Size(62, 21);
            this.cmbDrinkSize.TabIndex = 46;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(12, 275);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(96, 13);
            this.lblTotalPrice.TabIndex = 50;
            this.lblTotalPrice.Text = "Total price of items";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(114, 272);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(90, 20);
            this.txtTotalPrice.TabIndex = 49;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(283, 266);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(120, 31);
            this.btnAddOrder.TabIndex = 51;
            this.btnAddOrder.Text = "Add";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // lblPizzaSize
            // 
            this.lblPizzaSize.AutoSize = true;
            this.lblPizzaSize.Location = new System.Drawing.Point(181, 68);
            this.lblPizzaSize.Name = "lblPizzaSize";
            this.lblPizzaSize.Size = new System.Drawing.Size(27, 13);
            this.lblPizzaSize.TabIndex = 52;
            this.lblPizzaSize.Text = "Size";
            // 
            // lblDrinkVolume
            // 
            this.lblDrinkVolume.AutoSize = true;
            this.lblDrinkVolume.Location = new System.Drawing.Point(181, 117);
            this.lblDrinkVolume.Name = "lblDrinkVolume";
            this.lblDrinkVolume.Size = new System.Drawing.Size(42, 13);
            this.lblDrinkVolume.TabIndex = 53;
            this.lblDrinkVolume.Text = "Volume";
            // 
            // lblnewOrdDescr
            // 
            this.lblnewOrdDescr.AutoSize = true;
            this.lblnewOrdDescr.Location = new System.Drawing.Point(12, 199);
            this.lblnewOrdDescr.Name = "lblnewOrdDescr";
            this.lblnewOrdDescr.Size = new System.Drawing.Size(60, 13);
            this.lblnewOrdDescr.TabIndex = 54;
            this.lblnewOrdDescr.Text = "Description";
            // 
            // rtfDescription
            // 
            this.rtfDescription.Location = new System.Drawing.Point(78, 175);
            this.rtfDescription.Name = "rtfDescription";
            this.rtfDescription.Size = new System.Drawing.Size(325, 66);
            this.rtfDescription.TabIndex = 56;
            this.rtfDescription.Text = "";
            // 
            // frmAddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 335);
            this.Controls.Add(this.rtfDescription);
            this.Controls.Add(this.lblnewOrdDescr);
            this.Controls.Add(this.lblDrinkVolume);
            this.Controls.Add(this.lblPizzaSize);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.cmbDrinkSize);
            this.Controls.Add(this.cmbPizzaSize);
            this.Controls.Add(this.numDrinks);
            this.Controls.Add(this.numPizzas);
            this.Controls.Add(this.cmbDrinks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPizzaType);
            this.Controls.Add(this.lblPizzaType);
            this.Controls.Add(this.txtOrderNo);
            this.Controls.Add(this.lblOrderNo);
            this.Controls.Add(this.mnuMainMenuStrip);
            this.Name = "frmAddOrder";
            this.Text = "Add new order";
            this.mnuMainMenuStrip.ResumeLayout(false);
            this.mnuMainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPizzas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDrinks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Label lblOrderNo;
        private System.Windows.Forms.Label lblPizzaType;
        private System.Windows.Forms.ComboBox cmbPizzaType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDrinks;
        private System.Windows.Forms.NumericUpDown numPizzas;
        private System.Windows.Forms.NumericUpDown numDrinks;
        private System.Windows.Forms.ComboBox cmbPizzaSize;
        private System.Windows.Forms.ComboBox cmbDrinkSize;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Label lblPizzaSize;
        private System.Windows.Forms.Label lblDrinkVolume;
        private System.Windows.Forms.Label lblnewOrdDescr;
        private System.Windows.Forms.RichTextBox rtfDescription;
        public System.Windows.Forms.TextBox txtOrderNo;
    }
}