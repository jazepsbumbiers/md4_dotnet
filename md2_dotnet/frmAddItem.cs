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
    public partial class frmAddItem : Form
    {
        public frmAddItem()
        {
            InitializeComponent();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            String itemNo = txtItemNo.Text;
            String category = cmbCategory.Text;
            String title = txtTitle.Text;
            String descr = rtfItemDescription.Text;
            String stringQuantity = txtQuantity.Text;
            String stringPrice = txtPrice.Text;

            double quantity = System.Convert.ToDouble(stringQuantity);
            double price = System.Convert.ToDouble(stringPrice);
            double pvn = (price * (21 / 100));
            double totalPrice = price + pvn;

            string dateTime = DateTime.Now.ToString("HH:mm:ss tt");

            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Jazeps Bumbiers\source\repos\md4_dotnet\inventory.mdb";
            connection.Open();

            OleDbCommand saveData = new OleDbCommand();
            saveData.Connection = connection;

            saveData.CommandText = "INSERT INTO items (ItemNo, Category, Title, Description, Quantity, Price, PVN, TotalPrice, DatenTime) VALUES (@itemNo, @category, @title, @descr, @quantity, @price, @pvn, @totalPrice, @dateTime)";
            saveData.Parameters.AddWithValue("@itemNo", OleDbType.Char).Value = itemNo;
            saveData.Parameters.AddWithValue("@category", OleDbType.Char).Value = category;
            saveData.Parameters.AddWithValue("@title", OleDbType.Char).Value = title;
            saveData.Parameters.AddWithValue("@descr", OleDbType.Char).Value = descr;
            saveData.Parameters.AddWithValue("@quantity", OleDbType.Double).Value = quantity;
            saveData.Parameters.AddWithValue("@price", OleDbType.Double).Value = price;
            saveData.Parameters.AddWithValue("@pvn", OleDbType.Double).Value = pvn;
            saveData.Parameters.AddWithValue("@totalPrice", OleDbType.Double).Value = totalPrice;
            saveData.Parameters.AddWithValue("@dateTime", OleDbType.Char).Value = dateTime;


            saveData.ExecuteNonQuery();
            MessageBox.Show("Item added!");

            connection.Close();

            this.Hide();
        }
    }
}
