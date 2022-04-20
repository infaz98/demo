﻿using System.ComponentModel.DataAnnotations;

namespace PresentationLayer.Models
{
    public class ProductViewModel
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public double Price { get; set; }
    }
}
