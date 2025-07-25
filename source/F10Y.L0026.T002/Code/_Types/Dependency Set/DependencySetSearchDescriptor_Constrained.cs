using System;

using F10Y.T0004;


namespace F10Y.L0026.T002
{
    /// <summary>
    /// Describes a search on the dependencies set of an instances set as being constrained to a specific context name.
    /// </summary>
    /// <remarks>
    /// <para>
    /// This dependency set descriptor indicates the dependencies of an instance set are fundamentally constrained to a certain context,
    /// which is different from the <see cref="DependencySearchDescriptor_Constrained"/>, which indicates that instead there is a set of dependencies,
    /// one of which being constained to a certain context.
    /// </para>
    /// <para>
    /// This constrained type can be seen as the complement to the <see cref="DependencySetSearchDescriptor_Leaf"/> type.
    /// In the leaf, no dependencies from the given context are allowed.
    /// For this constrained type, only dependencies from the given context are allowed.
    /// </para>
    /// </remarks>
    [DataTypeMarker]
    public class DependencySetSearchDescriptor_Constrained : IDependencySetSearchDescriptor,
        IWith_ContextName
    {
        /// <summary>
        /// Name (not identity or description, but midway between) of the context in which an instance set is constrained.
        /// </summary>
        public string Context_Name { get; set; }
    }
}
