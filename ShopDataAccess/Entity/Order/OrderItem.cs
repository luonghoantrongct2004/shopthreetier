﻿using System.ComponentModel.DataAnnotations;

namespace ShopDataAccess.Entity.Order
{
    public class OrderItem
    {
        [Key]
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        [Display(Name = "Số lượng")]
        public int Quantity { get; set; }
        [Display(Name = "Giá tiền mỗi sản phẩm")]
        public decimal UnitPrice { get; set; }
    }
}
