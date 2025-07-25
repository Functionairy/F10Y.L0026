using System;

using F10Y.T0003;


namespace F10Y.L0026.L002
{
    [ValuesMarker]
    public partial interface ITypeSpecifiers
    {
        #region Applicability Search Descriptors

        public For_TypeSpecifiers.TypeSpecifier<IApplicabilitySearchDescriptor, ApplicabilitySearchDescriptor> For_ApplicabilitySearchDescriptor =>
            For_TypeSpecifiers.TypeSpecifier<IApplicabilitySearchDescriptor, ApplicabilitySearchDescriptor>.Instance;

        #endregion

        #region Dependency Search Descriptors

        public For_TypeSpecifiers.TypeSpecifier<IDependencySearchDescriptor, DependencySearchDescriptor_Constrained> For_DependencySearchDescriptor_Constrained =>
            For_TypeSpecifiers.TypeSpecifier<IDependencySearchDescriptor, DependencySearchDescriptor_Constrained>.Instance;

        public For_TypeSpecifiers.TypeSpecifier<IDependencySearchDescriptor, DependencySearchDescriptor_Leaf> For_DependencySearchDescriptor_Leaf =>
            For_TypeSpecifiers.TypeSpecifier<IDependencySearchDescriptor, DependencySearchDescriptor_Leaf>.Instance;

        public For_TypeSpecifiers.TypeSpecifier<IDependencySearchDescriptor, DependencySearchDescriptor_Name> For_DependencySearchDescriptor_Name =>
            For_TypeSpecifiers.TypeSpecifier<IDependencySearchDescriptor, DependencySearchDescriptor_Name>.Instance;

        public For_TypeSpecifiers.TypeSpecifier<IDependencySearchDescriptor, DependencySearchDescriptor_NuGetPackage> For_DependencySearchDescriptor_NuGetPackage =>
            For_TypeSpecifiers.TypeSpecifier<IDependencySearchDescriptor, DependencySearchDescriptor_NuGetPackage>.Instance;

        public For_TypeSpecifiers.TypeSpecifier<IDependencySearchDescriptor, DependencySearchDescriptor_Project> For_DependencySearchDescriptor_Project =>
            For_TypeSpecifiers.TypeSpecifier<IDependencySearchDescriptor, DependencySearchDescriptor_Project>.Instance;

        #endregion

        #region Dependency Set Search Descriptors

        public For_TypeSpecifiers.TypeSpecifier<IDependencySetSearchDescriptor, DependencySetSearchDescriptor_Constrained> For_DependencySetSearchDescriptor_Constrained =>
            For_TypeSpecifiers.TypeSpecifier<IDependencySetSearchDescriptor, DependencySetSearchDescriptor_Constrained>.Instance;

        public For_TypeSpecifiers.TypeSpecifier<IDependencySetSearchDescriptor, DependencySetSearchDescriptor_DependencySearchDescriptor> For_DependencySetSearchDescriptor_DependencySearchDescriptor =>
            For_TypeSpecifiers.TypeSpecifier<IDependencySetSearchDescriptor, DependencySetSearchDescriptor_DependencySearchDescriptor>.Instance;

        public For_TypeSpecifiers.TypeSpecifier<IDependencySetSearchDescriptor, DependencySetSearchDescriptor_Leaf> For_DependencySetSearchDescriptor_Leaf =>
            For_TypeSpecifiers.TypeSpecifier<IDependencySetSearchDescriptor, DependencySetSearchDescriptor_Leaf>.Instance;

        public For_TypeSpecifiers.TypeSpecifier<IDependencySetSearchDescriptor, DependencySetSearchDescriptor_None> For_DependencySetSearchDescriptor_None =>
            For_TypeSpecifiers.TypeSpecifier<IDependencySetSearchDescriptor, DependencySetSearchDescriptor_None>.Instance;

