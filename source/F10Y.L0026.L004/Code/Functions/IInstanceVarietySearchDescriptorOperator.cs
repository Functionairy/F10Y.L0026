using System;
using System.Collections.Generic;

using F10Y.L0000.Extensions;
using F10Y.L0001.L000.Extensions;
using F10Y.T0002;
using F10Y.T0011;

using IEqualityOperationDescriptors = F10Y.L0062.L002.Z000.IEqualityOperationDescriptors;


namespace F10Y.L0026.L004
{
    [FunctionsMarker]
    public partial interface IInstanceVarietySearchDescriptorOperator :
        T004.IInstanceVarietySearchDescriptorOperator,
        For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IInstanceVarietySearchDescriptor>,
        For_Bases_IPredicateOperator.IPredicateOperator<IInstanceVarietySearchDescriptor, IInstanceVarietyDescriptor>
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public T004.IInstanceVarietySearchDescriptorOperator _T004 => T004.InstanceVarietySearchDescriptorOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceVarietySearchDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IInstanceVarietySearchDescriptor>.TextHandlerSuites_ByType
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_InstanceVarietySearchDescriptors_ByType;

        Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceVarietySearchDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IInstanceVarietySearchDescriptor>.TextHandlerSuites_ByTypeName
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_InstanceVarietySearchDescriptors_ByTypeName;

        Dictionary<Type, For_PredicateProviderSuite.PredicateProviderSuite<IInstanceVarietySearchDescriptor, IInstanceVarietyDescriptor>>
            For_Bases_IPredicateOperator.IPredicateOperator<IInstanceVarietySearchDescriptor, IInstanceVarietyDescriptor>.PredicateProviderSuites_ByType =>
            Instances.PredicateProviderSuiteSets.For_InstanceVarietySearchDescriptors_ByType;


        public bool Evaluate(
            InstanceVarietySearchDescriptor_Values searchDescriptor,
            IInstanceVarietyDescriptor descriptor)
        {
            var output = Instances.PredicateOperator.If_TypeIs_ElseFalse<InstanceVarietyDescriptor_Values>(
                descriptor,
                instanceVarietyDescriptor =>
                {
                    var has_implementationSchemePredicate = Instances.ImplementationSchemeSearchDescriptorOperator.Has_Predicate_Synchronous(
                        searchDescriptor.ImplementationScheme,
                        out var implementationSchemePredicate_OrDefault);

                    if (has_implementationSchemePredicate)
                    {
                        var implementationSchemeStool = implementationSchemePredicate_OrDefault(instanceVarietyDescriptor.ImplementationScheme);
                        if (!implementationSchemeStool)
                        {
                            return false;
                        }
                    }

                    var has_namingSchemePredicate = Instances.NamingSchemeSearchDescriptorOperator.Has_Predicate_Synchronous(
                        searchDescriptor.NamingScheme,
                        out var namingSchemePredicate_OrDefault);

                    if (has_namingSchemePredicate)
                    {
                        var namingSchemeStool = namingSchemePredicate_OrDefault(instanceVarietyDescriptor.NamingScheme);
                        if (!namingSchemeStool)
                        {
                            return false;
                        }
                    }

                    var has_typingSchemePredicate = Instances.TypingSchemeSearchDescriptorOperator.Has_Predicate_Synchronous(
                        searchDescriptor.TypingScheme,
                        out var typingSchemePredicate_OrDefault);

                    if (has_typingSchemePredicate)
                    {
                        var typingSchemeStool = typingSchemePredicate_OrDefault(instanceVarietyDescriptor.TypingScheme);
                        if (!typingSchemeStool)
                        {
                            return false;
                        }
                    }

                    // Else, return true!
                    return true;
                });

            return output;
        }

        public Func<IInstanceVarietyDescriptor, bool> Get_PredicateFor(InstanceVarietySearchDescriptor_Values searchDescriptor)
            => descriptor => this.Evaluate(
                searchDescriptor,
                descriptor);

