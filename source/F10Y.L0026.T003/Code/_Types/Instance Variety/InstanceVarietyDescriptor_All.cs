using System;

using F10Y.T0004;


namespace F10Y.L0026.T003
{
    /// <summary>
    /// Indicates that an instances set accepts any and all instance varieties (including executable scripts, and all non-executable instance varieties like types, functions, etc.).
    /// </summary>
    [DataTypeMarker]
    public class InstanceVarietyDescriptor_All : IInstanceVarietyDescriptor
    {
        #region Static

        public static InstanceVarietyDescriptor_All Instance { get; } = new();

        #endregion


        /// <summary>
        /// Singleton.
        /// </summary>
        private InstanceVarietyDescriptor_All()
        {
            // Do nothing.
        }
    }
}
