using System;


namespace F10Y.L0026.T001
{
    public static class Instances
    {
        public static IApplicabilityDescriptorOperator ApplicabilityDescriptorOperator => T001.ApplicabilityDescriptorOperator.Instance;
        public static L0000.IArrayOperator ArrayOperator => L0000.ArrayOperator.Instance;
        public static L0000.ICountOperator CountOperator => L0000.CountOperator.Instance;
        public static IDependencyDescriptorOperator DependencyDescriptorOperator => T001.DependencyDescriptorOperator.Instance;
        public static IDependencySetDescriptorOperator DependencySetDescriptorOperator => T001.DependencySetDescriptorOperator.Instance;
        public static IDomainDescriptorOperator DomainDescriptorOperator => T001.DomainDescriptorOperator.Instance;
        public static L0000.IEnumerationOperator EnumerationOperator => L0000.EnumerationOperator.Instance;
        public static L0000.IHashCodeOperator HashCodeOperator => L0000.HashCodeOperator.Instance;
        public static IImplementationSchemeDescriptorOperator ImplementationSchemeDescriptorOperator => T001.ImplementationSchemeDescriptorOperator.Instance;
        public static ILocationDescriptorOperator LocationDescriptorOperator => T001.LocationDescriptorOperator.Instance;
        public static INamingSchemeDescriptorOperator NamingSchemeDescriptorOperator => T001.NamingSchemeDescriptorOperator.Instance;
        public static INetVersionDescriptorOperator NetVersionDescriptorOperator => T001.NetVersionDescriptorOperator.Instance;
        public static IOpinionDescriptorOperator OpinionDescriptorOperator => T001.OpinionDescriptorOperator.Instance;
        public static IOrganizationDescriptorOperator OrganizationDescriptorOperator => T001.OrganizationDescriptorOperator.Instance;
        public static L0008.Z000.ITargetFrameworkMonikers TargetFrameworkMonikers => L0008.Z000.TargetFrameworkMonikers.Instance;
        public static ITypingSchemeDescriptorOperator TypingSchemeDescriptorOperator => T001.TypingSchemeDescriptorOperator.Instance;
        public static IVisibilityDescriptorOperator VisibilityDescriptorOperator => T001.VisibilityDescriptorOperator.Instance;
    }
}