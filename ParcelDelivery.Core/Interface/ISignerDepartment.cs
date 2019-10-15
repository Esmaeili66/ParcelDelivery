using ParcelDelivery.Core.Domain;

namespace ParcelDelivery.Core.Interface
{
    public interface ISignerDepartment
    {
        void SignOf(Parcel parcel);
    }
}
