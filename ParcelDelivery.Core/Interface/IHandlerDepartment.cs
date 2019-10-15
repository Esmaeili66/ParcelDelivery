using ParcelDelivery.Core.Domain;

namespace ParcelDelivery.Core.Interface
{
    public interface IHandlerDepartment
    {
        void Execute(Parcel parcel);
    }
}
