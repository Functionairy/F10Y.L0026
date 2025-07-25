using System;
using System.Collections.Generic;

using F10Y.L0000.Extensions;
using F10Y.L0001.L000.Extensions;
using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0026.L004
{
    [FunctionsMarker]
    public partial interface IInstanceSetTypeSearchDescriptorOperator :
        T004.IInstanceSetTypeSearchDescriptorOperator,
        For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IInstanceSetTypeSearchDescriptor>,
        For_Bases_IPredicateOperator.IPredicateOperator<IInstanceSetTypeSearchDescriptor, IInstanceSetTypeDescriptor>
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public T004.IInstanceSetTypeSearchDescriptorOperator _T004 => T004.InstanceSetTypeSearchDescriptorOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetTypeSearchDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IInstanceSetTypeSearchDescriptor>.TextHandlerSuites_ByType
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_InstanceSetTypeSearchDescriptors_ByType;

        Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetTypeSearchDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IInstanceSetTypeSearchDescriptor>.TextHandlerSuites_ByTypeName
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_InstanceSetTypeSearchDescriptors_ByTypeName;

        Dictionary<Type, For_PredicateProviderSuite.PredicateProviderSuite<IInstanceSetTypeSearchDescriptor, IInstanceSetTypeDescriptor>>
            For_Bases_IPredicateOperator.IPredicateOperator<IInstanceSetTypeSearchDescriptor, IInstanceSetTypeDescriptor>.PredicateProviderSuites_ByType =>
            Instances.PredicateProviderSuiteSets.For_InstanceSetTypeSearchDescriptors_ByType;


        public InstanceSetTypeSearchDescriptor_Name From_SerializationType(Serialization_InstanceSetTypeSearchDescriptor_Name instanceSetTypeSearchDescriptor)
        {
            var equalityOperationDescriptor = Instances.EqualityOperationDescriptorOperator.From_JsonSerializationObject(instanceSetTypeSearchDescriptor.EqualityOperationDescriptor);

            var output = new InstanceSetTypeSearchDescriptor_Name
            {
                EqualityOperationDescriptor = equalityOperationDescriptor,
                InstanceSetType_Name = instanceSetTypeSearchDescriptor.InstanceSetType_Name
            };

            return output;
        }

        public Serialization_InstanceSetTypeSearchDescriptor_Name To_SerializationType(InstanceSetTypeSearchDescriptor_Name instanceSetTypeSearchDescriptor)
        {
            var equalityOperationDescriptor = Instances.EqualityOperationDescriptorOperator.To_JsonSerializationObject(instanceSetTypeSearchDescriptor.EqualityOperationDescriptor);

            var output = new Serialization_InstanceSetTypeSearchDescriptor_Name
            {
                EqualityOperationDescriptor = equalityOperationDescriptor,
                InstanceSetType_Name = instanceSetTypeSearchDescriptor.InstanceSetType_Name
            };

            return output;
        }

        public bool Evaluate(
            InstanceSetTypeSearchDescriptor_Name searchDescriptor,
            IInstanceSetTypeDescriptor instanceSetTypeDescriptor)
        {
            var output = Instances.PredicateOperator.If_TypeIs_ElseFalse<IHas_InstanceSetTypeName>(
                instanceSetTypeDescriptor,
                descriptor =>
                {
                    var equalityOperation_Predicate = Instances.EqualityOperationDescriptorOperator.Get_Predicate_Synchronous(searchDescriptor.EqualityOperationDescriptor);

                    var output = equalityOperation_Predicate(
                        searchDescriptor.InstanceSetType_Name,
                        descriptor.InstanceSetType_Name);

                    return output;
                });

            return output;
        }

        public Func<IInstanceSetTypeDescriptor, bool> Get_PredicateFor(InstanceSetTypeSearchDescriptor_Name searchDescriptor)
            => descriptor => this.Evaluate(
                searchDescriptor,
                descriptor);

        public IEnumerable<string> To_Text_ContentOnly(InstanceSetTypeSearchDescriptor_Name instanceSetTypeSearchDescriptor)
        {
            var equalityOperation_Lines = Instances.EqualityOperationDescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceSetTypeSearchDescriptor.EqualityOperationDescriptor);

            var output = Instances.EnumerableOperator.From($"{instanceSetTypeSearchDescriptor.InstanceSetType_Name}: instance set type")
                .Append_Many(Instances.EnumerableOperator.From("Equality Operation:")
                    .Append_Many(equalityOperation_Lines.Entab())
                )
                ;

            return output;
        }

        public IEnumerable<string> To_Text(InstanceSetTypeSearchDescriptor_Name instanceSetTypeSearchDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(instanceSetTypeSearchDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(instanceSetTypeSearchDescriptor);

            var output = Instances.EnumerableOperator.From($"Instance Set Type Search Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }
    }
}
