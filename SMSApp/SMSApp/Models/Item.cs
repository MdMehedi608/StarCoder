using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSApp.Models
{
    public class Item
    {
        public int ID { get; set; }
        public int CategoryID { get; set; }
        public int CompanyID { get; set; }
        public string ItemName { get; set; }
        public decimal ReorderLevel { get; set; }
        public decimal AvailableQuantity { get; set; }
    }
}
