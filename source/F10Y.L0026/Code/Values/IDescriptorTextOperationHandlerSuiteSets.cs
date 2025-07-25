using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.T0003;


namespace F10Y.L0026
{
    [ValuesMarker]
    public partial interface IDescriptorTextOperationHandlerSuiteSets
    {
#pragma warning disable IDE1006 // Naming Styles

        private static IDescriptorTextOperationHandlerSuites _DescriptorTextOperationHandlerSuites => Instances.DescriptorTextOperationHandlerSuites;

#pragma warning restore IDE1006 // Naming Styles


        #region Instance Set Flows

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetFlow>[] For_InstanceSetFlows =>
        [
            _DescriptorTextOperationHandlerSuites.For_InstanceSetFlow,
        ];

        private static readonly Lazy<Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetFlow>>> For_InstanceSetFlows_ByType_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_InstanceSetFlows
                .ToDictionary(x => x.Type)
        );

        public Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetFlow>> For_InstanceSetFlows_ByType => For_InstanceSetFlows_ByType_Lazy.Value;

        private static readonly Lazy<Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetFlow>>> For_InstanceSetFlows_ByTypeName_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_InstanceSetFlows_ByType
                .ToDictionary(
                    pair => Instances.TypeNameOperator.Get_TypeName(pair.Key),
                    pair => pair.Value)
        );

        public Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetFlow>> For_InstanceSetFlows_ByTypeName => For_InstanceSetFlows_ByTypeName_Lazy.Value;

        #endregion
    }
}
