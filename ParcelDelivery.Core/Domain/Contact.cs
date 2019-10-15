namespace ParcelDelivery.Core.Domain
{
    public class Contact : Company
    {
        public string Name { get; set; }
        public Address Address { get; set; }
    }
}