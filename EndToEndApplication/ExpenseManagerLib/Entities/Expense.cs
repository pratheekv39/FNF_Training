using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManagerLib
{
    public class Expense
    {
        public string ExpDesc { get; set; }
        public decimal Amount { get; set; }
        public DateTime ExpDate { get; set; }
        public int ExpId { get; set; }
    }
}
