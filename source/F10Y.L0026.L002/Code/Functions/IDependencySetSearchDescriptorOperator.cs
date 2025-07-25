using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.L0000.Extensions;
using F10Y.T0002;


namespace F10Y.L0026.L002
{
    [FunctionsMarker]
    public partial interface IDependencySetSearchDescriptorOperator :
        For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IDependencySetSearchDescriptor>,
        For_Bases_IPredicateOperator.IPredicateOperator<IDependencySetSearchDescriptor, IDependencySetDescriptor>
    {
        Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDependencySetSearchDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IDependencySetSearchDescriptor>.TextHandlerSuites_ByType
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_DependencySetSearchDescriptors_ByType;

        Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDependencySetSearchDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IDependencySetSearchDescriptor>.TextHandlerSuites_ByTypeName
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_DependencySetSearchDescriptors_ByTypeName;

        Dictionary<Type, For_PredicateProviderSuite.PredicateProviderSuite<IDependencySetSearchDescriptor, IDependencySetDescriptor>>
            For_Bases_IPredicateOperator.IPredicateOperator<IDependencySetSearchDescriptor, IDependencySetDescriptor>.PredicateProviderSuites_ByType =>
            Instances.PredicateProviderSuiteSets.For_DependencySetSearchDescriptors_ByType;


        public bool Evaluate(
            DependencySetSearchDescriptor_Constrained searchDescriptor,
            IDependencySetDescriptor descriptor)
        {
            var dependencySet_Stool = Instances.PredicateOperator.If_TypeIs_ElseFalse<DependencySetDescriptor_Constrained>(
                descriptor,
                dependencySet =>
                {
                    var output = dependencySet.Context_Name == searchDescriptor.Context_Name;
                    return output;
                });

            if (dependencySet_Stool)
            {
                return true;
            }

            return false;
        }

        public bool Evaluate(
            DependencySetSearchDescriptor_DependencySearchDescriptor searchDescriptor,
            IDependencySetDescriptor descriptor)
        {
            var dependencySet_Stool = Instances.PredicateOperator.If_TypeIs_ElseFalse<DependencySetDescriptor>(
                descriptor,
                dependencySet =>
                {
                    var dependencyPredicate = Instances.DependencySearchDescriptorOperator.Get_Predicate_Synchronous(searchDescriptor.DependencySearchDescriptor);

                    var output = dependencySet.DependencyDescriptors
                        .Where(dependencyPredicate)
                        .Any();

                    return output;
                });

            if (dependencySet_Stool)
            {
                return true;
            }

            return false;
        }

        public bool Evaluate(
            DependencySetSearchDescriptor_Leaf searchDescriptor,
            IDependencySetDescriptor descriptor)
        {
            var dependencySet_Stool = Instances.PredicateOperator.If_TypeIs_ElseFalse<DependencySetDescriptor_Leaf>(
                descriptor,
                dependencySet =>
                {
                    var output = dependencySet.Context_Name == searchDescriptor.Context_Name;
                    return output;
                });

            if (dependencySet_Stool)
            {
                return true;
            }

            return false;
        }

        public bool Evaluate(
            DependencySetSearchDescriptor_None searchDescriptor,
            IDependencySetDescriptor descriptor)
        {
            var output = Instances.TypeOperator.Is_Type<DependencySetDescriptor_None>(descriptor);
            return output;
        }

        public bool Evaluate(
            DependencySetSearchDescriptor_Unconstrained searchDescriptor,
            IDependencySetDescriptor descriptor)
        {
            var output = Instances.TypeOperator.Is_Type<DependencySetDescriptor_Unconstrained>(descriptor);
            return output;
        }

        public DependencySetSearchDescriptor_Constrained Constrained_From(string contextName)
        {
            var output = new DependencySetSearchDescriptor_Constrained
            {
                Context_Name = contextName,
            };

            return output;
        }

        public DependencySetSearchDescriptor_DependencySearchDescriptor From(IDependencySearchDescriptor dependencySearchDescriptor)
        {
            var output = new DependencySetSearchDescriptor_DependencySearchDescriptor
            {
                DependencySearchDescriptor = dependencySearchDescriptor,
            };

            return output;
        }

        public DependencySetSearchDescriptor_Leaf Leaf_From(string contextName)
        {
            var output = new DependencySetSearchDescriptor_Leaf
            {
                Context_Name = contextName,
            };

            return output;
        }

        public DependencySetSearchDescriptor_None Get_None()
            => DependencySetSearchDescriptor_None.Instance;

        public DependencySetSearchDescriptor_Unconstrained Get_Unconstrained()
            => DependencySetSearchDescriptor_Unconstrained.Instance;

        public DependencySetSearchDescriptor_DependencySearchDescriptor From_SerializationType(Serialization_DependencySetSearchDescriptor_DependencySearchDescriptor dependencySetSearchDescriptor)
        {
            var dependencySearchDescriptor = Instances.DependencySearchDescriptorOperator.From_JsonSerializationObject(dependencySetSearchDescriptor.DependencySearchDescriptor);

            var output = new DependencySetSearchDescriptor_DependencySearchDescriptor
            {
                DependencySearchDescriptor = dependencySearchDescriptor
            };

            return output;
        }

        public Func<IDependencySetDescriptor, bool> Get_PredicateFor(DependencySetSearchDescriptor_Constrained searchDescriptor)
            => descriptor => this.Evaluate(
                searchDescriptor,
                descriptor);

        public Func<IDependencySetDescriptor, bool> Get_PredicateFor(DependencySetSearchDescriptor_DependencySearchDescriptor searchDescriptor)
            => descriptor => this.Evaluate(
                searchDescriptor,
                descriptor);

        public Func<IDependencySetDescriptor, bool> Get_PredicateFor(DependencySetSearchDescriptor_Leaf searchDescriptor)
            => descriptor => this.Evaluate(
                searchDescriptor,
                descriptor);

        public Func<IDependencySetDescriptor, bool> Get_PredicateFor(DependencySetSearchDescriptor_None searchDescriptor)
            => descriptor => this.Evaluate(
                searchDescriptor,
                descriptor);

        public Func<IDependencySetDescriptor, bool> Get_PredicateFor(DependencySetSearchDescriptor_Unconstrained searchDescriptor)
            => descriptor => this.Evaluate(
                searchDescriptor,
                descriptor);

        public Serialization_DependencySetSearchDescriptor_DependencySearchDescriptor To_SerializationType(DependencySetSearchDescriptor_DependencySearchDescriptor dependencySetSearchDescriptor)
        {
            var dependencySearchDescriptor = Instances.DependencySearchDescriptorOperator.To_JsonSerializationObject(dependencySetSearchDescriptor.DependencySearchDescriptor);

            var output = new Serialization_DependencySetSearchDescriptor_DependencySearchDescriptor
            {
                DependencySearchDescriptor = dependencySearchDescriptor
            };

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(DependencySetSearchDescriptor_Constrained dependencySetSearchDescriptor)
        {
            var output = Instances.EnumerableOperator.From($"{dependencySetSearchDescriptor.Context_Name}: context name")
                ;

            return output;
        }

        public IEnumerable<string> To_Text(DependencySetSearchDescriptor_Constrained dependencySetSearchDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(dependencySetSearchDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(dependencySetSearchDescriptor);

            var output = Instances.EnumerableOperator.From($"Dependency Set Search Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(DependencySetSearchDescriptor_DependencySearchDescriptor dependencySetSearchDescriptor)
        {
            var dependencySearch_Lines = Instances.DependencySearchDescriptorOperator.To_Text_ContentOnly_Noexceptive(dependencySetSearchDescriptor.DependencySearchDescriptor);

            var output = Instances.EnumerableOperator.From(
                Instances.EnumerableOperator.From("Dependency Search:")
                    .Append_Many(dependencySearch_Lines.Entab())
                )
                ;

            return output;
        }

        public IEnumerable<string> To_Text(DependencySetSearchDescriptor_DependencySearchDescriptor dependencySetSearchDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(dependencySetSearchDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(dependencySetSearchDescriptor);

            var output = Instances.EnumerableOperator.From($"Dependency Set Search Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(DependencySetSearchDescriptor_Leaf dependencySetSearchDescriptor)
        {
            var output = Instances.EnumerableOperator.From($"{dependencySetSearchDescriptor.Context_Name}: context name")
                ;

            return output;
        }

        public IEnumerable<string> To_Text(DependencySetSearchDescriptor_Leaf dependencySetSearchDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(dependencySetSearchDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(dependencySetSearchDescriptor);

            var output = Instances.EnumerableOperator.From($"Dependency Set Search Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(DependencySetSearchDescriptor_None dependencySetSearchDescriptor)
        {
            var output = Instances.EnumerableOperator.From(Instances.Texts.None)
                ;

            return output;
        }

        public IEnumerable<string> To_Text(DependencySetSearchDescriptor_None dependencySetSearchDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(dependencySetSearchDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(dependencySetSearchDescriptor);

            var output = Instances.EnumerableOperator.From($"Dependency Set Search Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(DependencySetSearchDescriptor_Unconstrained dependencySetSearchDescriptor)
        {
            var output = Instances.EnumerableOperator.From(Instances.Texts.UNCONSTRAINED)
                ;

            return output;
        }

        public IEnumerable<string> To_Text(DependencySetSearchDescriptor_Unconstrained dependencySetSearchDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(dependencySetSearchDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(dependencySetSearchDescriptor);

            var output = Instances.EnumerableOperator.From($"Dependency Set Search Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }
    }
}
