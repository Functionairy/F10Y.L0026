using System;


namespace F10Y.L0026
{
    public static class Instances
    {
        public static IDescriptorTextOperationHandlerSuites DescriptorTextOperationHandlerSuites => L0026.DescriptorTextOperationHandlerSuites.Instance;
        public static IDescriptorTextOperationHandlerSuiteSets DescriptorTextOperationHandlerSuiteSets => L0026.DescriptorTextOperationHandlerSuiteSets.Instance;
        public static L0000.IEnumerableOperator EnumerableOperator => L0000.EnumerableOperator.Instance;
        public static L003.IInstanceSetDescriptorOperator InstanceSetDescriptorOperator => L003.InstanceSetDescriptorOperator.Instance;
        public static L003.IInstanceSetFlowDescriptorOperator InstanceSetFlowDescriptorOperator => L003.InstanceSetFlowDescriptorOperator.Instance;
        public static L004.IInstanceSetSearchDescriptorOperator InstanceSetSearchDescriptorOperator => L004.InstanceSetSearchDescriptorOperator.Instance;
        public static IInstanceSetFlowOperator InstanceSetFlowOperator => L0026.InstanceSetFlowOperator.Instance;
        public static L0060.IJsonElementOperator JsonElementOperator => L0060.JsonElementOperator.Instance;
        public static IPredicateProviderSuites PredicateProviderSuites => L0026.PredicateProviderSuites.Instance;
        public static IPredicateProviderSuiteSets PredicateProviderSuiteSets => L0026.PredicateProviderSuiteSets.Instance;
        public static L0000.IPredicates Predicates => L0000.Predicates.Instance;
        public static L0000.ITypeNameOperator TypeNameOperator => L0000.TypeNameOperator.Instance;
        public static L0062.ITypeOperator TypeOperator => L0062.TypeOperator.Instance;
        public static ITypeSpecifiers TypeSpecifiers => L0026.TypeSpecifiers.Instance;
    }
}