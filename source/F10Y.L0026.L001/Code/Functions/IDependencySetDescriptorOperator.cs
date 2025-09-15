using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0026.L001
{
    [FunctionsMarker]
    public partial interface IDependencySetDescriptorOperator :
        T001.IDependencySetDescriptorOperator,
        For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IDependencySetDescriptor>
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public T001.IDependencySetDescriptorOperator _T001 => T001.DependencySetDescriptorOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDependencySetDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IDependencySetDescriptor>.TextHandlerSuites_ByType
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_DependencySetDescriptors_ByType;

        Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDependencySetDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IDependencySetDescriptor>.TextHandlerSuites_ByTypeName
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_DependencySetDescriptors_ByTypeName;


        public DependencySetDescriptor From_SerializationType(Serialization_DependencySetDescriptor dependencySetDescriptor)
        {
            var dependencyDescriptors = dependencySetDescriptor.DependencyDescriptors
                .Select(Instances.DependencyDescriptorOperator.From_JsonSerializationObject)
                .ToArray();

            var output = new DependencySetDescriptor
            {
                DependencyDescriptors = dependencyDescriptors
            };

            return output;
        }

        public Serialization_DependencySetDescriptor To_SerializationType(DependencySetDescriptor dependencySetDescriptor)
        {
            var dependencyDescriptors = dependencySetDescriptor.DependencyDescriptors
                .Select(Instances.DependencyDescriptorOperator.To_JsonSerializationObject)
                .ToArray();

            var output = new Serialization_DependencySetDescriptor
            {
                DependencyDescriptors = dependencyDescriptors
            };

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(DependencySetDescriptor dependencySetDescriptor)
        {
            var output = dependencySetDescriptor.DependencyDescriptors
                .SelectMany(Instances.DependencyDescriptorOperator.To_Text_ContentOnly_Noexceptive)
                ;

            return output;
        }

        public IEnumerable<string> To_Text(DependencySetDescriptor dependencySetDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(dependencySetDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(dependencySetDescriptor);

            var output = Instances.EnumerableOperator.From($"Dependency Set Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(DependencySetDescriptor_Constrained dependencySetDescriptor)
        {
            var output = Instances.EnumerableOperator.From($"{dependencySetDescriptor.Context_Name}: context name, constrained-to")
                ;

            return output;
        }

        public IEnumerable<string> To_Text(DependencySetDescriptor_Constrained dependencySetDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(dependencySetDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(dependencySetDescriptor);

            var output = Instances.EnumerableOperator.From($"Dependency Set Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(DependencySetDescriptor_Leaf dependencySetDescriptor)
        {
            var output = Instances.EnumerableOperator.From($"{dependencySetDescriptor.Context_Name}: context name, leaf-for")
                ;

            return output;
        }

        public IEnumerable<string> To_Text(DependencySetDescriptor_Leaf dependencySetDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(dependencySetDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(dependencySetDescriptor);

            var output = Instances.EnumerableOperator.From($"Dependency Set Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(DependencySetDescriptor_None dependencySetDescriptor)
        {
            var output = Instances.EnumerableOperator.From($"{Instances.Texts.None_Capitalized}")
                ;

            return output;
        }

        public IEnumerable<string> To_Text(DependencySetDescriptor_None dependencySetDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(dependencySetDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(dependencySetDescriptor);

            var output = Instances.EnumerableOperator.From($"Dependency Set Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(DependencySetDescriptor_Unconstrained dependencySetDescriptor)
        {
            var output = Instances.EnumerableOperator.From($"{Instances.Texts.UNCONSTRAINED}")
                ;

            return output;
        }

        public IEnumerable<string> To_Text(DependencySetDescriptor_Unconstrained dependencySetDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(dependencySetDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(dependencySetDescriptor);

            var output = Instances.EnumerableOperator.From($"Dependency Set Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }
    }
}
