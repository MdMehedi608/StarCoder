using System;
using SMSApp.Models;
using SMSApp.Quarry;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SMSApp
{
    public partial class StockOutUi : Form
    {
        StockOutQueryFunction stockOutFunction = new StockOutQueryFunction();

        private List<StockOut> stockOut = new List<StockOut>();
        private List<Item> itemQuantity = new List<Item>();
        public StockOutUi()
        {
            InitializeComponent();
            companyComboBox.DataSource = stockOutFunction.GetCopanyCombo();
        }

        private void companyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item item = new Item();
            item.CompanyID = Convert.ToInt32(companyComboBox.SelectedValue);
            itemComboBox.DataSource = stockOutFunction.GetItemCombo(item);
        }

        private int i = 0;
        private int j = 0;
        private void AddButton_Click(object sender, EventArgs e)
        {
            StockOut stock = new StockOut();
            Item item = new Item();
            dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = null;
            stock.CompanyID = Convert.ToInt32(companyComboBox.SelectedValue);
            stock.ItemID = Convert.ToInt32(itemComboBox.SelectedValue);
            stock.StockOutDate = DateTime.Now;
            stock.StockOutQuantity = Convert.ToDecimal(stockOutQuantityTextBox.Text);
            item.AvailableQuantity = (Convert.ToDecimal(abailableQuantityTextBox.Text));
            stockOut.Add(stock);
            dataGridView.DataSource = stockOut;
            while (j<=i)
            {
                item.AvailableQuantity -= stock.StockOutQuantity;
                item.ID = stock.ItemID;
                itemQuantity.Add(item);
                j++;
            }
            i++;
            
        }

        private void SellButton_Click(object sender, EventArgs e)
        {
            int isSave = 0;
            int isUpdate = 0;
            stockOutFunction = new StockOutQueryFunction();
            foreach (var list in stockOut)
            {
                list.Status = "S";
                string query =
                        @"INSERT INTO StockOut (CompanyID, ItemID, StockOutQuantity, StockOutDate, Status )VALUES('" +
                        list.CompanyID + "', '" + list.ItemID + "', '" + list.StockOutQuantity + "', '" +
                        list.StockOutDate + "', '" + list.Status + "')";
                isSave = stockOutFunction.Add(query);
                
            }
            foreach (var item in itemQuantity)
            {
                string query = @"UPDATE Item Set AvailableQuantity = '" + item.AvailableQuantity + "' WHERE ID = '" +
                           item.ID+ "'";
                if (isSave > 0)
                {
                    isUpdate = stockOutFunction.Upadate(query);
                }
            }
            if (isUpdate > 0)
            {
                if (isSave > 0)
                {
                    MessageBox.Show("Save Success!!");
                }
                else
                {
                    MessageBox.Show("Not Save Success!!");
                }
            }
            else
            {
                MessageBox.Show("Not Update!!");
            }
            
            
        }

        private void itemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            StockOut stockOut = new StockOut();
            Item item = new Item();
            stockOut.ItemID = (int)itemComboBox.SelectedValue;
            item = stockOutFunction.GetFieldData(stockOut);
            if (item.ReorderLevel != null || item.AvailableQuantity != null)
            {
                reorderLevelTextBox.Text = item.ReorderLevel.ToString();
                abailableQuantityTextBox.Text = item.AvailableQuantity.ToString();
            }
            else
            {
                reorderLevelTextBox.Text = "0";
                abailableQuantityTextBox.Text = "0";
            }


        }




        //int row = 0;
        //dataGridView.Rows.Add();
        //row = dataGridView.Rows.Count - 2;
        //dataGridView["CompanyID", row].Value = stock.CompanyID;
        //dataGridView["ItemID", row].Value = stock.ItemID;
        //dataGridView["StockOutQuantity", row].Value = stock.StockOutQuantity;


    }
}
