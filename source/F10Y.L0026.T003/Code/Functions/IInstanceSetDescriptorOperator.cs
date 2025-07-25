using System;

using F10Y.T0002;


namespace F10Y.L0026.T003
{
    [FunctionsMarker]
    public partial interface IInstanceSetDescriptorOperator
    {
        public string To_String(InstanceSetDescriptor instanceSetDescriptor)
        {
            var output = $"Instance Set: {instanceSetDescriptor.Descriptor.Name}";
            return output;
        }

        public string To_String(InstanceSetDescriptor_CatchAllLibrary instanceSetDescriptor)
        {
            var output = $"Instance Set (catch-all library): {instanceSetDescriptor.Descriptor.Name}";
            return output;
        }

        public string To_String(InstanceSetDescriptor_EntryPointExecutable instanceSetDescriptor)
        {
            var output = $"Instance Set (entry-point executable): {instanceSetDescriptor.Descriptor.Name}";
            return output;
        }

        public string To_String(InstanceSetDescriptor_FoundationLibrary instanceSetDescriptor)
        {
            var output = $"Instance Set (foundation library): {instanceSetDescriptor.Descriptor.Name}";
            return output;
        }
    }
}
