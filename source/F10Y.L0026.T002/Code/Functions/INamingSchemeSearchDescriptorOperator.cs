using System;

using F10Y.T0002;


namespace F10Y.L0026.T002
{
    [FunctionsMarker]
    public partial interface INamingSchemeSearchDescriptorOperator
    {
        public NamingSchemeSearchDescriptor_Enumeration From(NamingScheme namingScheme)
        {
            var output = new NamingSchemeSearchDescriptor_Enumeration
            {
                NamingScheme = namingScheme
            };

            return output;
        }
    }
}
