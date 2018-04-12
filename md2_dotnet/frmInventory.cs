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

            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Jazeps Bumbiers\source\repos\md4_dotnet\inventory.mdb";
            string query = "SELECT * FROM items";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgdInventoryTable.DataSource = ds.Tables[0];

                }
            }

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            frmAddItem addItem = new frmAddItem();
            addItem.ShowDialog();
        }
    }
}
