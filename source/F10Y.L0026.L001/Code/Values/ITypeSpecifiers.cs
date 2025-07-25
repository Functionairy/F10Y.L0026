using System;

using F10Y.T0003;


namespace F10Y.L0026.L001
{
    [ValuesMarker]
    public partial interface ITypeSpecifiers
    {
        #region Applicability Descriptors

        public For_TypeSpecifiers.TypeSpecifier<IApplicabilityDescriptor, ApplicabilityDescriptor> For_ApplicabilityDescriptor =>
            For_TypeSpecifiers.TypeSpecifier<IApplicabilityDescriptor, ApplicabilityDescriptor>.Instance;

        public For_TypeSpecifiers.TypeSpecifier<IApplicabilityDescriptor, ApplicabilityDescriptor_Machine> For_ApplicabilityDescriptor_Machine =>
            For_TypeSpecifiers.TypeSpecifier<IApplicabilityDescriptor, ApplicabilityDescriptor_Machine>.Instance;

        public For_TypeSpecifiers.TypeSpecifier<IApplicabilityDescriptor, ApplicabilityDescriptor_Organization> For_ApplicabilityDescriptor_Organization =>
            For_TypeSpecifiers.TypeSpecifier<IApplicabilityDescriptor, ApplicabilityDescriptor_Organization>.Instance;

        public For_TypeSpecifiers.TypeSpecifier<IApplicabilityDescriptor, ApplicabilityDescriptor_Personal> For_ApplicabilityDescriptor_Personal =>
            For_TypeSpecifiers.TypeSpecifier<IApplicabilityDescriptor, ApplicabilityDescriptor_Personal>.Instance;

        public For_TypeSpecifiers.TypeSpecifier<IApplicabilityDescriptor, ApplicabilityDescriptor_Project> For_ApplicabilityDescriptor_Project =>
            For_TypeSpecifiers.TypeSpecifier<IApplicabilityDescriptor, ApplicabilityDescriptor_Project>.Instance;

        #endregion

        #region Dependency Descriptors

        public For_TypeSpecifiers.TypeSpecifier<IDependencyDescriptor, DependencyDescriptor_Constrained> For_DependencyDescriptor_Constrained =>
            For_TypeSpecifiers.TypeSpecifier<IDependencyDescriptor, DependencyDescriptor_Constrained>.Instance;

        public For_TypeSpecifiers.TypeSpecifier<IDependencyDescriptor, DependencyDescriptor_Leaf> For_DependencyDescriptor_Leaf =>
            For_TypeSpecifiers.TypeSpecifier<IDependencyDescriptor, DependencyDescriptor_Leaf>.Instance;

        public For_TypeSpecifiers.TypeSpecifier<IDependencyDescriptor, DependencyDescriptor_Name> For_DependencyDescriptor_Name =>
            For_TypeSpecifiers.TypeSpecifier<IDependencyDescriptor, DependencyDescriptor_Name>.Instance;

        public For_TypeSpecifiers.TypeSpecifier<IDependencyDescriptor, DependencyDescriptor_NuGetPackage> For_DependencyDescriptor_NugetPackage =>
            For_TypeSpecifiers.TypeSpecifier<IDependencyDescriptor, DependencyDescriptor_NuGetPackage>.Instance;

        public For_TypeSpecifiers.TypeSpecifier<IDependencyDescriptor, DependencyDescriptor_Project> For_DependencyDescriptor_Project =>
            For_TypeSpecifiers.TypeSpecifier<IDependencyDescriptor, DependencyDescriptor_Project>.Instance;

        #endregion

        #region Dependency Set Descriptors

        public For_TypeSpecifiers.TypeSpecifier<IDependencySetDescriptor, DependencySetDescriptor> For_DependencySetDescriptor =>
            For_TypeSpecifiers.TypeSpecifier<IDependencySetDescriptor, DependencySetDescriptor>.Instance;

        public For_TypeSpecifiers.TypeSpecifier<IDependencySetDescriptor, DependencySetDescriptor_Constrained> For_DependencySetDescriptor_Constrained =>
            For_TypeSpecifiers.TypeSpecifier<IDependencySetDescriptor, DependencySetDescriptor_Constrained>.Instance;

        public For_TypeSpecifiers.TypeSpecifier<IDependencySetDescriptor, DependencySetDescriptor_Leaf> For_DependencySetDescriptor_Leaf =>
            For_TypeSpecifiers.TypeSpecifier<IDependencySetDescriptor, DependencySetDescriptor_Leaf>.Instance;

        public For_TypeSpecifiers.TypeSpecifier<IDependencySetDescriptor, DependencySetDescriptor_None> For_DependencySetDescriptor_None =>
            For_TypeSpecifiers.TypeSpecifier<IDependencySetDescriptor, DependencySetDescriptor_None>.Instance;

        public For_TypeSpecifiers.TypeSpecifier<IDependencySetDescriptor, DependencySetDescriptor_Unconstrained> For_DependencySetDescriptor_Unconstrained =>
            For_TypeSpecifiers.TypeSpecifier<IDependencySetDescriptor, DependencySetDescriptor_Unconstrained>.Instance;

