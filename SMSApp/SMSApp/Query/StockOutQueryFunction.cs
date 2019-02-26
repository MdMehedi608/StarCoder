using System;
using SMSApp.Models;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMSApp.Quarry
{
    public class StockOutQueryFunction
    {
        string dbConn = @"Server=DESKTOP-MQBJVD6\SQLEXPRESS; Database=SMSDB; Integrated Security=true; User Id = sa; Password = 123";
        private SqlConnection conn;
        private SqlCommand cmd;
        private DataTable dataTable;
        private SqlDataAdapter dataAdapter;
        private SqlDataReader dataReader;
        public int Add(string query)
        {
            int isExcuted = 0;
            try
            {
                conn = new SqlConnection(dbConn);
                cmd = new SqlCommand(query, conn);
                conn.Open();
                isExcuted = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isExcuted;
        }
        public int Upadate(string query)
        {
            int isExcuted = 0;
            try
            {
                conn = new SqlConnection(dbConn);
                cmd = new SqlCommand(query, conn);
                conn.Open();
                isExcuted = cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return isExcuted;
        }
        public bool Delete(StockOut stockOut)
        {
            bool isAdd = false;
            try
            {
                conn = new SqlConnection(dbConn);
                string query =
                    @"DELETE StockOut WHERE ID = '" + stockOut.ID + "' )";
                cmd = new SqlCommand(query, conn);
                conn.Open();
                int isExcuted = cmd.ExecuteNonQuery();
                if (isExcuted > 0)
                {
                    isAdd = true;
                }
                else
                {
                    isAdd = false;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return isAdd;
        }
        public DataTable GetCopanyCombo()
        {
            dataTable = new DataTable();
            try
            {
                conn = new SqlConnection(dbConn);
                string query = @"SELECT ID, Name FROM Company";
                cmd = new SqlCommand(query, conn);
                conn.Open();
                dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(dataTable);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dataTable;
        }

        public DataTable GetItemCombo(Item item)
        {
            dataTable = new DataTable();
            try
            {
                conn = new SqlConnection(dbConn);
                string query = @"SELECT ID, ItemName FROM Item WHERE  CompanyID = '" + item.CompanyID + "'";
                cmd = new SqlCommand(query, conn);
                conn.Open();
                dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(dataTable);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dataTable;
        }

        public Item GetFieldData(StockOut stockOut)
        {
            Item item = new Item();
            dataTable = new DataTable();
            try
            {
                conn = new SqlConnection(dbConn);
                string query = @"SELECT ReorderLevel, AvailableQuantity FROM Item WHERE  ID = '" + stockOut.ItemID + "'";
                cmd = new SqlCommand(query, conn);
                conn.Open();
                dataReader = cmd.ExecuteReader();
                while(dataReader.Read())
                {
                    item.ReorderLevel += Convert.ToDecimal(dataReader["ReorderLevel"]);
                    item.AvailableQuantity += Convert.ToDecimal(dataReader["AvailableQuantity"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return item;
        }
    }
}
