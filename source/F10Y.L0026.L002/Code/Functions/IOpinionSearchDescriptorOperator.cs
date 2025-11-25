using System;
using System.Collections.Generic;

using F10Y.L0000.Extensions;
using F10Y.L0001.L000.Extensions;
using F10Y.L0026.T000;
using F10Y.T0002;


namespace F10Y.L0026.L002
{
    [FunctionsMarker]
    public partial interface IOpinionSearchDescriptorOperator :
        For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IOpinionSearchDescriptor>,
        For_Bases_IPredicateOperator.IPredicateOperator<IOpinionSearchDescriptor, IOpinionDescriptor>
    {
        Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IOpinionSearchDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IOpinionSearchDescriptor>.TextHandlerSuites_ByType
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_OpinionSearchDescriptors_ByType;

        Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IOpinionSearchDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IOpinionSearchDescriptor>.TextHandlerSuites_ByTypeName
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_OpinionSearchDescriptors_ByTypeName;

        Dictionary<Type, For_PredicateProviderSuite.PredicateProviderSuite<IOpinionSearchDescriptor, IOpinionDescriptor>>
            For_Bases_IPredicateOperator.IPredicateOperator<IOpinionSearchDescriptor, IOpinionDescriptor>.PredicateProviderSuites_ByType =>
            Instances.PredicateProviderSuiteSets.For_OpinionSearchDescriptors_ByType;


        public bool Evaluate(
            OpinionSearchDescriptor searchDescriptor,
            IOpinionDescriptor descriptor)
        {
            var hasDomain_Stool = Instances.PredicateOperator.If_TypeIs_ElseFalse<IHas_Opinion>(
                descriptor,
                hasDomain =>
                {
                    var output = hasDomain.Opinion == searchDescriptor.Opinion;
                    return output;
                });

            if (hasDomain_Stool)
            {
                return true;
            }

            var hasDomains_Stool = Instances.PredicateOperator.If_TypeIs_ElseFalse<IHas_Opinions>(
                descriptor,
                hasDomains =>
                {
                    var output = Instances.ArrayOperator.Contains(
                        hasDomains.Opinions,
                        searchDescriptor.Opinion);

                    return output;
                });

            if (hasDomains_Stool)
            {
                return true;
            }

            return false;
        }

        public Func<IOpinionDescriptor, bool> Get_PredicateFor(OpinionSearchDescriptor searchDescriptor)
            => descriptor => this.Evaluate(
                searchDescriptor,
                descriptor);

        public OpinionSearchDescriptor From(string opinion)
        {
            var output = new OpinionSearchDescriptor
            {
                Opinion = opinion
            };

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(OpinionSearchDescriptor opinionSearchDescriptor)
        {
            var output = Instances.EnumerableOperator.From($"{opinionSearchDescriptor.Opinion}: opinion")
                ;

            return output;
        }

        public IEnumerable<string> To_Text(OpinionSearchDescriptor opinionSearchDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(opinionSearchDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeName_OfDeclaredType(opinionSearchDescriptor);

            var output = Instances.EnumerableOperator.From($"Opinion Search Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }
    }
}
