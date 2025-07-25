using System;


namespace F10Y.L0026.L003
{
    public static class Instances
    {
        public static L001.IApplicabilityDescriptorOperator ApplicabilityDescriptorOperator => L001.ApplicabilityDescriptorOperator.Instance;
        public static L0062.L002.IDescriptorOperator DescriptorOperator => L0062.L002.DescriptorOperator.Instance;
        public static IDescriptorTextOperationHandlerSuites DescriptorTextOperationHandlerSuites => L003.DescriptorTextOperationHandlerSuites.Instance;
        public static IDescriptorTextOperationHandlerSuiteSets DescriptorTextOperationHandlerSuiteSets => L003.DescriptorTextOperationHandlerSuiteSets.Instance;
        public static L001.IDependencySetDescriptorOperator DependencySetDescriptorOperator => L001.DependencySetDescriptorOperator.Instance;
        public static L001.IDomainDescriptorOperator DomainDescriptorOperator => L001.DomainDescriptorOperator.Instance;
        public static L0000.IEnumerableOperator EnumerableOperator => L0000.EnumerableOperator.Instance;
        public static L0000.IEnumerationOperator EnumerationOperator => L0000.EnumerationOperator.Instance;
        public static L001.IImplementationSchemeDescriptorOperator ImplementationSchemeDescriptorOperator => L001.ImplementationSchemeDescriptorOperator.Instance;
        public static IInstanceSetDescriptorOperator InstanceSetDescriptorOperator => L003.InstanceSetDescriptorOperator.Instance;
        public static IInstanceSetFlowDescriptorOperator InstanceSetFlowDescriptorOperator => L003.InstanceSetFlowDescriptorOperator.Instance;
        public static IInstanceSetLocationDescriptorOperator InstanceSetLocationDescriptorOperator => L003.InstanceSetLocationDescriptorOperator.Instance;
        public static IInstanceSetTypeDescriptorOperator InstanceSetTypeDescriptorOperator => L003.InstanceSetTypeDescriptorOperator.Instance;
        public static IInstanceSetTypeDescriptors InstanceSetTypeDescriptors => L003.InstanceSetTypeDescriptors.Instance;
        public static IInstanceSetTypeNames InstanceSetTypeNames => L003.InstanceSetTypeNames.Instance;
        public static IInstanceVarietyDescriptorOperator InstanceVarietyDescriptorOperator => L003.InstanceVarietyDescriptorOperator.Instance;
        public static L0060.IJsonElementOperator JsonElementOperator => L0060.JsonElementOperator.Instance;
        public static L001.ILocationDescriptorOperator LocationDescriptorOperator => L001.LocationDescriptorOperator.Instance;
        public static L001.INamingSchemeDescriptorOperator NamingSchemeDescriptorOperator => L001.NamingSchemeDescriptorOperator.Instance;
        public static L001.INetVersionDescriptorOperator NetVersionDescriptorOperator => L001.NetVersionDescriptorOperator.Instance;
        public static L001.IOpinionDescriptorOperator OpinionDescriptorOperator => L001.OpinionDescriptorOperator.Instance;
        public static L001.IOrganizationDescriptorOperator OrganizationDescriptorOperator => L001.OrganizationDescriptorOperator.Instance;
        public static L0000.IPredicateOperator PredicateOperator => L0000.PredicateOperator.Instance;
        public static ITexts Texts => L003.Texts.Instance;
        public static L0001.ITypeOperator TypeOperator => L0001.TypeOperator.Instance;
        public static L0000.ITypeNameOperator TypeNameOperator => L0000.TypeNameOperator.Instance;
        public static ITypeSpecifiers TypeSpecifiers => L003.TypeSpecifiers.Instance;
        public static L001.ITypingSchemeDescriptorOperator TypingSchemeDescriptorOperator => L001.TypingSchemeDescriptorOperator.Instance;
        public static L001.IVisibilityDescriptorOperator VisibilityDescriptorOperator => L001.VisibilityDescriptorOperator.Instance;
    }
}