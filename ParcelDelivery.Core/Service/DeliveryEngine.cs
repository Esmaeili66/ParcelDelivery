using ParcelDelivery.Core.Constant;
using ParcelDelivery.Core.Domain;
using ParcelDelivery.Core.Enums;
using ParcelDelivery.Core.Interface;
using System.Linq;

namespace ParcelDelivery.Core.Service
{
    public class DeliveryEngine
    {
        public DeliveryResult Send(Parcel parcel)
        {
            var result = new DeliveryResult();
            var signer = DepartmentStructure.DepartmentList.FirstOrDefault(x => x is ISignerDepartment && x.CheckStatus(parcel));
            if (signer != null)
            {
                ((ISignerDepartment)signer).SignOf(parcel);
                result.ExecutedDepartmentList.Add(signer);
            }

            var handler = DepartmentStructure.DepartmentList.FirstOrDefault(x => x is IHandlerDepartment && x.CheckStatus(parcel));
            if (handler != null)
            {
                ((IHandlerDepartment)handler).Execute(parcel);
                result.ExecutedDepartmentList.Add(handler);
            }

            result.IsSucceed = true;

            return result;
        }
    }
}
