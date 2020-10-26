using System;
using System.Collections.Generic;
using System.Text;

namespace EFDataAccess.Models
{
    public class OrderInfo
    {
        public int Id { get; set; }
        public DateTime DateOrder { get; set; } = DateTime.Now;
        public Staff Staff { get; set; } = new Staff();
        public Order Order { get; set; } = new Order();
        public Product Product { get; set; } = new Product();
        public PopupItem PopupItem { get; set; } = new PopupItem();
        public CookStatus CookStatus { get; set; } = new CookStatus();
        public int Quantity { get; set; }
        public float Price { get; set; }
        public string Comment { get; set; }
    }
}
