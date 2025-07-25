using System;

using F10Y.T0004;


namespace F10Y.L0026.T002
{
    /// <summary>
    /// Describes a search for dependencies of an instances set that are constrained to a specific context name.
    /// </summary>
    /// <remarks>
    /// This constrained type can be seen as the complement to the <see cref="DependencySearchDescriptor_Leaf"/> type.
    /// <inheritdoc cref="Documentation_InstanceSet.Constrained_vs_Leaf" path="/summary"/>>
    /// </remarks>
    [DataTypeMarker]
    public class DependencySearchDescriptor_Constrained : IDependencySearchDescriptor,
        IWith_ContextName
    {
        /// <summary>
        /// Name (not identity or description, but midway between) of the context in which an instance set is a leaf.
        /// </summary>
        public string Context_Name { get; set; }
    }
}
