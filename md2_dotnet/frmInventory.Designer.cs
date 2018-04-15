namespace md2_dotnet
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
            this.btnExportToExcel = new System.Windows.Forms.Button();
            this.lblTotalItems = new System.Windows.Forms.Label();
            this.txtTotalItems = new System.Windows.Forms.TextBox();
            this.lblFilterSalesDateTo = new System.Windows.Forms.Label();
            this.dtpFilterInventoryDateTo = new System.Windows.Forms.DateTimePicker();
            this.lblFilterSalesDateFrom = new System.Windows.Forms.Label();
            this.dtpFilterInventoryDateFrom = new System.Windows.Forms.DateTimePicker();
            this.dgdInventoryTable = new System.Windows.Forms.DataGridView();
            this.lblPriceOfItemsInventory = new System.Windows.Forms.Label();
            this.txtTotalPriceOfItemsInventory = new System.Windows.Forms.TextBox();
            this.btnFilterInventory = new System.Windows.Forms.Button();
            this.lblTotalPVNInventory = new System.Windows.Forms.Label();
            this.txtTotalPVNInventory = new System.Windows.Forms.TextBox();
            this.lblTotalPriceInventory = new System.Windows.Forms.Label();
            this.txtTotalPriceInventory = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgdInventoryTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Location = new System.Drawing.Point(749, 402);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(90, 22);
            this.btnExportToExcel.TabIndex = 17;
            this.btnExportToExcel.Text = "Export to excel";
            this.btnExportToExcel.UseVisualStyleBackColor = true;
            // 
            // lblTotalItems
            // 
            this.lblTotalItems.AutoSize = true;
            this.lblTotalItems.Location = new System.Drawing.Point(628, 372);
            this.lblTotalItems.Name = "lblTotalItems";
            this.lblTotalItems.Size = new System.Drawing.Size(115, 13);
            this.lblTotalItems.TabIndex = 16;
            this.lblTotalItems.Text = "Total items in inventory";
            // 
            // txtTotalItems
            // 
            this.txtTotalItems.Location = new System.Drawing.Point(749, 369);
            this.txtTotalItems.Name = "txtTotalItems";
            this.txtTotalItems.ReadOnly = true;
            this.txtTotalItems.Size = new System.Drawing.Size(90, 20);
            this.txtTotalItems.TabIndex = 15;
            // 
            // lblFilterSalesDateTo
            // 
            this.lblFilterSalesDateTo.AutoSize = true;
            this.lblFilterSalesDateTo.Location = new System.Drawing.Point(255, 9);
            this.lblFilterSalesDateTo.Name = "lblFilterSalesDateTo";
            this.lblFilterSalesDateTo.Size = new System.Drawing.Size(44, 13);
            this.lblFilterSalesDateTo.TabIndex = 14;
            this.lblFilterSalesDateTo.Text = "To date";
            // 
            // dtpFilterInventoryDateTo
            // 
            this.dtpFilterInventoryDateTo.Location = new System.Drawing.Point(258, 25);
            this.dtpFilterInventoryDateTo.Name = "dtpFilterInventoryDateTo";
            this.dtpFilterInventoryDateTo.Size = new System.Drawing.Size(200, 20);
            this.dtpFilterInventoryDateTo.TabIndex = 13;
            // 
            // lblFilterSalesDateFrom
            // 
            this.lblFilterSalesDateFrom.AutoSize = true;
            this.lblFilterSalesDateFrom.Location = new System.Drawing.Point(12, 9);
            this.lblFilterSalesDateFrom.Name = "lblFilterSalesDateFrom";
            this.lblFilterSalesDateFrom.Size = new System.Drawing.Size(54, 13);
            this.lblFilterSalesDateFrom.TabIndex = 12;
            this.lblFilterSalesDateFrom.Text = "From date";
            // 
            // dtpFilterInventoryDateFrom
            // 
            this.dtpFilterInventoryDateFrom.Location = new System.Drawing.Point(12, 25);
            this.dtpFilterInventoryDateFrom.Name = "dtpFilterInventoryDateFrom";
            this.dtpFilterInventoryDateFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpFilterInventoryDateFrom.TabIndex = 11;
            // 
            // dgdInventoryTable
            // 
            this.dgdInventoryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdInventoryTable.Location = new System.Drawing.Point(12, 63);
            this.dgdInventoryTable.Name = "dgdInventoryTable";
            this.dgdInventoryTable.Size = new System.Drawing.Size(873, 290);
            this.dgdInventoryTable.TabIndex = 10;
            // 
            // lblPriceOfItemsInventory
            // 
            this.lblPriceOfItemsInventory.AutoSize = true;
            this.lblPriceOfItemsInventory.Location = new System.Drawing.Point(399, 372);
            this.lblPriceOfItemsInventory.Name = "lblPriceOfItemsInventory";
            this.lblPriceOfItemsInventory.Size = new System.Drawing.Size(117, 13);
            this.lblPriceOfItemsInventory.TabIndex = 19;
            this.lblPriceOfItemsInventory.Text = "Price of items w/o PVN";
            // 
            // txtTotalPriceOfItemsInventory
            // 
            this.txtTotalPriceOfItemsInventory.Location = new System.Drawing.Point(522, 369);
            this.txtTotalPriceOfItemsInventory.Name = "txtTotalPriceOfItemsInventory";
            this.txtTotalPriceOfItemsInventory.ReadOnly = true;
            this.txtTotalPriceOfItemsInventory.Size = new System.Drawing.Size(90, 20);
            this.txtTotalPriceOfItemsInventory.TabIndex = 18;
            // 
            // btnFilterInventory
            // 
            this.btnFilterInventory.Location = new System.Drawing.Point(491, 21);
            this.btnFilterInventory.Name = "btnFilterInventory";
            this.btnFilterInventory.Size = new System.Drawing.Size(75, 23);
            this.btnFilterInventory.TabIndex = 20;
            this.btnFilterInventory.Text = "Filter";
            this.btnFilterInventory.UseVisualStyleBackColor = true;
            // 
            // lblTotalPVNInventory
            // 
            this.lblTotalPVNInventory.AutoSize = true;
            this.lblTotalPVNInventory.Location = new System.Drawing.Point(419, 402);
            this.lblTotalPVNInventory.Name = "lblTotalPVNInventory";
            this.lblTotalPVNInventory.Size = new System.Drawing.Size(85, 13);
            this.lblTotalPVNInventory.TabIndex = 22;
            this.lblTotalPVNInventory.Text = "Total PVN value";
            // 
            // txtTotalPVNInventory
            // 
            this.txtTotalPVNInventory.Location = new System.Drawing.Point(522, 399);
            this.txtTotalPVNInventory.Name = "txtTotalPVNInventory";
            this.txtTotalPVNInventory.ReadOnly = true;
            this.txtTotalPVNInventory.Size = new System.Drawing.Size(90, 20);
            this.txtTotalPVNInventory.TabIndex = 21;
            // 
            // lblTotalPriceInventory
            // 
            this.lblTotalPriceInventory.AutoSize = true;
            this.lblTotalPriceInventory.Location = new System.Drawing.Point(419, 431);
            this.lblTotalPriceInventory.Name = "lblTotalPriceInventory";
            this.lblTotalPriceInventory.Size = new System.Drawing.Size(96, 13);
            this.lblTotalPriceInventory.TabIndex = 24;
            this.lblTotalPriceInventory.Text = "Total price of items";
            // 
            // txtTotalPriceInventory
            // 
            this.txtTotalPriceInventory.Location = new System.Drawing.Point(522, 428);
            this.txtTotalPriceInventory.Name = "txtTotalPriceInventory";
            this.txtTotalPriceInventory.ReadOnly = true;
            this.txtTotalPriceInventory.Size = new System.Drawing.Size(90, 20);
            this.txtTotalPriceInventory.TabIndex = 23;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(15, 379);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(91, 36);
            this.btnAddItem.TabIndex = 25;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 494);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.lblTotalPriceInventory);
            this.Controls.Add(this.txtTotalPriceInventory);
            this.Controls.Add(this.lblTotalPVNInventory);
            this.Controls.Add(this.txtTotalPVNInventory);
            this.Controls.Add(this.btnFilterInventory);
            this.Controls.Add(this.lblPriceOfItemsInventory);
            this.Controls.Add(this.txtTotalPriceOfItemsInventory);
            this.Controls.Add(this.btnExportToExcel);
            this.Controls.Add(this.lblTotalItems);
            this.Controls.Add(this.txtTotalItems);
            this.Controls.Add(this.lblFilterSalesDateTo);
            this.Controls.Add(this.dtpFilterInventoryDateTo);
            this.Controls.Add(this.lblFilterSalesDateFrom);
            this.Controls.Add(this.dtpFilterInventoryDateFrom);
            this.Controls.Add(this.dgdInventoryTable);
            this.Name = "frmInventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.frmInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdInventoryTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExportToExcel;
        private System.Windows.Forms.Label lblTotalItems;
        private System.Windows.Forms.TextBox txtTotalItems;
        private System.Windows.Forms.Label lblFilterSalesDateTo;
        private System.Windows.Forms.DateTimePicker dtpFilterInventoryDateTo;
        private System.Windows.Forms.Label lblFilterSalesDateFrom;
        private System.Windows.Forms.DateTimePicker dtpFilterInventoryDateFrom;
        private System.Windows.Forms.DataGridView dgdInventoryTable;
        private System.Windows.Forms.Label lblPriceOfItemsInventory;
        private System.Windows.Forms.TextBox txtTotalPriceOfItemsInventory;
        private System.Windows.Forms.Button btnFilterInventory;
        private System.Windows.Forms.Label lblTotalPVNInventory;
        private System.Windows.Forms.TextBox txtTotalPVNInventory;
        private System.Windows.Forms.Label lblTotalPriceInventory;
        private System.Windows.Forms.TextBox txtTotalPriceInventory;
        private System.Windows.Forms.Button btnAddItem;
    }
}