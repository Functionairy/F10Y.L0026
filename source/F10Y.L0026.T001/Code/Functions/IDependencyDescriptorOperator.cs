using System;

using F10Y.T0002;


namespace F10Y.L0026.T001
{
    [FunctionsMarker]
    public partial interface IDependencyDescriptorOperator
    {
        public DependencyDescriptor_Constrained Constrained_To(string contextName)
        {
            var output = new DependencyDescriptor_Constrained
            {
                Context_Name = contextName,
            };

            return output;
        }

        public DependencyDescriptor_Name From_Name(string name)
        {
            var output = new DependencyDescriptor_Name
            {
                Name = name
            };

            return output;
        }

        public DependencyDescriptor_NuGetPackage From_NuGetPackage(
            string packageName,
            string version)
        {
            var output = new DependencyDescriptor_NuGetPackage
            {
                PackageName = packageName,
                Version = version
            };

            return output;
        }

        public DependencyDescriptor_Project From_Project(string projectFilePath)
        {
            var output = new DependencyDescriptor_Project
            {
                ProjectFilePath = projectFilePath
            };

            return output;
        }

        public DependencyDescriptor_Leaf Leaf_For(string contextName)
        {
            var output = new DependencyDescriptor_Leaf
            {
                Context_Name = contextName,
            };

            return output;
        }

        public string To_String(DependencyDescriptor_Constrained dependencyDescriptor)
        {
            var output = $"Constrained to: {dependencyDescriptor.Context_Name}";
            return output;
        }

        public string To_String(DependencyDescriptor_Leaf dependencyDescriptor)
        {
            var output = $"Leaf within: {dependencyDescriptor.Context_Name}";
            return output;
        }

        public string To_String(DependencyDescriptor_Name dependencyDescriptor)
        {
            var output = $"Dependency: {dependencyDescriptor.Name}";
            return output;
        }

        public string To_String(DependencyDescriptor_NuGetPackage dependencyDescriptor)
        {
            var output = $"NuGet: {dependencyDescriptor.PackageName} ({dependencyDescriptor.Version})";
            return output;
        }

        public string To_String(DependencyDescriptor_Project dependencyDescriptor)
        {
            var output = $"Project: {dependencyDescriptor.ProjectFilePath}";
            return output;
        }
    }
}
