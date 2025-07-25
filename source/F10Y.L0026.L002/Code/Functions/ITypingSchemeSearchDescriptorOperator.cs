using System;
using System.Collections.Generic;

using F10Y.L0000.Extensions;
using F10Y.L0001.L000.Extensions;
using F10Y.L0026.T000;
using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0026.L002
{
    [FunctionsMarker]
    public partial interface ITypingSchemeSearchDescriptorOperator :
        T002.ITypingSchemeSearchDescriptorOperator,
        For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<ITypingSchemeSearchDescriptor>,
        For_Bases_IPredicateOperator.IPredicateOperator<ITypingSchemeSearchDescriptor, ITypingSchemeDescriptor>
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public T002.ITypingSchemeSearchDescriptorOperator _T002 => T002.TypingSchemeSearchDescriptorOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<ITypingSchemeSearchDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<ITypingSchemeSearchDescriptor>.TextHandlerSuites_ByType
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_TypingSchemeSearchDescriptors_ByType;

        Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<ITypingSchemeSearchDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<ITypingSchemeSearchDescriptor>.TextHandlerSuites_ByTypeName
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_TypingSchemeSearchDescriptors_ByTypeName;

        Dictionary<Type, For_PredicateProviderSuite.PredicateProviderSuite<ITypingSchemeSearchDescriptor, ITypingSchemeDescriptor>>
            For_Bases_IPredicateOperator.IPredicateOperator<ITypingSchemeSearchDescriptor, ITypingSchemeDescriptor>.PredicateProviderSuites_ByType =>
            Instances.PredicateProviderSuiteSets.For_TypingSchemeSearchDescriptors_ByType;


        public bool Evaluate(
            TypingSchemeSearchDescriptor_Enumeration searchDescriptor,
            ITypingSchemeDescriptor descriptor)
        {
            var output = Instances.PredicateOperator.If_TypeIs_ElseFalse<IHas_TypingScheme>(
                descriptor,
                hasVisibility =>
                {
                    var output = hasVisibility.TypingScheme == searchDescriptor.TypingScheme;
                    return output;
                });

            return output;
        }

        public Func<ITypingSchemeDescriptor, bool> Get_PredicateFor(TypingSchemeSearchDescriptor_Enumeration searchDescriptor)
            => descriptor => this.Evaluate(
                searchDescriptor,
                descriptor);

        public TypingSchemeSearchDescriptor_Enumeration From_SerializationType(Serialization_TypingSchemeSearchDescriptor_Enumeration implementationSchemeSearchDescriptor)
        {
            var typingScheme = Instances.TypingSchemeOperator.From_String(implementationSchemeSearchDescriptor.TypingScheme);

            var output = new TypingSchemeSearchDescriptor_Enumeration
            {
                TypingScheme = typingScheme
            };

            return output;
        }

        public Serialization_TypingSchemeSearchDescriptor_Enumeration To_SerializationType(TypingSchemeSearchDescriptor_Enumeration implementationSchemeSearchDescriptor)
        {
            var typingScheme = Instances.TypingSchemeOperator.To_String(implementationSchemeSearchDescriptor.TypingScheme);

            var output = new Serialization_TypingSchemeSearchDescriptor_Enumeration
            {
                TypingScheme = typingScheme
            };

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(TypingSchemeSearchDescriptor_Enumeration typingSchemeSearchDescriptor)
        {
            var typingScheme = Instances.TypingSchemeOperator.To_String(typingSchemeSearchDescriptor.TypingScheme);

            var output = Instances.EnumerableOperator.From($"{typingScheme}: typing scheme")
                ;

            return output;
        }

        public IEnumerable<string> To_Text(TypingSchemeSearchDescriptor_Enumeration typingSchemeSearchDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(typingSchemeSearchDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(typingSchemeSearchDescriptor);

            var output = Instances.EnumerableOperator.From($"Typing Scheme Search Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }
    }
}
