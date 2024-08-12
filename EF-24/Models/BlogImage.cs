using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_24.Models
{
    internal class BlogImage
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Caption { get; set; }
        public int Blog_Id { get; set; }
        [ForeignKey("Blog_Id")]
        public Blog Blog { get; set; }
    }
}
