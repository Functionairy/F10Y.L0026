using System;

using F10Y.T0003;


namespace F10Y.L0026.L004
{
    [ValuesMarker]
    public partial interface IDescriptorTextOperationHandlerSuites
    {
        #region Instance Set Search Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetSearchDescriptor> For_InstanceSetSearchDescriptor => new()
        {
            Type = Instances.TypeOperator.Get_Type<InstanceSetSearchDescriptor>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceSetSearchDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_InstanceSetSearchDescriptor),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceSetSearchDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_InstanceSetSearchDescriptor),
            From_JsonElement = Instances.JsonElementOperator.Get_Deserialize<InstanceSetSearchDescriptor, Serialization_InstanceSetSearchDescriptor>(
                Instances.InstanceSetSearchDescriptorOperator.From_SerializationType),
            To_JsonElement = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.JsonElementOperator.Get_Serialize<InstanceSetSearchDescriptor, Serialization_InstanceSetSearchDescriptor>(
                    Instances.InstanceSetSearchDescriptorOperator.To_SerializationType),
                Instances.TypeSpecifiers.For_InstanceSetSearchDescriptor)
        };

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetSearchDescriptor> For_InstanceSetSearchDescriptor_Aggregate => new()
        {
            Type = Instances.TypeOperator.Get_Type<InstanceSetSearchDescriptor_Aggregate>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceSetSearchDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_InstanceSetSearchDescriptor_Aggregate),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceSetSearchDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_InstanceSetSearchDescriptor_Aggregate),
            From_JsonElement = Instances.JsonElementOperator.Get_Deserialize<InstanceSetSearchDescriptor_Aggregate, Serialization_InstanceSetSearchDescriptor_Aggregate>(
                Instances.InstanceSetSearchDescriptorOperator.From_SerializationType),
            To_JsonElement = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.JsonElementOperator.Get_Serialize<InstanceSetSearchDescriptor_Aggregate, Serialization_InstanceSetSearchDescriptor_Aggregate>(
                    Instances.InstanceSetSearchDescriptorOperator.To_SerializationType),
                Instances.TypeSpecifiers.For_InstanceSetSearchDescriptor_Aggregate)
        };

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetSearchDescriptor> For_InstanceSetSearchDescriptor_Aggregate_N001 => new()
        {
            Type = Instances.TypeOperator.Get_Type<N001_InstanceSetSearchDescriptor_Aggregate>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceSetSearchDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_InstanceSetSearchDescriptor_Aggregate_N001),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceSetSearchDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_InstanceSetSearchDescriptor_Aggregate_N001),
            From_JsonElement = Instances.JsonElementOperator.Get_Deserialize<N001_InstanceSetSearchDescriptor_Aggregate, N001_Serialization_InstanceSetSearchDescriptor_Aggregate>(
                Instances.InstanceSetSearchDescriptorOperator.From_SerializationType),
            To_JsonElement = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.JsonElementOperator.Get_Serialize<N001_InstanceSetSearchDescriptor_Aggregate, N001_Serialization_InstanceSetSearchDescriptor_Aggregate>(
                    Instances.InstanceSetSearchDescriptorOperator.To_SerializationType),
                Instances.TypeSpecifiers.For_InstanceSetSearchDescriptor_Aggregate_N001)
        };

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetSearchDescriptor> For_InstanceSetSearchDescriptor_Aggregate_N002 => new()
        {
            Type = Instances.TypeOperator.Get_Type<N002_InstanceSetSearchDescriptor_Aggregate>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceSetSearchDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_InstanceSetSearchDescriptor_Aggregate_N002),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceSetSearchDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_InstanceSetSearchDescriptor_Aggregate_N002),
            From_JsonElement = Instances.JsonElementOperator.Get_Deserialize<N002_InstanceSetSearchDescriptor_Aggregate, N002_Serialization_InstanceSetSearchDescriptor_Aggregate>(
                Instances.InstanceSetSearchDescriptorOperator.From_SerializationType),
            To_JsonElement = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.JsonElementOperator.Get_Serialize<N002_InstanceSetSearchDescriptor_Aggregate, N002_Serialization_InstanceSetSearchDescriptor_Aggregate>(
                    Instances.InstanceSetSearchDescriptorOperator.To_SerializationType),
                Instances.TypeSpecifiers.For_InstanceSetSearchDescriptor_Aggregate_N002)
        };

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetSearchDescriptor> For_InstanceSetSearchDescriptor_ApplicabilitySearchDescriptor => new()
        {
            Type = Instances.TypeOperator.Get_Type<InstanceSetSearchDescriptor_ApplicabilitySearchDescriptor>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceSetSearchDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_InstanceSetSearchDescriptor_ApplicabilitySearchDescriptor),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceSetSearchDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_InstanceSetSearchDescriptor_ApplicabilitySearchDescriptor),
            From_JsonElement = Instances.JsonElementOperator.Get_Deserialize<InstanceSetSearchDescriptor_ApplicabilitySearchDescriptor, Serialization_InstanceSetSearchDescriptor_ApplicabilitySearchDescriptor>(
                Instances.InstanceSetSearchDescriptorOperator.From_SerializationType),
            To_JsonElement = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.JsonElementOperator.Get_Serialize<InstanceSetSearchDescriptor_ApplicabilitySearchDescriptor, Serialization_InstanceSetSearchDescriptor_ApplicabilitySearchDescriptor>(
                    Instances.InstanceSetSearchDescriptorOperator.To_SerializationType),
                Instances.TypeSpecifiers.For_InstanceSetSearchDescriptor_ApplicabilitySearchDescriptor)
        };

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetSearchDescriptor> For_InstanceSetSearchDescriptor_DependencySetSearchDescriptor => new()
        {
            Type = Instances.TypeOperator.Get_Type<InstanceSetSearchDescriptor_DependencySetSearchDescriptor>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceSetSearchDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_InstanceSetSearchDescriptor_DependencySetSearchDescriptor),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceSetSearchDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_InstanceSetSearchDescriptor_DependencySetSearchDescriptor),
            From_JsonElement = Instances.JsonElementOperator.Get_Deserialize<InstanceSetSearchDescriptor_DependencySetSearchDescriptor, Serialization_InstanceSetSearchDescriptor_DependencySetSearchDescriptor>(
                Instances.InstanceSetSearchDescriptorOperator.From_SerializationType),
            To_JsonElement = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.JsonElementOperator.Get_Serialize<InstanceSetSearchDescriptor_DependencySetSearchDescriptor, Serialization_InstanceSetSearchDescriptor_DependencySetSearchDescriptor>(
                    Instances.InstanceSetSearchDescriptorOperator.To_SerializationType),
                Instances.TypeSpecifiers.For_InstanceSetSearchDescriptor_DependencySetSearchDescriptor)
        };

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetSearchDescriptor> For_InstanceSetSearchDescriptor_DomainSearchDescriptor => new()
        {
            Type = Instances.TypeOperator.Get_Type<InstanceSetSearchDescriptor_DomainSearchDescriptor>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceSetSearchDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_InstanceSetSearchDescriptor_DomainSearchDescriptor),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceSetSearchDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_InstanceSetSearchDescriptor_DomainSearchDescriptor),
            From_JsonElement = Instances.JsonElementOperator.Get_Deserialize<InstanceSetSearchDescriptor_DomainSearchDescriptor, Serialization_InstanceSetSearchDescriptor_DomainSearchDescriptor>(
                Instances.InstanceSetSearchDescriptorOperator.From_SerializationType),
            To_JsonElement = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.JsonElementOperator.Get_Serialize<InstanceSetSearchDescriptor_DomainSearchDescriptor, Serialization_InstanceSetSearchDescriptor_DomainSearchDescriptor>(
                    Instances.InstanceSetSearchDescriptorOperator.To_SerializationType),
                Instances.TypeSpecifiers.For_InstanceSetSearchDescriptor_DomainSearchDescriptor)
        };

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetSearchDescriptor> For_InstanceSetSearchDescriptor_DescriptorSearchDescriptor => new()
        {
            Type = Instances.TypeOperator.Get_Type<InstanceSetSearchDescriptor_DescriptorSearchDescriptor>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceSetSearchDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_InstanceSetSearchDescriptor_DescriptorSearchDescriptor),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceSetSearchDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_InstanceSetSearchDescriptor_DescriptorSearchDescriptor),
            From_JsonElement = Instances.JsonElementOperator.Get_Deserialize<InstanceSetSearchDescriptor_DescriptorSearchDescriptor, Serialization_InstanceSetSearchDescriptor_DescriptorSearchDescriptor>(
                Instances.InstanceSetSearchDescriptorOperator.From_SerializationType),
            To_JsonElement = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.JsonElementOperator.Get_Serialize<InstanceSetSearchDescriptor_DescriptorSearchDescriptor, Serialization_InstanceSetSearchDescriptor_DescriptorSearchDescriptor>(
                    Instances.InstanceSetSearchDescriptorOperator.To_SerializationType),
                Instances.TypeSpecifiers.For_InstanceSetSearchDescriptor_DescriptorSearchDescriptor)
        };

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetSearchDescriptor> For_InstanceSetSearchDescriptor_InstanceSetTypeSearchDescriptor => new()
        {
            Type = Instances.TypeOperator.Get_Type<InstanceSetSearchDescriptor_InstanceSetTypeSearchDescriptor>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceSetSearchDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_InstanceSetSearchDescriptor_InstanceSetTypeSearchDescriptor),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceSetSearchDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_InstanceSetSearchDescriptor_InstanceSetTypeSearchDescriptor),
            From_JsonElement = Instances.JsonElementOperator.Get_Deserialize<InstanceSetSearchDescriptor_InstanceSetTypeSearchDescriptor, Serialization_InstanceSetSearchDescriptor_InstanceSetTypeSearchDescriptor>(
                Instances.InstanceSetSearchDescriptorOperator.From_SerializationType),
            To_JsonElement = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.JsonElementOperator.Get_Serialize<InstanceSetSearchDescriptor_InstanceSetTypeSearchDescriptor, Serialization_InstanceSetSearchDescriptor_InstanceSetTypeSearchDescriptor>(
                    Instances.InstanceSetSearchDescriptorOperator.To_SerializationType),
                Instances.TypeSpecifiers.For_InstanceSetSearchDescriptor_InstanceSetTypeSearchDescriptor)
        };

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetSearchDescriptor> For_InstanceSetSearchDescriptor_InstanceVarietySearchDescriptor => new()
        {
            Type = Instances.TypeOperator.Get_Type<InstanceSetSearchDescriptor_InstanceVarietySearchDescriptor>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
               Instances.InstanceSetSearchDescriptorOperator.To_Text,
               Instances.TypeSpecifiers.For_InstanceSetSearchDescriptor_InstanceVarietySearchDescriptor),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
               Instances.InstanceSetSearchDescriptorOperator.To_Text_ContentOnly,
               Instances.TypeSpecifiers.For_InstanceSetSearchDescriptor_InstanceVarietySearchDescriptor),
            From_JsonElement = Instances.JsonElementOperator.Get_Deserialize<InstanceSetSearchDescriptor_InstanceVarietySearchDescriptor, Serialization_InstanceSetSearchDescriptor_InstanceVarietySearchDescriptor>(
               Instances.InstanceSetSearchDescriptorOperator.From_SerializationType),
            To_JsonElement = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
               Instances.JsonElementOperator.Get_Serialize<InstanceSetSearchDescriptor_InstanceVarietySearchDescriptor, Serialization_InstanceSetSearchDescriptor_InstanceVarietySearchDescriptor>(
                   Instances.InstanceSetSearchDescriptorOperator.To_SerializationType),
               Instances.TypeSpecifiers.For_InstanceSetSearchDescriptor_InstanceVarietySearchDescriptor)
        };

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetSearchDescriptor> For_InstanceSetSearchDescriptor_NetVersionSearchDescriptor => new()
        {
            Type = Instances.TypeOperator.Get_Type<InstanceSetSearchDescriptor_NetVersionSearchDescriptor>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceSetSearchDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_InstanceSetSearchDescriptor_NetVersionSearchDescriptor),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceSetSearchDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_InstanceSetSearchDescriptor_NetVersionSearchDescriptor),
            From_JsonElement = Instances.JsonElementOperator.Get_Deserialize<InstanceSetSearchDescriptor_NetVersionSearchDescriptor, Serialization_InstanceSetSearchDescriptor_NetVersionSearchDescriptor>(
                Instances.InstanceSetSearchDescriptorOperator.From_SerializationType),
            To_JsonElement = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.JsonElementOperator.Get_Serialize<InstanceSetSearchDescriptor_NetVersionSearchDescriptor, Serialization_InstanceSetSearchDescriptor_NetVersionSearchDescriptor>(
                    Instances.InstanceSetSearchDescriptorOperator.To_SerializationType),
                Instances.TypeSpecifiers.For_InstanceSetSearchDescriptor_NetVersionSearchDescriptor)
        };

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetSearchDescriptor> For_InstanceSetSearchDescriptor_OpinionSearchDescriptor => new()
        {
            Type = Instances.TypeOperator.Get_Type<InstanceSetSearchDescriptor_OpinionSearchDescriptor>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceSetSearchDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_InstanceSetSearchDescriptor_OpinionSearchDescriptor),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceSetSearchDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_InstanceSetSearchDescriptor_OpinionSearchDescriptor),
            From_JsonElement = Instances.JsonElementOperator.Get_Deserialize<InstanceSetSearchDescriptor_OpinionSearchDescriptor, Serialization_InstanceSetSearchDescriptor_OpinionSearchDescriptor>(
                Instances.InstanceSetSearchDescriptorOperator.From_SerializationType),
            To_JsonElement = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.JsonElementOperator.Get_Serialize<InstanceSetSearchDescriptor_OpinionSearchDescriptor, Serialization_InstanceSetSearchDescriptor_OpinionSearchDescriptor>(
                    Instances.InstanceSetSearchDescriptorOperator.To_SerializationType),
                Instances.TypeSpecifiers.For_InstanceSetSearchDescriptor_OpinionSearchDescriptor)
        };

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetSearchDescriptor> For_InstanceSetSearchDescriptor_OrganizationName => new()
        {
            Type = Instances.TypeOperator.Get_Type<InstanceSetSearchDescriptor_OrganizationName>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceSetSearchDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_InstanceSetSearchDescriptor_OrganizationName),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceSetSearchDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_InstanceSetSearchDescriptor_OrganizationName),
            From_JsonElement = Instances.JsonElementOperator.Deserialize<InstanceSetSearchDescriptor_OrganizationName>,
            To_JsonElement = Instances.JsonElementOperator.Serialize
        };

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetSearchDescriptor> For_InstanceSetSearchDescriptor_OrganizationSearchDescriptor => new()
        {
            Type = Instances.TypeOperator.Get_Type<InstanceSetSearchDescriptor_OrganizationSearchDescriptor>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceSetSearchDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_InstanceSetSearchDescriptor_OrganizationSearchDescriptor),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceSetSearchDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_InstanceSetSearchDescriptor_OrganizationSearchDescriptor),
            From_JsonElement = Instances.JsonElementOperator.Get_Deserialize<InstanceSetSearchDescriptor_OrganizationSearchDescriptor, Serialization_InstanceSetSearchDescriptor_OrganizationSearchDescriptor>(
                Instances.InstanceSetSearchDescriptorOperator.From_SerializationType),
            To_JsonElement = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.JsonElementOperator.Get_Serialize<InstanceSetSearchDescriptor_OrganizationSearchDescriptor, Serialization_InstanceSetSearchDescriptor_OrganizationSearchDescriptor>(
                    Instances.InstanceSetSearchDescriptorOperator.To_SerializationType),
                Instances.TypeSpecifiers.For_InstanceSetSearchDescriptor_OrganizationSearchDescriptor)
        };

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetSearchDescriptor> For_InstanceSetSearchDescriptor_VisibilitySearchDescriptor => new()
        {
            Type = Instances.TypeOperator.Get_Type<InstanceSetSearchDescriptor_VisibilitySearchDescriptor>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceSetSearchDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_InstanceSetSearchDescriptor_VisibilitySearchDescriptor),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceSetSearchDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_InstanceSetSearchDescriptor_VisibilitySearchDescriptor),
            From_JsonElement = Instances.JsonElementOperator.Get_Deserialize<InstanceSetSearchDescriptor_VisibilitySearchDescriptor, Serialization_InstanceSetSearchDescriptor_VisibilitySearchDescriptor>(
                Instances.InstanceSetSearchDescriptorOperator.From_SerializationType),
            To_JsonElement = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.JsonElementOperator.Get_Serialize<InstanceSetSearchDescriptor_VisibilitySearchDescriptor, Serialization_InstanceSetSearchDescriptor_VisibilitySearchDescriptor>(
                    Instances.InstanceSetSearchDescriptorOperator.To_SerializationType),
                Instances.TypeSpecifiers.For_InstanceSetSearchDescriptor_VisibilitySearchDescriptor)
        };

        #endregion

        #region Instance Set Type Search Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetTypeSearchDescriptor> For_InstanceSetTypeSearchDescriptor_Name => new()
        {
            Type = Instances.TypeOperator.Get_Type<InstanceSetTypeSearchDescriptor_Name>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceSetTypeSearchDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_InstanceSetTypeSearchDescriptor_Name),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceSetTypeSearchDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_InstanceSetTypeSearchDescriptor_Name),
            From_JsonElement = Instances.JsonElementOperator.Get_Deserialize<InstanceSetTypeSearchDescriptor_Name, Serialization_InstanceSetTypeSearchDescriptor_Name>(
                Instances.InstanceSetTypeSearchDescriptorOperator.From_SerializationType),
            To_JsonElement = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.JsonElementOperator.Get_Serialize<InstanceSetTypeSearchDescriptor_Name, Serialization_InstanceSetTypeSearchDescriptor_Name>(
                    Instances.InstanceSetTypeSearchDescriptorOperator.To_SerializationType),
                Instances.TypeSpecifiers.For_InstanceSetTypeSearchDescriptor_Name)
        };

        #endregion

        #region Instance Variety Search Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceVarietySearchDescriptor> For_InstanceVarietySearchDescriptor_Name => new()
        {
            Type = Instances.TypeOperator.Get_Type<InstanceVarietySearchDescriptor_Name>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceVarietySearchDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_InstanceVarietySearchDescriptor_Name),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceVarietySearchDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_InstanceVarietySearchDescriptor_Name),
            From_JsonElement = Instances.JsonElementOperator.Get_Deserialize<InstanceVarietySearchDescriptor_Name, Serialization_InstanceVarietySearchDescriptor_Name>(
                Instances.InstanceVarietySearchDescriptorOperator.From_SerializationType),
            To_JsonElement = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.JsonElementOperator.Get_Serialize<InstanceVarietySearchDescriptor_Name, Serialization_InstanceVarietySearchDescriptor_Name>(
                    Instances.InstanceVarietySearchDescriptorOperator.To_SerializationType),
                Instances.TypeSpecifiers.For_InstanceVarietySearchDescriptor_Name)
        };

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceVarietySearchDescriptor> For_InstanceVarietySearchDescriptor_Values => new()
        {
            Type = Instances.TypeOperator.Get_Type<InstanceVarietySearchDescriptor_Values>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceVarietySearchDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_InstanceVarietySearchDescriptor_Values),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceVarietySearchDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_InstanceVarietySearchDescriptor_Values),
            From_JsonElement = Instances.JsonElementOperator.Get_Deserialize<InstanceVarietySearchDescriptor_Values, Serialization_InstanceVarietySearchDescriptor_Values>(
                Instances.InstanceVarietySearchDescriptorOperator.From_SerializationType),
            To_JsonElement = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.JsonElementOperator.Get_Serialize<InstanceVarietySearchDescriptor_Values, Serialization_InstanceVarietySearchDescriptor_Values>(
                    Instances.InstanceVarietySearchDescriptorOperator.To_SerializationType),
                Instances.TypeSpecifiers.For_InstanceVarietySearchDescriptor_Values)
        };

        #endregion
    }
}
