using System;

using F10Y.T0002;


namespace F10Y.L0026.T001
{
    [FunctionsMarker]
    public partial interface IImplementationSchemeDescriptorOperator
    {
        public ImplementationSchemeDescriptor_Enumeration From(ImplementationScheme implementationScheme)
        {
            var output = new ImplementationSchemeDescriptor_Enumeration
            {
                ImplementationScheme = implementationScheme,
            };

            return output;
        }

        public string To_String(ImplementationSchemeDescriptor_Enumeration implementationSchemeDescriptor)
        {
            var implementationScheme = Instances.EnumerationOperator.Get_StringRepresentation(implementationSchemeDescriptor.ImplementationScheme);

            var output = $"Implementation scheme: {implementationScheme}";
            return output;
        }
    }
}
