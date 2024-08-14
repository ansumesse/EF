using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_26.Models
{
    internal class Car
    {
        public int CarId { get; set; }
        
        public string LicensePlate { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        // public List<RecordSales> RecordSales { get; set; }
        public List<CarRecordSales> carRecordSales { get; set; }
    }
}
