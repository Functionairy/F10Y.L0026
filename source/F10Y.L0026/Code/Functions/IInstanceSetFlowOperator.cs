using System;
using System.Collections.Generic;

using F10Y.L0000.Extensions;
using F10Y.L0001.L000.Extensions;
using F10Y.T0002;


namespace F10Y.L0026
{
    [FunctionsMarker]
    public partial interface IInstanceSetFlowOperator :
        For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IInstanceSetFlow>
    {
        Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetFlow>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IInstanceSetFlow>.TextHandlerSuites_ByType
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_InstanceSetFlows_ByType;

        Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetFlow>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IInstanceSetFlow>.TextHandlerSuites_ByTypeName
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_InstanceSetFlows_ByTypeName;


        public InstanceSetFlow From(
            IInstanceSetDescriptor source,
            IInstanceSetDescriptor destination,
            IInstanceSetFlowDescriptor flow)
        {
            var output = new InstanceSetFlow
            {
                Source = source,
                Destination = destination,
                Flow = flow,
            };

            return output;
        }

        public InstanceSetFlow From_SerializationType(Serialization_InstanceSetFlow instanceSetFlow)
        {
            var sourceDescriptor = Instances.InstanceSetDescriptorOperator.From_JsonSerializationObject(instanceSetFlow.Source);
            var destinationDescriptor = Instances.InstanceSetDescriptorOperator.From_JsonSerializationObject(instanceSetFlow.Destination);
            var flowDescriptor = Instances.InstanceSetFlowDescriptorOperator.From_JsonSerializationObject(instanceSetFlow.Flow);

            var output = new InstanceSetFlow
            {
                Source = sourceDescriptor,
                Destination = destinationDescriptor,
                Flow = flowDescriptor,
            };

            return output;
        }

        public Serialization_InstanceSetFlow To_SerializationType(InstanceSetFlow instanceSetFlow)
        {
            var sourceDescriptor = Instances.InstanceSetDescriptorOperator.To_JsonSerializationObject(instanceSetFlow.Source);
            var destinationDescriptor = Instances.InstanceSetDescriptorOperator.To_JsonSerializationObject(instanceSetFlow.Destination);
            var flowDescriptor = Instances.InstanceSetFlowDescriptorOperator.To_JsonSerializationObject(instanceSetFlow.Flow);

            var output = new Serialization_InstanceSetFlow
            {
                Source = sourceDescriptor,
                Destination = destinationDescriptor,
                Flow = flowDescriptor,
            };

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(InstanceSetFlow instanceSetFlow)
        {
            var source_Lines = Instances.InstanceSetDescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceSetFlow.Source);
            var destination_Lines = Instances.InstanceSetDescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceSetFlow.Destination);
            var flow_Lines = Instances.InstanceSetFlowDescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceSetFlow.Flow);

            var output = Instances.EnumerableOperator.From(
                Instances.EnumerableOperator.From("Source:")
                    .Append_Many(source_Lines.Entab())
                    ,
                Instances.EnumerableOperator.From("Destination:")
                    .Append_Many(destination_Lines.Entab())
                    ,
                Instances.EnumerableOperator.From("Flow:")
                    .Append_Many(flow_Lines.Entab())
                )
                ;

            return output;
        }

        public IEnumerable<string> To_Text(InstanceSetFlow instanceSetFlow)
        {
            var lines_ForContent = this.To_Text_ContentOnly(instanceSetFlow);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(instanceSetFlow);

            var output = Instances.EnumerableOperator.From($"Instance Set Flow ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }
    }
}
