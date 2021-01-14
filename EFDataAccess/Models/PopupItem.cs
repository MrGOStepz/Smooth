using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFDataAccess.Models
{
    public class PopupItem
    {
        public int Id { get; set; }

        [MaxLength(200)]
        public string Name { get; set; }
        public virtual Popup Popup { get; set; } = new Popup();
        public float Price { get; set; } = 0.00f;
        public string ImagePath { get; set; } = "";
        public bool IsActive { get; set; } = true;
    }
}
