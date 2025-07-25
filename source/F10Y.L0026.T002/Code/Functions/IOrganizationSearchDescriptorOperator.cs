using System;

using F10Y.T0002;


namespace F10Y.L0026.T002
{
    [FunctionsMarker]
    public partial interface IOrganizationSearchDescriptorOperator
    {
        public OrganizationSearchDescriptor_Name From(
            string organization_Name,
            For_EqualityOperationDescriptor.IEqualityOperationDescriptor equalityOperationDescriptor)
        {
            var output = new OrganizationSearchDescriptor_Name
            {
                EqualityOperationDescriptor = equalityOperationDescriptor,
                Organization_Name = organization_Name,
            };

            return output;
        }
    }
}
