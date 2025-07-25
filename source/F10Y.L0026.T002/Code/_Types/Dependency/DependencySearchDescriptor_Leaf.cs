using System;

using F10Y.T0004;


namespace F10Y.L0026.T002
{
    /// <summary>
    /// Describes a search for dependencies that are a "leaf" within a certain context, in that it has no dependencies within that context.
    /// </summary>
    /// <remarks>
    /// This leaf type can be seen as the complement to the <see cref="DependencySearchDescriptor_Constrained"/> type.
    /// <inheritdoc cref="Documentation_InstanceSet.Leaf_vs_Constrained" path="/summary"/>
    /// </remarks>
    [DataTypeMarker]
    public class DependencySearchDescriptor_Leaf : IDependencySearchDescriptor,
        IWith_ContextName
    {
        /// <summary>
        /// Name (not identity or description, but midway between) of the context in which an instance set is a leaf.
        /// </summary>
        public string Context_Name { get; set; }
    }
}
