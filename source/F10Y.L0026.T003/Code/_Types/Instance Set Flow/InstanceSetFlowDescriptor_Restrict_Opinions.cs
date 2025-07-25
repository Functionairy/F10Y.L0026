using System;

using F10Y.T0004;


namespace F10Y.L0026.T003
{
    /// <summary>
    /// Indicates that the destination instance set has fewer opinions that the source instance set.
    /// </summary>
    /// <remarks>
    /// Sometimes an instance is moved from one set to another because it does not use some of the opinions of the source set.
    /// Because the destination set has fewer opinions than the source set, the instance is now more widely accessible.
    /// For example, instances in an organization's instance set (project) are frequently moved to an complementary unopinionated instance set (project) that has all the same characteristics, but fewer opinions.
    /// </remarks>
    [DataTypeMarker]
    public class InstanceSetFlowDescriptor_Restrict_Opinions : IInstanceSetFlowDescriptor
    {
        #region Static

        public static InstanceSetFlowDescriptor_Restrict_Opinions Instance { get; } = new();

        #endregion


        /// <summary>
        /// Singleton.
        /// </summary>
        private InstanceSetFlowDescriptor_Restrict_Opinions()
        {
            // Do nothing.
        }
    }
}
