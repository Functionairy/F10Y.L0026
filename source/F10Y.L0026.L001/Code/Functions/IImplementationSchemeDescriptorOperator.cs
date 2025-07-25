using System;
using System.Collections.Generic;

using F10Y.L0000.Extensions;
using F10Y.L0001.L000.Extensions;
using F10Y.T0002;


namespace F10Y.L0026.L001
{
    [FunctionsMarker]
    public partial interface IImplementationSchemeDescriptorOperator :
        T001.IImplementationSchemeDescriptorOperator,
        For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IImplementationSchemeDescriptor>
    {
        Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IImplementationSchemeDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IImplementationSchemeDescriptor>.TextHandlerSuites_ByType
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_ImplementationSchemeDescriptors_ByType;

        Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IImplementationSchemeDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IImplementationSchemeDescriptor>.TextHandlerSuites_ByTypeName
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_ImplementationSchemeDescriptors_ByTypeName;


        public ImplementationSchemeDescriptor_Enumeration From_SerializationType(Serialization_ImplementationSchemeDescriptor_Enumeration implementationSchemeDescriptor)
        {
            var implementationScheme = Instances.EnumerationOperator.Get_Value<ImplementationScheme>(implementationSchemeDescriptor.ImplementationScheme);

            var output = new ImplementationSchemeDescriptor_Enumeration
            {
                ImplementationScheme = implementationScheme
            };

            return output;
        }

        public Serialization_ImplementationSchemeDescriptor_Enumeration To_SerializationType(ImplementationSchemeDescriptor_Enumeration implementationSchemeDescriptor)
        {
            var implementationScheme = Instances.EnumerationOperator.Get_StringRepresentation(implementationSchemeDescriptor.ImplementationScheme);

            var output = new Serialization_ImplementationSchemeDescriptor_Enumeration
            {
                ImplementationScheme = implementationScheme
            };

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(ImplementationSchemeDescriptor_Enumeration implementationSchemeDescriptor)
        {
            var schemeToken = Instances.EnumerationOperator.Get_StringRepresentation(implementationSchemeDescriptor.ImplementationScheme);

            var output = Instances.EnumerableOperator.From($"{schemeToken}: implementation scheme")
                ;

            return output;
        }

        public IEnumerable<string> To_Text(ImplementationSchemeDescriptor_Enumeration implementationSchemeDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(implementationSchemeDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(implementationSchemeDescriptor);

            var output = Instances.EnumerableOperator.From($"Implementation Scheme Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }
    }
}
