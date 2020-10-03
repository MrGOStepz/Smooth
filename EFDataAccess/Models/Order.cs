using System;
using System.Collections.Generic;
using System.Text;

namespace EFDataAccess.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string DateTimeOrder { get; set; }
        public OrderStatus OrderStatus { get; set; } = new OrderStatus();
        public OrderType OrderType { get; set; } = new OrderType();
        public Staff Staff { get; set; } = new Staff();
        public TableInfo TableInfo { get; set; } = new TableInfo();
        public PaymentType PaymentType { get; set; } = new PaymentType();
        public Customer Customer { get; set; } = new Customer();

    }
}
