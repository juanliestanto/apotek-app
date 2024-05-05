using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apotek_app
{
    public class Transactions
    {
        public int Id { get; set; }
        public int Operator_Id { get; set; }
        public DateTime Transaction_Date { get; set; }
        public string Invoice_Number { get; set; }
    }
}
