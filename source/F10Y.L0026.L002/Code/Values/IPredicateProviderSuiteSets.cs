using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.T0003;


namespace F10Y.L0026.L002
{
    [ValuesMarker]
    public partial interface IPredicateProviderSuiteSets
    {
#pragma warning disable IDE1006 // Naming Styles

        private static IPredicateProviderSuites _PredicateProviderOperationHandlerSuites => Instances.PredicateProviderSuites;

#pragma warning restore IDE1006 // Naming Styles


        #region Applicability Search Descriptors

        public For_PredicateProviderSuite.PredicateProviderSuite<IApplicabilitySearchDescriptor, IApplicabilityDescriptor>[] For_ApplicabilitySearchDescriptors => new[]
        {
            _PredicateProviderOperationHandlerSuites.For_ApplicabilitySearchDescriptor,
        };

        private static readonly Lazy<Dictionary<Type, For_PredicateProviderSuite.PredicateProviderSuite<IApplicabilitySearchDescriptor, IApplicabilityDescriptor>>> For_ApplicabilitySearchDescriptors_ByType_Lazy = new(() =>
            Instances.PredicateProviderSuiteSets.For_ApplicabilitySearchDescriptors
                .ToDictionary(x => x.Type)
        );

        public Dictionary<Type, For_PredicateProviderSuite.PredicateProviderSuite<IApplicabilitySearchDescriptor, IApplicabilityDescriptor>> For_ApplicabilitySearchDescriptors_ByType => For_ApplicabilitySearchDescriptors_ByType_Lazy.Value;

        #endregion

        #region Dependency Search Descriptors

        public For_PredicateProviderSuite.PredicateProviderSuite<IDependencySearchDescriptor, IDependencyDescriptor>[] For_DependencySearchDescriptors => new[]
        {
            _PredicateProviderOperationHandlerSuites.For_DependencySearchDescriptor_Constrained,
            _PredicateProviderOperationHandlerSuites.For_DependencySearchDescriptor_Leaf,
            _PredicateProviderOperationHandlerSuites.For_DependencySearchDescriptor_Name,
            _PredicateProviderOperationHandlerSuites.For_DependencySearchDescriptor_NuGetPackage,
            _PredicateProviderOperationHandlerSuites.For_DependencySearchDescriptor_Project,
        };

        private static readonly Lazy<Dictionary<Type, For_PredicateProviderSuite.PredicateProviderSuite<IDependencySearchDescriptor, IDependencyDescriptor>>> For_DependencySearchDescriptors_ByType_Lazy = new(() =>
            Instances.PredicateProviderSuiteSets.For_DependencySearchDescriptors
                .ToDictionary(x => x.Type)
        );

        public Dictionary<Type, For_PredicateProviderSuite.PredicateProviderSuite<IDependencySearchDescriptor, IDependencyDescriptor>> For_DependencySearchDescriptors_ByType => For_DependencySearchDescriptors_ByType_Lazy.Value;

        #endregion

        #region Dependency Set Search Descriptors

        public For_PredicateProviderSuite.PredicateProviderSuite<IDependencySetSearchDescriptor, IDependencySetDescriptor>[] For_DependencySetSearchDescriptors => new[]
        {
            _PredicateProviderOperationHandlerSuites.For_DependencySetSearchDescriptor_Constrained,
            _PredicateProviderOperationHandlerSuites.For_DependencySetSearchDescriptor_DependencySearchDescriptor,
            _PredicateProviderOperationHandlerSuites.For_DependencySetSearchDescriptor_Leaf,
            _PredicateProviderOperationHandlerSuites.For_DependencySetSearchDescriptor_None,
            _PredicateProviderOperationHandlerSuites.For_DependencySetSearchDescriptor_Unconstrained,
        };

        private static readonly Lazy<Dictionary<Type, For_PredicateProviderSuite.PredicateProviderSuite<IDependencySetSearchDescriptor, IDependencySetDescriptor>>> For_DependencySetSearchDescriptors_ByType_Lazy = new(() =>
            Instances.PredicateProviderSuiteSets.For_DependencySetSearchDescriptors
                .ToDictionary(x => x.Type)
        );

        public Dictionary<Type, For_PredicateProviderSuite.PredicateProviderSuite<IDependencySetSearchDescriptor, IDependencySetDescriptor>> For_DependencySetSearchDescriptors_ByType => For_DependencySetSearchDescriptors_ByType_Lazy.Value;

