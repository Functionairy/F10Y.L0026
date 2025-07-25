using System;

using F10Y.T0003;


namespace F10Y.L0026.L002
{
    [ValuesMarker]
    public partial interface IDescriptorTextOperationHandlerSuites
    {
        #region Applicability Search Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IApplicabilitySearchDescriptor> For_ApplicabilitySearchDescriptor => new()
        {
            Type = Instances.TypeOperator.Get_Type<ApplicabilitySearchDescriptor>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.ApplicabilitySearchDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_ApplicabilitySearchDescriptor),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.ApplicabilitySearchDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_ApplicabilitySearchDescriptor),
            From_JsonElement = Instances.JsonElementOperator.Deserialize<ApplicabilitySearchDescriptor>,
            To_JsonElement = Instances.JsonElementOperator.Serialize
        };

        #endregion

        #region Dependency Search Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDependencySearchDescriptor> For_DependencySearchDescriptor_Constrained => new()
        {
            Type = Instances.TypeOperator.Get_Type<DependencySearchDescriptor_Constrained>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DependencySearchDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_DependencySearchDescriptor_Constrained),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DependencySearchDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_DependencySearchDescriptor_Constrained),
            From_JsonElement = Instances.JsonElementOperator.Deserialize<DependencySearchDescriptor_Constrained>,
            To_JsonElement = Instances.JsonElementOperator.Serialize
        };

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDependencySearchDescriptor> For_DependencySearchDescriptor_Leaf => new()
        {
            Type = Instances.TypeOperator.Get_Type<DependencySearchDescriptor_Leaf>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DependencySearchDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_DependencySearchDescriptor_Leaf),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DependencySearchDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_DependencySearchDescriptor_Leaf),
            From_JsonElement = Instances.JsonElementOperator.Deserialize<DependencySearchDescriptor_Leaf>,
            To_JsonElement = Instances.JsonElementOperator.Serialize
        };

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDependencySearchDescriptor> For_DependencySearchDescriptor_Name => new()
        {
            Type = Instances.TypeOperator.Get_Type<DependencySearchDescriptor_Name>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DependencySearchDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_DependencySearchDescriptor_Name),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DependencySearchDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_DependencySearchDescriptor_Name),
            From_JsonElement = Instances.JsonElementOperator.Deserialize<DependencySearchDescriptor_Name>,
            To_JsonElement = Instances.JsonElementOperator.Serialize
        };

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDependencySearchDescriptor> For_DependencySearchDescriptor_NuGetPackage => new()
        {
            Type = Instances.TypeOperator.Get_Type<DependencySearchDescriptor_NuGetPackage>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DependencySearchDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_DependencySearchDescriptor_NuGetPackage),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DependencySearchDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_DependencySearchDescriptor_NuGetPackage),
            From_JsonElement = Instances.JsonElementOperator.Deserialize<DependencySearchDescriptor_NuGetPackage>,
            To_JsonElement = Instances.JsonElementOperator.Serialize
        };

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDependencySearchDescriptor> For_DependencySearchDescriptor_Project => new()
        {
            Type = Instances.TypeOperator.Get_Type<DependencySearchDescriptor_Project>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DependencySearchDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_DependencySearchDescriptor_Project),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DependencySearchDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_DependencySearchDescriptor_Project),
            From_JsonElement = Instances.JsonElementOperator.Deserialize<DependencySearchDescriptor_Project>,
            To_JsonElement = Instances.JsonElementOperator.Serialize
        };

        #endregion

        #region Dependency Set Search Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDependencySetSearchDescriptor> For_DependencySetSearchDescriptor_Constrained => new()
        {
            Type = Instances.TypeOperator.Get_Type<DependencySetSearchDescriptor_Constrained>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DependencySetSearchDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_DependencySetSearchDescriptor_Constrained),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DependencySetSearchDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_DependencySetSearchDescriptor_Constrained),
            From_JsonElement = Instances.JsonElementOperator.Deserialize<DependencySetSearchDescriptor_Constrained>,
            To_JsonElement = Instances.JsonElementOperator.Serialize
        };

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDependencySetSearchDescriptor> For_DependencySetSearchDescriptor_DependencySearchDescriptor => new()
        {
            Type = Instances.TypeOperator.Get_Type<DependencySetSearchDescriptor_DependencySearchDescriptor>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DependencySetSearchDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_DependencySetSearchDescriptor_DependencySearchDescriptor),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DependencySetSearchDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_DependencySetSearchDescriptor_DependencySearchDescriptor),
            From_JsonElement = Instances.JsonElementOperator.Get_Deserialize<DependencySetSearchDescriptor_DependencySearchDescriptor, Serialization_DependencySetSearchDescriptor_DependencySearchDescriptor>(
                Instances.DependencySetSearchDescriptorOperator.From_SerializationType),
            To_JsonElement = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.JsonElementOperator.Get_Serialize<DependencySetSearchDescriptor_DependencySearchDescriptor, Serialization_DependencySetSearchDescriptor_DependencySearchDescriptor>(
                    Instances.DependencySetSearchDescriptorOperator.To_SerializationType),
                Instances.TypeSpecifiers.For_DependencySetSearchDescriptor_DependencySearchDescriptor
            )
        };

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDependencySetSearchDescriptor> For_DependencySetSearchDescriptor_Leaf => new()
        {
            Type = Instances.TypeOperator.Get_Type<DependencySetSearchDescriptor_Leaf>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DependencySetSearchDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_DependencySetSearchDescriptor_Leaf),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DependencySetSearchDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_DependencySetSearchDescriptor_Leaf),
            From_JsonElement = Instances.JsonElementOperator.Deserialize<DependencySetSearchDescriptor_Leaf>,
            To_JsonElement = Instances.JsonElementOperator.Serialize
        };

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDependencySetSearchDescriptor> For_DependencySetSearchDescriptor_None => new()
        {
            Type = Instances.TypeOperator.Get_Type<DependencySetSearchDescriptor_None>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DependencySetSearchDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_DependencySetSearchDescriptor_None),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DependencySetSearchDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_DependencySetSearchDescriptor_None),
            From_JsonElement = Instances.JsonElementOperator.Deserialize<DependencySetSearchDescriptor_None>,
            To_JsonElement = Instances.JsonElementOperator.Serialize
        };

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDependencySetSearchDescriptor> For_DependencySetSearchDescriptor_Unconstrained => new()
        {
            Type = Instances.TypeOperator.Get_Type<DependencySetSearchDescriptor_Unconstrained>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DependencySetSearchDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_DependencySetSearchDescriptor_Unconstrained),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DependencySetSearchDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_DependencySetSearchDescriptor_Unconstrained),
            From_JsonElement = Instances.JsonElementOperator.Deserialize<DependencySetSearchDescriptor_Unconstrained>,
            To_JsonElement = Instances.JsonElementOperator.Serialize
        };

        #endregion

        #region Domain Search Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDomainSearchDescriptor> For_DomainSearchDescriptor => new()
        {
            Type = Instances.TypeOperator.Get_Type<DomainSearchDescriptor>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DomainSearchDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_DomainSearchDescriptor),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DomainSearchDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_DomainSearchDescriptor),
            From_JsonElement = Instances.JsonElementOperator.Deserialize<DomainSearchDescriptor>,
            To_JsonElement = Instances.JsonElementOperator.Serialize
        };

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDomainSearchDescriptor> For_DomainSearchDescriptor_Set => new()
        {
            Type = Instances.TypeOperator.Get_Type<DomainSearchDescriptor_Set>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DomainSearchDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_DomainSearchDescriptor_Set),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DomainSearchDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_DomainSearchDescriptor_Set),
            From_JsonElement = Instances.JsonElementOperator.Get_Deserialize<DomainSearchDescriptor_Set, Serialization_DomainSearchDescriptor_Set>(
                Instances.DomainSearchDescriptorOperator.From_SerializationType),
            To_JsonElement = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.JsonElementOperator.Get_Serialize<DomainSearchDescriptor_Set, Serialization_DomainSearchDescriptor_Set>(
                    Instances.DomainSearchDescriptorOperator.To_SerializationType),
                Instances.TypeSpecifiers.For_DomainSearchDescriptor_Set)
        };

        #endregion

        #region Implementation Scheme Search Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IImplementationSchemeSearchDescriptor> For_ImplementationSchemeSearchDescriptor_Enumeration => new()
        {
            Type = Instances.TypeOperator.Get_Type<ImplementationSchemeSearchDescriptor_Enumeration>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.ImplementationSchemeSearchDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_ImplementationSchemeSearchDescriptor_Enumeration),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.ImplementationSchemeSearchDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_ImplementationSchemeSearchDescriptor_Enumeration),
            From_JsonElement = Instances.JsonElementOperator.Get_Deserialize<ImplementationSchemeSearchDescriptor_Enumeration, Serialization_ImplementationSchemeSearchDescriptor_Enumeration>(
                Instances.ImplementationSchemeSearchDescriptorOperator.From_SerializationType),
            To_JsonElement = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.JsonElementOperator.Get_Serialize<ImplementationSchemeSearchDescriptor_Enumeration, Serialization_ImplementationSchemeSearchDescriptor_Enumeration>(
                    Instances.ImplementationSchemeSearchDescriptorOperator.To_SerializationType),
                Instances.TypeSpecifiers.For_ImplementationSchemeSearchDescriptor_Enumeration)
        };

        #endregion

        #region Naming Scheme Search Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<INamingSchemeSearchDescriptor> For_NamingSchemeSearchDescriptor_Enumeration => new()
        {
            Type = Instances.TypeOperator.Get_Type<NamingSchemeSearchDescriptor_Enumeration>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.NamingSchemeSearchDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_NamingSchemeSearchDescriptor_Enumeration),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.NamingSchemeSearchDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_NamingSchemeSearchDescriptor_Enumeration),
            From_JsonElement = Instances.JsonElementOperator.Get_Deserialize<NamingSchemeSearchDescriptor_Enumeration, Serialization_NamingSchemeSearchDescriptor_Enumeration>(
                Instances.NamingSchemeSearchDescriptorOperator.From_SerializationType),
            To_JsonElement = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.JsonElementOperator.Get_Serialize<NamingSchemeSearchDescriptor_Enumeration, Serialization_NamingSchemeSearchDescriptor_Enumeration>(
                    Instances.NamingSchemeSearchDescriptorOperator.To_SerializationType),
                Instances.TypeSpecifiers.For_NamingSchemeSearchDescriptor_Enumeration)
        };

        #endregion

        #region .NET Version Search Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<INetVersionSearchDescriptor> For_NetVersionSearchDescriptor => new()
        {
            Type = Instances.TypeOperator.Get_Type<NetVersionSearchDescriptor>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.NetVersionSearchDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_NetVersionSearchDescriptor),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.NetVersionSearchDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_NetVersionSearchDescriptor),
            From_JsonElement = Instances.JsonElementOperator.Deserialize<NetVersionSearchDescriptor>,
            To_JsonElement = Instances.JsonElementOperator.Serialize
        };

        #endregion

        #region Opinion Search Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IOpinionSearchDescriptor> For_OpinionSearchDescriptor => new()
        {
            Type = Instances.TypeOperator.Get_Type<OpinionSearchDescriptor>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.OpinionSearchDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_OpinionSearchDescriptor),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.OpinionSearchDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_OpinionSearchDescriptor),
            From_JsonElement = Instances.JsonElementOperator.Deserialize<OpinionSearchDescriptor>,
            To_JsonElement = Instances.JsonElementOperator.Serialize
        };

        #endregion

        #region Organization Search Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IOrganizationSearchDescriptor> For_OrganizationSerachDescriptor_Name => new()
        {
            Type = Instances.TypeOperator.Get_Type<OrganizationSearchDescriptor_Name>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.OrganizationSearchDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_OrganizationSearchDescriptor),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.OrganizationSearchDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_OrganizationSearchDescriptor),
            From_JsonElement = Instances.JsonElementOperator.Get_Deserialize<OrganizationSearchDescriptor_Name, Serialization_OrganizationSearchDescriptor_Name>(
                Instances.OrganizationSearchDescriptorOperator.From_SerializationType),
            To_JsonElement = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.JsonElementOperator.Get_Serialize<OrganizationSearchDescriptor_Name, Serialization_OrganizationSearchDescriptor_Name>(
                    Instances.OrganizationSearchDescriptorOperator.To_SerializationType),
                Instances.TypeSpecifiers.For_OrganizationSearchDescriptor)
        };

        #endregion

        #region Typing Scheme Search Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<ITypingSchemeSearchDescriptor> For_TypingSchemeSearchDescriptor_Enumeration => new()
        {
            Type = Instances.TypeOperator.Get_Type<TypingSchemeSearchDescriptor_Enumeration>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.TypingSchemeSearchDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_TypingSchemeSearchDescriptor_Enumeration),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.TypingSchemeSearchDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_TypingSchemeSearchDescriptor_Enumeration),
            From_JsonElement = Instances.JsonElementOperator.Get_Deserialize<TypingSchemeSearchDescriptor_Enumeration, Serialization_TypingSchemeSearchDescriptor_Enumeration>(
                Instances.TypingSchemeSearchDescriptorOperator.From_SerializationType),
            To_JsonElement = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.JsonElementOperator.Get_Serialize<TypingSchemeSearchDescriptor_Enumeration, Serialization_TypingSchemeSearchDescriptor_Enumeration>(
                    Instances.TypingSchemeSearchDescriptorOperator.To_SerializationType),
                Instances.TypeSpecifiers.For_TypingSchemeSearchDescriptor_Enumeration)
        };

        #endregion

        #region Visibility Search Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IVisibilitySearchDescriptor> For_VisibilitySearchDescriptor => new()
        {
            Type = Instances.TypeOperator.Get_Type<VisibilitySearchDescriptor>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.VisibilitySearchDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_VisibilitySearchDescriptor),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.VisibilitySearchDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_VisibilitySearchDescriptor),
            From_JsonElement = Instances.JsonElementOperator.Get_Deserialize<VisibilitySearchDescriptor, Serialization_VisibilitySearchDescriptor>(
                Instances.VisibilitySearchDescriptorOperator.From_SerializationType),
            To_JsonElement = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.JsonElementOperator.Get_Serialize<VisibilitySearchDescriptor, Serialization_VisibilitySearchDescriptor>(
                    Instances.VisibilitySearchDescriptorOperator.To_SerializationType),
                Instances.TypeSpecifiers.For_VisibilitySearchDescriptor)
        };

        #endregion
    }
}
