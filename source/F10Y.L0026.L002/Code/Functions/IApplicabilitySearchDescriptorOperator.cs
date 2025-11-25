using System;
using System.Collections.Generic;

using F10Y.L0000.Extensions;
using F10Y.L0001.L000.Extensions;
using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0026.L002
{
    [FunctionsMarker]
    public partial interface IApplicabilitySearchDescriptorOperator :
        T002.IApplicabilitySearchDescriptorOperator,
        For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IApplicabilitySearchDescriptor>,
        For_Bases_IPredicateOperator.IPredicateOperator<IApplicabilitySearchDescriptor, IApplicabilityDescriptor>
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public T002.IApplicabilitySearchDescriptorOperator _T002 => T002.ApplicabilitySearchDescriptorOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IApplicabilitySearchDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IApplicabilitySearchDescriptor>.TextHandlerSuites_ByType
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_ApplicabilitySearchDescriptors_ByType;

        Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IApplicabilitySearchDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IApplicabilitySearchDescriptor>.TextHandlerSuites_ByTypeName
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_ApplicabilitySearchDescriptors_ByTypeName;

        Dictionary<Type, For_PredicateProviderSuite.PredicateProviderSuite<IApplicabilitySearchDescriptor, IApplicabilityDescriptor>>
            For_Bases_IPredicateOperator.IPredicateOperator<IApplicabilitySearchDescriptor, IApplicabilityDescriptor>.PredicateProviderSuites_ByType =>
            Instances.PredicateProviderSuiteSets.For_ApplicabilitySearchDescriptors_ByType;


        public bool Evaluate(
            ApplicabilitySearchDescriptor searchDescriptor,
            IApplicabilityDescriptor descriptor)
        {
            var hasApplicability_Stool = Instances.PredicateOperator.If_TypeIs_ElseFalse<IHas_Applicability>(
                descriptor,
                hasDomain =>
                {
                    var output = hasDomain.Applicability == searchDescriptor.Applicability;
                    return output;
                });

            if (hasApplicability_Stool)
            {
                return true;
            }

            return false;
        }

        public Func<IApplicabilityDescriptor, bool> Get_PredicateFor(ApplicabilitySearchDescriptor searchDescriptor)
            => descriptor => this.Evaluate(
                searchDescriptor,
                descriptor);

        public IEnumerable<string> To_Text_ContentOnly(ApplicabilitySearchDescriptor opinionSearchDescriptor)
        {
            var output = Instances.EnumerableOperator.From($"{opinionSearchDescriptor.Applicability}: applicability")
                ;

            return output;
        }

        public IEnumerable<string> To_Text(ApplicabilitySearchDescriptor domainSearchDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(domainSearchDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeName_OfDeclaredType(domainSearchDescriptor);

            var output = Instances.EnumerableOperator.From($"Applicability Search Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }
    }
}
