using System;

using F10Y.T0002;


namespace F10Y.L0026.T001
{
    [FunctionsMarker]
    public partial interface INamingSchemeDescriptorOperator
    {
        public NamingSchemeDescriptor_Enumeration From(NamingScheme namingScheme)
        {
            var output = new NamingSchemeDescriptor_Enumeration
            {
                NamingScheme = namingScheme
            };

            return output;
        }

        public string To_String(NamingSchemeDescriptor_Enumeration namingSchemeDescriptor)
        {
            var namingScheme = Instances.EnumerationOperator.Get_StringRepresentation(namingSchemeDescriptor.NamingScheme);

            var output = $"Naming scheme: {namingScheme}";
            return output;
        }
    }
}
