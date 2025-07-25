using System;

using F10Y.T0004;


namespace F10Y.L0026.T003
{
    /// <summary>
    /// Indicates that the destination instance set has fewer dependencies that the source instance set.
    /// </summary>
    /// <remarks>
    /// Sometimes an instance is moved from one set to another because it does not require some of the dependencies of the source set.
    /// Because the destination set has fewer dependencies than the source set, the instance is now more widely accessible.
    /// For example, instances in a platform instance set (projects) are frequently moved to a foundation instance set (projects) that have all the same characteristics, but fewer dependencies.
    /// </remarks>
    [DataTypeMarker]
    public class InstanceSetFlowDescriptor_Restrict_Dependencies : IInstanceSetFlowDescriptor
    {
        #region Static

        public static InstanceSetFlowDescriptor_Restrict_Dependencies Instance { get; } = new();

        #endregion


        /// <summary>
        /// Singleton.
        /// </summary>
        private InstanceSetFlowDescriptor_Restrict_Dependencies()
        {
            // Do nothing.
        }
    }
}
