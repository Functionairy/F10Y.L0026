using System;
using System.Collections.Generic;

using F10Y.L0000.Extensions;
using F10Y.L0001.L000.Extensions;
using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0026.L002
{
    [FunctionsMarker]
    public partial interface IVisibilitySearchDescriptorOperator :
        T002.IVisibilitySearchDescriptorOperator,
        For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IVisibilitySearchDescriptor>,
        For_Bases_IPredicateOperator.IPredicateOperator<IVisibilitySearchDescriptor, IVisibilityDescriptor>
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public T002.IVisibilitySearchDescriptorOperator _T002 => T002.VisibilitySearchDescriptorOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IVisibilitySearchDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IVisibilitySearchDescriptor>.TextHandlerSuites_ByType
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_VisibilitySearchDescriptors_ByType;

        Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IVisibilitySearchDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IVisibilitySearchDescriptor>.TextHandlerSuites_ByTypeName
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_VisibilitySearchDescriptors_ByTypeName;

        Dictionary<Type, For_PredicateProviderSuite.PredicateProviderSuite<IVisibilitySearchDescriptor, IVisibilityDescriptor>>
            For_Bases_IPredicateOperator.IPredicateOperator<IVisibilitySearchDescriptor, IVisibilityDescriptor>.PredicateProviderSuites_ByType =>
            Instances.PredicateProviderSuiteSets.For_VisibilitySearchDescriptors_ByType;


        public bool Evaluate(
            VisibilitySearchDescriptor searchDescriptor,
            IVisibilityDescriptor descriptor)
        {
            var output = Instances.PredicateOperator.If_TypeIs_ElseFalse<IHas_Visibility>(
                descriptor,
                hasVisibility =>
                {
                    var output = hasVisibility.Visibility == searchDescriptor.Visibility;
                    return output;
                });

            return output;
        }

        public Func<IVisibilityDescriptor, bool> Get_PredicateFor(VisibilitySearchDescriptor searchDescriptor)
            => descriptor => this.Evaluate(
                searchDescriptor,
                descriptor);

        public VisibilitySearchDescriptor From_SerializationType(Serialization_VisibilitySearchDescriptor visibilitySearchDescriptor)
        {
            var visibility = Instances.VisibilityOperator.From_String(visibilitySearchDescriptor.Visibility);

            var output = new VisibilitySearchDescriptor
            {
                Visibility = visibility
            };

            return output;
        }

        public Serialization_VisibilitySearchDescriptor To_SerializationType(VisibilitySearchDescriptor visibilitySearchDescriptor)
        {
            var visibility = Instances.VisibilityOperator.To_String(visibilitySearchDescriptor.Visibility);

            var output = new Serialization_VisibilitySearchDescriptor
            {
                Visibility = visibility
            };

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(VisibilitySearchDescriptor visibilitySearchDescriptor)
        {
            var visibility = Instances.VisibilityOperator.To_String(visibilitySearchDescriptor.Visibility);

            var output = Instances.EnumerableOperator.From($"{visibility}: visibility")
                ;

            return output;
        }

        public IEnumerable<string> To_Text(VisibilitySearchDescriptor visibilitySearchDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(visibilitySearchDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeName_OfDeclaredType(visibilitySearchDescriptor);

            var output = Instances.EnumerableOperator.From($"Visibility Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }
    }
}
