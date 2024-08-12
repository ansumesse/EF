using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_09.Models
{
    internal class Book
    {
        [Key]
        public int BookKey { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
