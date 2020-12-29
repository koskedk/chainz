using System;

namespace Ole.Orders.Models
{
    public class Order
    {
        public string Id { get; }
        public string Agent { get; }
        public string Product { get; }
        public decimal Quantity { get; }

        public DateTime Date { get; }

        private Order(string agent, string product, decimal quantity)
        {
            Id = $"{agent}-{IdGen.Generate()}";
            Agent = agent;
            Product = product;
            Quantity = quantity;
            Date = DateTime.Now;
        }

        public static Order Create(OrderDto dto)
        {
            return new Order(dto.Agent,dto.Product,dto.Quantity);
        }
    }
}
