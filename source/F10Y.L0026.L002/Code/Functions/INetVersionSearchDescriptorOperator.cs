using System;
using System.Collections.Generic;

using F10Y.L0000.Extensions;
using F10Y.L0001.L000.Extensions;
using F10Y.L0008.T001;
using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0026.L002
{
    [FunctionsMarker]
    public partial interface INetVersionSearchDescriptorOperator :
        T002.INetVersionSearchDescriptorOperator,
        For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<INetVersionSearchDescriptor>,
        For_Bases_IPredicateOperator.IPredicateOperator<INetVersionSearchDescriptor, INetVersionDescriptor>
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public T002.INetVersionSearchDescriptorOperator _T002 => T002.NetVersionSearchDescriptorOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<INetVersionSearchDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<INetVersionSearchDescriptor>.TextHandlerSuites_ByType
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_NetVersionSearchDescriptors_ByType;

        Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<INetVersionSearchDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<INetVersionSearchDescriptor>.TextHandlerSuites_ByTypeName
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_NetVersionSearchDescriptors_ByTypeName;

        Dictionary<Type, For_PredicateProviderSuite.PredicateProviderSuite<INetVersionSearchDescriptor, INetVersionDescriptor>>
            For_Bases_IPredicateOperator.IPredicateOperator<INetVersionSearchDescriptor, INetVersionDescriptor>.PredicateProviderSuites_ByType =>
            Instances.PredicateProviderSuiteSets.For_NetVersionSearchDescriptors_ByType;


        public bool Evaluate(
            NetVersionSearchDescriptor searchDescriptor,
            INetVersionDescriptor descriptor)
        {
            var hasTargetFrameworkMoniker_Stool = Instances.PredicateOperator.If_TypeIs_ElseFalse<IHas_TargetFrameworkMoniker>(
                descriptor,
                hasDomain =>
                {
                    var output = hasDomain.TargetFrameworkMoniker == searchDescriptor.TargetFrameworkMoniker;
                    return output;
                });

            if (hasTargetFrameworkMoniker_Stool)
            {
                return true;
            }

            return false;
        }

        public Func<INetVersionDescriptor, bool> Get_PredicateFor(NetVersionSearchDescriptor searchDescriptor)
            => descriptor => this.Evaluate(
                searchDescriptor,
                descriptor);

        public IEnumerable<string> To_Text_ContentOnly(NetVersionSearchDescriptor netVersionSearchDescriptor)
        {
            var output = Instances.EnumerableOperator.From($"{netVersionSearchDescriptor.TargetFrameworkMoniker}: target framework moniker")
                ;

            return output;
        }

        public IEnumerable<string> To_Text(NetVersionSearchDescriptor netVersionSearchDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(netVersionSearchDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeName_OfDeclaredType(netVersionSearchDescriptor);

            var output = Instances.EnumerableOperator.From($".NET Version Search Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }
    }
}
