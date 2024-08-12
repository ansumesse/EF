using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_09.Models
{
   // [Table("Blogs", Schema = "Blogging")] // Change Schema name By Annotation
    internal class Blog
    {
       
        public int Id { get; set; }
        // [Column("BlogUrl")] // Change column name 
        // [Column(TypeName = "varchar(50)")]
        // [MaxLength(200)]
        // [Comment("This is a comment")]
        public string Url { get; set; }

        [NotMapped] // Exclude property using Annotation
        public DateTime AddedOn { get; set; }

        // [NotMapped] // Excluding Post from Model by annotaions
        public List<Post> Posts { get; set; } // Called Navigation property that makes post a model domain
    }
}
