using System;

using F10Y.T0004;


namespace F10Y.L0026.T003
{
    /// <summary>
    /// Indicates that an instance set (source) has been deprecated by another (destination).
    /// </summary>
    /// <remarks>
    /// Instances are frequently moved from an instance set to a new instance set.
    /// Sometimes this is done only for the benefits of rebuilding, sometimes for organizational purposes.
    /// </remarks>
    [DataTypeMarker]
    public class InstanceSetFlowDescriptor_Deprecate : IInstanceSetFlowDescriptor
    {
        #region Static

        public static InstanceSetFlowDescriptor_Deprecate Instance { get; } = new();

        #endregion


        /// <summary>
        /// Singleton.
        /// </summary>
        private InstanceSetFlowDescriptor_Deprecate()
        {
            // Do nothing.
        }
    }
}
