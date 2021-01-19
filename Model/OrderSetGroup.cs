namespace OrderLibrary.Model
{
    public class OrderSetGroup
    {
        public int Id { get; set; }

        public SetGroup SetGroup { get; set; }

        public int SetGroupId { get; set; }

        public Product Product { get; set; }

        public int ProductId { get; set; }

        public Variant Variant { get; set; }

        public int VariantId { get; set; }
    }
}