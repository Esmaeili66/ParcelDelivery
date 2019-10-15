namespace ParcelDelivery.Core.Domain
{
    public abstract class Department
    {
        public abstract bool CheckStatus(Parcel parcel);
    }
}
