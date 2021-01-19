using System.Collections.Generic;

namespace OrderLibrary.Model
{
    public class CollectionCategory
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<ProductCollection> ProductCollections { get; set; }
    }
}