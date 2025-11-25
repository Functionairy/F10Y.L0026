using System;
using System.Collections.Generic;

using F10Y.L0000.Extensions;
using F10Y.L0001.L000.Extensions;
using F10Y.T0002;


namespace F10Y.L0026.L003
{
    [FunctionsMarker]
    public partial interface IInstanceSetLocationDescriptorOperator :
        For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IInstanceSetLocationDescriptor>
    {
        Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetLocationDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IInstanceSetLocationDescriptor>.TextHandlerSuites_ByType
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_InstanceSetLocationDescriptors_ByType;

        Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetLocationDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IInstanceSetLocationDescriptor>.TextHandlerSuites_ByTypeName
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_InstanceSetLocationDescriptors_ByTypeName;


        public InstanceSetLocationDescriptor From(
            IInstanceSetDescriptor instanceSetDescriptor,
            ILocationDescriptor locationDescriptor)
        {
            var output = new InstanceSetLocationDescriptor
            {
                InstanceSetDescriptor = instanceSetDescriptor,
                LocationDescriptor = locationDescriptor,
            };

            return output;
        }

        public InstanceSetLocationDescriptor From_SerializationType(Serialization_InstanceSetLocationDescriptor instanceSetLocationDescriptor)
        {
            var instanceSetDescriptor = Instances.InstanceSetDescriptorOperator.From_JsonSerializationObject(instanceSetLocationDescriptor.InstanceSetDescriptor);
            var locationDescriptor = Instances.LocationDescriptorOperator.From_JsonSerializationObject(instanceSetLocationDescriptor.LocationDescriptor);

            var output = new InstanceSetLocationDescriptor
            {
                InstanceSetDescriptor = instanceSetDescriptor,
                LocationDescriptor = locationDescriptor,
            };

            return output;
        }

        public Serialization_InstanceSetLocationDescriptor To_SerializationType(InstanceSetLocationDescriptor instanceSetLocationDescriptor)
        {
            var instanceSetDescriptor = Instances.InstanceSetDescriptorOperator.To_JsonSerializationObject(instanceSetLocationDescriptor.InstanceSetDescriptor);
            var locationDescriptor = Instances.LocationDescriptorOperator.To_JsonSerializationObject(instanceSetLocationDescriptor.LocationDescriptor);

            var output = new Serialization_InstanceSetLocationDescriptor
            {
                InstanceSetDescriptor = instanceSetDescriptor,
                LocationDescriptor = locationDescriptor,
            };

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(InstanceSetLocationDescriptor instanceSetLocationDescriptor)
        {
            var instanceSet_Lines = Instances.InstanceSetDescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceSetLocationDescriptor.InstanceSetDescriptor);
            var location_Lines = Instances.LocationDescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceSetLocationDescriptor.LocationDescriptor);

            var lastModified = Instances.DateTimeOperator.To_String_YYYY_MM_DD(instanceSetLocationDescriptor.LastModified);

            var output = Instances.EnumerableOperator.From($"{lastModified}: last-modified")
                .Append_Many(Instances.EnumerableOperator.From("Instance Set:")
                    .Append_Many(instanceSet_Lines.Entab())
                )
                .Append_Many(Instances.EnumerableOperator.From("Location:")
                    .Append_Many(location_Lines.Entab())
                )
                ;

            return output;
        }

        public IEnumerable<string> To_Text(InstanceSetLocationDescriptor instanceSetLocationDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(instanceSetLocationDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeName_OfDeclaredType(instanceSetLocationDescriptor);

            var output = Instances.EnumerableOperator.From($"Instance Set Location Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }
    }
}
