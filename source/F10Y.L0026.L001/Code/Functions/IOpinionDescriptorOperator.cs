using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0026.L001
{
    [FunctionsMarker]
    public partial interface IOpinionDescriptorOperator :
        T001.IOpinionDescriptorOperator,
        For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IOpinionDescriptor>
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public T001.IOpinionDescriptorOperator _T001 => T001.OpinionDescriptorOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IOpinionDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IOpinionDescriptor>.TextHandlerSuites_ByType
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_OpinionDescriptors_ByType;

        Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IOpinionDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IOpinionDescriptor>.TextHandlerSuites_ByTypeName
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_OpinionDescriptors_ByTypeName;


        public IEnumerable<string> To_Text_ContentOnly(OpinionDescriptor opinionDescriptor)
        {
            var output = Instances.EnumerableOperator.From($"{opinionDescriptor.Opinion}: opinion")
                ;

            return output;
        }

        public IEnumerable<string> To_Text(OpinionDescriptor opinionDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(opinionDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(opinionDescriptor);

            var output = Instances.EnumerableOperator.From($"Dependency Set Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(OpinionDescriptor_Set opinionDescriptor)
        {
            var count = Instances.ArrayOperator.Get_Count(opinionDescriptor.Opinions);

            var output = Instances.EnumerableOperator.From($"{count}: opinion count")
                .Append_Many(opinionDescriptor.Opinions
                    .Order_Alphabetically()
                    .Append(Instances.Texts.Order_Alphabetical_Parenthetical)
                    .Entab()
                )
                ;

            return output;
        }

        public IEnumerable<string> To_Text(OpinionDescriptor_Set opinionDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(opinionDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(opinionDescriptor);

            var output = Instances.EnumerableOperator.From($"Dependency Set Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }
    }
}
