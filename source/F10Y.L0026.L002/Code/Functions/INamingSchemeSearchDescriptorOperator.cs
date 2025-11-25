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
    public partial interface INamingSchemeSearchDescriptorOperator :
        T002.INamingSchemeSearchDescriptorOperator,
        For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<INamingSchemeSearchDescriptor>,
        For_Bases_IPredicateOperator.IPredicateOperator<INamingSchemeSearchDescriptor, INamingSchemeDescriptor>
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public T002.INamingSchemeSearchDescriptorOperator _T002 => T002.NamingSchemeSearchDescriptorOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<INamingSchemeSearchDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<INamingSchemeSearchDescriptor>.TextHandlerSuites_ByType
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_NamingSchemeSearchDescriptors_ByType;

        Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<INamingSchemeSearchDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<INamingSchemeSearchDescriptor>.TextHandlerSuites_ByTypeName
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_NamingSchemeSearchDescriptors_ByTypeName;

        Dictionary<Type, For_PredicateProviderSuite.PredicateProviderSuite<INamingSchemeSearchDescriptor, INamingSchemeDescriptor>>
            For_Bases_IPredicateOperator.IPredicateOperator<INamingSchemeSearchDescriptor, INamingSchemeDescriptor>.PredicateProviderSuites_ByType =>
            Instances.PredicateProviderSuiteSets.For_NamingSchemeSearchDescriptors_ByType;


        public bool Evaluate(
            NamingSchemeSearchDescriptor_Enumeration searchDescriptor,
            INamingSchemeDescriptor descriptor)
        {
            var output = Instances.PredicateOperator.If_TypeIs_ElseFalse<IHas_NamingScheme>(
                descriptor,
                hasVisibility =>
                {
                    var output = hasVisibility.NamingScheme == searchDescriptor.NamingScheme;
                    return output;
                });

            return output;
        }

        public Func<INamingSchemeDescriptor, bool> Get_PredicateFor(NamingSchemeSearchDescriptor_Enumeration searchDescriptor)
            => descriptor => this.Evaluate(
                searchDescriptor,
                descriptor);

        public NamingSchemeSearchDescriptor_Enumeration From_SerializationType(Serialization_NamingSchemeSearchDescriptor_Enumeration namingSchemeSearchDescriptor)
        {
            var namingScheme = Instances.NamingSchemeOperator.From_String(namingSchemeSearchDescriptor.NamingScheme);

            var output = new NamingSchemeSearchDescriptor_Enumeration
            {
                NamingScheme = namingScheme
            };

            return output;
        }

        public Serialization_NamingSchemeSearchDescriptor_Enumeration To_SerializationType(NamingSchemeSearchDescriptor_Enumeration namingSchemeSearchDescriptor)
        {
            var namingScheme = Instances.NamingSchemeOperator.To_String(namingSchemeSearchDescriptor.NamingScheme);

            var output = new Serialization_NamingSchemeSearchDescriptor_Enumeration
            {
                NamingScheme = namingScheme
            };

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(NamingSchemeSearchDescriptor_Enumeration namingSchemeSearchDescriptor)
        {
            var namingScheme = Instances.NamingSchemeOperator.To_String(namingSchemeSearchDescriptor.NamingScheme);

            var output = Instances.EnumerableOperator.From($"{namingScheme}: naming scheme")
                ;

            return output;
        }

        public IEnumerable<string> To_Text(NamingSchemeSearchDescriptor_Enumeration namingSchemeSearchDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(namingSchemeSearchDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeName_OfDeclaredType(namingSchemeSearchDescriptor);

            var output = Instances.EnumerableOperator.From($"Naming Scheme Search Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }
    }
}
