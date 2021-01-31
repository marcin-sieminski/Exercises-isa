﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Ex8.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
        [Range(0, Int32.MaxValue)]
        public double Price { get; set; }
    }
}
