using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.L0000.Extensions;
using F10Y.L0026.T000;
using F10Y.L0062.T001;
using F10Y.T0002;


namespace F10Y.L0026.L002
{
    [FunctionsMarker]
    public partial interface IDependencySearchDescriptorOperator :
        For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IDependencySearchDescriptor>,
        For_Bases_IPredicateOperator.IPredicateOperator<IDependencySearchDescriptor, IDependencyDescriptor>
    {
        Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDependencySearchDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IDependencySearchDescriptor>.TextHandlerSuites_ByType
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_DependencySearchDescriptors_ByType;

        Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDependencySearchDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IDependencySearchDescriptor>.TextHandlerSuites_ByTypeName
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_DependencySearchDescriptors_ByTypeName;

        Dictionary<Type, For_PredicateProviderSuite.PredicateProviderSuite<IDependencySearchDescriptor, IDependencyDescriptor>>
            For_Bases_IPredicateOperator.IPredicateOperator<IDependencySearchDescriptor, IDependencyDescriptor>.PredicateProviderSuites_ByType =>
            Instances.PredicateProviderSuiteSets.For_DependencySearchDescriptors_ByType;


        public bool Evaluate(
            DependencySearchDescriptor_Constrained searchDescriptor,
            IDependencyDescriptor descriptor)
        {
            var hasContextName_Stool = Instances.PredicateOperator.If_TypeIs_ElseFalse<DependencyDescriptor_Constrained>(
                descriptor,
                constrained =>
                {
                    var output = constrained.Context_Name == searchDescriptor.Context_Name;
                    return output;
                });

            if (hasContextName_Stool)
            {
                return true;
            }

            return false;
        }

        public bool Evaluate(
            DependencySearchDescriptor_Leaf searchDescriptor,
            IDependencyDescriptor descriptor)
        {
            var hasContextName_Stool = Instances.PredicateOperator.If_TypeIs_ElseFalse<DependencyDescriptor_Leaf>(
                descriptor,
                constrained =>
                {
                    var output = constrained.Context_Name == searchDescriptor.Context_Name;
                    return output;
                });

            if (hasContextName_Stool)
            {
                return true;
            }

            return false;
        }

        public bool Evaluate(
            DependencySearchDescriptor_Name searchDescriptor,
            IDependencyDescriptor descriptor)
        {
            var hasName_Stool = Instances.PredicateOperator.If_TypeIs_ElseFalse<IHas_Name>(
                descriptor,
                hasName =>
                {
                    var output = hasName.Name == searchDescriptor.Name;
                    return output;
                });

            if (hasName_Stool)
            {
                return true;
            }

            return false;
        }

        public bool Evaluate(
            DependencySearchDescriptor_NuGetPackage searchDescriptor,
            IDependencyDescriptor descriptor)
        {
            var isNuGetPackage_Stool = Instances.PredicateOperator.If_TypeIs_ElseFalse<DependencyDescriptor_NuGetPackage>(
                descriptor,
                isNuGetPackage =>
                {
                    var output = true
                        && isNuGetPackage.PackageName == searchDescriptor.PackageName
                        && isNuGetPackage.Version == searchDescriptor.Version
                        ;

                    return output;
                });

            if (isNuGetPackage_Stool)
            {
                return true;
            }

            return false;
        }

        public bool Evaluate(
            DependencySearchDescriptor_Project searchDescriptor,
            IDependencyDescriptor descriptor)
        {
            var hasName_Stool = Instances.PredicateOperator.If_TypeIs_ElseFalse<IHas_ProjectFilePath>(
                descriptor,
                hasName =>
                {
                    var output = hasName.ProjectFilePath == searchDescriptor.ProjectFilePath;
                    return output;
                });

            if (hasName_Stool)
            {
                return true;
            }

            return false;
        }

        public DependencySearchDescriptor_Constrained Constrained_From_ContextName(string context_Name)
        {
            var output = new DependencySearchDescriptor_Constrained
            {
                Context_Name = context_Name,
            };

            return output;
        }

        public DependencySearchDescriptor_Leaf Leaf_From_ContextName(string context_Name)
        {
            var output = new DependencySearchDescriptor_Leaf
            {
                Context_Name = context_Name,
            };

            return output;
        }

        public DependencySearchDescriptor_Name From_Name(string name)
        {
            var output = new DependencySearchDescriptor_Name
            {
                Name = name,
            };

            return output;
        }

        public DependencySearchDescriptor_NuGetPackage From_NuGetPackage(
            string packageName,
            string version)
        {
            var output = new DependencySearchDescriptor_NuGetPackage
            {
                PackageName = packageName,
                Version = version
            };

            return output;
        }

        public DependencySearchDescriptor_Project From_ProjectFilePath(string projectFilePath)
        {
            var output = new DependencySearchDescriptor_Project
            {
                ProjectFilePath = projectFilePath,
            };

            return output;
        }

        public Func<IDependencyDescriptor, bool> Get_PredicateFor(DependencySearchDescriptor_Constrained searchDescriptor)
            => descriptor => this.Evaluate(
                searchDescriptor,
                descriptor);

        public Func<IDependencyDescriptor, bool> Get_PredicateFor(DependencySearchDescriptor_Leaf searchDescriptor)
            => descriptor => this.Evaluate(
                searchDescriptor,
                descriptor);

        public Func<IDependencyDescriptor, bool> Get_PredicateFor(DependencySearchDescriptor_Name searchDescriptor)
            => descriptor => this.Evaluate(
                searchDescriptor,
                descriptor);

        public Func<IDependencyDescriptor, bool> Get_PredicateFor(DependencySearchDescriptor_NuGetPackage searchDescriptor)
            => descriptor => this.Evaluate(
                searchDescriptor,
                descriptor);

        public Func<IDependencyDescriptor, bool> Get_PredicateFor(DependencySearchDescriptor_Project searchDescriptor)
            => descriptor => this.Evaluate(
                searchDescriptor,
                descriptor);

        public IEnumerable<string> To_Text_ContentOnly(DependencySearchDescriptor_Name dependencySearchDescriptor)
        {
            var output = Instances.EnumerableOperator.From($"{dependencySearchDescriptor.Name}: name")
                ;

            return output;
        }

        public IEnumerable<string> To_Text(DependencySearchDescriptor_Name dependencySearchDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(dependencySearchDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(dependencySearchDescriptor);

            var output = Instances.EnumerableOperator.From($"Dependency Search Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(DependencySearchDescriptor_Leaf dependencySearchDescriptor)
        {
            var output = Instances.EnumerableOperator.From($"{dependencySearchDescriptor.Context_Name}: context name")
                ;

            return output;
        }

        public IEnumerable<string> To_Text(DependencySearchDescriptor_Leaf dependencySearchDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(dependencySearchDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(dependencySearchDescriptor);

            var output = Instances.EnumerableOperator.From($"Dependency Search Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(DependencySearchDescriptor_Constrained dependencySearchDescriptor)
        {
            var output = Instances.EnumerableOperator.From($"{dependencySearchDescriptor.Context_Name}: context name")
                ;

            return output;
        }

        public IEnumerable<string> To_Text(DependencySearchDescriptor_Constrained dependencySearchDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(dependencySearchDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(dependencySearchDescriptor);

            var output = Instances.EnumerableOperator.From($"Dependency Search Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(DependencySearchDescriptor_Project dependencySearchDescriptor)
        {
            var output = Instances.EnumerableOperator.From($"{dependencySearchDescriptor.ProjectFilePath}: project file path")
                ;

            return output;
        }

        public IEnumerable<string> To_Text(DependencySearchDescriptor_Project dependencySearchDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(dependencySearchDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(dependencySearchDescriptor);

            var output = Instances.EnumerableOperator.From($"Dependency Search Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(DependencySearchDescriptor_NuGetPackage dependencySearchDescriptor)
        {
            var output = Instances.EnumerableOperator.Empty<string>()
                .Append($"{dependencySearchDescriptor.PackageName}: package name")
                .Append($"{dependencySearchDescriptor.Version}: version")
                ;

            return output;
        }

        public IEnumerable<string> To_Text(DependencySearchDescriptor_NuGetPackage dependencySearchDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(dependencySearchDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(dependencySearchDescriptor);

            var output = Instances.EnumerableOperator.From($"Dependency Search Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }
    }
}
