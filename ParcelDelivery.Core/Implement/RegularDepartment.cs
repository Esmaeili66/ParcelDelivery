using ParcelDelivery.Core.Domain;
using ParcelDelivery.Core.Interface;
using System;

namespace ParcelDelivery.Core.Implement
{
    public class RegularDepartment : Department, IHandlerDepartment
    {
        public void Execute(Parcel parcel)
        {
            Console.WriteLine("This is handled by Regular...");
        }

        public override bool CheckStatus(Parcel parcel)
        {
            return parcel.Weight >= 1 && parcel.Weight < 10;
        }
    }
}
