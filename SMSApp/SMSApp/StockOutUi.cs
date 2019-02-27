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
            dataGridView.DataSource = null;
            string query = @"SELECT ID, Name FROM Company";
            companyComboBox.DataSource = stockOutFunction.GetData(query);
        }

        private void companyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item item = new Item();
            item.CompanyID = Convert.ToInt32(companyComboBox.SelectedValue);
            string query = @"SELECT ID, ItemName FROM Item WHERE  CompanyID = '" + item.CompanyID + "'";
            itemComboBox.DataSource = stockOutFunction.GetData(query);
        }

        private int i = 0;
        private int j = 0;

        public bool Exsit()
        {
            bool isExsit = false;
            for (int k = 0; k < stockOut.Count; k++)
            {
                if (stockOut[k].CompanyID == (int)companyComboBox.SelectedValue && stockOut[k].ItemID == (int)itemComboBox.SelectedValue)
                {
                    isExsit = true;
                }
            }
            return isExsit;
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (companyComboBox.SelectedValue != null && itemComboBox.SelectedValue != null && stockOutQuantityTextBox.Text != "")
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
                if (Convert.ToDecimal(abailableQuantityTextBox.Text) < stock.StockOutQuantity)
                {
                    MessageBox.Show("Please AbailableQuntity less then Stock Out Quantity!!");
                    dataGridView.DataSource = stockOut;
                    return;
                }
                if (Exsit())
                {
                    MessageBox.Show("Company And Item Allready Exsit!!");
                    dataGridView.DataSource = stockOut;
                    return;
                }
                stockOut.Add(stock);
                dataGridView.DataSource = stockOut;
                while (j <= i)
                {
                    item.AvailableQuantity -= stock.StockOutQuantity;
                    item.ID = stock.ItemID;
                    itemQuantity.Add(item);
                    j++;
                }
                i++;
                
            }
            else
            {
                MessageBox.Show("Please All Field Required");
            }
            
            
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
                    SaveClearData();
                }
                else
                {
                    MessageBox.Show("Not Save Success!!");
                    SaveClearData();
                }
            }
            else
            {
                MessageBox.Show("Not Update!!");
                SaveClearData();
            }
            
            
        }

        // Damage Save
        private void DamageButton_Click(object sender, EventArgs e)
        {
            int isSave = 0;
            int isUpdate = 0;
            stockOutFunction = new StockOutQueryFunction();
            foreach (var list in stockOut)
            {
                list.Status = "D";
                string query =
                        @"INSERT INTO StockOut (CompanyID, ItemID, StockOutQuantity, StockOutDate, Status )VALUES('" +
                        list.CompanyID + "', '" + list.ItemID + "', '" + list.StockOutQuantity + "', '" +
                        list.StockOutDate + "', '" + list.Status + "')";
                isSave = stockOutFunction.Add(query);

            }
            foreach (var item in itemQuantity)
            {
                string query = @"UPDATE Item Set AvailableQuantity = '" + item.AvailableQuantity + "' WHERE ID = '" +
                           item.ID + "'";
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
                    SaveClearData();
                }
                else
                {
                    MessageBox.Show("Not Save Success!!");
                    SaveClearData();
                }
            }
            else
            {
                MessageBox.Show("Not Update!!");
                SaveClearData();
            }
        }

        //Lost 

        private void LostButton_Click(object sender, EventArgs e)
        {
            int isSave = 0;
            int isUpdate = 0;
            stockOutFunction = new StockOutQueryFunction();
            foreach (var list in stockOut)
            {
                list.Status = "L";
                string query =
                        @"INSERT INTO StockOut (CompanyID, ItemID, StockOutQuantity, StockOutDate, Status )VALUES('" +
                        list.CompanyID + "', '" + list.ItemID + "', '" + list.StockOutQuantity + "', '" +
                        list.StockOutDate + "', '" + list.Status + "')";
                isSave = stockOutFunction.Add(query);

            }
            foreach (var item in itemQuantity)
            {
                string query = @"UPDATE Item Set AvailableQuantity = '" + item.AvailableQuantity + "' WHERE ID = '" +
                           item.ID + "'";
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
                    SaveClearData();
                }
                else
                {
                    MessageBox.Show("Not Save Success!!");
                    SaveClearData();
                }
            }
            else
            {
                MessageBox.Show("Not Update!!");
                SaveClearData();
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

        public void Clear()
        {
            stockOutQuantityTextBox.Text = "";
        }
        public void SaveClearData()
        {
            companyComboBox.SelectedValue = 0;
            itemComboBox.SelectedValue = 0;
            itemComboBox.Text = "";
            stockOutQuantityTextBox.Text = "";
            reorderLevelTextBox.Text = "";
            abailableQuantityTextBox.Text = "";
            dataGridView.DataSource = null;
        }

        private void dataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridView.Rows[e.RowIndex].Cells["Sl"].Value = (e.RowIndex + 1).ToString();
        }



        




        //int row = 0;
        //dataGridView.Rows.Add();
        //row = dataGridView.Rows.Count - 2;
        //dataGridView["CompanyID", row].Value = stock.CompanyID;
        //dataGridView["ItemID", row].Value = stock.ItemID;
        //dataGridView["StockOutQuantity", row].Value = stock.StockOutQuantity;


    }
}
