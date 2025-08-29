using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.T0003;


namespace F10Y.L0026.L004
{
    [ValuesMarker]
    public partial interface IDescriptorTextOperationHandlerSuiteSets
    {
#pragma warning disable IDE1006 // Naming Styles

        private static IDescriptorTextOperationHandlerSuites _DescriptorTextOperationHandlerSuites => Instances.DescriptorTextOperationHandlerSuites;

#pragma warning restore IDE1006 // Naming Styles

        #region Instance Set Search Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetSearchDescriptor>[] For_InstanceSetSearchDescriptors => new[]
        {
            _DescriptorTextOperationHandlerSuites.For_InstanceSetSearchDescriptor,
            _DescriptorTextOperationHandlerSuites.For_InstanceSetSearchDescriptor_Aggregate,
            _DescriptorTextOperationHandlerSuites.For_InstanceSetSearchDescriptor_Aggregate_N001,
            _DescriptorTextOperationHandlerSuites.For_InstanceSetSearchDescriptor_Aggregate_N002,
            _DescriptorTextOperationHandlerSuites.For_InstanceSetSearchDescriptor_ApplicabilitySearchDescriptor,
            _DescriptorTextOperationHandlerSuites.For_InstanceSetSearchDescriptor_DependencySetSearchDescriptor,
            _DescriptorTextOperationHandlerSuites.For_InstanceSetSearchDescriptor_DescriptorSearchDescriptor,
            _DescriptorTextOperationHandlerSuites.For_InstanceSetSearchDescriptor_DomainSearchDescriptor,
            _DescriptorTextOperationHandlerSuites.For_InstanceSetSearchDescriptor_InstanceSetTypeSearchDescriptor,
            _DescriptorTextOperationHandlerSuites.For_InstanceSetSearchDescriptor_InstanceVarietySearchDescriptor,
            _DescriptorTextOperationHandlerSuites.For_InstanceSetSearchDescriptor_NetVersionSearchDescriptor,
            _DescriptorTextOperationHandlerSuites.For_InstanceSetSearchDescriptor_OpinionSearchDescriptor,
            _DescriptorTextOperationHandlerSuites.For_InstanceSetSearchDescriptor_OrganizationName,
            _DescriptorTextOperationHandlerSuites.For_InstanceSetSearchDescriptor_OrganizationSearchDescriptor,
            _DescriptorTextOperationHandlerSuites.For_InstanceSetSearchDescriptor_VisibilitySearchDescriptor,
        };

        private static readonly Lazy<Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetSearchDescriptor>>> For_InstanceSetSearchDescriptors_ByType_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_InstanceSetSearchDescriptors
                .ToDictionary(x => x.Type)
        );

        public Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetSearchDescriptor>> For_InstanceSetSearchDescriptors_ByType => For_InstanceSetSearchDescriptors_ByType_Lazy.Value;

        private static readonly Lazy<Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetSearchDescriptor>>> For_InstanceSetSearchDescriptors_ByTypeName_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_InstanceSetSearchDescriptors_ByType
                .ToDictionary(
                    pair => Instances.TypeNameOperator.Get_TypeName(pair.Key),
                    pair => pair.Value)
        );

        public Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetSearchDescriptor>> For_InstanceSetSearchDescriptors_ByTypeName => For_InstanceSetSearchDescriptors_ByTypeName_Lazy.Value;

        #endregion        

        #region Instance Set Type Search Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetTypeSearchDescriptor>[] For_InstanceSetTypeSearchDescriptors => new[]
        {
            _DescriptorTextOperationHandlerSuites.For_InstanceSetTypeSearchDescriptor_Name
        };

        private static readonly Lazy<Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetTypeSearchDescriptor>>> For_InstanceSetTypeSearchDescriptors_ByType_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_InstanceSetTypeSearchDescriptors
                .ToDictionary(x => x.Type)
        );

        public Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetTypeSearchDescriptor>> For_InstanceSetTypeSearchDescriptors_ByType => For_InstanceSetTypeSearchDescriptors_ByType_Lazy.Value;

        private static readonly Lazy<Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetTypeSearchDescriptor>>> For_InstanceSetTypeSearchDescriptors_ByTypeName_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_InstanceSetTypeSearchDescriptors_ByType
                .ToDictionary(
                    pair => Instances.TypeNameOperator.Get_TypeName(pair.Key),
                    pair => pair.Value)
        );

        public Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetTypeSearchDescriptor>> For_InstanceSetTypeSearchDescriptors_ByTypeName => For_InstanceSetTypeSearchDescriptors_ByTypeName_Lazy.Value;

        #endregion

        #region Instance Variety Search Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceVarietySearchDescriptor>[] For_InstanceVarietySearchDescriptors => new[]
        {
            _DescriptorTextOperationHandlerSuites.For_InstanceVarietySearchDescriptor_Values,
            _DescriptorTextOperationHandlerSuites.For_InstanceVarietySearchDescriptor_Name,
        };

        private static readonly Lazy<Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceVarietySearchDescriptor>>> For_InstanceVarietySearchDescriptors_ByType_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_InstanceVarietySearchDescriptors
                .ToDictionary(x => x.Type)
        );

        public Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceVarietySearchDescriptor>> For_InstanceVarietySearchDescriptors_ByType => For_InstanceVarietySearchDescriptors_ByType_Lazy.Value;

        private static readonly Lazy<Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceVarietySearchDescriptor>>> For_InstanceVarietySearchDescriptors_ByTypeName_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_InstanceVarietySearchDescriptors_ByType
                .ToDictionary(
                    pair => Instances.TypeNameOperator.Get_TypeName(pair.Key),
                    pair => pair.Value)
        );

        public Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceVarietySearchDescriptor>> For_InstanceVarietySearchDescriptors_ByTypeName => For_InstanceVarietySearchDescriptors_ByTypeName_Lazy.Value;

        #endregion
    }
}
