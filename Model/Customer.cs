namespace OrderLibrary.Model
{ 
    public class Customer
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public string PhoneNumber { get; set; }

        public string StripeCustomerId { get; set; }
        
        public Address ShippingAddress { get; set; }

        public int ShippingAddressId { get; set; }

        public Address BillingAddress { get; set; }

        public int BillingAddressId { get; set; }
    }
}