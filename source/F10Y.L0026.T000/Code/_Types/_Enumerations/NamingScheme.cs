using System;

using F10Y.T0004;


namespace F10Y.L0026.T000
{
    /// <summary>
    /// Naming schemes for value instance sets.
    /// </summary>
    [DataTypeMarker]
    public enum NamingScheme
    {
        /// <summary>
        /// Any old name is contextual.
        /// (As opposed to absolute, whcih requires some work to decided on an absolute naming scheme, hence the default.)
        /// </summary>
        Contextual = 0,

        /// <summary>
        /// Absolutely named values require some work.
        /// </summary>
        /// <remarks>
        /// The best absolute naming scheme is just numerical: N_0001.
        /// </remarks>
        Absolute = 1,

        // Might be more entries?
    }
}
