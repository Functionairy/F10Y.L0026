using System;
using System.Collections.Generic;

using F10Y.L0000.Extensions;
using F10Y.L0001.L000.Extensions;
using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0026.L001
{
    [FunctionsMarker]
    public partial interface INetVersionDescriptorOperator :
        T001.INetVersionDescriptorOperator,
        For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<INetVersionDescriptor>
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public T001.INetVersionDescriptorOperator _T001 => T001.NetVersionDescriptorOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<INetVersionDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<INetVersionDescriptor>.TextHandlerSuites_ByType
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_NetVersionDescriptors_ByType;

        Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<INetVersionDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<INetVersionDescriptor>.TextHandlerSuites_ByTypeName
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_NetVersionDescriptors_ByTypeName;


        public IEnumerable<string> To_Text_ContentOnly(NetVersionDescriptor netVersionDescriptor)
        {
            var output = Instances.EnumerableOperator.From($"{netVersionDescriptor.TargetFrameworkMoniker}: target framework moniker")
                ;

            return output;
        }

        public IEnumerable<string> To_Text(NetVersionDescriptor netVersionDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(netVersionDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(netVersionDescriptor);

            var output = Instances.EnumerableOperator.From($".NET Version Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(NetVersionDescriptor_Latest netVersionDescriptor)
        {
            var output = Instances.EnumerableOperator.From($"{Instances.Texts.LATEST}: .NET Version")
                ;

            return output;
        }

        public IEnumerable<string> To_Text(NetVersionDescriptor_Latest netVersionDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(netVersionDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(netVersionDescriptor);

            var output = Instances.EnumerableOperator.From($".NET Version Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }
    }
}
