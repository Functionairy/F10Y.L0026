using System;

using F10Y.T0004;


namespace F10Y.L0026.T003
{
    /// <summary>
    /// Instances are frequently moved from executables to libraries with the goal of making that instance commonly available.
    /// </summary>
    /// <remarks>
    /// For example, entry-point instance sets (projects) frequently have an associated library instance set (project).
    /// Or an organization's initial entry-point instance set (project) will have an organizational catch-all library to which instances can be easily moved.
    /// <para>
    /// Note that you <em>can</em> reference an executable project from another executable project!
    /// In this sense, all projects are libraries!
    /// But it's better to keep an artificial distinction.
    /// </para>
    /// </remarks>
    [DataTypeMarker]
    public class InstanceSetFlowDescriptor_Librarate : IInstanceSetFlowDescriptor
    {
        #region Static

        public static InstanceSetFlowDescriptor_Librarate Instance { get; } = new();

        #endregion


        /// <summary>
        /// Singleton.
        /// </summary>
        private InstanceSetFlowDescriptor_Librarate()
        {
            // Do nothing.
        }
    }
}
