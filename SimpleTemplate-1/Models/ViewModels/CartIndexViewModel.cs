﻿
namespace SimpleTemplate_1.Models.ViewModels
{
    public class CartIndexViewModel
    {
        public int CartId { get; set; }
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
    }
}
