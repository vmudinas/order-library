using System.Collections.Generic;
using System.Text.Json;

namespace OrderLibrary.Model
{
    public class Variant
    {
        public int Id { get; set; }
        
        public JsonDocument Parameters { get; set; }

        public Product Product { get; set; }

        public int ProductId { get; set; }

        public bool IsDefault { get; set; }

        public ICollection<InventoryItem> Inventory { get; set; }
        
        public ICollection<VariantReservationByDate> Reservations { get; set; }
    }
}