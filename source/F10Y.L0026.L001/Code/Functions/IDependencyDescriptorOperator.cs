using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0026.L001
{
    [FunctionsMarker]
    public partial interface IDependencyDescriptorOperator :
        T001.IDependencyDescriptorOperator,
        For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IDependencyDescriptor>
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public T001.IDependencyDescriptorOperator _T001 => T001.DependencyDescriptorOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDependencyDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IDependencyDescriptor>.TextHandlerSuites_ByType
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_DependencyDescriptors_ByType;

        Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDependencyDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IDependencyDescriptor>.TextHandlerSuites_ByTypeName
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_DependencyDescriptors_ByTypeName;


        public IEnumerable<string> To_Text_ContentOnly(DependencyDescriptor_Constrained dependencyDescriptor)
        {
            var output = Instances.EnumerableOperator.From($"{dependencyDescriptor.Context_Name}: context name, constrained-to")
                ;

            return output;
        }

        public IEnumerable<string> To_Text(DependencyDescriptor_Constrained dependencyDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(dependencyDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(dependencyDescriptor);

            var output = Instances.EnumerableOperator.From($"Dependency Set Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(DependencyDescriptor_Leaf dependencyDescriptor)
        {
            var output = Instances.EnumerableOperator.From($"{dependencyDescriptor.Context_Name}: context name, leaf-for")
                ;

            return output;
        }

        public IEnumerable<string> To_Text(DependencyDescriptor_Leaf dependencyDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(dependencyDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(dependencyDescriptor);

            var output = Instances.EnumerableOperator.From($"Dependency Set Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(DependencyDescriptor_Name dependencyDescriptor)
        {
            var output = Instances.EnumerableOperator.From($"{dependencyDescriptor.Name}: dependency name")
                ;

            return output;
        }

        public IEnumerable<string> To_Text(DependencyDescriptor_Name dependencyDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(dependencyDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(dependencyDescriptor);

            var output = Instances.EnumerableOperator.From($"Dependency Set Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(DependencyDescriptor_NuGetPackage dependencyDescriptor)
        {
            var output = Instances.EnumerableOperator.From($"{dependencyDescriptor.PackageName}: package name")
                .Append($"{dependencyDescriptor.Version}: version")
                ;

            return output;
        }

        public IEnumerable<string> To_Text(DependencyDescriptor_NuGetPackage dependencyDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(dependencyDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(dependencyDescriptor);

            var output = Instances.EnumerableOperator.From($"Dependency Set Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(DependencyDescriptor_Project dependencyDescriptor)
        {
            var output = Instances.EnumerableOperator.From($"{dependencyDescriptor.ProjectFilePath}: project file")
                ;

            return output;
        }

        public IEnumerable<string> To_Text(DependencyDescriptor_Project dependencyDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(dependencyDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(dependencyDescriptor);

            var output = Instances.EnumerableOperator.From($"Dependency Set Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }
    }
}
