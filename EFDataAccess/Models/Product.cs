using System;
using System.Collections.Generic;
using System.Text;

namespace EFDataAccess.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public string Description { get; set; }
        public Popup Popup { get; set; } = new Popup();
        public FoodType FoodType { get; set; } = new FoodType();
        public List<PrinterInfo> PrinterInfo { get; set; }
        public List<Ingredient> Ingredient { get; set; } = new List<Ingredient>();
        public List<Material> Material { get; set; } = new List<Material>();
        public bool IsGlutenFree { get; set; }
        public bool IsVagen { get; set; }
        public int Stock { get; set; }
        public float Price { get; set; }
        public int IsAvaliable { get; set; }
        public string ImagePath { get; set; }
        public int IsActive { get; set; }

    }
}
