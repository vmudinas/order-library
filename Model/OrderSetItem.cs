using System.Collections.Generic;

namespace OrderLibrary.Model
{
    public class OrderSetItem
    {
        public int Id { get; set; }

        public Product Product { get; set; }

        public int ProductId { get; set; }

        public ICollection<OrderSetGroup> OrderSetGroups { get; set; }
    }
}