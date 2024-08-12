using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_26.Models
{
    internal class RecordSales
    {
         
        public int RecordSaleId { get; set; }
        public DateTime DateSold { get; set; }
        public decimal Price { get; set; }
        public string LicensePlate { get; set; }
        public Car Car { get; set; }
    }
}
