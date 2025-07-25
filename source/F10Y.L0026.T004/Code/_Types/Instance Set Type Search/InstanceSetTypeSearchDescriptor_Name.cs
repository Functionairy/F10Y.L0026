using System;

using F10Y.T0004;


namespace F10Y.L0026.T004
{
    [DataTypeMarker]
    public class InstanceSetTypeSearchDescriptor_Name : IInstanceSetTypeSearchDescriptor,
        IWith_InstanceSetTypeName
    {
        public For_EqualityOperationDescriptor.IEqualityOperationDescriptor EqualityOperationDescriptor { get; set; }

        public string InstanceSetType_Name { get; set; }
    }


    namespace Serialization
    {
        [DataTypeMarker]
        public class InstanceSetTypeSearchDescriptor_Name : IInstanceSetTypeSearchDescriptor
        {
            public JsonSerializationObject EqualityOperationDescriptor { get; set; }

            public string InstanceSetType_Name { get; set; }
        }
    }
}
