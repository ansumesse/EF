using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_09.Models
{
    // Depndent Entity or Child Entity
    internal class Post
    {
       
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Blogid { get; set; } // foreign key FK // When Deleting the foreign key EF still recoginze the 1-M Relation Because of the referenc Navigation prop
        // and will Create shadow foreign key
        // public Blog Blog { get; set; } //Reference navigation property // Even if we delete the reference navigation prop EF still recoginze the 1-M Relation
                                                                           // Because of collection navigation prop in Blog Entity
                                                                           // and produces a single 

    }
}
