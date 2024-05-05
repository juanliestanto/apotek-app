using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apotek_app
{
    public class TransactionDetail
    {
        public int Id { get; set; }
        public int Product_ID { get; set; }
        public string Code_Product { get; set; }
        public string Product_Name { get; set; }
        public int Quantity { get; set; }
        public int Sub_Total { get; set; }
    }
}
