using ParcelDelivery.Core.Domain;
using ParcelDelivery.Core.Implement;
using System.Collections.Generic;

namespace ParcelDelivery.Core.Constant
{
    public static class DepartmentStructure
    {
        public static List<Department> DepartmentList = new List<Department>
        {
            new EmailDepartment(), new HeavyDepartment(), new InsuranceDepartment(), new RegularDepartment()
        };
    }
}
