using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_24.Models
{
    internal class Blog
    {
        [Key]
        public int Id { get; set; }
        public string Url { get; set; }
        public BlogImage Image { get; set; }
    }
}
