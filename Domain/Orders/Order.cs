using Domain.Customers;
using Domain.Products;
using Domain.SharedResources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Orders
{
    public class Order
    {
        public Guid Id { get; private set; }
        public Guid CustomerId { get; private set; }

        private readonly HashSet<Item> itemsToBuy = new HashSet<Item>();

        private Order(Guid customerId)
        {
            Id = Guid.NewGuid();
            CustomerId = customerId;
        }


        public static Order Create(Customer customer)
        {
            Order order = new Order(customer.Id);
            return order;
        }

        public void AddProduct(Product product)
        {
            itemsToBuy.Add(new Item(Guid.NewGuid(), Id, product.Id, product.Price));
        }

    }
}

public struct Item
{
    public Item(Guid Id, Guid OrderId, Guid ProductId, Money Price)
    {
        this.Id = Id;
        this.OrderId = OrderId;
        this.ProductId = ProductId;
        this.Price = Price;
    }
    private Guid Id;
    private Guid OrderId;
    private Guid ProductId;
    private Money Price;
}
