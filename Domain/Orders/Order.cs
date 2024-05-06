using Domain.Customers;
using Domain.Orders;
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
        public OrderId Id { get; private set; }
        public CustomerId CustomerId { get; private set; }

        private readonly HashSet<Item> itemsToBuy = new HashSet<Item>();

        private Order(Customer customer)
        {
            Id = new OrderId(Guid.NewGuid());
            CustomerId = customer.Id;
        }


        public static Order Create(Customer customer)
        {
            Order order = new Order(customer);
            return order;
        }

        public void AddProduct(Product product)
        {
            itemsToBuy.Add(new Item(new ItemId(Guid.NewGuid()), Id, product.Id, product.Price));
        }

    }
}

public struct Item
{
    public Item(ItemId id, OrderId orderId, ProductId productId, Money price)
    {
        this.Id = id;
        this.OrderId = orderId;
        this.ProductId = productId;
        this.Price = price;
    }
    private ItemId Id;
    private OrderId OrderId;
    private ProductId ProductId;
    private Money Price;
}
