using System;

using F10Y.T0003;


namespace F10Y.L0026.L002
{
    [ValuesMarker]
    public partial interface IPredicateProviderSuites
    {
        #region Applicability Search Descriptor

        public For_PredicateProviderSuite.PredicateProviderSuite<IApplicabilitySearchDescriptor, IApplicabilityDescriptor> For_ApplicabilitySearchDescriptor => new()
        {
            Type = Instances.TypeOperator.Get_Type<ApplicabilitySearchDescriptor>(),
            Get_PredicateProvider_Synchronous = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.ApplicabilitySearchDescriptorOperator.Get_PredicateFor,
                Instances.TypeSpecifiers.For_ApplicabilitySearchDescriptor),
            //Predicate_Asynchronous = ,
        };

        #endregion

        #region Dependency Search Descriptor

        public For_PredicateProviderSuite.PredicateProviderSuite<IDependencySearchDescriptor, IDependencyDescriptor> For_DependencySearchDescriptor_Constrained => new()
        {
            Type = Instances.TypeOperator.Get_Type<DependencySearchDescriptor_Constrained>(),
            Get_PredicateProvider_Synchronous = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DependencySearchDescriptorOperator.Get_PredicateFor,
                Instances.TypeSpecifiers.For_DependencySearchDescriptor_Constrained),
            //Predicate_Asynchronous = ,
        };

        public For_PredicateProviderSuite.PredicateProviderSuite<IDependencySearchDescriptor, IDependencyDescriptor> For_DependencySearchDescriptor_Leaf => new()
        {
            Type = Instances.TypeOperator.Get_Type<DependencySearchDescriptor_Leaf>(),
            Get_PredicateProvider_Synchronous = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DependencySearchDescriptorOperator.Get_PredicateFor,
                Instances.TypeSpecifiers.For_DependencySearchDescriptor_Leaf),
            //Predicate_Asynchronous = ,
        };

        public For_PredicateProviderSuite.PredicateProviderSuite<IDependencySearchDescriptor, IDependencyDescriptor> For_DependencySearchDescriptor_Name => new()
        {
            Type = Instances.TypeOperator.Get_Type<DependencySearchDescriptor_Name>(),
            Get_PredicateProvider_Synchronous = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DependencySearchDescriptorOperator.Get_PredicateFor,
                Instances.TypeSpecifiers.For_DependencySearchDescriptor_Name),
            //Predicate_Asynchronous = ,
        };

        public For_PredicateProviderSuite.PredicateProviderSuite<IDependencySearchDescriptor, IDependencyDescriptor> For_DependencySearchDescriptor_NuGetPackage => new()
        {
            Type = Instances.TypeOperator.Get_Type<DependencySearchDescriptor_NuGetPackage>(),
            Get_PredicateProvider_Synchronous = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DependencySearchDescriptorOperator.Get_PredicateFor,
                Instances.TypeSpecifiers.For_DependencySearchDescriptor_NuGetPackage),
            //Predicate_Asynchronous = ,
        };

        public For_PredicateProviderSuite.PredicateProviderSuite<IDependencySearchDescriptor, IDependencyDescriptor> For_DependencySearchDescriptor_Project => new()
        {
            Type = Instances.TypeOperator.Get_Type<DependencySearchDescriptor_Project>(),
            Get_PredicateProvider_Synchronous = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DependencySearchDescriptorOperator.Get_PredicateFor,
                Instances.TypeSpecifiers.For_DependencySearchDescriptor_Project),
            //Predicate_Asynchronous = ,
        };

        #endregion

        #region Dependency Set Search Descriptor

        public For_PredicateProviderSuite.PredicateProviderSuite<IDependencySetSearchDescriptor, IDependencySetDescriptor> For_DependencySetSearchDescriptor_Constrained => new()
        {
            Type = Instances.TypeOperator.Get_Type<DependencySetSearchDescriptor_Constrained>(),
            Get_PredicateProvider_Synchronous = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DependencySetSearchDescriptorOperator.Get_PredicateFor,
                Instances.TypeSpecifiers.For_DependencySetSearchDescriptor_Constrained),
            //Predicate_Asynchronous = ,
        };

        public For_PredicateProviderSuite.PredicateProviderSuite<IDependencySetSearchDescriptor, IDependencySetDescriptor> For_DependencySetSearchDescriptor_DependencySearchDescriptor => new()
        {
            Type = Instances.TypeOperator.Get_Type<DependencySetSearchDescriptor_DependencySearchDescriptor>(),
            Get_PredicateProvider_Synchronous = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DependencySetSearchDescriptorOperator.Get_PredicateFor,
                Instances.TypeSpecifiers.For_DependencySetSearchDescriptor_DependencySearchDescriptor),
            //Predicate_Asynchronous = ,
        };

        public For_PredicateProviderSuite.PredicateProviderSuite<IDependencySetSearchDescriptor, IDependencySetDescriptor> For_DependencySetSearchDescriptor_Leaf => new()
        {
            Type = Instances.TypeOperator.Get_Type<DependencySetSearchDescriptor_Leaf>(),
            Get_PredicateProvider_Synchronous = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DependencySetSearchDescriptorOperator.Get_PredicateFor,
                Instances.TypeSpecifiers.For_DependencySetSearchDescriptor_Leaf),
            //Predicate_Asynchronous = ,
        };

        public For_PredicateProviderSuite.PredicateProviderSuite<IDependencySetSearchDescriptor, IDependencySetDescriptor> For_DependencySetSearchDescriptor_None => new()
        {
            Type = Instances.TypeOperator.Get_Type<DependencySetSearchDescriptor_None>(),
            Get_PredicateProvider_Synchronous = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DependencySetSearchDescriptorOperator.Get_PredicateFor,
                Instances.TypeSpecifiers.For_DependencySetSearchDescriptor_None),
            //Predicate_Asynchronous = ,
        };

        public For_PredicateProviderSuite.PredicateProviderSuite<IDependencySetSearchDescriptor, IDependencySetDescriptor> For_DependencySetSearchDescriptor_Unconstrained => new()
        {
            Type = Instances.TypeOperator.Get_Type<DependencySetSearchDescriptor_Unconstrained>(),
            Get_PredicateProvider_Synchronous = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DependencySetSearchDescriptorOperator.Get_PredicateFor,
                Instances.TypeSpecifiers.For_DependencySetSearchDescriptor_Unconstrained),
            //Predicate_Asynchronous = ,
        };

        #endregion

        #region Domain Search Descriptor

        public For_PredicateProviderSuite.PredicateProviderSuite<IDomainSearchDescriptor, IDomainDescriptor> For_DomainSearchDescriptor => new()
        {
            Type = Instances.TypeOperator.Get_Type<DomainSearchDescriptor>(),
            Get_PredicateProvider_Synchronous = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DomainSearchDescriptorOperator.Get_PredicateFor,
                Instances.TypeSpecifiers.For_DomainSearchDescriptor),
            //Predicate_Asynchronous = ,
        };

        public For_PredicateProviderSuite.PredicateProviderSuite<IDomainSearchDescriptor, IDomainDescriptor> For_DomainSearchDescriptor_Set => new()
        {
            Type = Instances.TypeOperator.Get_Type<DomainSearchDescriptor_Set>(),
            Get_PredicateProvider_Synchronous = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DomainSearchDescriptorOperator.Get_PredicateFor,
                Instances.TypeSpecifiers.For_DomainSearchDescriptor_Set),
            //Predicate_Asynchronous = ,
        };

        #endregion

        #region Implementation Scheme Search Descriptor

        public For_PredicateProviderSuite.PredicateProviderSuite<IImplementationSchemeSearchDescriptor, IImplementationSchemeDescriptor> For_ImplementationSchemeSearchDescriptor_Enumeration => new()
        {
            Type = Instances.TypeOperator.Get_Type<ImplementationSchemeSearchDescriptor_Enumeration>(),
            Get_PredicateProvider_Synchronous = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.ImplementationSchemeSearchDescriptorOperator.Get_PredicateFor,
                Instances.TypeSpecifiers.For_ImplementationSchemeSearchDescriptor_Enumeration),
            //Predicate_Asynchronous = ,
        };

        #endregion

        #region Naming Scheme Search Descriptor

        public For_PredicateProviderSuite.PredicateProviderSuite<INamingSchemeSearchDescriptor, INamingSchemeDescriptor> For_NamingSchemeSearchDescriptor_Enumeration => new()
        {
            Type = Instances.TypeOperator.Get_Type<NamingSchemeSearchDescriptor_Enumeration>(),
            Get_PredicateProvider_Synchronous = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.NamingSchemeSearchDescriptorOperator.Get_PredicateFor,
                Instances.TypeSpecifiers.For_NamingSchemeSearchDescriptor_Enumeration),
            //Predicate_Asynchronous = ,
        };

        #endregion

        #region .NET Version Search Descriptor

        public For_PredicateProviderSuite.PredicateProviderSuite<INetVersionSearchDescriptor, INetVersionDescriptor> For_NetVersionSearchDescriptor => new()
        {
            Type = Instances.TypeOperator.Get_Type<NetVersionSearchDescriptor>(),
            Get_PredicateProvider_Synchronous = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.NetVersionSearchDescriptorOperator.Get_PredicateFor,
                Instances.TypeSpecifiers.For_NetVersionSearchDescriptor),
            //Predicate_Asynchronous = ,
        };

        #endregion

        #region Opinion Search Descriptor

        public For_PredicateProviderSuite.PredicateProviderSuite<IOpinionSearchDescriptor, IOpinionDescriptor> For_OpinionSearchDescriptor => new()
        {
            Type = Instances.TypeOperator.Get_Type<OpinionSearchDescriptor>(),
            Get_PredicateProvider_Synchronous = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.OpinionSearchDescriptorOperator.Get_PredicateFor,
                Instances.TypeSpecifiers.For_OpinionSearchDescriptor),
            //Predicate_Asynchronous = ,
        };

        #endregion

        #region Organization Search Descriptor

        public For_PredicateProviderSuite.PredicateProviderSuite<IOrganizationSearchDescriptor, IOrganizationDescriptor> For_OrganizationSearchDescriptor_Name => new()
        {
            Type = Instances.TypeOperator.Get_Type<OrganizationSearchDescriptor_Name>(),
            Get_PredicateProvider_Synchronous = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.OrganizationSearchDescriptorOperator.Get_PredicateFor,
                Instances.TypeSpecifiers.For_OrganizationSearchDescriptor),
            //Predicate_Asynchronous = ,
        };

        #endregion

        #region Typing Scheme Search Descriptor

        public For_PredicateProviderSuite.PredicateProviderSuite<ITypingSchemeSearchDescriptor, ITypingSchemeDescriptor> For_TypingSchemeSearchDescriptor_Enumeration => new()
        {
            Type = Instances.TypeOperator.Get_Type<TypingSchemeSearchDescriptor_Enumeration>(),
            Get_PredicateProvider_Synchronous = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.TypingSchemeSearchDescriptorOperator.Get_PredicateFor,
                Instances.TypeSpecifiers.For_TypingSchemeSearchDescriptor_Enumeration),
            //Predicate_Asynchronous = ,
        };

        #endregion

        #region Visibility Search Descriptor

        public For_PredicateProviderSuite.PredicateProviderSuite<IVisibilitySearchDescriptor, IVisibilityDescriptor> For_VisibilitySearchDescriptor => new()
        {
            Type = Instances.TypeOperator.Get_Type<VisibilitySearchDescriptor>(),
            Get_PredicateProvider_Synchronous = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.VisibilitySearchDescriptorOperator.Get_PredicateFor,
                Instances.TypeSpecifiers.For_VisibilitySearchDescriptor),
            //Predicate_Asynchronous = ,
        };

        #endregion
    }
}
