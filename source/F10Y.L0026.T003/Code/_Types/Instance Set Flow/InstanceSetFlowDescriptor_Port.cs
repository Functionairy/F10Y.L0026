using System;

using F10Y.T0004;


namespace F10Y.L0026.T003
{
    /// <summary>
    /// Sometimes you just move an instance from one set to another, with no changes in description.
    /// </summary>
    /// <remarks>
    /// For example, instances in experimental instance sets (projects) are frequently moved to production instance sets (projects) that have all the same characteristics.
    /// </remarks>
    [DataTypeMarker]
    public class InstanceSetFlowDescriptor_Port : IInstanceSetFlowDescriptor
    {
        #region Static

        public static InstanceSetFlowDescriptor_Port Instance { get; } = new();

        #endregion


        /// <summary>
        /// Singleton.
        /// </summary>
        private InstanceSetFlowDescriptor_Port()
        {
            // Do nothing.
        }
    }
}
