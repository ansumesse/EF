﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_08.Models
{
    internal class Blog
    {
        public int Id { get; set; }

        [Required]
        public string Url { get; set; }
    }
}
