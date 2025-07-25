using System;

using F10Y.T0003;


namespace F10Y.L0026.L003
{
    [ValuesMarker]
    public partial interface IDescriptorTextOperationHandlerSuites
    {
        #region Instance Set Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetDescriptor> For_InstanceSetDescriptor => new()
        {
            Type = Instances.TypeOperator.Get_Type<InstanceSetDescriptor>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceSetDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_InstanceSetDescriptor),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceSetDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_InstanceSetDescriptor),
            From_JsonElement = Instances.JsonElementOperator.Get_Deserialize<InstanceSetDescriptor, Serialization_InstanceSetDescriptor>(
                Instances.InstanceSetDescriptorOperator.From_SerializationType),
            To_JsonElement = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.JsonElementOperator.Get_Serialize<InstanceSetDescriptor, Serialization_InstanceSetDescriptor>(
                    Instances.InstanceSetDescriptorOperator.To_SerializationType),
                Instances.TypeSpecifiers.For_InstanceSetDescriptor)
        };

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetDescriptor> For_InstanceSetDescriptor_CatchAllLibrary => new()
        {
            Type = Instances.TypeOperator.Get_Type<InstanceSetDescriptor_CatchAllLibrary>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceSetDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_InstanceSetDescriptor_CatchAllLibrary),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceSetDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_InstanceSetDescriptor_CatchAllLibrary),
            From_JsonElement = Instances.JsonElementOperator.Get_Deserialize<InstanceSetDescriptor_CatchAllLibrary, Serialization_InstanceSetDescriptor_CatchAllLibrary>(
                Instances.InstanceSetDescriptorOperator.From_SerializationType),
            To_JsonElement = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.JsonElementOperator.Get_Serialize<InstanceSetDescriptor_CatchAllLibrary, Serialization_InstanceSetDescriptor_CatchAllLibrary>(
                    Instances.InstanceSetDescriptorOperator.To_SerializationType),
                Instances.TypeSpecifiers.For_InstanceSetDescriptor_CatchAllLibrary
            )
        };

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetDescriptor> For_InstanceSetDescriptor_EntryPointExecutable => new()
        {
            Type = Instances.TypeOperator.Get_Type<InstanceSetDescriptor_EntryPointExecutable>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceSetDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_InstanceSetDescriptor_EntryPointExecutable),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceSetDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_InstanceSetDescriptor_EntryPointExecutable),
            From_JsonElement = Instances.JsonElementOperator.Get_Deserialize<InstanceSetDescriptor_EntryPointExecutable, Serialization_InstanceSetDescriptor_EntryPointExecutable>(
                Instances.InstanceSetDescriptorOperator.From_SerializationType),
            To_JsonElement = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.JsonElementOperator.Get_Serialize<InstanceSetDescriptor_EntryPointExecutable, Serialization_InstanceSetDescriptor_EntryPointExecutable>(
                    Instances.InstanceSetDescriptorOperator.To_SerializationType),
                Instances.TypeSpecifiers.For_InstanceSetDescriptor_EntryPointExecutable
            )
        };

        #endregion

        #region Instance Set Flow Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetFlowDescriptor> For_InstanceSetFlowDescriptor_Aggregate => new()
        {
            Type = Instances.TypeOperator.Get_Type<InstanceSetFlowDescriptor_Aggregate>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceSetFlowDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_InstanceSetFlowDescriptor_Aggregate),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceSetFlowDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_InstanceSetFlowDescriptor_Aggregate),
            From_JsonElement = Instances.JsonElementOperator.Get_Deserialize<InstanceSetFlowDescriptor_Aggregate, Serialization_InstanceSetFlowDescriptor_Aggregate>(
                Instances.InstanceSetFlowDescriptorOperator.From_SerializationType),
            To_JsonElement = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.JsonElementOperator.Get_Serialize<InstanceSetFlowDescriptor_Aggregate, Serialization_InstanceSetFlowDescriptor_Aggregate>(
                    Instances.InstanceSetFlowDescriptorOperator.To_SerializationType),
                Instances.TypeSpecifiers.For_InstanceSetFlowDescriptor_Aggregate)
        };

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetFlowDescriptor> For_InstanceSetFlowDescriptor_Contribute => new()
        {
            Type = Instances.TypeOperator.Get_Type<InstanceSetFlowDescriptor_Contribute>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceSetFlowDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_InstanceSetFlowDescriptor_Contribute),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceSetFlowDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_InstanceSetFlowDescriptor_Contribute),
            From_JsonElement = Instances.JsonElementOperator.Deserialize<InstanceSetFlowDescriptor_Contribute>,
            To_JsonElement = Instances.JsonElementOperator.Serialize
        };

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetFlowDescriptor> For_InstanceSetFlowDescriptor_Deprecate => new()
        {
            Type = Instances.TypeOperator.Get_Type<InstanceSetFlowDescriptor_Deprecate>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceSetFlowDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_InstanceSetFlowDescriptor_Deprecate),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceSetFlowDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_InstanceSetFlowDescriptor_Deprecate),
            From_JsonElement = Instances.JsonElementOperator.Deserialize<InstanceSetFlowDescriptor_Deprecate>,
            To_JsonElement = Instances.JsonElementOperator.Serialize
        };

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetFlowDescriptor> For_InstanceSetFlowDescriptor_Librarate => new()
        {
            Type = Instances.TypeOperator.Get_Type<InstanceSetFlowDescriptor_Librarate>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceSetFlowDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_InstanceSetFlowDescriptor_Librarate),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceSetFlowDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_InstanceSetFlowDescriptor_Librarate),
            From_JsonElement = Instances.JsonElementOperator.Deserialize<InstanceSetFlowDescriptor_Librarate>,
            To_JsonElement = Instances.JsonElementOperator.Serialize
        };

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetFlowDescriptor> For_InstanceSetFlowDescriptor_NetVersion_Change => new()
        {
            Type = Instances.TypeOperator.Get_Type<InstanceSetFlowDescriptor_NetVersion_Change>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceSetFlowDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_InstanceSetFlowDescriptor_NetVersion_Change),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceSetFlowDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_InstanceSetFlowDescriptor_NetVersion_Change),
            From_JsonElement = Instances.JsonElementOperator.Deserialize<InstanceSetFlowDescriptor_NetVersion_Change>,
            To_JsonElement = Instances.JsonElementOperator.Serialize
        };

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetFlowDescriptor> For_InstanceSetFlowDescriptor_NetVersion_Choose => new()
        {
            Type = Instances.TypeOperator.Get_Type<InstanceSetFlowDescriptor_NetVersion_Choose>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceSetFlowDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_InstanceSetFlowDescriptor_NetVersion_Choose),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceSetFlowDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_InstanceSetFlowDescriptor_NetVersion_Choose),
            From_JsonElement = Instances.JsonElementOperator.Deserialize<InstanceSetFlowDescriptor_NetVersion_Choose>,
            To_JsonElement = Instances.JsonElementOperator.Serialize
        };

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetFlowDescriptor> For_InstanceSetFlowDescriptor_Port => new()
        {
            Type = Instances.TypeOperator.Get_Type<InstanceSetFlowDescriptor_Port>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceSetFlowDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_InstanceSetFlowDescriptor_Port),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceSetFlowDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_InstanceSetFlowDescriptor_Port),
            From_JsonElement = Instances.JsonElementOperator.Deserialize<InstanceSetFlowDescriptor_Port>,
            To_JsonElement = Instances.JsonElementOperator.Serialize
        };

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetFlowDescriptor> For_InstanceSetFlowDescriptor_Publicize => new()
        {
            Type = Instances.TypeOperator.Get_Type<InstanceSetFlowDescriptor_Publicize>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceSetFlowDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_InstanceSetFlowDescriptor_Publicize),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceSetFlowDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_InstanceSetFlowDescriptor_Publicize),
            From_JsonElement = Instances.JsonElementOperator.Deserialize<InstanceSetFlowDescriptor_Publicize>,
            To_JsonElement = Instances.JsonElementOperator.Serialize
        };

        #endregion

        #region Instance Set Location Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetLocationDescriptor> For_InstanceSetLocationDescriptor => new()
        {
            Type = Instances.TypeOperator.Get_Type<InstanceSetLocationDescriptor>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceSetLocationDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_InstanceSetLocationDescriptor),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceSetLocationDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_InstanceSetLocationDescriptor),
            From_JsonElement = Instances.JsonElementOperator.Get_Deserialize<InstanceSetLocationDescriptor, Serialization_InstanceSetLocationDescriptor>(
                Instances.InstanceSetLocationDescriptorOperator.From_SerializationType),
            To_JsonElement = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.JsonElementOperator.Get_Serialize<InstanceSetLocationDescriptor, Serialization_InstanceSetLocationDescriptor>(
                    Instances.InstanceSetLocationDescriptorOperator.To_SerializationType),
                Instances.TypeSpecifiers.For_InstanceSetLocationDescriptor)
        };

        #endregion

        #region Instance Set Type Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetTypeDescriptor> For_InstanceSetTypeDescriptor_Name => new()
        {
            Type = Instances.TypeOperator.Get_Type<InstanceSetTypeDescriptor_Name>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceSetTypeDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_InstanceSetTypeDescriptor_Name),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceSetTypeDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_InstanceSetTypeDescriptor_Name),
            From_JsonElement = Instances.JsonElementOperator.Deserialize<InstanceSetTypeDescriptor_Name>,
            To_JsonElement = Instances.JsonElementOperator.Serialize
        };

        #endregion

        #region Instance Variety Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceVarietyDescriptor> For_InstanceVarietyDescriptor_All => new()
        {
            Type = Instances.TypeOperator.Get_Type<InstanceVarietyDescriptor_All>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceVarietyDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_InstanceVarietyDescriptor_All),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceVarietyDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_InstanceVarietyDescriptor_All),
            From_JsonElement = Instances.JsonElementOperator.Deserialize<InstanceVarietyDescriptor_All>,
            To_JsonElement = Instances.JsonElementOperator.Serialize
        };

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceVarietyDescriptor> For_InstanceVarietyDescriptor_Aggregate => new()
        {
            Type = Instances.TypeOperator.Get_Type<InstanceVarietyDescriptor_Aggregate>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceVarietyDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_InstanceVarietyDescriptor_Aggregate),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceVarietyDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_InstanceVarietyDescriptor_Aggregate),
            From_JsonElement = Instances.JsonElementOperator.Get_Deserialize<InstanceVarietyDescriptor_Aggregate, Serialization_InstanceVarietyDescriptor_Aggregate>(
                Instances.InstanceVarietyDescriptorOperator.From_SerializationType),
            To_JsonElement = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.JsonElementOperator.Get_Serialize<InstanceVarietyDescriptor_Aggregate, Serialization_InstanceVarietyDescriptor_Aggregate>(
                    Instances.InstanceVarietyDescriptorOperator.To_SerializationType),
                Instances.TypeSpecifiers.For_InstanceVarietyDescriptor_Aggregate)
        };

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceVarietyDescriptor> For_InstanceVarietyDescriptor_Name => new()
        {
            Type = Instances.TypeOperator.Get_Type<InstanceVarietyDescriptor_Name>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceVarietyDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_InstanceVarietyDescriptor_Name),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceVarietyDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_InstanceVarietyDescriptor_Name),
            From_JsonElement = Instances.JsonElementOperator.Deserialize<InstanceVarietyDescriptor_Name>,
            To_JsonElement = Instances.JsonElementOperator.Serialize
        };

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceVarietyDescriptor> For_InstanceVarietyDescriptor_Name_Set => new()
        {
            Type = Instances.TypeOperator.Get_Type<InstanceVarietyDescriptor_Name_Set>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceVarietyDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_InstanceVarietyDescriptor_Name_Set),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceVarietyDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_InstanceVarietyDescriptor_Name_Set),
            From_JsonElement = Instances.JsonElementOperator.Deserialize<InstanceVarietyDescriptor_Name_Set>,
            To_JsonElement = Instances.JsonElementOperator.Serialize
        };

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceVarietyDescriptor> For_InstanceVarietyDescriptor_Values => new()
        {
            Type = Instances.TypeOperator.Get_Type<InstanceVarietyDescriptor_Values>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceVarietyDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_InstanceVarietyDescriptor_Values),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceVarietyDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_InstanceVarietyDescriptor_Values),
            From_JsonElement = Instances.JsonElementOperator.Get_Deserialize<InstanceVarietyDescriptor_Values, Serialization_InstanceVarietyDescriptor_Values>(
                Instances.InstanceVarietyDescriptorOperator.From_SerializationType),
            To_JsonElement = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.JsonElementOperator.Get_Serialize<InstanceVarietyDescriptor_Values, Serialization_InstanceVarietyDescriptor_Values>(
                    Instances.InstanceVarietyDescriptorOperator.To_SerializationType),
                Instances.TypeSpecifiers.For_InstanceVarietyDescriptor_Values)
        };

        #endregion
    }
}
