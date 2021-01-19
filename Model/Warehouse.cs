using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using NetTopologySuite.Geometries;

namespace OrderLibrary.Model
{
    public class Warehouse
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [Column(TypeName="geometry (point)")]
        public Point Location { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zipcode { get; set; }

        public int PartnerId { get; set; }

        public Partner Partner { get; set; }

        public WarehouseType WarehouseType { get; set; }

        public ICollection<InventoryItem> Inventory { get; set; }
    }

    public enum WarehouseType
    {
        Warehouse,
        Store
    }
}