﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProductManagement.Models
{
    //Category Model
    public class Category
    {
        public short Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}