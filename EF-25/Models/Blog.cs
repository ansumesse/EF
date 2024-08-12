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
    // Principle Entity or parent Entity
   internal class Blog
    {
       // 1-M Relationship
        public int Id { get; set; } // Pk: primary key or principle key 
        
        public string Url { get; set; }

        public DateTime AddedOn { get; set; }
        public int Rate { get; set; }

        //public List<Post> Posts { get; set; } // Called Collection Navigation property 
    }
}
