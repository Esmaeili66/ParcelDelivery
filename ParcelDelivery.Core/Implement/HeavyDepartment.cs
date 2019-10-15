using ParcelDelivery.Core.Domain;
using ParcelDelivery.Core.Interface;
using System;

namespace ParcelDelivery.Core.Implement
{
    public class HeavyDepartment : Department, IHandlerDepartment
    {
        public void Execute(Parcel parcel)
        {
            Console.WriteLine("This is handled by Heavy...");
        }

        public override bool CheckStatus(Parcel parcel)
        {
            return parcel.Weight >= 10;
        }
    }
}
