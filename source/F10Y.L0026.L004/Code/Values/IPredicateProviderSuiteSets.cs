using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.T0003;


namespace F10Y.L0026.L004
{
    [ValuesMarker]
    public partial interface IPredicateProviderSuiteSets
    {
#pragma warning disable IDE1006 // Naming Styles

        private static IPredicateProviderSuites _PredicateProviderOperationHandlerSuites => Instances.PredicateProviderSuites;

#pragma warning restore IDE1006 // Naming Styles


        #region Instance Set Search Descriptors

        public For_PredicateProviderSuite.PredicateProviderSuite<IInstanceSetSearchDescriptor, IInstanceSetDescriptor>[] For_InstanceSetSearchDescriptors => new[]
        {
            //_PredicateProviderOperationHandlerSuites.For_InstanceSetSearchDescriptor,
            _PredicateProviderOperationHandlerSuites.For_InstanceSetSearchDescriptor_Aggregate,
            _PredicateProviderOperationHandlerSuites.For_InstanceSetSearchDescriptor_Aggregate_N001,
            _PredicateProviderOperationHandlerSuites.For_InstanceSetSearchDescriptor_Aggregate_N002,
            _PredicateProviderOperationHandlerSuites.For_InstanceSetSearchDescriptor_ApplicabilitySearchDescriptor,
            _PredicateProviderOperationHandlerSuites.For_InstanceSetSearchDescriptor_DependencySetSearchDescriptor,
            _PredicateProviderOperationHandlerSuites.For_InstanceSetSearchDescriptor_DomainSearchDescriptor,
            //_PredicateProviderOperationHandlerSuites.For_InstanceSetSearchDescriptor_InstanceSetDescriptor,
            _PredicateProviderOperationHandlerSuites.For_InstanceSetSearchDescriptor_InstanceSetTypeSearchDescriptor,
            _PredicateProviderOperationHandlerSuites.For_InstanceSetSearchDescriptor_InstanceVarietySearchDescriptor,
            _PredicateProviderOperationHandlerSuites.For_InstanceSetSearchDescriptor_NetVersionSearchDescriptor,
            _PredicateProviderOperationHandlerSuites.For_InstanceSetSearchDescriptor_OpinionSearchDescriptor,
            _PredicateProviderOperationHandlerSuites.For_InstanceSetSearchDescriptor_OrganizationName,
            _PredicateProviderOperationHandlerSuites.For_InstanceSetSearchDescriptor_OrganizationSearchDescriptor,
            _PredicateProviderOperationHandlerSuites.For_InstanceSetSearchDescriptor_VisibilitySearchDescriptor,
        };

        private static readonly Lazy<Dictionary<Type, For_PredicateProviderSuite.PredicateProviderSuite<IInstanceSetSearchDescriptor, IInstanceSetDescriptor>>> For_InstanceSetSearchDescriptors_ByType_Lazy = new(() =>
            Instances.PredicateProviderSuiteSets.For_InstanceSetSearchDescriptors
                .ToDictionary(x => x.Type)
        );

        public Dictionary<Type, For_PredicateProviderSuite.PredicateProviderSuite<IInstanceSetSearchDescriptor, IInstanceSetDescriptor>> For_InstanceSetSearchDescriptors_ByType => For_InstanceSetSearchDescriptors_ByType_Lazy.Value;

        #endregion

        #region Instance Set Type Search Descriptors

        public For_PredicateProviderSuite.PredicateProviderSuite<IInstanceSetTypeSearchDescriptor, IInstanceSetTypeDescriptor>[] For_InstanceSetTypeSearchDescriptors => new[]
        {
            _PredicateProviderOperationHandlerSuites.For_InstanceSetTypeSearchDescriptor_Name,
        };

        private static readonly Lazy<Dictionary<Type, For_PredicateProviderSuite.PredicateProviderSuite<IInstanceSetTypeSearchDescriptor, IInstanceSetTypeDescriptor>>> For_InstanceSetTypeSearchDescriptors_ByType_Lazy = new(() =>
            Instances.PredicateProviderSuiteSets.For_InstanceSetTypeSearchDescriptors
                .ToDictionary(x => x.Type)
        );

        public Dictionary<Type, For_PredicateProviderSuite.PredicateProviderSuite<IInstanceSetTypeSearchDescriptor, IInstanceSetTypeDescriptor>> For_InstanceSetTypeSearchDescriptors_ByType => For_InstanceSetTypeSearchDescriptors_ByType_Lazy.Value;

        #endregion

        #region Instance Variety Search Descriptors

        public For_PredicateProviderSuite.PredicateProviderSuite<IInstanceVarietySearchDescriptor, IInstanceVarietyDescriptor>[] For_InstanceVarietySearchDescriptors => new[]
        {
            _PredicateProviderOperationHandlerSuites.For_InstanceVarietySearchDescriptor_Values,
            _PredicateProviderOperationHandlerSuites.For_InstanceVarietySearchDescriptor_Name,
        };

        private static readonly Lazy<Dictionary<Type, For_PredicateProviderSuite.PredicateProviderSuite<IInstanceVarietySearchDescriptor, IInstanceVarietyDescriptor>>> For_InstanceVarietySearchDescriptors_ByType_Lazy = new(() =>
            Instances.PredicateProviderSuiteSets.For_InstanceVarietySearchDescriptors
                .ToDictionary(x => x.Type)
        );

        public Dictionary<Type, For_PredicateProviderSuite.PredicateProviderSuite<IInstanceVarietySearchDescriptor, IInstanceVarietyDescriptor>> For_InstanceVarietySearchDescriptors_ByType => For_InstanceVarietySearchDescriptors_ByType_Lazy.Value;

        #endregion
    }
}
