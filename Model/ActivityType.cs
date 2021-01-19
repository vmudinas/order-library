using System.Collections.Generic;

namespace OrderLibrary.Model
{
    public class ActivityType
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}