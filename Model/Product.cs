using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using NodaTime;
using NpgsqlTypes;

namespace OrderLibrary.Model
{
    public class Product
    {
        public int Id { get; set; }

        public ProductType ProductType { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        
        public string Slug { get; set; }

        public string DescriptionPlainText { get; set; }

        public NpgsqlTsVector SearchVector { get; set; }

        public Brand Brand { get; set; }

        public int BrandId { get; set; }

        public Partner Partner { get; set; }

        public int PartnerId { get; set; }

        public string PartnerSku { get; set; }

        public string ManufacturerUpc { get; set; }

        public Seasons Seasons { get; set; }

        public int? TemperatureRating { get; set; }

        public int? Weight { get; set; }

        public ICollection<Variant> Variants { get; set; }

        public ICollection<ActivityType> ActivityTypes { get; set; }

        public ICollection<Feature> Features { get; set; }

        public ICollection<SetGroup> SetGroups { get; set; }

        public ICollection<SetGroup> MemberSets { get; set; }

        public ICollection<SetGroup> SubstitutionMemberSets { get; set; }

        public ICollection<ProductCollection> ProductCollections { get; set; }

        public bool IsPublished { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Instant CreatedAt { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public Instant? UpdatedAt { get; set; }
    }

    public enum ProductType
    {
        Product,
        Set
    }
}