        #endregion

        #region Domain Search Descriptors

        public For_PredicateProviderSuite.PredicateProviderSuite<IDomainSearchDescriptor, IDomainDescriptor>[] For_DomainSearchDescriptors => new[]
        {
            _PredicateProviderOperationHandlerSuites.For_DomainSearchDescriptor,
            _PredicateProviderOperationHandlerSuites.For_DomainSearchDescriptor_Set,
        };

        private static readonly Lazy<Dictionary<Type, For_PredicateProviderSuite.PredicateProviderSuite<IDomainSearchDescriptor, IDomainDescriptor>>> For_DomainSearchDescriptors_ByType_Lazy = new(() =>
            Instances.PredicateProviderSuiteSets.For_DomainSearchDescriptors
                .ToDictionary(x => x.Type)
        );

        public Dictionary<Type, For_PredicateProviderSuite.PredicateProviderSuite<IDomainSearchDescriptor, IDomainDescriptor>> For_DomainSearchDescriptors_ByType => For_DomainSearchDescriptors_ByType_Lazy.Value;

        #endregion

        #region Implementation Scheme Search Descriptors

        public For_PredicateProviderSuite.PredicateProviderSuite<IImplementationSchemeSearchDescriptor, IImplementationSchemeDescriptor>[] For_ImplementationSchemeSearchDescriptors => new[]
        {
            _PredicateProviderOperationHandlerSuites.For_ImplementationSchemeSearchDescriptor_Enumeration,
        };

        private static readonly Lazy<Dictionary<Type, For_PredicateProviderSuite.PredicateProviderSuite<IImplementationSchemeSearchDescriptor, IImplementationSchemeDescriptor>>> For_ImplementationSchemeSearchDescriptors_ByType_Lazy = new(() =>
            Instances.PredicateProviderSuiteSets.For_ImplementationSchemeSearchDescriptors
                .ToDictionary(x => x.Type)
        );

        public Dictionary<Type, For_PredicateProviderSuite.PredicateProviderSuite<IImplementationSchemeSearchDescriptor, IImplementationSchemeDescriptor>> For_ImplementationSchemeSearchDescriptors_ByType => For_ImplementationSchemeSearchDescriptors_ByType_Lazy.Value;

        #endregion

        #region Naming Scheme Search Descriptors

        public For_PredicateProviderSuite.PredicateProviderSuite<INamingSchemeSearchDescriptor, INamingSchemeDescriptor>[] For_NamingSchemeSearchDescriptors => new[]
        {
            _PredicateProviderOperationHandlerSuites.For_NamingSchemeSearchDescriptor_Enumeration,
        };

        private static readonly Lazy<Dictionary<Type, For_PredicateProviderSuite.PredicateProviderSuite<INamingSchemeSearchDescriptor, INamingSchemeDescriptor>>> For_NamingSchemeSearchDescriptors_ByType_Lazy = new(() =>
            Instances.PredicateProviderSuiteSets.For_NamingSchemeSearchDescriptors
                .ToDictionary(x => x.Type)
        );

        public Dictionary<Type, For_PredicateProviderSuite.PredicateProviderSuite<INamingSchemeSearchDescriptor, INamingSchemeDescriptor>> For_NamingSchemeSearchDescriptors_ByType => For_NamingSchemeSearchDescriptors_ByType_Lazy.Value;

        #endregion

        #region .NET Version Search Descriptors

        public For_PredicateProviderSuite.PredicateProviderSuite<INetVersionSearchDescriptor, INetVersionDescriptor>[] For_NetVersionSearchDescriptors => new[]
        {
            _PredicateProviderOperationHandlerSuites.For_NetVersionSearchDescriptor,
        };

        private static readonly Lazy<Dictionary<Type, For_PredicateProviderSuite.PredicateProviderSuite<INetVersionSearchDescriptor, INetVersionDescriptor>>> For_NetVersionSearchDescriptors_ByType_Lazy = new(() =>
            Instances.PredicateProviderSuiteSets.For_NetVersionSearchDescriptors
                .ToDictionary(x => x.Type)
        );

        public Dictionary<Type, For_PredicateProviderSuite.PredicateProviderSuite<INetVersionSearchDescriptor, INetVersionDescriptor>> For_NetVersionSearchDescriptors_ByType => For_NetVersionSearchDescriptors_ByType_Lazy.Value;

