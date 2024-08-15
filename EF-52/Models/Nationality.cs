using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_52.Models
{
    internal class Nationality
    {
        public int NationalityId { get; set; }
        public string? NationalityName { get; set; }
        public int? AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
