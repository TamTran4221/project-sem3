﻿namespace eproject_sem3.Models
{
	public class OrderDetail
	{
		public int Id { get; set; }
		public int OrderId { get; set; }
		public int ProductId { get; set; }
		public int ServiceId { get; set; }
		public int Quantity { get; set; }
		public float Price { get; set; }
		public Order Order { get; set; }
		public Product Product { get; set; }
		public Services Services { get; set; }
	}
}
