using System;
using F10Y.T0002;


namespace F10Y.L0026.T001
{
    [FunctionsMarker]
    public partial interface IDomainDescriptorOperator
    {
        public DomainDescriptor From_Domain(string domain)
        {
            var output = new DomainDescriptor
            {
                Domain = domain,
            };

            return output;
        }

        public DomainDescriptor_Set From_Domains(params string[] domains)
        {
            var output = new DomainDescriptor_Set
            {
                Domains = domains
            };

            return output;
        }

        public DomainDescriptor_Set_Ordered From_Domains_Ordered(params string[] domains_Ordered)
        {
            var output = new DomainDescriptor_Set_Ordered
            {
                Domains = domains_Ordered
            };

            return output;
        }

        public string To_String(DomainDescriptor domainDescriptor)
        {
            var output = $"Domain: {domainDescriptor.Domain}";
            return output;
        }

        public string To_String(DomainDescriptor_Set domainDescriptor)
        {
            var count = Instances.CountOperator.Get_CountOf(domainDescriptor.Domains);

            var output = $"Domain Set - count: {count}";
            return output;
        }

        public string To_String(DomainDescriptor_Set_Ordered domainDescriptor)
        {
            var count = Instances.CountOperator.Get_CountOf(domainDescriptor.Domains);

            var output = $"Domain Set (Ordered) - count: {count}";
            return output;
        }
    }
}
