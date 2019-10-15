using ParcelDelivery.Core.Domain;
using ParcelDelivery.Core.Interface;
using System;

namespace ParcelDelivery.Core.Implement
{
    public class EmailDepartment : Department, IHandlerDepartment
    {
        public void Execute(Parcel parcel)
        {
            Console.WriteLine("This coming is handled by Email");
        }

        public override bool CheckStatus(Parcel parcel)
        {
            return parcel.Weight < 1;
        }
    }
}
