﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFDataAccess.Models
{
    public class Product
    {
        public int Id { get; set; }

        [MaxLength(200)]
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual Popup Popup { get; set; } = new Popup();
        public virtual FoodType FoodType { get; set; }
        public virtual ICollection<PrinterProduct> PrinterProduct { get; set; } = new HashSet<PrinterProduct>();
        public virtual ICollection<Ingredient> Ingredient { get; set; } = new HashSet<Ingredient>();
        public virtual ICollection<Material> Material { get; set; } = new HashSet<Material>();
        public bool IsGlutenFree { get; set; } = false;
        public bool IsVagen { get; set; } = false;
        public int Stock { get; set; } = 0;
        public float Price { get; set; } = 0.00f;
        public bool IsAvaliable { get; set; } = true;
        public string ImagePath { get; set; }
        public bool IsActive { get; set; } = true;

    }
}