        public bool Evaluate(
            InstanceVarietySearchDescriptor_Name searchDescriptor,
            IInstanceVarietyDescriptor descriptor)
        {
            // First check for null.
            var isNull = Instances.NullOperator.Is_Null(descriptor);
            if (isNull)
            {
                return false;
            }

            // Then check if the instance variety descriptor is an aggregate.
            // Use ANY logic.
            var aggregateResult = Instances.PredicateOperator.If_TypeIs_ElseFalse<IEnumerable<IInstanceVarietyDescriptor>>(
                descriptor,
                aggregate =>
                {
                    foreach (var descriptor in aggregate)
                    {
                        var output = this.Evaluate(
                            searchDescriptor,
                            descriptor);

                        if (output)
                        {
                            return true;
                        }
                    }

                    return false;
                });

            if (aggregateResult)
            {
                return true;
            }

            // Then handle the ALL instance variety type.
            var is_DescriptorAll = Instances.TypeOperator.Is_Type<InstanceVarietyDescriptor_All>(descriptor);
            if (is_DescriptorAll)
            {
                var output = searchDescriptor.Include_All;
                return output;
            }

            // Now handle individual values.
            var equalityOperation = Instances.EqualityOperationDescriptorOperator.Get_Predicate_Synchronous(searchDescriptor.EqualityOperationDescriptor);

            // Single valued.
            var instanceVarietyName_Stool = Instances.PredicateOperator.If_TypeIs_ElseFalse<IHas_InstanceVarietyName>(
                descriptor,
                has_InstanceVarietyName =>
                {
                    var output = equalityOperation(
                        has_InstanceVarietyName.InstanceVariety_Name,
                        searchDescriptor.InstanceVariety_Name);

                    return output;
                });

            if (instanceVarietyName_Stool)
            {
                return true;
            }

            // Multiple valued.
            var instanceVarietyNames_Stool = Instances.PredicateOperator.If_TypeIs_ElseFalse<IHas_InstanceVarietyNames>(
                descriptor,
                has_InstanceVarietyNames =>
                {
                    foreach (var instanceVarietyName in has_InstanceVarietyNames.InstanceVariety_Names)
                    {
                        var stool = equalityOperation(instanceVarietyName, searchDescriptor.InstanceVariety_Name);
                        if (stool)
                        {
                            return true;
                        }
                    }

                    return false;
                });

            if (instanceVarietyName_Stool)
            {
                return true;
            }

            // Finally, return false.
            return false;
        }

        public Func<IInstanceVarietyDescriptor, bool> Get_PredicateFor(InstanceVarietySearchDescriptor_Name searchDescriptor)
            => descriptor => this.Evaluate(
                searchDescriptor,
                descriptor);

        /// <summary>
        /// Uses <see cref="IEqualityOperationDescriptors.For_String_Simple"/>.
        /// </summary>
        public InstanceVarietySearchDescriptor_Name From(
            string instanceVariety_Name,
            bool includeAll = false)
            => this.From(
                instanceVariety_Name,
                Instances.EqualityOperationDescriptors.For_String_Simple,
                includeAll);

        public InstanceVarietySearchDescriptor_Values From_SerializationType(Serialization_InstanceVarietySearchDescriptor_Values instanceVarietySearchDescriptor)
        {
            var implementationSearchDescriptor = Instances.ImplementationSchemeSearchDescriptorOperator.From_JsonSerializationObject(instanceVarietySearchDescriptor.ImplementationScheme);
            var namingSearchDescriptor = Instances.NamingSchemeSearchDescriptorOperator.From_JsonSerializationObject(instanceVarietySearchDescriptor.NamingScheme);
            var typingSearchDescriptor = Instances.TypingSchemeSearchDescriptorOperator.From_JsonSerializationObject(instanceVarietySearchDescriptor.TypingScheme);

            var output = new InstanceVarietySearchDescriptor_Values
            {
                ImplementationScheme = implementationSearchDescriptor,
                NamingScheme = namingSearchDescriptor,
                TypingScheme = typingSearchDescriptor,
            };

            return output;
        }

