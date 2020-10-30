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
        public Popup Popup { get; set; }
        public float Price { get; set; }
        public string ImagePath { get; set; }
        public bool IsActive { get; set; }
    }
}
