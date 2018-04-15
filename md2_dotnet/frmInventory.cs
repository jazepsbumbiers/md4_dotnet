using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace md2_dotnet
{
    public partial class frmInventory : Form
    {
        public frmInventory()
        {
            InitializeComponent();
        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            dgdInventoryTable.ColumnCount = 11;

            dgdInventoryTable.Columns[0].Name = "Item number";
            dgdInventoryTable.Columns[0].DataPropertyName = "ItemNo";
            dgdInventoryTable.Columns[1].Name = "Category";
            dgdInventoryTable.Columns[1].DataPropertyName = "Category";
            dgdInventoryTable.Columns[2].Name = "Title";
            dgdInventoryTable.Columns[2].DataPropertyName = "Title";
            dgdInventoryTable.Columns[3].Name = "Description";
            dgdInventoryTable.Columns[3].DataPropertyName = "Description";
            dgdInventoryTable.Columns[4].Name = "Quantity";
            dgdInventoryTable.Columns[4].DataPropertyName = "Quantity";
            dgdInventoryTable.Columns[5].Name = "Price per unit";
            dgdInventoryTable.Columns[5].DataPropertyName = "PricePerUnit";
            dgdInventoryTable.Columns[6].Name = "Total price";
            dgdInventoryTable.Columns[6].DataPropertyName = "TotalPrice";
            dgdInventoryTable.Columns[7].Name = "PVN";
            dgdInventoryTable.Columns[7].DataPropertyName = "PVN";
            dgdInventoryTable.Columns[8].Name = "Price + PVN";
            dgdInventoryTable.Columns[8].DataPropertyName = "PriceWithPVN";
            dgdInventoryTable.Columns[9].Name = "Date";
            dgdInventoryTable.Columns[9].DataPropertyName = "Date";
            dgdInventoryTable.Columns[10].Name = "Time";
            dgdInventoryTable.Columns[10].DataPropertyName = "Time";        

            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Jazeps Bumbiers\source\repos\md4_dotnet\inventory.mdb";
            string query = "SELECT * FROM items";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgdInventoryTable.AutoGenerateColumns = false;
                    dgdInventoryTable.DataSource = ds.Tables[0];
                }
            }

            int numRows = dgdInventoryTable.Rows.Count;
            //int count = numRows - 1;
            txtTotalItems.Text = (numRows - 1).ToString();

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            frmAddItem addItem = new frmAddItem();
            addItem.ShowDialog();
        }

    }
}
