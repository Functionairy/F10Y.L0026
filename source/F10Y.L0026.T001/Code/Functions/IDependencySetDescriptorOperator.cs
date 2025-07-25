using System;

using F10Y.T0002;


namespace F10Y.L0026.T001
{
    [FunctionsMarker]
    public partial interface IDependencySetDescriptorOperator
    {
        public DependencySetDescriptor_Constrained Constrained_To(string contextName)
        {
            var output = new DependencySetDescriptor_Constrained
            {
                Context_Name = contextName,
            };

            return output;
        }

        public DependencySetDescriptor From(params IDependencyDescriptor[] dependencyDescriptors)
        {
            var output = new DependencySetDescriptor
            {
                DependencyDescriptors = dependencyDescriptors
            };

            return output;
        }

        public DependencySetDescriptor_Leaf Leaf_For(string contextName)
        {
            var output = new DependencySetDescriptor_Leaf
            {
                Context_Name = contextName,
            };

            return output;
        }

        public string To_String(DependencySetDescriptor dependencySetDescriptor)
        {
            var count = Instances.CountOperator.Get_CountOf(dependencySetDescriptor.DependencyDescriptors);

            var output = $"Dependency Set: {count} count";
            return output;
        }

        public string To_String(DependencySetDescriptor_Constrained dependencySetDescriptor)
        {
            var output = $"Constrained to: {dependencySetDescriptor.Context_Name}";
            return output;
        }

        public string To_String(DependencySetDescriptor_Leaf dependencySetDescriptor)
        {
            var output = $"Leaf within: {dependencySetDescriptor.Context_Name}";
            return output;
        }

        public string To_String(DependencySetDescriptor_None dependencySetDescriptor)
        {
            var output = "Dependencies: NONE";
            return output;
        }

        public string To_String(DependencySetDescriptor_Unconstrained dependencySetDescriptor)
        {
            var output = "Dependencies: UNCONSTRAINED";
            return output;
        }
    }
}
