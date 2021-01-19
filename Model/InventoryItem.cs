namespace OrderLibrary.Model
{
    public class InventoryItem
    {
        public int WarehouseId { get; set; }

        public Warehouse Warehouse { get; set; }

        public int VariantId { get; set; }

        public Variant Variant { get; set; }

        public int Stock { get; set; }

        public int StockBuffer { get; set; }
    }
}