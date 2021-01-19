using NodaTime;
using System.Collections.Generic;


namespace OrderLibrary.Model
{
    public class Order
    {
        public int Id { get; set; }

        public string PublicId { get; set; }

        public OrderStatus Status { get; set; }

        public Customer Customer { get; set; }

        public LocalDate DateFrom { get; set; }

        public LocalDate DateTo { get; set; }

        public Partner Partner { get; set; }

        public int PartnerId { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }

        public ICollection<OrderSetItem> OrderSetItems { get; set; }
      
    }


    public enum OrderStatus
    {
        Placed,
        PaymentProcessed,
        Cancelled,
        Refunded,
        Shipped,
        Returned
    }
}