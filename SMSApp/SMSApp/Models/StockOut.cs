using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSApp.Models
{
    public class StockOut
    {
        public int ID { get; set; }
        public int CompanyID { get; set; }
        public int ItemID { get; set; }
        public decimal StockOutQuantity { get; set; }
        public DateTime StockOutDate { get; set; }
        public string Status { get; set; }
    }
}
