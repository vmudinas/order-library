using System.Collections.Generic;

namespace OrderLibrary.Model
{
    public class SetGroup
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<Product> Products { get; set; }

        public ICollection<Product> Substitutions { get; set; }

        public Product Product { get; set; }

        public int ProductId { get; set; }
    }
}