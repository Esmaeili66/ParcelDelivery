namespace ParcelDelivery.Core.Domain
{
    public class Parcel
    {
        public Contact Sender { get; set; }
        public Contact Recipient { get; set; }
        public double Weight { get; set; }
        public double Value { get; set; }
    }
}
