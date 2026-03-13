using CafeSale.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace CafeSale
{
    public class DrinkSale
    {
        public string DrinkName { get; set; }
        public decimal PricePerUnit { get; set; }
        public List<DaySale> DailySales { get; set; }

        public DrinkSale()
        {
            DailySales = new List<DaySale>();
        }
    }
}
