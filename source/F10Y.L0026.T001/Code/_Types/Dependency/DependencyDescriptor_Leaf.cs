using System;

using F10Y.T0004;


namespace F10Y.L0026.T001
{
    /// <summary>
    /// Describes the situation where an instances is a "leaf" within a certain context, in that it has no dependencies within that context.
    /// </summary>
    /// <remarks>
    /// This leaf type can be seen as the complement to the <see cref="DependencyDescriptor_Constrained"/> type.
    /// In this leaf, no dependencies from the given context are allowed.
    /// For the constrained type, only dependencies from the given context are allowed.
    /// </remarks>
    [DataTypeMarker]
    public class DependencyDescriptor_Leaf : IDependencyDescriptor,
        IEquatable<DependencyDescriptor_Leaf>,
        IWith_ContextName
    {
        /// <summary>
        /// Name (not identity or description, but midway between) of the context in which an instance set is a leaf.
        /// </summary>
        public string Context_Name { get; set; }


        public override bool Equals(object obj)
        {
            var output = obj is DependencyDescriptor_Leaf applicabilityDescriptor
                && this.Equals(applicabilityDescriptor);

            return output;
        }

        public bool Equals(DependencyDescriptor_Leaf other)
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
