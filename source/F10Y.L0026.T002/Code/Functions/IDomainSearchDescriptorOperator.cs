using System;

using F10Y.T0002;


namespace F10Y.L0026.T002
{
    [FunctionsMarker]
    public partial interface IDomainSearchDescriptorOperator
    {
        public DomainSearchDescriptor From(string domain)
        {
            var output = new DomainSearchDescriptor
            {
                Domain = domain
            };

            return output;
        }

        public DomainSearchDescriptor_Set From(
            For_SetEqualityOperationDescriptors.ISetEqualityOperationDescriptor setEqualityOperationDescriptor,
            params string[] domains)
        {
            var output = new DomainSearchDescriptor_Set
            {
                Domains = domains,
                SetEqualityOperationDescriptor = setEqualityOperationDescriptor,
            };

            return output;
        }
    }
}
