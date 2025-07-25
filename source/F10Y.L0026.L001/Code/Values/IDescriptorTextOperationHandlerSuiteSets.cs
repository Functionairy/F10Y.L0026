using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.T0003;


namespace F10Y.L0026.L001
{
    [ValuesMarker]
    public partial interface IDescriptorTextOperationHandlerSuiteSets
    {
#pragma warning disable IDE1006 // Naming Styles

        private static IDescriptorTextOperationHandlerSuites _DescriptorTextOperationHandlerSuites => Instances.DescriptorTextOperationHandlerSuites;

#pragma warning restore IDE1006 // Naming Styles


        #region Applicability Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IApplicabilityDescriptor>[] For_ApplicabilityDescriptors => new[]
        {
            _DescriptorTextOperationHandlerSuites.For_ApplicabilityDescriptor,
            _DescriptorTextOperationHandlerSuites.For_ApplicabilityDescriptor_Machine,
            _DescriptorTextOperationHandlerSuites.For_ApplicabilityDescriptor_Organization,
            _DescriptorTextOperationHandlerSuites.For_ApplicabilityDescriptor_Personal,
            _DescriptorTextOperationHandlerSuites.For_ApplicabilityDescriptor_Project,
        };

        private static readonly Lazy<Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IApplicabilityDescriptor>>> For_ApplicabilityDescriptors_ByType_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_ApplicabilityDescriptors
                .ToDictionary(x => x.Type)
        );

        public Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IApplicabilityDescriptor>> For_ApplicabilityDescriptors_ByType => For_ApplicabilityDescriptors_ByType_Lazy.Value;

