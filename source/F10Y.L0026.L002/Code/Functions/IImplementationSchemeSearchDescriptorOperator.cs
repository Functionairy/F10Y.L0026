using System;
using System.Collections.Generic;

using F10Y.L0000.Extensions;
using F10Y.L0001.L000.Extensions;
using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0026.L002
{
    [FunctionsMarker]
    public partial interface IImplementationSchemeSearchDescriptorOperator :
        T002.IImplementationSchemeSearchDescriptorOperator,
        For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IImplementationSchemeSearchDescriptor>,
        For_Bases_IPredicateOperator.IPredicateOperator<IImplementationSchemeSearchDescriptor, IImplementationSchemeDescriptor>
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public T002.IImplementationSchemeSearchDescriptorOperator _T002 => T002.ImplementationSchemeSearchDescriptorOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IImplementationSchemeSearchDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IImplementationSchemeSearchDescriptor>.TextHandlerSuites_ByType
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_ImplementationSchemeSearchDescriptors_ByType;

        Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IImplementationSchemeSearchDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IImplementationSchemeSearchDescriptor>.TextHandlerSuites_ByTypeName
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_ImplementationSchemeSearchDescriptors_ByTypeName;

        Dictionary<Type, For_PredicateProviderSuite.PredicateProviderSuite<IImplementationSchemeSearchDescriptor, IImplementationSchemeDescriptor>>
            For_Bases_IPredicateOperator.IPredicateOperator<IImplementationSchemeSearchDescriptor, IImplementationSchemeDescriptor>.PredicateProviderSuites_ByType =>
            Instances.PredicateProviderSuiteSets.For_ImplementationSchemeSearchDescriptors_ByType;


        public bool Evaluate(
            ImplementationSchemeSearchDescriptor_Enumeration searchDescriptor,
            IImplementationSchemeDescriptor descriptor)
        {
            var output = Instances.PredicateOperator.If_TypeIs_ElseFalse<IHas_ImplementationScheme>(
                descriptor,
                hasVisibility =>
                {
                    var output = hasVisibility.ImplementationScheme == searchDescriptor.ImplementationScheme;
                    return output;
                });

            return output;
        }

        public Func<IImplementationSchemeDescriptor, bool> Get_PredicateFor(ImplementationSchemeSearchDescriptor_Enumeration searchDescriptor)
            => descriptor => this.Evaluate(
                searchDescriptor,
                descriptor);

        public ImplementationSchemeSearchDescriptor_Enumeration From_SerializationType(Serialization_ImplementationSchemeSearchDescriptor_Enumeration implementationSchemeSearchDescriptor)
        {
            var implementationScheme = Instances.ImplementationSchemeOperator.From_String(implementationSchemeSearchDescriptor.ImplementationScheme);

            var output = new ImplementationSchemeSearchDescriptor_Enumeration
            {
                ImplementationScheme = implementationScheme
            };

            return output;
        }

        public Serialization_ImplementationSchemeSearchDescriptor_Enumeration To_SerializationType(ImplementationSchemeSearchDescriptor_Enumeration implementationSchemeSearchDescriptor)
        {
            var implementationScheme = Instances.ImplementationSchemeOperator.To_String(implementationSchemeSearchDescriptor.ImplementationScheme);

            var output = new Serialization_ImplementationSchemeSearchDescriptor_Enumeration
            {
                ImplementationScheme = implementationScheme
            };

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(ImplementationSchemeSearchDescriptor_Enumeration implementationSchemeSearchDescriptor)
        {
            var implementationScheme = Instances.ImplementationSchemeOperator.To_String(implementationSchemeSearchDescriptor.ImplementationScheme);

            var output = Instances.EnumerableOperator.From($"{implementationScheme}: implementation scheme")
                ;

            return output;
        }

        public IEnumerable<string> To_Text(ImplementationSchemeSearchDescriptor_Enumeration implementationSchemeSearchDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(implementationSchemeSearchDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeName_OfDeclaredType(implementationSchemeSearchDescriptor);

            var output = Instances.EnumerableOperator.From($"Implementation Scheme Search Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }
    }
}
