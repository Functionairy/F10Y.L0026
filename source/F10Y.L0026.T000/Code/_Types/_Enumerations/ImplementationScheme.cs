using System;

using F10Y.T0004;


namespace F10Y.L0026.T000
{
    /// <summary>
    /// Implementation schemes for value instance sets.
    /// </summary>
    [DataTypeMarker]
    public enum ImplementationScheme
    {
        /// <summary>
        /// If the value is directly provided.
        /// (As opposed to indirectly provided from another value, and most values are directly provided, hence the default.)
        /// </summary>
        Direct = 0,

        /// <summary>
        /// If a value is indirectly provided or constructed from another value.
        /// </summary>
        Derived = 1,

        // Might be more entries?
    }
}
