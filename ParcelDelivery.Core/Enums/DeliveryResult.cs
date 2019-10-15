using ParcelDelivery.Core.Domain;
using System.Collections.Generic;

namespace ParcelDelivery.Core.Enums
{
    public class DeliveryResult
    {
        public DeliveryResult()
        {
            ExecutedDepartmentList = new List<Department>();
        }
        public List<Department> ExecutedDepartmentList { get; set; }
        public bool IsSucceed { get; set; }
    }
}
