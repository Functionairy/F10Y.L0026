using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.T0003;


namespace F10Y.L0026.L003
{
    [ValuesMarker]
    public partial interface IDescriptorTextOperationHandlerSuiteSets
    {
#pragma warning disable IDE1006 // Naming Styles

        private static IDescriptorTextOperationHandlerSuites _DescriptorTextOperationHandlerSuites => Instances.DescriptorTextOperationHandlerSuites;

#pragma warning restore IDE1006 // Naming Styles


        #region Instance Set Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetDescriptor>[] For_InstanceSetDescriptors => new[]
        {
            _DescriptorTextOperationHandlerSuites.For_InstanceSetDescriptor,
            _DescriptorTextOperationHandlerSuites.For_InstanceSetDescriptor_CatchAllLibrary,
            _DescriptorTextOperationHandlerSuites.For_InstanceSetDescriptor_EntryPointExecutable,
        };

        private static readonly Lazy<Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetDescriptor>>> For_InstanceSetDescriptors_ByType_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_InstanceSetDescriptors
                .ToDictionary(x => x.Type)
        );

        public Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetDescriptor>> For_InstanceSetDescriptors_ByType => For_InstanceSetDescriptors_ByType_Lazy.Value;

        private static readonly Lazy<Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetDescriptor>>> For_InstanceSetDescriptors_ByTypeName_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_InstanceSetDescriptors_ByType
                .ToDictionary(
                    pair => Instances.TypeNameOperator.Get_TypeName(pair.Key),
                    pair => pair.Value)
        );

        public Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetDescriptor>> For_InstanceSetDescriptors_ByTypeName => For_InstanceSetDescriptors_ByTypeName_Lazy.Value;

        #endregion

        #region Instance Set Flow Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetFlowDescriptor>[] For_InstanceSetFlowDescriptors => new[]
        {
            _DescriptorTextOperationHandlerSuites.For_InstanceSetFlowDescriptor_Aggregate,
            _DescriptorTextOperationHandlerSuites.For_InstanceSetFlowDescriptor_Contribute,
            _DescriptorTextOperationHandlerSuites.For_InstanceSetFlowDescriptor_Deprecate,
            _DescriptorTextOperationHandlerSuites.For_InstanceSetFlowDescriptor_Librarate,
            _DescriptorTextOperationHandlerSuites.For_InstanceSetFlowDescriptor_NetVersion_Change,
            _DescriptorTextOperationHandlerSuites.For_InstanceSetFlowDescriptor_NetVersion_Choose,
            _DescriptorTextOperationHandlerSuites.For_InstanceSetFlowDescriptor_Port,
            _DescriptorTextOperationHandlerSuites.For_InstanceSetFlowDescriptor_Publicize
        };

        private static readonly Lazy<Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetFlowDescriptor>>> For_InstanceSetFlowDescriptors_ByType_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_InstanceSetFlowDescriptors
                .ToDictionary(x => x.Type)
        );

        public Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetFlowDescriptor>> For_InstanceSetFlowDescriptors_ByType => For_InstanceSetFlowDescriptors_ByType_Lazy.Value;

        private static readonly Lazy<Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetFlowDescriptor>>> For_InstanceSetFlowDescriptors_ByTypeName_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_InstanceSetFlowDescriptors_ByType
                .ToDictionary(
                    pair => Instances.TypeNameOperator.Get_TypeName(pair.Key),
                    pair => pair.Value)
        );

        public Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetFlowDescriptor>> For_InstanceSetFlowDescriptors_ByTypeName => For_InstanceSetFlowDescriptors_ByTypeName_Lazy.Value;

        #endregion

        #region Instance Set Location Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetLocationDescriptor>[] For_InstanceSetLocationDescriptors => new[]
        {
            _DescriptorTextOperationHandlerSuites.For_InstanceSetLocationDescriptor
        };

        private static readonly Lazy<Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetLocationDescriptor>>> For_InstanceSetLocationDescriptors_ByType_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_InstanceSetLocationDescriptors
                .ToDictionary(x => x.Type)
        );

        public Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetLocationDescriptor>> For_InstanceSetLocationDescriptors_ByType => For_InstanceSetLocationDescriptors_ByType_Lazy.Value;

        private static readonly Lazy<Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetLocationDescriptor>>> For_InstanceSetLocationDescriptors_ByTypeName_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_InstanceSetLocationDescriptors_ByType
                .ToDictionary(
                    pair => Instances.TypeNameOperator.Get_TypeName(pair.Key),
                    pair => pair.Value)
        );

        public Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetLocationDescriptor>> For_InstanceSetLocationDescriptors_ByTypeName => For_InstanceSetLocationDescriptors_ByTypeName_Lazy.Value;

        #endregion

        #region Instance Set Type Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetTypeDescriptor>[] For_InstanceSetTypeDescriptors => new[]
        {
            _DescriptorTextOperationHandlerSuites.For_InstanceSetTypeDescriptor_Name
        };

        private static readonly Lazy<Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetTypeDescriptor>>> For_InstanceSetTypeDescriptors_ByType_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_InstanceSetTypeDescriptors
                .ToDictionary(x => x.Type)
        );

        public Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetTypeDescriptor>> For_InstanceSetTypeDescriptors_ByType => For_InstanceSetTypeDescriptors_ByType_Lazy.Value;

        private static readonly Lazy<Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetTypeDescriptor>>> For_InstanceSetTypeDescriptors_ByTypeName_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_InstanceSetTypeDescriptors_ByType
                .ToDictionary(
                    pair => Instances.TypeNameOperator.Get_TypeName(pair.Key),
                    pair => pair.Value)
        );

        public Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetTypeDescriptor>> For_InstanceSetTypeDescriptors_ByTypeName => For_InstanceSetTypeDescriptors_ByTypeName_Lazy.Value;

        #endregion

        #region Instance Variety Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceVarietyDescriptor>[] For_InstanceVarietyDescriptors => new[]
        {
            _DescriptorTextOperationHandlerSuites.For_InstanceVarietyDescriptor_All,
            _DescriptorTextOperationHandlerSuites.For_InstanceVarietyDescriptor_Aggregate,
            _DescriptorTextOperationHandlerSuites.For_InstanceVarietyDescriptor_Name,
            _DescriptorTextOperationHandlerSuites.For_InstanceVarietyDescriptor_Name_Set,
            _DescriptorTextOperationHandlerSuites.For_InstanceVarietyDescriptor_Values,
        };

        private static readonly Lazy<Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceVarietyDescriptor>>> For_InstanceVarietyDescriptors_ByType_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_InstanceVarietyDescriptors
                .ToDictionary(x => x.Type)
        );

        public Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceVarietyDescriptor>> For_InstanceVarietyDescriptors_ByType => For_InstanceVarietyDescriptors_ByType_Lazy.Value;

        private static readonly Lazy<Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceVarietyDescriptor>>> For_InstanceVarietyDescriptors_ByTypeName_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_InstanceVarietyDescriptors_ByType
                .ToDictionary(
                    pair => Instances.TypeNameOperator.Get_TypeName(pair.Key),
                    pair => pair.Value)
        );

        public Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceVarietyDescriptor>> For_InstanceVarietyDescriptors_ByTypeName => For_InstanceVarietyDescriptors_ByTypeName_Lazy.Value;

        #endregion
    }
}
