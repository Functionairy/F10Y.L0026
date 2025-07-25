using System;

using F10Y.T0004;


namespace F10Y.L0026.T001
{
    /// <summary>
    /// Describes the dependencies of an instances set as being constrained to a specific context name.
    /// </summary>
    /// <remarks>
    /// This constrained type can be seen as the complement to the <see cref="DependencyDescriptor_Leaf"/> type.
    /// <inheritdoc cref="Documentation_InstanceSet.Constrained_vs_Leaf" path="/summary"/>
    /// </remarks>
    [DataTypeMarker]
    public class DependencyDescriptor_Constrained : IDependencyDescriptor,
        IEquatable<DependencyDescriptor_Constrained>,
        IWith_ContextName
    {
        /// <summary>
        /// Name (not identity or description, but midway between) of the context in which an instance set is a leaf.
        /// </summary>
        public string Context_Name { get; set; }


        public override bool Equals(object obj)
        {
            var output = obj is DependencyDescriptor_Constrained applicabilityDescriptor
                && this.Equals(applicabilityDescriptor);

            return output;
        }

        public bool Equals(DependencyDescriptor_Constrained other)
        {
            var output = true
                && this.Context_Name == other.Context_Name
                ;

            return output;
        }

        public override int GetHashCode()
        {
            var output = Instances.HashCodeOperator.Get_HashCode(this.Context_Name);
            return output;
        }

        public override string ToString()
        {
            var output = Instances.DependencyDescriptorOperator.To_String(this);
            return output;
        }
    }
}
