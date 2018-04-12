using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace md2_dotnet
{
    public partial class frmAccounting : Form
    {
        public frmAccounting()
        {
            InitializeComponent();
        }

        private void mnuInventoryBrowse_Click(object sender, EventArgs e)
        {
            frmInventory inventoryForm = new frmInventory();
            inventoryForm.ShowDialog();
        }

        private void mnuFileProductsBrowser_Click(object sender, EventArgs e)
        {
            frmBrowser browserForm = new frmBrowser();
            browserForm.ShowDialog();
        }

        private void mnuHelpAbout_Click(object sender, EventArgs e)
        {
            frmAbout aboutForm = new frmAbout();
            aboutForm.ShowDialog();
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            frmAddOrder newOrderForm = new frmAddOrder(this);
            newOrderForm.ShowDialog();
        }

        private void frmAccounting_Load(object sender, EventArgs e)
        {
           
            
        }
    }
}


