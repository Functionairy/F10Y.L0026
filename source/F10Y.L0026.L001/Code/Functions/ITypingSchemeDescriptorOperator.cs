using System;
using System.Collections.Generic;

using F10Y.L0000.Extensions;
using F10Y.L0001.L000.Extensions;
using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0026.L001
{
    [FunctionsMarker]
    public partial interface ITypingSchemeDescriptorOperator :
        T001.ITypingSchemeDescriptorOperator,
        For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<ITypingSchemeDescriptor>
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public T001.ITypingSchemeDescriptorOperator _T001 => T001.TypingSchemeDescriptorOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<ITypingSchemeDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<ITypingSchemeDescriptor>.TextHandlerSuites_ByType
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_TypingSchemeDescriptors_ByType;

        Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<ITypingSchemeDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<ITypingSchemeDescriptor>.TextHandlerSuites_ByTypeName
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_TypingSchemeDescriptors_ByTypeName;


        public TypingSchemeDescriptor_Enumeration From_SerializationType(Serialization_TypingSchemeDescriptor_Enumeration typingSchemeDescriptor)
        {
            var typingScheme = Instances.EnumerationOperator.Get_Value<TypingScheme>(typingSchemeDescriptor.TypingScheme);

            var output = new TypingSchemeDescriptor_Enumeration
            {
                TypingScheme = typingScheme
            };

            return output;
        }

        public Serialization_TypingSchemeDescriptor_Enumeration To_SerializationType(TypingSchemeDescriptor_Enumeration typingSchemeDescriptor)
        {
            var typingScheme = Instances.EnumerationOperator.Get_StringRepresentation(typingSchemeDescriptor.TypingScheme);

            var output = new Serialization_TypingSchemeDescriptor_Enumeration
            {
                TypingScheme = typingScheme
            };

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(TypingSchemeDescriptor_Enumeration typingSchemeDescriptor)
        {
            var schemeToken = Instances.EnumerationOperator.Get_StringRepresentation(typingSchemeDescriptor.TypingScheme);

            var output = Instances.EnumerableOperator.From($"{schemeToken}: typing scheme")
                ;

            return output;
        }

        public IEnumerable<string> To_Text(TypingSchemeDescriptor_Enumeration typingSchemeDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(typingSchemeDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(typingSchemeDescriptor);

            var output = Instances.EnumerableOperator.From($"Typing Scheme Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }
    }
}
