using System;

using F10Y.T0002;


namespace F10Y.L0026.T004
{
    [FunctionsMarker]
    public partial interface IInstanceSetTypeSearchDescriptorOperator
    {
        public InstanceSetTypeSearchDescriptor_Name From(
            string instanceSetType_Name,
            For_EqualityOperationDescriptor.IEqualityOperationDescriptor equalityOperationDescriptor)
        {
            var output = new InstanceSetTypeSearchDescriptor_Name
            {
                EqualityOperationDescriptor = equalityOperationDescriptor,
                InstanceSetType_Name = instanceSetType_Name
            };

            return output;
        }
    }
}
