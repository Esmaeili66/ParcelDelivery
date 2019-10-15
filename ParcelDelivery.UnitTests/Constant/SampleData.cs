using ParcelDelivery.Core.Domain;

namespace ParcelDelivery.UnitTests.Constant
{
    public static class SampleData
    {
        public static Contact Sender => new Contact
        {
            Name = "Oil Industry",
            Address = new Address
            {
                City = "Tehran",
                HouseNumber = 125,
                PostalCode = "125478521",
                Street = "RoodSar Sreet"
            },
            CcNumber = "54d256s"
        };

        public static Contact Recipient => new Contact
        {
            Name = "Mohsen",
            Address = new Address
            {
                Street = "Shariati",
                HouseNumber = 23,
                PostalCode = "234234324",
                City = "Tehran"
            }
        };
    }
}
