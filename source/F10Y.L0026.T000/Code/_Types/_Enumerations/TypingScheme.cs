using System;

using F10Y.T0004;


namespace F10Y.L0026.T000
{
    /// <summary>
    /// Typing schemes for value instance sets.
    /// </summary>
    [DataTypeMarker]
    public enum TypingScheme
    {
        /// <summary>
        /// Unadorned (or system-typed, which any old value can be, hence the default).
        /// </summary>
        Unadorned = 0,

        /// <summary>
        /// Decorated (or strongly-typed).
        /// </summary>
        Decorated = 1,

        // Might be more entries?
    }
}
