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
    public partial interface IOrganizationSearchDescriptorOperator :
        T002.IOrganizationSearchDescriptorOperator,
        For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IOrganizationSearchDescriptor>,
        For_Bases_IPredicateOperator.IPredicateOperator<IOrganizationSearchDescriptor, IOrganizationDescriptor>
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public T002.IOrganizationSearchDescriptorOperator _T002 => T002.OrganizationSearchDescriptorOperator.Instance;
        
#pragma warning restore IDE1006 // Naming Styles


        Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IOrganizationSearchDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IOrganizationSearchDescriptor>.TextHandlerSuites_ByType
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_OrganizationSerachDescriptors_ByType;

        Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IOrganizationSearchDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IOrganizationSearchDescriptor>.TextHandlerSuites_ByTypeName
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_OrganizationSerachDescriptors_ByTypeName;

        Dictionary<Type, For_PredicateProviderSuite.PredicateProviderSuite<IOrganizationSearchDescriptor, IOrganizationDescriptor>>
            For_Bases_IPredicateOperator.IPredicateOperator<IOrganizationSearchDescriptor, IOrganizationDescriptor>.PredicateProviderSuites_ByType =>
            Instances.PredicateProviderSuiteSets.For_OrganizationSearchDescriptors_ByType;


        public bool Evaluate(
            OrganizationSearchDescriptor_Name searchDescriptor,
            IOrganizationDescriptor organizationDescriptor)
        {
            var output = Instances.PredicateOperator.If_TypeIs_ElseFalse<IHas_OrganizationName>(
                organizationDescriptor,
                descriptor =>
                {
                    var equalityOperation_Predicate = Instances.EqualityOperationDescriptorOperator.Get_Predicate_Synchronous(searchDescriptor.EqualityOperationDescriptor);

                    var output = equalityOperation_Predicate(
                        searchDescriptor.Organization_Name,
                        descriptor.Organization_Name);

                    return output;
                });

            return output;
        }

        public Func<IOrganizationDescriptor, bool> Get_PredicateFor(OrganizationSearchDescriptor_Name searchDescriptor)
            => descriptor => this.Evaluate(
                searchDescriptor,
                descriptor);

        public OrganizationSearchDescriptor_Name From_SerializationType(Serialization_OrganizationSearchDescriptor_Name organizationSearchDescriptor)
        {
            var equalityOperationDescriptor = Instances.EqualityOperationDescriptorOperator.From_JsonSerializationObject(organizationSearchDescriptor.EqualityOperationDescriptor);

            var output = new OrganizationSearchDescriptor_Name
            {
                EqualityOperationDescriptor = equalityOperationDescriptor,
                Organization_Name = organizationSearchDescriptor.Organization_Name
            };

            return output;
        }

        public Serialization_OrganizationSearchDescriptor_Name To_SerializationType(OrganizationSearchDescriptor_Name organizationSearchDescriptor)
        {
            var equalityOperationDescriptor = Instances.EqualityOperationDescriptorOperator.To_JsonSerializationObject(organizationSearchDescriptor.EqualityOperationDescriptor);

            var output = new Serialization_OrganizationSearchDescriptor_Name
            {
                EqualityOperationDescriptor = equalityOperationDescriptor,
                Organization_Name = organizationSearchDescriptor.Organization_Name
            };

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(OrganizationSearchDescriptor_Name organizationSearchDescriptor)
        {
            var equalityOperation_Lines = Instances.EqualityOperationDescriptorOperator.To_Text_ContentOnly_Noexceptive(organizationSearchDescriptor.EqualityOperationDescriptor);

            var output = Instances.EnumerableOperator.From($"{organizationSearchDescriptor.Organization_Name}: organization name")
                .Append_Many(Instances.EnumerableOperator.From("Equality Operation:")
                    .Append_Many(equalityOperation_Lines.Entab())
                )
                ;

            return output;
        }

        public IEnumerable<string> To_Text(OrganizationSearchDescriptor_Name organizationSearchDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(organizationSearchDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(organizationSearchDescriptor);

            var output = Instances.EnumerableOperator.From($"Organization Search Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }
    }
}
