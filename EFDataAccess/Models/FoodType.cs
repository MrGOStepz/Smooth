using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFDataAccess.Models
{
    public class FoodType
    {
        private FoodType(FoodTypeEnum @enum)
        {
            Id = (int)@enum;
            Name = @enum.ToString();
        }

        protected FoodType() { }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [MaxLength(200)]
        public string Name { get; set; }

        public static implicit operator FoodType(FoodTypeEnum @enum) => new FoodType(@enum);

        public static implicit operator FoodTypeEnum(FoodType FoodType) => (FoodTypeEnum)FoodType.Id;
    }

    public enum FoodTypeEnum
    {
        Entree = 1,
        Main = 2,
        Dessert = 3,
        Beverage = 4

    }

}