        private static readonly Lazy<Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IApplicabilityDescriptor>>> For_ApplicabilityDescriptors_ByTypeName_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_ApplicabilityDescriptors_ByType
                .ToDictionary(
                    pair => Instances.TypeNameOperator.Get_TypeName(pair.Key),
                    pair => pair.Value)
        );

        public Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IApplicabilityDescriptor>> For_ApplicabilityDescriptors_ByTypeName => For_ApplicabilityDescriptors_ByTypeName_Lazy.Value;

        #endregion

        #region Dependency Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDependencyDescriptor>[] For_DependencyDescriptors => new[]
        {
            _DescriptorTextOperationHandlerSuites.For_DependencyDescriptor_Constrained,
            _DescriptorTextOperationHandlerSuites.For_DependencyDescriptor_Leaf,
            _DescriptorTextOperationHandlerSuites.For_DependencyDescriptor_Name,
            _DescriptorTextOperationHandlerSuites.For_DependencyDescriptor_NugetPackage,
            _DescriptorTextOperationHandlerSuites.For_DependencyDescriptor_Project,
        };

        private static readonly Lazy<Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDependencyDescriptor>>> For_DependencyDescriptors_ByType_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_DependencyDescriptors
                .ToDictionary(x => x.Type)
        );

        public Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDependencyDescriptor>> For_DependencyDescriptors_ByType => For_DependencyDescriptors_ByType_Lazy.Value;

        private static readonly Lazy<Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDependencyDescriptor>>> For_DependencyDescriptors_ByTypeName_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_DependencyDescriptors_ByType
                .ToDictionary(
                    pair => Instances.TypeNameOperator.Get_TypeName(pair.Key),
                    pair => pair.Value)
        );

        public Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDependencyDescriptor>> For_DependencyDescriptors_ByTypeName => For_DependencyDescriptors_ByTypeName_Lazy.Value;

        #endregion

        #region Dependency Set Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDependencySetDescriptor>[] For_DependencySetDescriptors => new[]
        {
            _DescriptorTextOperationHandlerSuites.For_DependencySetDescriptor,
            _DescriptorTextOperationHandlerSuites.For_DependencySetDescriptor_Constrained,
            _DescriptorTextOperationHandlerSuites.For_DependencySetDescriptor_Leaf,
            _DescriptorTextOperationHandlerSuites.For_DependencySetDescriptor_None,
            _DescriptorTextOperationHandlerSuites.For_DependencySetDescriptor_Unconstrained,
        };

        private static readonly Lazy<Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDependencySetDescriptor>>> For_DependencySetDescriptors_ByType_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_DependencySetDescriptors
                .ToDictionary(x => x.Type)
        );

        public Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDependencySetDescriptor>> For_DependencySetDescriptors_ByType => For_DependencySetDescriptors_ByType_Lazy.Value;

        private static readonly Lazy<Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDependencySetDescriptor>>> For_DependencySetDescriptors_ByTypeName_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_DependencySetDescriptors_ByType
                .ToDictionary(
                    pair => Instances.TypeNameOperator.Get_TypeName(pair.Key),
                    pair => pair.Value)
        );

        public Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDependencySetDescriptor>> For_DependencySetDescriptors_ByTypeName => For_DependencySetDescriptors_ByTypeName_Lazy.Value;

        #endregion

        #region Domain Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDomainDescriptor>[] For_DomainDescriptors => new[]
        {
            _DescriptorTextOperationHandlerSuites.For_DomainDescriptor,
            _DescriptorTextOperationHandlerSuites.For_DomainDescriptor_Set,
            _DescriptorTextOperationHandlerSuites.For_DomainDescriptor_Set_Ordered,
        };

        private static readonly Lazy<Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDomainDescriptor>>> For_DomainDescriptors_ByType_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_DomainDescriptors
                .ToDictionary(x => x.Type)
        );

        public Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDomainDescriptor>> For_DomainDescriptors_ByType => For_DomainDescriptors_ByType_Lazy.Value;

        private static readonly Lazy<Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDomainDescriptor>>> For_DomainDescriptors_ByTypeName_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_DomainDescriptors_ByType
                .ToDictionary(
                    pair => Instances.TypeNameOperator.Get_TypeName(pair.Key),
                    pair => pair.Value)
        );

        public Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDomainDescriptor>> For_DomainDescriptors_ByTypeName => For_DomainDescriptors_ByTypeName_Lazy.Value;

        #endregion

        #region Implementation Scheme Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IImplementationSchemeDescriptor>[] For_ImplementationSchemeDescriptors => new[]
        {
            _DescriptorTextOperationHandlerSuites.For_ImplementationSchemeDescriptor_Enumeration
        };

        private static readonly Lazy<Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IImplementationSchemeDescriptor>>> For_ImplementationSchemeDescriptors_ByType_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_ImplementationSchemeDescriptors
                .ToDictionary(x => x.Type)
        );

        public Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IImplementationSchemeDescriptor>> For_ImplementationSchemeDescriptors_ByType => For_ImplementationSchemeDescriptors_ByType_Lazy.Value;

        private static readonly Lazy<Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IImplementationSchemeDescriptor>>> For_ImplementationSchemeDescriptors_ByTypeName_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_ImplementationSchemeDescriptors_ByType
                .ToDictionary(
                    pair => Instances.TypeNameOperator.Get_TypeName(pair.Key),
                    pair => pair.Value)
        );

        public Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IImplementationSchemeDescriptor>> For_ImplementationSchemeDescriptors_ByTypeName => For_ImplementationSchemeDescriptors_ByTypeName_Lazy.Value;

        #endregion

        #region Location Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<ILocationDescriptor>[] For_LocationDescriptors => new[]
        {
            _DescriptorTextOperationHandlerSuites.For_LocationDescriptor_Aggregate,
            _DescriptorTextOperationHandlerSuites.For_LocationDescriptor_GitHubRepository,
            _DescriptorTextOperationHandlerSuites.For_LocationDescriptor_ProjectFile,
        };

        private static readonly Lazy<Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<ILocationDescriptor>>> For_LocationDescriptors_ByType_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_LocationDescriptors
                .ToDictionary(x => x.Type)
        );

        public Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<ILocationDescriptor>> For_LocationDescriptors_ByType => For_LocationDescriptors_ByType_Lazy.Value;

        private static readonly Lazy<Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<ILocationDescriptor>>> For_LocationDescriptors_ByTypeName_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_LocationDescriptors_ByType
                .ToDictionary(
                    pair => Instances.TypeNameOperator.Get_TypeName(pair.Key),
                    pair => pair.Value)
        );

        public Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<ILocationDescriptor>> For_LocationDescriptors_ByTypeName => For_LocationDescriptors_ByTypeName_Lazy.Value;

        #endregion

        #region Naming Scheme Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<INamingSchemeDescriptor>[] For_NamingSchemeDescriptors => new[]
        {
            _DescriptorTextOperationHandlerSuites.For_NamingSchemeDescriptor_Enumeration
        };

        private static readonly Lazy<Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<INamingSchemeDescriptor>>> For_NamingSchemeDescriptors_ByType_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_NamingSchemeDescriptors
                .ToDictionary(x => x.Type)
        );

        public Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<INamingSchemeDescriptor>> For_NamingSchemeDescriptors_ByType => For_NamingSchemeDescriptors_ByType_Lazy.Value;

        private static readonly Lazy<Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<INamingSchemeDescriptor>>> For_NamingSchemeDescriptors_ByTypeName_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_NamingSchemeDescriptors_ByType
                .ToDictionary(
                    pair => Instances.TypeNameOperator.Get_TypeName(pair.Key),
                    pair => pair.Value)
        );

        public Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<INamingSchemeDescriptor>> For_NamingSchemeDescriptors_ByTypeName => For_NamingSchemeDescriptors_ByTypeName_Lazy.Value;

        #endregion

        #region .NET Version Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<INetVersionDescriptor>[] For_NetVersionDescriptors => new[]
        {
            _DescriptorTextOperationHandlerSuites.For_NetVersionDescriptor,
            _DescriptorTextOperationHandlerSuites.For_NetVersionDescriptor_Latest,
        };

        private static readonly Lazy<Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<INetVersionDescriptor>>> For_NetVersionDescriptors_ByType_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_NetVersionDescriptors
                .ToDictionary(x => x.Type)
        );

        public Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<INetVersionDescriptor>> For_NetVersionDescriptors_ByType => For_NetVersionDescriptors_ByType_Lazy.Value;

        private static readonly Lazy<Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<INetVersionDescriptor>>> For_NetVersionDescriptors_ByTypeName_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_NetVersionDescriptors_ByType
                .ToDictionary(
                    pair => Instances.TypeNameOperator.Get_TypeName(pair.Key),
                    pair => pair.Value)
        );

        public Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<INetVersionDescriptor>> For_NetVersionDescriptors_ByTypeName => For_NetVersionDescriptors_ByTypeName_Lazy.Value;

        #endregion

        #region Opinion Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IOpinionDescriptor>[] For_OpinionDescriptors => new[]
        {
            _DescriptorTextOperationHandlerSuites.For_OpinionDescriptor,
            _DescriptorTextOperationHandlerSuites.For_OpinionDescriptor_Set
        };

        private static readonly Lazy<Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IOpinionDescriptor>>> For_OpinionDescriptors_ByType_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_OpinionDescriptors
                .ToDictionary(x => x.Type)
        );

        public Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IOpinionDescriptor>> For_OpinionDescriptors_ByType => For_OpinionDescriptors_ByType_Lazy.Value;

        private static readonly Lazy<Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IOpinionDescriptor>>> For_OpinionDescriptors_ByTypeName_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_OpinionDescriptors_ByType
                .ToDictionary(
                    pair => Instances.TypeNameOperator.Get_TypeName(pair.Key),
                    pair => pair.Value)
        );

        public Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IOpinionDescriptor>> For_OpinionDescriptors_ByTypeName => For_OpinionDescriptors_ByTypeName_Lazy.Value;

        #endregion

        #region Organization Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IOrganizationDescriptor>[] For_OrganizationDescriptors => new[]
        {
            _DescriptorTextOperationHandlerSuites.For_OrganizationDescriptor,
        };

        private static readonly Lazy<Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IOrganizationDescriptor>>> For_OrganizationDescriptors_ByType_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_OrganizationDescriptors
                .ToDictionary(x => x.Type)
        );

        public Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IOrganizationDescriptor>> For_OrganizationDescriptors_ByType => For_OrganizationDescriptors_ByType_Lazy.Value;

        private static readonly Lazy<Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IOrganizationDescriptor>>> For_OrganizationDescriptors_ByTypeName_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_OrganizationDescriptors_ByType
                .ToDictionary(
                    pair => Instances.TypeNameOperator.Get_TypeName(pair.Key),
                    pair => pair.Value)
        );

        public Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IOrganizationDescriptor>> For_OrganizationDescriptors_ByTypeName => For_OrganizationDescriptors_ByTypeName_Lazy.Value;

        #endregion

        #region Typing Scheme Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<ITypingSchemeDescriptor>[] For_TypingSchemeDescriptors => new[]
        {
            _DescriptorTextOperationHandlerSuites.For_TypingSchemeDescriptor_Enumeration
        };

        private static readonly Lazy<Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<ITypingSchemeDescriptor>>> For_TypingSchemeDescriptors_ByType_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_TypingSchemeDescriptors
                .ToDictionary(x => x.Type)
        );

        public Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<ITypingSchemeDescriptor>> For_TypingSchemeDescriptors_ByType => For_TypingSchemeDescriptors_ByType_Lazy.Value;

        private static readonly Lazy<Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<ITypingSchemeDescriptor>>> For_TypingSchemeDescriptors_ByTypeName_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_TypingSchemeDescriptors_ByType
                .ToDictionary(
                    pair => Instances.TypeNameOperator.Get_TypeName(pair.Key),
                    pair => pair.Value)
        );

        public Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<ITypingSchemeDescriptor>> For_TypingSchemeDescriptors_ByTypeName => For_TypingSchemeDescriptors_ByTypeName_Lazy.Value;

        #endregion

        #region Visibility Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IVisibilityDescriptor>[] For_VisibilityDescriptors => new[]
        {
            _DescriptorTextOperationHandlerSuites.For_VisibilityDescriptor,
        };

        private static readonly Lazy<Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IVisibilityDescriptor>>> For_VisibilityDescriptors_ByType_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_VisibilityDescriptors
                .ToDictionary(x => x.Type)
        );

        public Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IVisibilityDescriptor>> For_VisibilityDescriptors_ByType => For_VisibilityDescriptors_ByType_Lazy.Value;

        private static readonly Lazy<Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IVisibilityDescriptor>>> For_VisibilityDescriptors_ByTypeName_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_VisibilityDescriptors_ByType
                .ToDictionary(
                    pair => Instances.TypeNameOperator.Get_TypeName(pair.Key),
                    pair => pair.Value)
        );

        public Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IVisibilityDescriptor>> For_VisibilityDescriptors_ByTypeName => For_VisibilityDescriptors_ByTypeName_Lazy.Value;

        #endregion
    }
}
