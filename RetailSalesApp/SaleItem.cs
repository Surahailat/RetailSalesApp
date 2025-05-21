using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailSalesApp
{
    public class SaleItem
    {
        public Guid ItemGuid { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }

        public decimal SubTotal => Quantity * UnitPrice;
        public decimal VAT => SubTotal * 0.16M;
        public decimal Total => SubTotal + VAT;

    }
}
