using System;

using F10Y.T0002;


namespace F10Y.L0026.T003
{
    [FunctionsMarker]
    public partial interface IInstanceSetTypeDescriptorOperator
    {
        public InstanceSetTypeDescriptor_Name From_Name(string instanceSetType_Name)
        {
            var output = new InstanceSetTypeDescriptor_Name
            {
                InstanceSetType_Name = instanceSetType_Name,
            };

            return output;
        }
    }
}
