using System;

using F10Y.T0004;


namespace F10Y.L0026.T003
{
    /// <summary>
    /// To change the visibility of an instance set from private to public.
    /// </summary>
    /// <remarks>
    /// Visibility only flows one way: from private to public.
    /// </remarks>
    [DataTypeMarker]
    public class InstanceSetFlowDescriptor_Publicize : IInstanceSetFlowDescriptor
    {
        #region Static

        public static InstanceSetFlowDescriptor_Publicize Instance { get; } = new();

        #endregion


        /// <summary>
        /// Singleton.
        /// </summary>
        private InstanceSetFlowDescriptor_Publicize()
        {
            // Do nothing.
        }
    }
}
