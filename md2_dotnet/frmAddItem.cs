using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
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

        public enum Categories
        {
            Coffee,
            Tea,
            Lemonades,
            Cheese,
            Sauces,
            Dough,
            Meat,
            Vegetables
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            string itemNo = txtItemNo.Text;
            string category = cmbCategory.Text;
            string title = txtTitle.Text;
            string descr = rtfItemDescription.Text;
            string stringQuantity = txtQuantity.Text;
            string stringPricePerUnit = txtPrice.Text;

            double quantity = System.Convert.ToDouble(stringQuantity);
            double pricePerUnit = System.Convert.ToDouble(stringPricePerUnit);

            double totalPrice = pricePerUnit * quantity;
            double pvn = (totalPrice * 21) / 100;
            double priceWithPvn = totalPrice + pvn;
            //Console.WriteLine(priceWithPvn);
            
            string date = DateTime.Now.ToString("MM/dd/yyyy");
            string time = DateTime.Now.ToString("HH:mm:ss");

            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Jazeps Bumbiers\source\repos\md4_dotnet\inventory.mdb";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                using (OleDbCommand saveData = new OleDbCommand())
                {
                    saveData.Connection = connection;

                    saveData.CommandText = "INSERT INTO items (ItemNo, Category, Title, Description, Quantity, PricePerUnit, TotalPrice, PVN, PriceWithPVN, [Date], [Time]) " +
                                           "VALUES (@itemNo, @category, @title, @descr, @quantity, @pricePerUnit, @totalPrice, @pvn, @priceWithPvn, @date, @time)";
                    saveData.Parameters.AddWithValue("@itemNo", OleDbType.Char).Value = itemNo;
                    saveData.Parameters.AddWithValue("@category", OleDbType.Char).Value = category;
                    saveData.Parameters.AddWithValue("@title", OleDbType.Char).Value = title;
                    saveData.Parameters.AddWithValue("@descr", OleDbType.Char).Value = descr;
                    saveData.Parameters.AddWithValue("@quantity", OleDbType.Double).Value = quantity;
                    saveData.Parameters.AddWithValue("@pricePerUnit", OleDbType.Double).Value = pricePerUnit;
                    saveData.Parameters.AddWithValue("@totalPrice", OleDbType.Double).Value = totalPrice;
                    saveData.Parameters.AddWithValue("@pvn", OleDbType.Double).Value = pvn;
                    saveData.Parameters.AddWithValue("@priceWithPvn", OleDbType.Double).Value = priceWithPvn.ToString();
                    saveData.Parameters.AddWithValue("@date", OleDbType.Char).Value = date;
                    saveData.Parameters.AddWithValue("@time", OleDbType.Char).Value = time;

                    saveData.ExecuteNonQuery();
                    MessageBox.Show("Item added!");
                    connection.Close();

                    this.Hide();
                }
            }
        }

        private void frmAddItem_Load(object sender, EventArgs e)
        {
            cmbCategory.DataSource = Enum.GetValues(typeof(Categories));
        }
    }
}
