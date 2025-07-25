using System;

using F10Y.T0004;


namespace F10Y.L0026.T002
{
    [DataTypeMarker]
    public class OrganizationSearchDescriptor_Name : IOrganizationSearchDescriptor,
        IWith_OrganizationName
    {
        public For_EqualityOperationDescriptor.IEqualityOperationDescriptor EqualityOperationDescriptor { get; set; }

        public string Organization_Name { get; set; }
    }


    namespace Serialization
    {
        [DataTypeMarker]
        public class OrganizationSearchDescriptor_Name
        {
            public JsonSerializationObject EqualityOperationDescriptor { get; set; }

            public string Organization_Name { get; set; }
        }
    }
}