        #endregion

        #region Opinion Search Descriptors

        public For_PredicateProviderSuite.PredicateProviderSuite<IOpinionSearchDescriptor, IOpinionDescriptor>[] For_OpinionSearchDescriptors => new[]
        {
            _PredicateProviderOperationHandlerSuites.For_OpinionSearchDescriptor,
        };

        private static readonly Lazy<Dictionary<Type, For_PredicateProviderSuite.PredicateProviderSuite<IOpinionSearchDescriptor, IOpinionDescriptor>>> For_OpinionSearchDescriptors_ByType_Lazy = new(() =>
            Instances.PredicateProviderSuiteSets.For_OpinionSearchDescriptors
                .ToDictionary(x => x.Type)
        );

        public Dictionary<Type, For_PredicateProviderSuite.PredicateProviderSuite<IOpinionSearchDescriptor, IOpinionDescriptor>> For_OpinionSearchDescriptors_ByType => For_OpinionSearchDescriptors_ByType_Lazy.Value;

        #endregion

        #region Organization Search Descriptors

        public For_PredicateProviderSuite.PredicateProviderSuite<IOrganizationSearchDescriptor, IOrganizationDescriptor>[] For_OrganizationSearchDescriptors => new[]
        {
            _PredicateProviderOperationHandlerSuites.For_OrganizationSearchDescriptor_Name,
        };

        private static readonly Lazy<Dictionary<Type, For_PredicateProviderSuite.PredicateProviderSuite<IOrganizationSearchDescriptor, IOrganizationDescriptor>>> For_OrganizationSearchDescriptors_ByType_Lazy = new(() =>
            Instances.PredicateProviderSuiteSets.For_OrganizationSearchDescriptors
                .ToDictionary(x => x.Type)
        );

        public Dictionary<Type, For_PredicateProviderSuite.PredicateProviderSuite<IOrganizationSearchDescriptor, IOrganizationDescriptor>> For_OrganizationSearchDescriptors_ByType => For_OrganizationSearchDescriptors_ByType_Lazy.Value;

        #endregion

        #region Typing Scheme Search Descriptors

        public For_PredicateProviderSuite.PredicateProviderSuite<ITypingSchemeSearchDescriptor, ITypingSchemeDescriptor>[] For_TypingSchemeSearchDescriptors => new[]
        {
            _PredicateProviderOperationHandlerSuites.For_TypingSchemeSearchDescriptor_Enumeration,
        };

        private static readonly Lazy<Dictionary<Type, For_PredicateProviderSuite.PredicateProviderSuite<ITypingSchemeSearchDescriptor, ITypingSchemeDescriptor>>> For_TypingSchemeSearchDescriptors_ByType_Lazy = new(() =>
            Instances.PredicateProviderSuiteSets.For_TypingSchemeSearchDescriptors
                .ToDictionary(x => x.Type)
        );

        public Dictionary<Type, For_PredicateProviderSuite.PredicateProviderSuite<ITypingSchemeSearchDescriptor, ITypingSchemeDescriptor>> For_TypingSchemeSearchDescriptors_ByType => For_TypingSchemeSearchDescriptors_ByType_Lazy.Value;

        #endregion

        #region Visibility Search Descriptors

        public For_PredicateProviderSuite.PredicateProviderSuite<IVisibilitySearchDescriptor, IVisibilityDescriptor>[] For_VisibilitySearchDescriptors => new[]
        {
            _PredicateProviderOperationHandlerSuites.For_VisibilitySearchDescriptor,
        };

        private static readonly Lazy<Dictionary<Type, For_PredicateProviderSuite.PredicateProviderSuite<IVisibilitySearchDescriptor, IVisibilityDescriptor>>> For_VisibilitySearchDescriptors_ByType_Lazy = new(() =>
            Instances.PredicateProviderSuiteSets.For_VisibilitySearchDescriptors
                .ToDictionary(x => x.Type)
        );

        public Dictionary<Type, For_PredicateProviderSuite.PredicateProviderSuite<IVisibilitySearchDescriptor, IVisibilityDescriptor>> For_VisibilitySearchDescriptors_ByType => For_VisibilitySearchDescriptors_ByType_Lazy.Value;

        #endregion
    }
}
