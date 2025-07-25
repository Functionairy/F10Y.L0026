using System;

using F10Y.T0003;


namespace F10Y.L0026.L001
{
    [ValuesMarker]
    public partial interface IDescriptorTextOperationHandlerSuites
    {
        #region Applicability Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IApplicabilityDescriptor> For_ApplicabilityDescriptor => new()
        {
            Type = Instances.TypeOperator.Get_Type<ApplicabilityDescriptor>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.ApplicabilityDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_ApplicabilityDescriptor),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.ApplicabilityDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_ApplicabilityDescriptor),
            From_JsonElement = Instances.JsonElementOperator.Deserialize<ApplicabilityDescriptor>,
            To_JsonElement = Instances.JsonElementOperator.Serialize
        };

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IApplicabilityDescriptor> For_ApplicabilityDescriptor_Machine => new()
        {
            Type = Instances.TypeOperator.Get_Type<ApplicabilityDescriptor_Machine>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.ApplicabilityDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_ApplicabilityDescriptor_Machine),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.ApplicabilityDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_ApplicabilityDescriptor_Machine),
            From_JsonElement = Instances.JsonElementOperator.Deserialize<ApplicabilityDescriptor_Machine>,
            To_JsonElement = Instances.JsonElementOperator.Serialize
        };

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IApplicabilityDescriptor> For_ApplicabilityDescriptor_Organization => new()
        {
            Type = Instances.TypeOperator.Get_Type<ApplicabilityDescriptor_Organization>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.ApplicabilityDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_ApplicabilityDescriptor_Organization),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.ApplicabilityDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_ApplicabilityDescriptor_Organization),
            From_JsonElement = Instances.JsonElementOperator.Deserialize<ApplicabilityDescriptor_Organization>,
            To_JsonElement = Instances.JsonElementOperator.Serialize
        };

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IApplicabilityDescriptor> For_ApplicabilityDescriptor_Personal => new()
        {
            Type = Instances.TypeOperator.Get_Type<ApplicabilityDescriptor_Personal>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.ApplicabilityDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_ApplicabilityDescriptor_Personal),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.ApplicabilityDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_ApplicabilityDescriptor_Personal),
            From_JsonElement = Instances.JsonElementOperator.Deserialize<ApplicabilityDescriptor_Personal>,
            To_JsonElement = Instances.JsonElementOperator.Serialize
        };

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IApplicabilityDescriptor> For_ApplicabilityDescriptor_Project => new()
        {
            Type = Instances.TypeOperator.Get_Type<ApplicabilityDescriptor_Project>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.ApplicabilityDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_ApplicabilityDescriptor_Project),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.ApplicabilityDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_ApplicabilityDescriptor_Project),
            From_JsonElement = Instances.JsonElementOperator.Deserialize<ApplicabilityDescriptor_Project>,
            To_JsonElement = Instances.JsonElementOperator.Serialize
        };

        #endregion

        #region Dependency Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDependencyDescriptor> For_DependencyDescriptor_Constrained => new()
        {
            Type = Instances.TypeOperator.Get_Type<DependencyDescriptor_Constrained>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DependencyDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_DependencyDescriptor_Constrained),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DependencyDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_DependencyDescriptor_Constrained),
            From_JsonElement = Instances.JsonElementOperator.Deserialize<DependencyDescriptor_Constrained>,
            To_JsonElement = Instances.JsonElementOperator.Serialize
        };

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDependencyDescriptor> For_DependencyDescriptor_Leaf => new()
        {
            Type = Instances.TypeOperator.Get_Type<DependencyDescriptor_Leaf>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DependencyDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_DependencyDescriptor_Leaf),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DependencyDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_DependencyDescriptor_Leaf),
            From_JsonElement = Instances.JsonElementOperator.Deserialize<DependencyDescriptor_Leaf>,
            To_JsonElement = Instances.JsonElementOperator.Serialize
        };

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDependencyDescriptor> For_DependencyDescriptor_Name => new()
        {
            Type = Instances.TypeOperator.Get_Type<DependencyDescriptor_Name>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DependencyDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_DependencyDescriptor_Name),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DependencyDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_DependencyDescriptor_Name),
            From_JsonElement = Instances.JsonElementOperator.Deserialize<DependencyDescriptor_Name>,
            To_JsonElement = Instances.JsonElementOperator.Serialize
        };

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDependencyDescriptor> For_DependencyDescriptor_NugetPackage => new()
        {
            Type = Instances.TypeOperator.Get_Type<DependencyDescriptor_NuGetPackage>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DependencyDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_DependencyDescriptor_NugetPackage),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DependencyDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_DependencyDescriptor_NugetPackage),
            From_JsonElement = Instances.JsonElementOperator.Deserialize<DependencyDescriptor_NuGetPackage>,
            To_JsonElement = Instances.JsonElementOperator.Serialize
        };

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDependencyDescriptor> For_DependencyDescriptor_Project => new()
        {
            Type = Instances.TypeOperator.Get_Type<DependencyDescriptor_Project>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DependencyDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_DependencyDescriptor_Project),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DependencyDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_DependencyDescriptor_Project),
            From_JsonElement = Instances.JsonElementOperator.Deserialize<DependencyDescriptor_Project>,
            To_JsonElement = Instances.JsonElementOperator.Serialize
        };

        #endregion

        #region Dependency Set Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDependencySetDescriptor> For_DependencySetDescriptor => new()
        {
            Type = Instances.TypeOperator.Get_Type<DependencySetDescriptor>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DependencySetDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_DependencySetDescriptor),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DependencySetDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_DependencySetDescriptor),
            From_JsonElement = Instances.JsonElementOperator.Get_Deserialize<DependencySetDescriptor, Serialization_DependencySetDescriptor>(
                Instances.DependencySetDescriptorOperator.From_SerializationType),
            To_JsonElement = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.JsonElementOperator.Get_Serialize<DependencySetDescriptor, Serialization_DependencySetDescriptor>(
                    Instances.DependencySetDescriptorOperator.To_SerializationType),
                Instances.TypeSpecifiers.For_DependencySetDescriptor
            )
        };

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDependencySetDescriptor> For_DependencySetDescriptor_Constrained => new()
        {
            Type = Instances.TypeOperator.Get_Type<DependencySetDescriptor_Constrained>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DependencySetDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_DependencySetDescriptor_Constrained),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DependencySetDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_DependencySetDescriptor_Constrained),
            From_JsonElement = Instances.JsonElementOperator.Deserialize<DependencySetDescriptor_Constrained>,
            To_JsonElement = Instances.JsonElementOperator.Serialize
        };

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDependencySetDescriptor> For_DependencySetDescriptor_Leaf => new()
        {
            Type = Instances.TypeOperator.Get_Type<DependencySetDescriptor_Leaf>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DependencySetDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_DependencySetDescriptor_Leaf),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DependencySetDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_DependencySetDescriptor_Leaf),
            From_JsonElement = Instances.JsonElementOperator.Deserialize<DependencySetDescriptor_Leaf>,
            To_JsonElement = Instances.JsonElementOperator.Serialize
        };

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDependencySetDescriptor> For_DependencySetDescriptor_None => new()
        {
            Type = Instances.TypeOperator.Get_Type<DependencySetDescriptor_None>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DependencySetDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_DependencySetDescriptor_None),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DependencySetDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_DependencySetDescriptor_None),
            From_JsonElement = Instances.JsonElementOperator.Deserialize<DependencySetDescriptor_None>,
            To_JsonElement = Instances.JsonElementOperator.Serialize
        };

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDependencySetDescriptor> For_DependencySetDescriptor_Unconstrained => new()
        {
            Type = Instances.TypeOperator.Get_Type<DependencySetDescriptor_Unconstrained>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DependencySetDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_DependencySetDescriptor_Unconstrained),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DependencySetDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_DependencySetDescriptor_Unconstrained),
            From_JsonElement = Instances.JsonElementOperator.Deserialize<DependencySetDescriptor_Unconstrained>,
            To_JsonElement = Instances.JsonElementOperator.Serialize
        };

        #endregion

        #region Domain Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDomainDescriptor> For_DomainDescriptor => new()
        {
            Type = Instances.TypeOperator.Get_Type<DomainDescriptor>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DomainDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_DomainDescriptor),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DomainDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_DomainDescriptor),
            From_JsonElement = Instances.JsonElementOperator.Deserialize<DomainDescriptor>,
            To_JsonElement = Instances.JsonElementOperator.Serialize
        };

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDomainDescriptor> For_DomainDescriptor_Set => new()
        {
            Type = Instances.TypeOperator.Get_Type<DomainDescriptor_Set>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DomainDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_DomainDescriptor_Set),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DomainDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_DomainDescriptor_Set),
            From_JsonElement = Instances.JsonElementOperator.Deserialize<DomainDescriptor_Set>,
            To_JsonElement = Instances.JsonElementOperator.Serialize
        };

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDomainDescriptor> For_DomainDescriptor_Set_Ordered => new()
        {
            Type = Instances.TypeOperator.Get_Type<DomainDescriptor_Set_Ordered>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DomainDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_DomainDescriptor_Set_Ordered),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DomainDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_DomainDescriptor_Set_Ordered),
            From_JsonElement = Instances.JsonElementOperator.Deserialize<DomainDescriptor_Set_Ordered>,
            To_JsonElement = Instances.JsonElementOperator.Serialize
        };

        #endregion

        #region Implementation Scheme Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IImplementationSchemeDescriptor> For_ImplementationSchemeDescriptor_Enumeration => new()
        {
            Type = Instances.TypeOperator.Get_Type<ImplementationSchemeDescriptor_Enumeration>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.ImplementationSchemeDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_ImplementationSchemeDescriptor_Enumeration),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.ImplementationSchemeDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_ImplementationSchemeDescriptor_Enumeration),
            From_JsonElement = Instances.JsonElementOperator.Get_Deserialize<ImplementationSchemeDescriptor_Enumeration, Serialization_ImplementationSchemeDescriptor_Enumeration>(
                Instances.ImplementationSchemeDescriptorOperator.From_SerializationType),
            To_JsonElement = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.JsonElementOperator.Get_Serialize<ImplementationSchemeDescriptor_Enumeration, Serialization_ImplementationSchemeDescriptor_Enumeration>(
                    Instances.ImplementationSchemeDescriptorOperator.To_SerializationType),
                Instances.TypeSpecifiers.For_ImplementationSchemeDescriptor_Enumeration)
        };

        #endregion

        #region Location Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<ILocationDescriptor> For_LocationDescriptor_Aggregate => new()
        {
            Type = Instances.TypeOperator.Get_Type<LocationDescriptor_Aggregate>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.LocationDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_LocationDescriptor_Aggregate),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.LocationDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_LocationDescriptor_Aggregate),
            From_JsonElement = Instances.JsonElementOperator.Get_Deserialize<LocationDescriptor_Aggregate, Serialization_LocationDescriptor_Aggregate>(
                Instances.LocationDescriptorOperator.From_SerializationType),
            To_JsonElement = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.JsonElementOperator.Get_Serialize<LocationDescriptor_Aggregate, Serialization_LocationDescriptor_Aggregate>(
                    Instances.LocationDescriptorOperator.To_SerializationType),
                Instances.TypeSpecifiers.For_LocationDescriptor_Aggregate
            )
        };

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<ILocationDescriptor> For_LocationDescriptor_GitHubRepository => new()
        {
            Type = Instances.TypeOperator.Get_Type<LocationDescriptor_GitHubRepository>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.LocationDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_LocationDescriptor_GitHubRepository),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.LocationDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_LocationDescriptor_GitHubRepository),
            From_JsonElement = Instances.JsonElementOperator.Deserialize<LocationDescriptor_GitHubRepository>,
            To_JsonElement = Instances.JsonElementOperator.Serialize
        };

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<ILocationDescriptor> For_LocationDescriptor_ProjectFile => new()
        {
            Type = Instances.TypeOperator.Get_Type<LocationDescriptor_ProjectFile>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.LocationDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_LocationDescriptor_ProjectFile),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.LocationDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_LocationDescriptor_ProjectFile),
            From_JsonElement = Instances.JsonElementOperator.Deserialize<LocationDescriptor_ProjectFile>,
            To_JsonElement = Instances.JsonElementOperator.Serialize
        };

        #endregion

        #region Naming Scheme Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<INamingSchemeDescriptor> For_NamingSchemeDescriptor_Enumeration => new()
        {
            Type = Instances.TypeOperator.Get_Type<NamingSchemeDescriptor_Enumeration>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.NamingSchemeDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_NamingSchemeDescriptor_Enumeration),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.NamingSchemeDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_NamingSchemeDescriptor_Enumeration),
            From_JsonElement = Instances.JsonElementOperator.Get_Deserialize<NamingSchemeDescriptor_Enumeration, Serialization_NamingSchemeDescriptor_Enumeration>(
                Instances.NamingSchemeDescriptorOperator.From_SerializationType),
            To_JsonElement = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.JsonElementOperator.Get_Serialize<NamingSchemeDescriptor_Enumeration, Serialization_NamingSchemeDescriptor_Enumeration>(
                    Instances.NamingSchemeDescriptorOperator.To_SerializationType),
                Instances.TypeSpecifiers.For_NamingSchemeDescriptor_Enumeration)
        };

        #endregion

        #region .NET Version Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<INetVersionDescriptor> For_NetVersionDescriptor => new()
        {
            Type = Instances.TypeOperator.Get_Type<NetVersionDescriptor>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.NetVersionDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_NetVersionDescriptor),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.NetVersionDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_NetVersionDescriptor),
            From_JsonElement = Instances.JsonElementOperator.Deserialize<NetVersionDescriptor>,
            To_JsonElement = Instances.JsonElementOperator.Serialize
        };

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<INetVersionDescriptor> For_NetVersionDescriptor_Latest => new()
        {
            Type = Instances.TypeOperator.Get_Type<NetVersionDescriptor_Latest>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.NetVersionDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_NetVersionDescriptor_Latest),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.NetVersionDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_NetVersionDescriptor_Latest),
            From_JsonElement = Instances.JsonElementOperator.Deserialize<NetVersionDescriptor_Latest>,
            To_JsonElement = Instances.JsonElementOperator.Serialize
        };

        #endregion

        #region Opinion Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IOpinionDescriptor> For_OpinionDescriptor => new()
        {
            Type = Instances.TypeOperator.Get_Type<OpinionDescriptor>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.OpinionDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_OpinionDescriptor),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.OpinionDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_OpinionDescriptor),
            From_JsonElement = Instances.JsonElementOperator.Deserialize<OpinionDescriptor>,
            To_JsonElement = Instances.JsonElementOperator.Serialize
        };

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IOpinionDescriptor> For_OpinionDescriptor_Set => new()
        {
            Type = Instances.TypeOperator.Get_Type<OpinionDescriptor_Set>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.OpinionDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_OpinionDescriptor_Set),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.OpinionDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_OpinionDescriptor_Set),
            From_JsonElement = Instances.JsonElementOperator.Deserialize<OpinionDescriptor_Set>,
            To_JsonElement = Instances.JsonElementOperator.Serialize
        };

        #endregion

        #region Organization Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IOrganizationDescriptor> For_OrganizationDescriptor => new()
        {
            Type = Instances.TypeOperator.Get_Type<OrganizationDescriptor_Name>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.OrganizationDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_OrganizationDescriptor),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.OrganizationDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_OrganizationDescriptor),
            From_JsonElement = Instances.JsonElementOperator.Deserialize<OrganizationDescriptor_Name>,
            To_JsonElement = Instances.JsonElementOperator.Serialize
        };

        #endregion

        #region Typing Scheme Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<ITypingSchemeDescriptor> For_TypingSchemeDescriptor_Enumeration => new()
        {
            Type = Instances.TypeOperator.Get_Type<TypingSchemeDescriptor_Enumeration>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.TypingSchemeDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_TypingSchemeDescriptor_Enumeration),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.TypingSchemeDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_TypingSchemeDescriptor_Enumeration),
            From_JsonElement = Instances.JsonElementOperator.Get_Deserialize<TypingSchemeDescriptor_Enumeration, Serialization_TypingSchemeDescriptor_Enumeration>(
                Instances.TypingSchemeDescriptorOperator.From_SerializationType),
            To_JsonElement = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.JsonElementOperator.Get_Serialize<TypingSchemeDescriptor_Enumeration, Serialization_TypingSchemeDescriptor_Enumeration>(
                    Instances.TypingSchemeDescriptorOperator.To_SerializationType),
                Instances.TypeSpecifiers.For_TypingSchemeDescriptor_Enumeration)
        };

        #endregion

        #region Visibility Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IVisibilityDescriptor> For_VisibilityDescriptor => new()
        {
            Type = Instances.TypeOperator.Get_Type<VisibilityDescriptor>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.VisibilityDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_VisibilityDescriptor),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.VisibilityDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_VisibilityDescriptor),
            From_JsonElement = Instances.JsonElementOperator.Get_Deserialize<VisibilityDescriptor, Serialization_VisibilityDescriptor>(
                Instances.VisibilityDescriptorOperator.From_SerializationType),
            To_JsonElement = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.JsonElementOperator.Get_Serialize<VisibilityDescriptor, Serialization_VisibilityDescriptor>(
                    Instances.VisibilityDescriptorOperator.To_SerializationType),
                Instances.TypeSpecifiers.For_VisibilityDescriptor
            )
        };

        #endregion
    }
}
