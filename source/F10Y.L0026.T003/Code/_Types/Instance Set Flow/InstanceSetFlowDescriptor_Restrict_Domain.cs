using System;

using F10Y.T0004;


namespace F10Y.L0026.T003
{
    /// <summary>
    /// Indicates that the destination instance set has a smaller domain than the source instance set.
    /// </summary>
    /// <remarks>
    /// Sometimes an instance is moved from one set to another because the destination instance set is a much better fit for what the instance <em>does</em>.
    /// Because the destination set is much more specific than the source set, the instance is now more widely accessible.
    /// For example, instances in an organization's catch-all library instance set (project) are frequently moved to a domain-specific instance set (project) that may have the same characteristics, but is specific 
    /// </remarks>
    [DataTypeMarker]
    public class InstanceSetFlowDescriptor_Restrict_Domain : IInstanceSetFlowDescriptor
    {
        #region Static

        public static InstanceSetFlowDescriptor_Restrict_Domain Instance { get; } = new();

        #endregion


        /// <summary>
        /// Singleton.
        /// </summary>
        private InstanceSetFlowDescriptor_Restrict_Domain()
        {
            // Do nothing.
        }
    }
}
