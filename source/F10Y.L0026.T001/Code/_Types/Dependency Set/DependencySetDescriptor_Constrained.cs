using System;

using F10Y.T0004;


namespace F10Y.L0026.T001
{
    /// <summary>
    /// Describes the dependencies of an instances set as being constrained to a specific context name.
    /// <para>
    /// Note: consider whether to use <see cref="DependencyDescriptor_Constrained"/> as one of the dependencies in the set, rather than <em>the</em> dependency set.
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>
    /// This dependency set descriptor indicates the dependencies of an instance set are fundamentally constrained to a certain context,
    /// which is different from the <see cref="DependencyDescriptor_Constrained"/>, which indicates that instead there is a set of dependencies,
    /// one of which being constained to a certain context.
    /// </para>
    /// <para>
    /// This constrained type can be seen as the complement to the <see cref="DependencySetDescriptor_Leaf"/> type.
    /// In the leaf, no dependencies from the given context are allowed.
    /// For this constrained type, only dependencies from the given context are allowed.
    /// </para>
    /// </remarks>
    [DataTypeMarker]
    public class DependencySetDescriptor_Constrained : IDependencySetDescriptor,
        IEquatable<DependencySetDescriptor_Constrained>,
        IWith_ContextName
    {
        /// <summary>
        /// Name (not identity or description, but midway between) of the context in which an instance set is constrained.
        /// </summary>
        public string Context_Name { get; set; }


        public override bool Equals(object obj)
        {
            var output = obj is DependencySetDescriptor_Constrained applicabilityDescriptor
                && this.Equals(applicabilityDescriptor);

            return output;
        }

        public bool Equals(DependencySetDescriptor_Constrained other)
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
            var output = Instances.DependencySetDescriptorOperator.To_String(this);
            return output;
        }
    }
}