        #endregion

        #region Domain Descriptors

        public For_TypeSpecifiers.TypeSpecifier<IDomainDescriptor, DomainDescriptor> For_DomainDescriptor =>
            For_TypeSpecifiers.TypeSpecifier<IDomainDescriptor, DomainDescriptor>.Instance;

        public For_TypeSpecifiers.TypeSpecifier<IDomainDescriptor, DomainDescriptor_Set> For_DomainDescriptor_Set =>
            For_TypeSpecifiers.TypeSpecifier<IDomainDescriptor, DomainDescriptor_Set>.Instance;

        public For_TypeSpecifiers.TypeSpecifier<IDomainDescriptor, DomainDescriptor_Set_Ordered> For_DomainDescriptor_Set_Ordered =>
            For_TypeSpecifiers.TypeSpecifier<IDomainDescriptor, DomainDescriptor_Set_Ordered>.Instance;

        #endregion

        #region Implementation Scheme Descriptors

        public For_TypeSpecifiers.TypeSpecifier<IImplementationSchemeDescriptor, ImplementationSchemeDescriptor_Enumeration> For_ImplementationSchemeDescriptor_Enumeration =>
            For_TypeSpecifiers.TypeSpecifier<IImplementationSchemeDescriptor, ImplementationSchemeDescriptor_Enumeration>.Instance;

        #endregion

        #region Location Descriptors

        public For_TypeSpecifiers.TypeSpecifier<ILocationDescriptor, LocationDescriptor_Aggregate> For_LocationDescriptor_Aggregate =>
            For_TypeSpecifiers.TypeSpecifier<ILocationDescriptor, LocationDescriptor_Aggregate>.Instance;

        public For_TypeSpecifiers.TypeSpecifier<ILocationDescriptor, LocationDescriptor_GitHubRepository> For_LocationDescriptor_GitHubRepository =>
            For_TypeSpecifiers.TypeSpecifier<ILocationDescriptor, LocationDescriptor_GitHubRepository>.Instance;

        public For_TypeSpecifiers.TypeSpecifier<ILocationDescriptor, LocationDescriptor_ProjectFile> For_LocationDescriptor_ProjectFile =>
            For_TypeSpecifiers.TypeSpecifier<ILocationDescriptor, LocationDescriptor_ProjectFile>.Instance;

        #endregion

        #region Naming Scheme Descriptor

        public For_TypeSpecifiers.TypeSpecifier<INamingSchemeDescriptor, NamingSchemeDescriptor_Enumeration> For_NamingSchemeDescriptor_Enumeration =>
            For_TypeSpecifiers.TypeSpecifier<INamingSchemeDescriptor, NamingSchemeDescriptor_Enumeration>.Instance;

        #endregion

        #region .NET Version Descriptors

        public For_TypeSpecifiers.TypeSpecifier<INetVersionDescriptor, NetVersionDescriptor> For_NetVersionDescriptor =>
            For_TypeSpecifiers.TypeSpecifier<INetVersionDescriptor, NetVersionDescriptor>.Instance;

        public For_TypeSpecifiers.TypeSpecifier<INetVersionDescriptor, NetVersionDescriptor_Latest> For_NetVersionDescriptor_Latest =>
            For_TypeSpecifiers.TypeSpecifier<INetVersionDescriptor, NetVersionDescriptor_Latest>.Instance;

        #endregion

        #region Opinion Descriptors

        public For_TypeSpecifiers.TypeSpecifier<IOpinionDescriptor, OpinionDescriptor> For_OpinionDescriptor =>
            For_TypeSpecifiers.TypeSpecifier<IOpinionDescriptor, OpinionDescriptor>.Instance;

        public For_TypeSpecifiers.TypeSpecifier<IOpinionDescriptor, OpinionDescriptor_Set> For_OpinionDescriptor_Set =>
            For_TypeSpecifiers.TypeSpecifier<IOpinionDescriptor, OpinionDescriptor_Set>.Instance;

        #endregion

        #region Organization Descriptors

        public For_TypeSpecifiers.TypeSpecifier<IOrganizationDescriptor, OrganizationDescriptor_Name> For_OrganizationDescriptor =>
            For_TypeSpecifiers.TypeSpecifier<IOrganizationDescriptor, OrganizationDescriptor_Name>.Instance;

        #endregion

        #region Typing Scheme Descriptors

        public For_TypeSpecifiers.TypeSpecifier<ITypingSchemeDescriptor, TypingSchemeDescriptor_Enumeration> For_TypingSchemeDescriptor_Enumeration =>
            For_TypeSpecifiers.TypeSpecifier<ITypingSchemeDescriptor, TypingSchemeDescriptor_Enumeration>.Instance;

        #endregion

        #region Visibility Descriptors

        public For_TypeSpecifiers.TypeSpecifier<IVisibilityDescriptor, VisibilityDescriptor> For_VisibilityDescriptor =>
            For_TypeSpecifiers.TypeSpecifier<IVisibilityDescriptor, VisibilityDescriptor>.Instance;

        #endregion
    }
}
