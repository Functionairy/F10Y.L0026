using System;

using F10Y.T0002;


namespace F10Y.L0026.T001
{
    [FunctionsMarker]
    public partial interface IOrganizationDescriptorOperator
    {
        public OrganizationDescriptor_Name From(string organizationName)
        {
            var output = new OrganizationDescriptor_Name
            {
                Organization_Name = organizationName
            };

            return output;
        }

        public string To_String(OrganizationDescriptor_Invalid organizationDescriptor)
        {
            var output = "Organization: INVALID";
            return output;
        }

        public string To_String(OrganizationDescriptor_Name organizationDescriptor)
        {
            var output = $"Organization: {organizationDescriptor.Organization_Name}";
            return output;
        }
    }
}
