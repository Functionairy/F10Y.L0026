using System;
using System.Collections.Generic;

using F10Y.L0000.Extensions;
using F10Y.L0001.L000.Extensions;
using F10Y.L0005.T001;
using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0026.L001
{
    /// <summary>
    /// 
    /// </summary>
    [FunctionsMarker]
    public partial interface IVisibilityDescriptorOperator :
        T001.IVisibilityDescriptorOperator,
        For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IVisibilityDescriptor>
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public T001.IVisibilityDescriptorOperator _T001 => T001.VisibilityDescriptorOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles



        Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IVisibilityDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IVisibilityDescriptor>.TextHandlerSuites_ByType
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_VisibilityDescriptors_ByType;

        Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IVisibilityDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IVisibilityDescriptor>.TextHandlerSuites_ByTypeName
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_VisibilityDescriptors_ByTypeName;


        public VisibilityDescriptor From_SerializationType(Serialization_VisibilityDescriptor visibilityDescriptor)
        {
            var visibility = Instances.VisibilityOperator.From_String(visibilityDescriptor.Visibility);

            var output = new VisibilityDescriptor
            {
                Visibility = visibility
            };

            return output;
        }

        public Func<IVisibilityDescriptor, bool> Get_If_HasVisibility_Is(Visibility visibility)
            => visibilityDescriptor => this.If_HasVisibility_Is(
                visibilityDescriptor,
                visibility);

        public bool If_HasVisibility_Is(
            IVisibilityDescriptor visibilityDescriptor,
            Visibility visibility)
        {
            var output = Instances.PredicateOperator.If_TypeIs<IHas_Visibility>(
                visibilityDescriptor,
                descriptor => descriptor.Visibility == visibility);

            return output;
        }

        public Serialization_VisibilityDescriptor To_SerializationType(VisibilityDescriptor visibilityDescriptor)
        {
            var visibility = Instances.VisibilityOperator.To_String(visibilityDescriptor.Visibility);

            var output = new Serialization_VisibilityDescriptor
            {
                Visibility = visibility
            };

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(VisibilityDescriptor visibilityDescriptor)
        {
            var visibility = Instances.VisibilityOperator.To_String(visibilityDescriptor.Visibility);

            var output = Instances.EnumerableOperator.From($"{visibility}: visibility")
                ;

            return output;
        }

        public IEnumerable<string> To_Text(VisibilityDescriptor visibilityDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(visibilityDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(visibilityDescriptor);

            var output = Instances.EnumerableOperator.From($"Visibility Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }
    }
}
