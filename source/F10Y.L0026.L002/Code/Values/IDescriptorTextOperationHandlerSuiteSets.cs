using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.T0003;


namespace F10Y.L0026.L002
{
    [ValuesMarker]
    public partial interface IDescriptorTextOperationHandlerSuiteSets
    {
#pragma warning disable IDE1006 // Naming Styles

        private static IDescriptorTextOperationHandlerSuites _DescriptorTextOperationHandlerSuites => Instances.DescriptorTextOperationHandlerSuites;

#pragma warning restore IDE1006 // Naming Styles

        #region Applicability Search Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IApplicabilitySearchDescriptor>[] For_ApplicabilitySearchDescriptors => new[]
        {
            _DescriptorTextOperationHandlerSuites.For_ApplicabilitySearchDescriptor
        };

        private static readonly Lazy<Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IApplicabilitySearchDescriptor>>> For_ApplicabilitySearchDescriptors_ByType_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_ApplicabilitySearchDescriptors
                .ToDictionary(x => x.Type)
        );

        public Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IApplicabilitySearchDescriptor>> For_ApplicabilitySearchDescriptors_ByType => For_ApplicabilitySearchDescriptors_ByType_Lazy.Value;

        private static readonly Lazy<Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IApplicabilitySearchDescriptor>>> For_ApplicabilitySearchDescriptors_ByTypeName_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_ApplicabilitySearchDescriptors_ByType
                .ToDictionary(
                    pair => Instances.TypeNameOperator.Get_TypeName(pair.Key),
                    pair => pair.Value)
        );

        public Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IApplicabilitySearchDescriptor>> For_ApplicabilitySearchDescriptors_ByTypeName => For_ApplicabilitySearchDescriptors_ByTypeName_Lazy.Value;

        #endregion

        #region Dependency Search Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDependencySearchDescriptor>[] For_DependencySearchDescriptors => new[]
        {
            _DescriptorTextOperationHandlerSuites.For_DependencySearchDescriptor_Constrained,
            _DescriptorTextOperationHandlerSuites.For_DependencySearchDescriptor_Leaf,
            _DescriptorTextOperationHandlerSuites.For_DependencySearchDescriptor_Name,
            _DescriptorTextOperationHandlerSuites.For_DependencySearchDescriptor_NuGetPackage,
            _DescriptorTextOperationHandlerSuites.For_DependencySearchDescriptor_Project,
        };

        private static readonly Lazy<Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDependencySearchDescriptor>>> For_DependencySearchDescriptors_ByType_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_DependencySearchDescriptors
                .ToDictionary(x => x.Type)
        );

        public Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDependencySearchDescriptor>> For_DependencySearchDescriptors_ByType => For_DependencySearchDescriptors_ByType_Lazy.Value;

        private static readonly Lazy<Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDependencySearchDescriptor>>> For_DependencySearchDescriptors_ByTypeName_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_DependencySearchDescriptors_ByType
                .ToDictionary(
                    pair => Instances.TypeNameOperator.Get_TypeName(pair.Key),
                    pair => pair.Value)
        );

        public Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDependencySearchDescriptor>> For_DependencySearchDescriptors_ByTypeName => For_DependencySearchDescriptors_ByTypeName_Lazy.Value;

        #endregion

        #region Dependency Set Search Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDependencySetSearchDescriptor>[] For_DependencySetSearchDescriptors => new[]
        {
            _DescriptorTextOperationHandlerSuites.For_DependencySetSearchDescriptor_Constrained,
            _DescriptorTextOperationHandlerSuites.For_DependencySetSearchDescriptor_DependencySearchDescriptor,
            _DescriptorTextOperationHandlerSuites.For_DependencySetSearchDescriptor_Leaf,
            _DescriptorTextOperationHandlerSuites.For_DependencySetSearchDescriptor_None,
            _DescriptorTextOperationHandlerSuites.For_DependencySetSearchDescriptor_Unconstrained,
        };

        private static readonly Lazy<Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDependencySetSearchDescriptor>>> For_DependencySetSearchDescriptors_ByType_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_DependencySetSearchDescriptors
                .ToDictionary(x => x.Type)
        );

        public Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDependencySetSearchDescriptor>> For_DependencySetSearchDescriptors_ByType => For_DependencySetSearchDescriptors_ByType_Lazy.Value;

        private static readonly Lazy<Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDependencySetSearchDescriptor>>> For_DependencySetSearchDescriptors_ByTypeName_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_DependencySetSearchDescriptors_ByType
                .ToDictionary(
                    pair => Instances.TypeNameOperator.Get_TypeName(pair.Key),
                    pair => pair.Value)
        );

        public Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDependencySetSearchDescriptor>> For_DependencySetSearchDescriptors_ByTypeName => For_DependencySetSearchDescriptors_ByTypeName_Lazy.Value;

        #endregion

        #region Domain Search Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDomainSearchDescriptor>[] For_DomainSearchDescriptors => new[]
        {
            _DescriptorTextOperationHandlerSuites.For_DomainSearchDescriptor,
            _DescriptorTextOperationHandlerSuites.For_DomainSearchDescriptor_Set,
        };

        private static readonly Lazy<Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDomainSearchDescriptor>>> For_DomainSearchDescriptors_ByType_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_DomainSearchDescriptors
                .ToDictionary(x => x.Type)
        );

        public Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDomainSearchDescriptor>> For_DomainSearchDescriptors_ByType => For_DomainSearchDescriptors_ByType_Lazy.Value;

        private static readonly Lazy<Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDomainSearchDescriptor>>> For_DomainSearchDescriptors_ByTypeName_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_DomainSearchDescriptors_ByType
                .ToDictionary(
                    pair => Instances.TypeNameOperator.Get_TypeName(pair.Key),
                    pair => pair.Value)
        );

        public Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDomainSearchDescriptor>> For_DomainSearchDescriptors_ByTypeName => For_DomainSearchDescriptors_ByTypeName_Lazy.Value;

        #endregion

        #region Implementation Scheme Search Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IImplementationSchemeSearchDescriptor>[] For_ImplementationSchemeSearchDescriptors => new[]
        {
            _DescriptorTextOperationHandlerSuites.For_ImplementationSchemeSearchDescriptor_Enumeration
        };

        private static readonly Lazy<Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IImplementationSchemeSearchDescriptor>>> For_ImplementationSchemeSearchDescriptors_ByType_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_ImplementationSchemeSearchDescriptors
                .ToDictionary(x => x.Type)
        );

        public Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IImplementationSchemeSearchDescriptor>> For_ImplementationSchemeSearchDescriptors_ByType => For_ImplementationSchemeSearchDescriptors_ByType_Lazy.Value;

        private static readonly Lazy<Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IImplementationSchemeSearchDescriptor>>> For_ImplementationSchemeSearchDescriptors_ByTypeName_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_ImplementationSchemeSearchDescriptors_ByType
                .ToDictionary(
                    pair => Instances.TypeNameOperator.Get_TypeName(pair.Key),
                    pair => pair.Value)
        );

        public Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IImplementationSchemeSearchDescriptor>> For_ImplementationSchemeSearchDescriptors_ByTypeName => For_ImplementationSchemeSearchDescriptors_ByTypeName_Lazy.Value;

        #endregion

        #region Naming Scheme Search Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<INamingSchemeSearchDescriptor>[] For_NamingSchemeSearchDescriptors => new[]
        {
            _DescriptorTextOperationHandlerSuites.For_NamingSchemeSearchDescriptor_Enumeration
        };

        private static readonly Lazy<Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<INamingSchemeSearchDescriptor>>> For_NamingSchemeSearchDescriptors_ByType_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_NamingSchemeSearchDescriptors
                .ToDictionary(x => x.Type)
        );

        public Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<INamingSchemeSearchDescriptor>> For_NamingSchemeSearchDescriptors_ByType => For_NamingSchemeSearchDescriptors_ByType_Lazy.Value;

        private static readonly Lazy<Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<INamingSchemeSearchDescriptor>>> For_NamingSchemeSearchDescriptors_ByTypeName_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_NamingSchemeSearchDescriptors_ByType
                .ToDictionary(
                    pair => Instances.TypeNameOperator.Get_TypeName(pair.Key),
                    pair => pair.Value)
        );

        public Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<INamingSchemeSearchDescriptor>> For_NamingSchemeSearchDescriptors_ByTypeName => For_NamingSchemeSearchDescriptors_ByTypeName_Lazy.Value;

        #endregion

        #region .NET Version Search Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<INetVersionSearchDescriptor>[] For_NetVersionSearchDescriptors => new[]
        {
            _DescriptorTextOperationHandlerSuites.For_NetVersionSearchDescriptor,
        };

        private static readonly Lazy<Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<INetVersionSearchDescriptor>>> For_NetVersionSearchDescriptors_ByType_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_NetVersionSearchDescriptors
                .ToDictionary(x => x.Type)
        );

        public Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<INetVersionSearchDescriptor>> For_NetVersionSearchDescriptors_ByType => For_NetVersionSearchDescriptors_ByType_Lazy.Value;

        private static readonly Lazy<Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<INetVersionSearchDescriptor>>> For_NetVersionSearchDescriptors_ByTypeName_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_NetVersionSearchDescriptors_ByType
                .ToDictionary(
                    pair => Instances.TypeNameOperator.Get_TypeName(pair.Key),
                    pair => pair.Value)
        );

        public Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<INetVersionSearchDescriptor>> For_NetVersionSearchDescriptors_ByTypeName => For_NetVersionSearchDescriptors_ByTypeName_Lazy.Value;

        #endregion

        #region Opinion Search Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IOpinionSearchDescriptor>[] For_OpinionSearchDescriptors => new[]
        {
            _DescriptorTextOperationHandlerSuites.For_OpinionSearchDescriptor
        };

        private static readonly Lazy<Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IOpinionSearchDescriptor>>> For_OpinionSearchDescriptors_ByType_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_OpinionSearchDescriptors
                .ToDictionary(x => x.Type)
        );

        public Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IOpinionSearchDescriptor>> For_OpinionSearchDescriptors_ByType => For_OpinionSearchDescriptors_ByType_Lazy.Value;

        private static readonly Lazy<Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IOpinionSearchDescriptor>>> For_OpinionSearchDescriptors_ByTypeName_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_OpinionSearchDescriptors_ByType
                .ToDictionary(
                    pair => Instances.TypeNameOperator.Get_TypeName(pair.Key),
                    pair => pair.Value)
        );

        public Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IOpinionSearchDescriptor>> For_OpinionSearchDescriptors_ByTypeName => For_OpinionSearchDescriptors_ByTypeName_Lazy.Value;

        #endregion

        #region Organization Search Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IOrganizationSearchDescriptor>[] For_OrganizationSerachDescriptors => new[]
        {
            _DescriptorTextOperationHandlerSuites.For_OrganizationSerachDescriptor_Name
        };

        private static readonly Lazy<Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IOrganizationSearchDescriptor>>> For_OrganizationSerachDescriptors_ByType_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_OrganizationSerachDescriptors
                .ToDictionary(x => x.Type)
        );

        public Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IOrganizationSearchDescriptor>> For_OrganizationSerachDescriptors_ByType => For_OrganizationSerachDescriptors_ByType_Lazy.Value;

        private static readonly Lazy<Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IOrganizationSearchDescriptor>>> For_OrganizationSerachDescriptors_ByTypeName_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_OrganizationSerachDescriptors_ByType
                .ToDictionary(
                    pair => Instances.TypeNameOperator.Get_TypeName(pair.Key),
                    pair => pair.Value)
        );

        public Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IOrganizationSearchDescriptor>> For_OrganizationSerachDescriptors_ByTypeName => For_OrganizationSerachDescriptors_ByTypeName_Lazy.Value;

        #endregion

        #region Typing Scheme Search Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<ITypingSchemeSearchDescriptor>[] For_TypingSchemeSearchDescriptors => new[]
        {
            _DescriptorTextOperationHandlerSuites.For_TypingSchemeSearchDescriptor_Enumeration
        };

        private static readonly Lazy<Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<ITypingSchemeSearchDescriptor>>> For_TypingSchemeSearchDescriptors_ByType_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_TypingSchemeSearchDescriptors
                .ToDictionary(x => x.Type)
        );

        public Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<ITypingSchemeSearchDescriptor>> For_TypingSchemeSearchDescriptors_ByType => For_TypingSchemeSearchDescriptors_ByType_Lazy.Value;

        private static readonly Lazy<Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<ITypingSchemeSearchDescriptor>>> For_TypingSchemeSearchDescriptors_ByTypeName_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_TypingSchemeSearchDescriptors_ByType
                .ToDictionary(
                    pair => Instances.TypeNameOperator.Get_TypeName(pair.Key),
                    pair => pair.Value)
        );

        public Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<ITypingSchemeSearchDescriptor>> For_TypingSchemeSearchDescriptors_ByTypeName => For_TypingSchemeSearchDescriptors_ByTypeName_Lazy.Value;

        #endregion

        #region Visibility Search Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IVisibilitySearchDescriptor>[] For_VisibilitySearchDescriptors => new[]
        {
            _DescriptorTextOperationHandlerSuites.For_VisibilitySearchDescriptor
        };

        private static readonly Lazy<Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IVisibilitySearchDescriptor>>> For_VisibilitySearchDescriptors_ByType_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_VisibilitySearchDescriptors
                .ToDictionary(x => x.Type)
        );

        public Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IVisibilitySearchDescriptor>> For_VisibilitySearchDescriptors_ByType => For_VisibilitySearchDescriptors_ByType_Lazy.Value;

        private static readonly Lazy<Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IVisibilitySearchDescriptor>>> For_VisibilitySearchDescriptors_ByTypeName_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_VisibilitySearchDescriptors_ByType
                .ToDictionary(
                    pair => Instances.TypeNameOperator.Get_TypeName(pair.Key),
                    pair => pair.Value)
        );

        public Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IVisibilitySearchDescriptor>> For_VisibilitySearchDescriptors_ByTypeName => For_VisibilitySearchDescriptors_ByTypeName_Lazy.Value;

        #endregion
    }
}
