using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleSales.WarrantyModel
{
    public class WarrantyInfo
    {
        public string BikeModelNo { get; set; }
        public string BikeSerialNo { get; set; }
        public DateTime DateSold { get; set; }
        public int WarrantyYears { get; set; }
        public string Retailer { get; set; }
        public string Notes { get; set; }

        public DateTime Expires
        {
            get { return DateSold.AddYears(WarrantyYears); }
        }
    }
}
