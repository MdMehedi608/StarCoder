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

namespace SMSApp
{
    public partial class StockOutUi : Form
    {
        StockOutQueryFunction stockOutFunction = new StockOutQueryFunction();
        public StockOutUi()
        {
            InitializeComponent();
            companyComboBox.DataSource = stockOutFunction.GetCopanyCombo();
        }

        private void companyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
