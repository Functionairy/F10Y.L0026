using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.L0000.Extensions;
using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0026.L001
{
    [FunctionsMarker]
    public partial interface IDomainDescriptorOperator :
        T001.IDomainDescriptorOperator,
        For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IDomainDescriptor>
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public T001.IDomainDescriptorOperator _T001 => T001.DomainDescriptorOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDomainDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IDomainDescriptor>.TextHandlerSuites_ByType
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_DomainDescriptors_ByType;

        Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDomainDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IDomainDescriptor>.TextHandlerSuites_ByTypeName
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_DomainDescriptors_ByTypeName;


        public IEnumerable<string> To_Text_ContentOnly(DomainDescriptor domainDescriptor)
        {
            var output = Instances.EnumerableOperator.From($"{domainDescriptor.Domain}: domain")
                ;

            return output;
        }

        public IEnumerable<string> To_Text(DomainDescriptor domainDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(domainDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(domainDescriptor);

            var output = Instances.EnumerableOperator.From($"Domain Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(DomainDescriptor_Set domainDescriptor)
        {
            var count = Instances.ArrayOperator.Get_Count(domainDescriptor.Domains);

            var output = Instances.EnumerableOperator.From($"{count}: domain count")
                .Append_Many(domainDescriptor.Domains
                    .Order_Alphabetically()
                    .Append(Instances.Texts.Order_Alphabetical_Parenthetical)
                    .Entab()
                )
                ;

            return output;
        }

        public IEnumerable<string> To_Text(DomainDescriptor_Set domainDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(domainDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(domainDescriptor);

            var output = Instances.EnumerableOperator.From($"Domain Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(DomainDescriptor_Set_Ordered domainDescriptor)
        {
            var count = Instances.ArrayOperator.Get_Count(domainDescriptor.Domains);

            var output = Instances.EnumerableOperator.From($"{count}: domain count")
                .Append_Many(domainDescriptor.Domains
                    // Do not reorder; preserve order from ordered set.
                    .Append(Instances.Texts.Order_In_Parenthetical)
                    .Entab()
                )
                ;

            return output;
        }

        public IEnumerable<string> To_Text(DomainDescriptor_Set_Ordered domainDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(domainDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(domainDescriptor);

            var output = Instances.EnumerableOperator.From($"Domain Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }
    }
}
