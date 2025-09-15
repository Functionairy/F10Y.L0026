using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0026.L003
{
    [FunctionsMarker]
    public partial interface IInstanceVarietyDescriptorOperator :
        T003.IInstanceVarietyDescriptorOperator,
        For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IInstanceVarietyDescriptor>
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public T003.IInstanceVarietyDescriptorOperator _T003 => T003.InstanceVarietyDescriptorOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceVarietyDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IInstanceVarietyDescriptor>.TextHandlerSuites_ByType
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_InstanceVarietyDescriptors_ByType;

        Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceVarietyDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IInstanceVarietyDescriptor>.TextHandlerSuites_ByTypeName
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_InstanceVarietyDescriptors_ByTypeName;


        public InstanceVarietyDescriptor_Aggregate From_InstanceVarietyDescriptors(IInstanceVarietyDescriptor[] instanceVarietyDescriptors)
        {
            var output = new InstanceVarietyDescriptor_Aggregate
            {
                InstanceVarietyDescriptors = instanceVarietyDescriptors,
            };

            return output;
        }

        public InstanceVarietyDescriptor_Aggregate From_SerializationType(Serialization_InstanceVarietyDescriptor_Aggregate instanceVarietyDescriptor)
        {
            var descriptors = instanceVarietyDescriptor.InstanceVarietyDescriptors
                .Select(this.From_JsonSerializationObject)
                .ToArray();

            var output = new InstanceVarietyDescriptor_Aggregate
            {
                InstanceVarietyDescriptors = descriptors
            };

            return output;
        }

        public Serialization_InstanceVarietyDescriptor_Aggregate To_SerializationType(InstanceVarietyDescriptor_Aggregate instanceVarietyDescriptor)
        {
            var descriptors = instanceVarietyDescriptor
                .Select(this.To_JsonSerializationObject)
                .ToArray();

            var output = new Serialization_InstanceVarietyDescriptor_Aggregate
            {
                InstanceVarietyDescriptors = descriptors
            };

            return output;
        }

        public InstanceVarietyDescriptor_Values From_SerializationType(Serialization_InstanceVarietyDescriptor_Values instanceVarietyDescriptor)
        {
            var implementationDescriptor = Instances.ImplementationSchemeDescriptorOperator.From_JsonSerializationObject(instanceVarietyDescriptor.ImplementationScheme);
            var namingDescriptor = Instances.NamingSchemeDescriptorOperator.From_JsonSerializationObject(instanceVarietyDescriptor.NamingScheme);
            var typingDescriptor = Instances.TypingSchemeDescriptorOperator.From_JsonSerializationObject(instanceVarietyDescriptor.TypingScheme);

            var output = new InstanceVarietyDescriptor_Values
            {
                ImplementationScheme = implementationDescriptor,
                NamingScheme = namingDescriptor,
                TypingScheme = typingDescriptor,
            };

            return output;
        }

        public Serialization_InstanceVarietyDescriptor_Values To_SerializationType(InstanceVarietyDescriptor_Values instanceVarietyDescriptor)
        {
            var implementationDescriptor = Instances.ImplementationSchemeDescriptorOperator.To_JsonSerializationObject(instanceVarietyDescriptor.ImplementationScheme);
            var namingDescriptor = Instances.NamingSchemeDescriptorOperator.To_JsonSerializationObject(instanceVarietyDescriptor.NamingScheme);
            var typingDescriptor = Instances.TypingSchemeDescriptorOperator.To_JsonSerializationObject(instanceVarietyDescriptor.TypingScheme);

            var output = new Serialization_InstanceVarietyDescriptor_Values
            {
                ImplementationScheme = implementationDescriptor,
                NamingScheme = namingDescriptor,
                TypingScheme = typingDescriptor,
            };

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(InstanceVarietyDescriptor_All instanceVarietyDescriptor)
        {
            var output = Instances.EnumerableOperator.From($"{Instances.Texts.ALL}")
                ;

            return output;
        }

        public IEnumerable<string> To_Text(InstanceVarietyDescriptor_All instanceVarietyDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(instanceVarietyDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(instanceVarietyDescriptor);

            var output = Instances.EnumerableOperator.From($"Instance Variety Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(InstanceVarietyDescriptor_Aggregate instanceVarietyDescriptor)
        {
            var count = instanceVarietyDescriptor.InstanceVarietyDescriptors.Length;

            var output = Instances.EnumerableOperator.From($"{count}: count")
                .Append_Many(instanceVarietyDescriptor.InstanceVarietyDescriptors
                    .SelectMany(this.To_Text_ContentOnly_Noexceptive)
                    .Entab()
                )
                ;

            return output;
        }

        public IEnumerable<string> To_Text(InstanceVarietyDescriptor_Aggregate instanceVarietyDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(instanceVarietyDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(instanceVarietyDescriptor);

            var output = Instances.EnumerableOperator.From($"Instance Variety Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(InstanceVarietyDescriptor_Name instanceVarietyDescriptor)
        {
            var output = Instances.EnumerableOperator.From($"{instanceVarietyDescriptor.InstanceVariety_Name}: instance variety name")
                ;

            return output;
        }

        public IEnumerable<string> To_Text(InstanceVarietyDescriptor_Name instanceVarietyDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(instanceVarietyDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(instanceVarietyDescriptor);

            var output = Instances.EnumerableOperator.From($"Instance Variety Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(InstanceVarietyDescriptor_Name_Set instanceVarietyDescriptor)
        {
            var count = instanceVarietyDescriptor.InstanceVariety_Names.Length;

            var output = Instances.EnumerableOperator.From($"{count}: count")
                .Append_Many(instanceVarietyDescriptor.InstanceVariety_Names
                    .Order_Alphabetically()
                    .Append(Instances.Texts.Order_Alphabetical_Parenthetical)
                    .Entab()
                )
                ;

            return output;
        }

        public IEnumerable<string> To_Text(InstanceVarietyDescriptor_Name_Set instanceVarietyDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(instanceVarietyDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(instanceVarietyDescriptor);

            var output = Instances.EnumerableOperator.From($"Instance Variety Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(InstanceVarietyDescriptor_Values instanceVarietyDescriptor)
        {
            var implementation_Lines = Instances.ImplementationSchemeDescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceVarietyDescriptor.ImplementationScheme);
            var naming_Lines = Instances.NamingSchemeDescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceVarietyDescriptor.NamingScheme);
            var typing_Lines = Instances.TypingSchemeDescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceVarietyDescriptor.TypingScheme);

            var output = Instances.EnumerableOperator.From(
                Instances.EnumerableOperator.From("Typing:")
                    .Append_Many(typing_Lines.Entab())
                    ,
                Instances.EnumerableOperator.From("Naming:")
                    .Append_Many(naming_Lines.Entab())
                    ,
                Instances.EnumerableOperator.From("Implementation:")
                    .Append_Many(implementation_Lines.Entab())
                );

            return output;
        }

        public IEnumerable<string> To_Text(InstanceVarietyDescriptor_Values instanceVarietyDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(instanceVarietyDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(instanceVarietyDescriptor);

            var output = Instances.EnumerableOperator.From($"Instance Variety Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }
    }
}
