﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleTemplate_1.Models
{
    public class CartLine
    {
        public int CartLineID { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal TotalSum { get; set; }
        public DateTime OrderTime { get; set; } = DateTime.Now; //когда сделали покупку.
    }
}
