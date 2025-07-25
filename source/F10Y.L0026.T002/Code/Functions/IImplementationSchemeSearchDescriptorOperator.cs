using System;

using F10Y.T0002;


namespace F10Y.L0026.T002
{
    [FunctionsMarker]
    public partial interface IImplementationSchemeSearchDescriptorOperator
    {
        public ImplementationSchemeSearchDescriptor_Enumeration From(ImplementationScheme implementationScheme)
        {
            var output = new ImplementationSchemeSearchDescriptor_Enumeration
            {
                ImplementationScheme = implementationScheme,
            };

            return output;
        }
    }
}
