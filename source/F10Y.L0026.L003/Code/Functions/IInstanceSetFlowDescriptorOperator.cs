using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0026.L003
{
    [FunctionsMarker]
    public partial interface IInstanceSetFlowDescriptorOperator :
        T003.IInstanceSetFlowDescriptorOperator,
        For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IInstanceSetFlowDescriptor>
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public T003.IInstanceSetFlowDescriptorOperator _T003 => T003.InstanceSetFlowDescriptorOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetFlowDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IInstanceSetFlowDescriptor>.TextHandlerSuites_ByType
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_InstanceSetFlowDescriptors_ByType;

        Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetFlowDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IInstanceSetFlowDescriptor>.TextHandlerSuites_ByTypeName
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_InstanceSetFlowDescriptors_ByTypeName;


        

        public InstanceSetFlowDescriptor_Aggregate From_SerializationType(Serialization_InstanceSetFlowDescriptor_Aggregate instanceSetFlowDescriptor_Aggregate)
        {
            var descriptors = instanceSetFlowDescriptor_Aggregate.Descriptors
                .Select(this.From_JsonSerializationObject)
                .ToArray();

            var output = this.From(descriptors);
            return output;
        }

        public Serialization_InstanceSetFlowDescriptor_Aggregate To_SerializationType(InstanceSetFlowDescriptor_Aggregate instanceSetFlowDescriptor_Aggregate)
        {
            var descriptor_JsonSerializationObjects = instanceSetFlowDescriptor_Aggregate.Descriptors
                .Select(this.To_JsonSerializationObject)
                .ToArray();

            var output = new Serialization_InstanceSetFlowDescriptor_Aggregate
            {
                Descriptors = descriptor_JsonSerializationObjects
            };

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(InstanceSetFlowDescriptor_Aggregate aggregateDescriptor)
        {
            var count = aggregateDescriptor.Descriptors.Length;

            var output = Instances.EnumerableOperator.From($"{count}: count")
                .Append_Many(aggregateDescriptor.Descriptors
                    .SelectMany(this.To_Text_ContentOnly_Noexceptive)
                    .Entab()
                )
                ;

            return output;
        }

        public IEnumerable<string> To_Text(InstanceSetFlowDescriptor_Aggregate aggregateDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(aggregateDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeName_OfDeclaredType(aggregateDescriptor);

            var output = Instances.EnumerableOperator.From($"Instance Set Flow Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(InstanceSetFlowDescriptor_Contribute contributeDescriptor)
        {
            var output = Instances.EnumerableOperator.From($"{contributeDescriptor.OrganizationName_Destination}: contribute to organization")
                ;

            return output;
        }

        public IEnumerable<string> To_Text(InstanceSetFlowDescriptor_Contribute contributeDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(contributeDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeName_OfDeclaredType(contributeDescriptor);

            var output = Instances.EnumerableOperator.From($"Instance Set Flow Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(InstanceSetFlowDescriptor_Deprecate deprecateDescriptor)
        {
            var output = Instances.EnumerableOperator.From($"{Instances.Texts.DEPRECATE}")
                ;

            return output;
        }

        public IEnumerable<string> To_Text(InstanceSetFlowDescriptor_Deprecate deprecateDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(deprecateDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeName_OfDeclaredType(deprecateDescriptor);

            var output = Instances.EnumerableOperator.From($"Instance Set Flow Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(InstanceSetFlowDescriptor_Librarate librarateDescriptor)
        {
            var output = Instances.EnumerableOperator.From($"{Instances.Texts.LIBRARATE}")
                ;

            return output;
        }

        public IEnumerable<string> To_Text(InstanceSetFlowDescriptor_Librarate librarateDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(librarateDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeName_OfDeclaredType(librarateDescriptor);

            var output = Instances.EnumerableOperator.From($"Instance Set Flow Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(InstanceSetFlowDescriptor_NetVersion_Change netVersionChangeDescriptor)
        {
            var grade = Instances.EnumerationOperator.Get_StringRepresentation(netVersionChangeDescriptor.Grade);

            var output = Instances.EnumerableOperator.From($"{netVersionChangeDescriptor.TargetFrameworkMoniker_Destination}: .NET Version {grade}")
                ;

            return output;
        }

        public IEnumerable<string> To_Text(InstanceSetFlowDescriptor_NetVersion_Change netVersionChangeDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(netVersionChangeDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeName_OfDeclaredType(netVersionChangeDescriptor);

            var output = Instances.EnumerableOperator.From($"Instance Set Flow Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(InstanceSetFlowDescriptor_NetVersion_Choose netVersionChooseDescriptor)
        {
            var output = Instances.EnumerableOperator.From($"{netVersionChooseDescriptor.TargetFrameworkMoniker_Destination}: .NET Version chosen")
                ;

            return output;
        }

        public IEnumerable<string> To_Text(InstanceSetFlowDescriptor_NetVersion_Choose netVersionChooseDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(netVersionChooseDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeName_OfDeclaredType(netVersionChooseDescriptor);

            var output = Instances.EnumerableOperator.From($"Instance Set Flow Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(InstanceSetFlowDescriptor_Port portDescriptor)
        {
            var output = Instances.EnumerableOperator.From($"{Instances.Texts.PORT}")
                ;

            return output;
        }

        public IEnumerable<string> To_Text(InstanceSetFlowDescriptor_Port portDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(portDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeName_OfDeclaredType(portDescriptor);

            var output = Instances.EnumerableOperator.From($"Instance Set Flow Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(InstanceSetFlowDescriptor_Publicize publicizeDescriptor)
        {
            var output = Instances.EnumerableOperator.From($"{Instances.Texts.PUBLICIZE}")
                ;

            return output;
        }

        public IEnumerable<string> To_Text(InstanceSetFlowDescriptor_Publicize publicizeDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(publicizeDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeName_OfDeclaredType(publicizeDescriptor);

            var output = Instances.EnumerableOperator.From($"Instance Set Flow Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }
    }
}
