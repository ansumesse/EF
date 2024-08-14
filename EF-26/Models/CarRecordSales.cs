using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_26.Models
{
    internal class CarRecordSales
    {
        public string LicensePlate { get; set; }
        public int RecordSaleId { get; set; }

        public Car Cars2 { get; set; }
        public RecordSales RecordSales { get; set; }

    }
}
