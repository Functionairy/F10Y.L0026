using System;

using F10Y.T0003;


namespace F10Y.L0026
{
    [ValuesMarker]
    public partial interface IDescriptorTextOperationHandlerSuites
    {
        #region Instance Set Flows

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetFlow> For_InstanceSetFlow => new()
        {
            Type = Instances.TypeOperator.Get_Type<InstanceSetFlow>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceSetFlowOperator.To_Text,
                Instances.TypeSpecifiers.For_InstanceSetFlow),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.InstanceSetFlowOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_InstanceSetFlow),
            From_JsonElement = Instances.JsonElementOperator.Get_Deserialize<InstanceSetFlow, Serialization_InstanceSetFlow>(
                Instances.InstanceSetFlowOperator.From_SerializationType),
            To_JsonElement = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.JsonElementOperator.Get_Serialize<InstanceSetFlow, Serialization_InstanceSetFlow>(
                    Instances.InstanceSetFlowOperator.To_SerializationType),
                Instances.TypeSpecifiers.For_InstanceSetFlow
            )
        };

        #endregion
    }
}
