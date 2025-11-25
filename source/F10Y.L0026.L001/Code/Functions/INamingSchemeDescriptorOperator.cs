using System;
using System.Collections.Generic;

using F10Y.L0000.Extensions;
using F10Y.L0001.L000.Extensions;
using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0026.L001
{
    [FunctionsMarker]
    public partial interface INamingSchemeDescriptorOperator :
        T001.INamingSchemeDescriptorOperator,
        For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<INamingSchemeDescriptor>
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public T001.INamingSchemeDescriptorOperator _T001 => T001.NamingSchemeDescriptorOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<INamingSchemeDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<INamingSchemeDescriptor>.TextHandlerSuites_ByType
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_NamingSchemeDescriptors_ByType;

        Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<INamingSchemeDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<INamingSchemeDescriptor>.TextHandlerSuites_ByTypeName
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_NamingSchemeDescriptors_ByTypeName;


        public NamingSchemeDescriptor_Enumeration From_SerializationType(Serialization_NamingSchemeDescriptor_Enumeration namingSchemeDescriptor)
        {
            var namingScheme = Instances.NamingSchemeOperator.From_String(namingSchemeDescriptor.NamingScheme);

            var output = new NamingSchemeDescriptor_Enumeration
            {
                NamingScheme = namingScheme
            };

            return output;
        }

        public Serialization_NamingSchemeDescriptor_Enumeration To_SerializationType(NamingSchemeDescriptor_Enumeration namingSchemeDescriptor)
        {
            var namingScheme = Instances.NamingSchemeOperator.To_String(namingSchemeDescriptor.NamingScheme);

            var output = new Serialization_NamingSchemeDescriptor_Enumeration
            {
                NamingScheme = namingScheme
            };

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(NamingSchemeDescriptor_Enumeration namingSchemeDescriptor)
        {
            var schemeToken = Instances.EnumerationOperator.Get_StringRepresentation(namingSchemeDescriptor.NamingScheme);

            var output = Instances.EnumerableOperator.From($"{schemeToken}: implementation scheme")
                ;

            return output;
        }

        public IEnumerable<string> To_Text(NamingSchemeDescriptor_Enumeration namingSchemeDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(namingSchemeDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeName_OfDeclaredType(namingSchemeDescriptor);

            var output = Instances.EnumerableOperator.From($"Naming Scheme Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }
    }
}
