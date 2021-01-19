using System.Collections.Generic;

namespace OrderLibrary.Model
{
    public class ProductCollection
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }

        public int CollectionCategoryId { get; set; }

        public CollectionCategory CollectionCategory { get; set; }
    }
}