        public For_TypeSpecifiers.TypeSpecifier<IDependencySetSearchDescriptor, DependencySetSearchDescriptor_Unconstrained> For_DependencySetSearchDescriptor_Unconstrained =>
            For_TypeSpecifiers.TypeSpecifier<IDependencySetSearchDescriptor, DependencySetSearchDescriptor_Unconstrained>.Instance;

        #endregion

        #region Domain Search Descriptors

        public For_TypeSpecifiers.TypeSpecifier<IDomainSearchDescriptor, DomainSearchDescriptor> For_DomainSearchDescriptor =>
            For_TypeSpecifiers.TypeSpecifier<IDomainSearchDescriptor, DomainSearchDescriptor>.Instance;

        public For_TypeSpecifiers.TypeSpecifier<IDomainSearchDescriptor, DomainSearchDescriptor_Set> For_DomainSearchDescriptor_Set =>
            For_TypeSpecifiers.TypeSpecifier<IDomainSearchDescriptor, DomainSearchDescriptor_Set>.Instance;

        #endregion

        #region Implementation Scheme Search Descriptors

        public For_TypeSpecifiers.TypeSpecifier<IImplementationSchemeSearchDescriptor, ImplementationSchemeSearchDescriptor_Enumeration> For_ImplementationSchemeSearchDescriptor_Enumeration =>
            For_TypeSpecifiers.TypeSpecifier<IImplementationSchemeSearchDescriptor, ImplementationSchemeSearchDescriptor_Enumeration>.Instance;

        #endregion

        #region Naming Scheme Search Descriptors

        public For_TypeSpecifiers.TypeSpecifier<INamingSchemeSearchDescriptor, NamingSchemeSearchDescriptor_Enumeration> For_NamingSchemeSearchDescriptor_Enumeration =>
            For_TypeSpecifiers.TypeSpecifier<INamingSchemeSearchDescriptor, NamingSchemeSearchDescriptor_Enumeration>.Instance;

        #endregion

        #region .NET Version Search Descriptors

        public For_TypeSpecifiers.TypeSpecifier<INetVersionSearchDescriptor, NetVersionSearchDescriptor> For_NetVersionSearchDescriptor =>
            For_TypeSpecifiers.TypeSpecifier<INetVersionSearchDescriptor, NetVersionSearchDescriptor>.Instance;

        #endregion

        #region Opinion Search Descriptors

        public For_TypeSpecifiers.TypeSpecifier<IOpinionSearchDescriptor, OpinionSearchDescriptor> For_OpinionSearchDescriptor =>
            For_TypeSpecifiers.TypeSpecifier<IOpinionSearchDescriptor, OpinionSearchDescriptor>.Instance;

        #endregion

        #region Organization Search Descriptor

        public For_TypeSpecifiers.TypeSpecifier<IOrganizationSearchDescriptor, OrganizationSearchDescriptor_Name> For_OrganizationSearchDescriptor =>
            For_TypeSpecifiers.TypeSpecifier<IOrganizationSearchDescriptor, OrganizationSearchDescriptor_Name>.Instance;

        #endregion

        #region Typing Scheme Search Descriptors

        public For_TypeSpecifiers.TypeSpecifier<ITypingSchemeSearchDescriptor, TypingSchemeSearchDescriptor_Enumeration> For_TypingSchemeSearchDescriptor_Enumeration =>
            For_TypeSpecifiers.TypeSpecifier<ITypingSchemeSearchDescriptor, TypingSchemeSearchDescriptor_Enumeration>.Instance;

        #endregion

        #region Visibility Search Descriptors

        public For_TypeSpecifiers.TypeSpecifier<IVisibilitySearchDescriptor, VisibilitySearchDescriptor> For_VisibilitySearchDescriptor =>
           For_TypeSpecifiers.TypeSpecifier<IVisibilitySearchDescriptor, VisibilitySearchDescriptor>.Instance;

        #endregion
    }
}
