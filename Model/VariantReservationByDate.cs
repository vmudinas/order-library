using NodaTime;

namespace OrderLibrary.Model
{
    public class VariantReservationByDate
    {
        public int VariantId { get; set; }

        public Variant Variant { get; set; }

        public Product Product { get; set; }

        public int ProductId { get; set; }

        public LocalDate ReservationDate { get; set; }

        public int Count { get; set; }

        public int WarehouseId { get; set; }

        public Warehouse Warehouse { get; set; }
    }
}