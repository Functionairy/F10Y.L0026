using System;

using F10Y.T0001;


namespace F10Y.L0026.Y000
{
    /// <summary>
    /// Documentation library for the F10Y.L0026 instance set machinery library.
    /// </summary>
    [DocumentationsMarker]
	public static class Documentation
	{
        /// <remarks>
        /// Arbitary descriptors include: Domain, Applicability, and Opinion (which map to "what", "to", and "from").
        /// </remarks>
        public static readonly object ArbitraryDescriptorRemarks_ForInstanceSet;

        /// <summary>
        /// In the leaf, no dependencies from the given context are allowed.
        /// For this constrained type, only dependencies from the given context are allowed.
        /// </summary>
        public static readonly object Constrained_vs_Leaf;

        /// <summary>
        /// In this leaf, no dependencies from the given context are allowed.
        /// For the constrained type, only dependencies from the given context are allowed.
        /// </summary>
        public static readonly object Leaf_vs_Constrained;

        /// <remarks>
        /// Ownership descriptors include: Organization, and Visibility.
        /// </remarks>
        public static readonly object OwnershipDescriptorRemarks_ForInstanceSet;

        /// <remarks>
        /// Physical descriptors include: .NET version, and dependencies set.
        /// </remarks>
        public static readonly object PhysicalDescriptorRemarks_ForInstanceSet;
    }
}