        public Serialization_InstanceVarietySearchDescriptor_Values To_SerializationType(InstanceVarietySearchDescriptor_Values instanceVarietySearchDescriptor)
        {
            var implementationSearchDescriptor = Instances.ImplementationSchemeSearchDescriptorOperator.To_JsonSerializationObject(instanceVarietySearchDescriptor.ImplementationScheme);
            var namingSearchDescriptor = Instances.NamingSchemeSearchDescriptorOperator.To_JsonSerializationObject(instanceVarietySearchDescriptor.NamingScheme);
            var typingSearchDescriptor = Instances.TypingSchemeSearchDescriptorOperator.To_JsonSerializationObject(instanceVarietySearchDescriptor.TypingScheme);

            var output = new Serialization_InstanceVarietySearchDescriptor_Values
            {
                ImplementationScheme = implementationSearchDescriptor,
                NamingScheme = namingSearchDescriptor,
                TypingScheme = typingSearchDescriptor,
            };

            return output;
        }

        public InstanceVarietySearchDescriptor_Name From_SerializationType(Serialization_InstanceVarietySearchDescriptor_Name instanceVarietySearchDescriptor)
        {
            var equalityOperationDescriptor = Instances.EqualityOperationDescriptorOperator.From_JsonSerializationObject(instanceVarietySearchDescriptor.EqualityOperationDescriptor);

            var output = new InstanceVarietySearchDescriptor_Name
            {
                EqualityOperationDescriptor = equalityOperationDescriptor,
                Include_All = instanceVarietySearchDescriptor.Include_All,
                InstanceVariety_Name = instanceVarietySearchDescriptor.InstanceVariety_Name
            };

            return output;
        }

        public Serialization_InstanceVarietySearchDescriptor_Name To_SerializationType(InstanceVarietySearchDescriptor_Name instanceVarietySearchDescriptor)
        {
            var equalityOperationDescriptor = Instances.EqualityOperationDescriptorOperator.To_JsonSerializationObject(instanceVarietySearchDescriptor.EqualityOperationDescriptor);

            var output = new Serialization_InstanceVarietySearchDescriptor_Name
            {
                EqualityOperationDescriptor = equalityOperationDescriptor,
                Include_All = instanceVarietySearchDescriptor.Include_All,
                InstanceVariety_Name = instanceVarietySearchDescriptor.InstanceVariety_Name
            };

            return output;
        }

        public IEnumerable<string> To_Text(InstanceVarietySearchDescriptor_Values instanceVarietySearchDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(instanceVarietySearchDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(instanceVarietySearchDescriptor);

            var output = Instances.EnumerableOperator.From($"Instance Variety Search Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(InstanceVarietySearchDescriptor_Values instanceVarietySearchDescriptor)
        {
            var implementationScheme_Lines = Instances.ImplementationSchemeSearchDescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceVarietySearchDescriptor.ImplementationScheme);
            var namingScheme_Lines = Instances.NamingSchemeSearchDescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceVarietySearchDescriptor.NamingScheme);
            var typingScheme_Lines = Instances.TypingSchemeSearchDescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceVarietySearchDescriptor.TypingScheme);

            var output = Instances.EnumerableOperator.From(
                Instances.EnumerableOperator.From("Implementation:")
                    .Append_Many(implementationScheme_Lines.Entab())
                    ,
                Instances.EnumerableOperator.From("Naming:")
                    .Append_Many(namingScheme_Lines.Entab())
                    ,
                Instances.EnumerableOperator.From("Typing:")
                    .Append_Many(typingScheme_Lines.Entab())
                )
                ;

            return output;
        }

        public IEnumerable<string> To_Text(InstanceVarietySearchDescriptor_Name instanceVarietySearchDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(instanceVarietySearchDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(instanceVarietySearchDescriptor);

            var output = Instances.EnumerableOperator.From($"Instance Variety Search Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(InstanceVarietySearchDescriptor_Name instanceVarietySearchDescriptor)
        {
            var equalityOperation_Lines = Instances.EqualityOperationDescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceVarietySearchDescriptor.EqualityOperationDescriptor);

            var output = Instances.EnumerableOperator.From(
                Instances.EnumerableOperator.From($"{instanceVarietySearchDescriptor.InstanceVariety_Name}: instance variety name")
                    ,
                Instances.EnumerableOperator.From("Equality Operation:")
                    .Append_Many(equalityOperation_Lines.Entab())
                )
                ;

            return output;
        }
    }
}
