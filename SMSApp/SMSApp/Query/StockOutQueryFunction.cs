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
        string dbConn = @"Server=DESKTOP-MQBJVD6\SQLEXPRESS; Database=SMSDB; Integrated Security=true; User ID=sa; Password=123";
        private SqlConnection conn;
        private SqlCommand cmd;
        private DataTable dataTable;
        private SqlDataAdapter dataAdapter;
        public bool Add(StockOut stockOut)
        {
            bool isAdd = false;
            try
            {
                conn = new SqlConnection(dbConn);
                string query =
                    @"INSERT INTO StockOut (CompanyID, ItemID, StockOutQuantity, StockOutDate, Status )VALUES('" +
                    stockOut.CompanyID + "', '" + stockOut.ItemID + "', '" + stockOut.StockOutQuantity + "', '" +
                    stockOut.StockOutDate + "', '" + stockOut.Status + "')";
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
        public bool Upadate(StockOut stockOut)
        {
            bool isAdd = false;
            try
            {
                conn = new SqlConnection(dbConn);
                string query =
                    @"Update StockOut Set CompanyID = '" + stockOut.CompanyID + "', ItemID = '" + stockOut.ItemID + "', StockOutQuantity = '" + stockOut.StockOutQuantity + "', StockOutDate = '" + stockOut.StockOutDate + "', Status = '" + stockOut.Status + "' WHERE ID = '" + stockOut.ID + "' )";
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
    }
}
