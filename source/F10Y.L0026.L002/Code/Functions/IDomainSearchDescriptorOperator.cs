using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0026.L002
{
    [FunctionsMarker]
    public partial interface IDomainSearchDescriptorOperator :
        T002.IDomainSearchDescriptorOperator,
        For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IDomainSearchDescriptor>,
        For_Bases_IPredicateOperator.IPredicateOperator<IDomainSearchDescriptor, IDomainDescriptor>
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public T002.IDomainSearchDescriptorOperator _T002 => T002.DomainSearchDescriptorOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDomainSearchDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IDomainSearchDescriptor>.TextHandlerSuites_ByType
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_DomainSearchDescriptors_ByType;

        Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDomainSearchDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IDomainSearchDescriptor>.TextHandlerSuites_ByTypeName
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_DomainSearchDescriptors_ByTypeName;

        Dictionary<Type, For_PredicateProviderSuite.PredicateProviderSuite<IDomainSearchDescriptor, IDomainDescriptor>>
            For_Bases_IPredicateOperator.IPredicateOperator<IDomainSearchDescriptor, IDomainDescriptor>.PredicateProviderSuites_ByType =>
            Instances.PredicateProviderSuiteSets.For_DomainSearchDescriptors_ByType;


        public bool Evaluate(
            DomainSearchDescriptor searchDescriptor,
            IDomainDescriptor descriptor)
        {
            var hasDomain_Stool = Instances.PredicateOperator.If_TypeIs_ElseFalse<IHas_Domain>(
                descriptor,
                hasDomain =>
                {
                    var output = hasDomain.Domain == searchDescriptor.Domain;
                    return output;
                });

            if (hasDomain_Stool)
            {
                return true;
            }

            var hasDomains_Stool = Instances.PredicateOperator.If_TypeIs_ElseFalse<IHas_Domains>(
                descriptor,
                hasDomains =>
                {
                    var output = Instances.ArrayOperator.Contains(
                        hasDomains.Domains,
                        searchDescriptor.Domain);

                    return output;
                });

            if (hasDomains_Stool)
            {
                return true;
            }

            return false;
        }

        public Func<IDomainDescriptor, bool> Get_PredicateFor(DomainSearchDescriptor searchDescriptor)
            => descriptor => this.Evaluate(
                searchDescriptor,
                descriptor);

        public bool Evaluate(
            DomainSearchDescriptor_Set searchDescriptor,
            IDomainDescriptor descriptor)
        {
            var hasDomain_Stool = Instances.PredicateOperator.If_TypeIs_ElseFalse<IHas_Domain>(
                descriptor,
                hasDomain =>
                {
                    var predicate = Instances.SetEqualityOperationDescriptorOperator.Get_Predicate_Synchronous(searchDescriptor.SetEqualityOperationDescriptor);

                    var domainSet = Instances.ArrayOperator.From(hasDomain.Domain);

                    // Order is important: is set A a superset of set B?
                    var output = predicate(
                        // Is A
                        domainSet,
                        searchDescriptor.Domains);

                    return output;
                });

            if (hasDomain_Stool)
            {
                return true;
            }

            var hasDomains_Stool = Instances.PredicateOperator.If_TypeIs_ElseFalse<IHas_Domains>(
                descriptor,
                hasDomains =>
                {
                    var predicate = Instances.SetEqualityOperationDescriptorOperator.Get_Predicate_Synchronous(searchDescriptor.SetEqualityOperationDescriptor);

                    // Order is important: is set A a superset of set B?
                    var output = predicate(
                        // Is A
                        hasDomains.Domains,
                        searchDescriptor.Domains);

                    return output;
                });

            if (hasDomains_Stool)
            {
                return true;
            }

            return false;
        }

        public Func<IDomainDescriptor, bool> Get_PredicateFor(DomainSearchDescriptor_Set searchDescriptor)
            => descriptor => this.Evaluate(
                searchDescriptor,
                descriptor);

        public DomainSearchDescriptor_Set From_SerializationType(Serialization_DomainSearchDescriptor_Set domainSearchDescriptor)
        {
            var setEqualityOperationDescriptor = Instances.SetEqualityOperationDescriptorOperator.From_JsonSerializationObject(domainSearchDescriptor.SetEqualityOperationDescriptor);

            var output = new DomainSearchDescriptor_Set
            {
                Domains = domainSearchDescriptor.Domains,
                SetEqualityOperationDescriptor = setEqualityOperationDescriptor,
            };

            return output;
        }

        public Serialization_DomainSearchDescriptor_Set To_SerializationType(DomainSearchDescriptor_Set domainSearchDescriptor)
        {
            var setEqualityOperationDescriptor = Instances.SetEqualityOperationDescriptorOperator.To_JsonSerializationObject(domainSearchDescriptor.SetEqualityOperationDescriptor);

            var output = new Serialization_DomainSearchDescriptor_Set
            {
                Domains = domainSearchDescriptor.Domains,
                SetEqualityOperationDescriptor = setEqualityOperationDescriptor,
            };

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(DomainSearchDescriptor domainSearchDescriptor)
        {
            var output = Instances.EnumerableOperator.From($"{domainSearchDescriptor.Domain}: domain")
                ;

            return output;
        }

        public IEnumerable<string> To_Text(DomainSearchDescriptor domainSearchDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(domainSearchDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeName_OfDeclaredType(domainSearchDescriptor);

            var output = Instances.EnumerableOperator.From($"Domain Search Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(DomainSearchDescriptor_Set domainSearchDescriptor)
        {
            var count = Instances.ArrayOperator.Get_Count(domainSearchDescriptor.Domains);

            var output = Instances.EnumerableOperator.From($"{count}: domain count")
                .Append_Many(domainSearchDescriptor.Domains
                    .Order_Alphabetically()
                    .Append(Instances.Texts.Order_Alphabetical_Parenthetical)
                    .Entab()
                )
                ;

            return output;
        }

        public IEnumerable<string> To_Text(DomainSearchDescriptor_Set domainSearchDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(domainSearchDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeName_OfDeclaredType(domainSearchDescriptor);

            var output = Instances.EnumerableOperator.From($"Domain Search Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }
    }
}
