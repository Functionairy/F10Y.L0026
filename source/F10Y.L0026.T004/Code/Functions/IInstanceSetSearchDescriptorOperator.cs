using System;

using F10Y.T0002;


namespace F10Y.L0026.T004
{
    [FunctionsMarker]
    public partial interface IInstanceSetSearchDescriptorOperator
    {
        public InstanceSetSearchDescriptor_InstanceSetDescriptor From(
            IDescriptor descriptor,
            InstanceSetDescriptor instanceSetDescriptor)
        {
            var output = new InstanceSetSearchDescriptor_InstanceSetDescriptor
            {
                Descriptor = descriptor,
                InstanceSetDescriptor = instanceSetDescriptor,
            };

            return output;
        }

        public InstanceSetSearchDescriptor_Aggregate From(
            IDescriptor descriptor,
            params IInstanceSetSearchDescriptor[] instanceSetSearchDescriptors)
        {
            var output = new InstanceSetSearchDescriptor_Aggregate
            {
                Descriptor = descriptor,
                InstanceSetSearchDescriptors = instanceSetSearchDescriptors,
            };

            return output;
        }
    }
}
