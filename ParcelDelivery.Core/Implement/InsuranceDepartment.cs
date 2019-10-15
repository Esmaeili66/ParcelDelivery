using ParcelDelivery.Core.Domain;
using ParcelDelivery.Core.Interface;
using System;

namespace ParcelDelivery.Core.Implement
{
    public class InsuranceDepartment : Department, ISignerDepartment
    {
        public void SignOf(Parcel parcel)
        {
            Console.WriteLine("This is signed...");
        }

        public override bool CheckStatus(Parcel parcel)
        {
            return parcel.Value > 1000;
        }
    }
}
