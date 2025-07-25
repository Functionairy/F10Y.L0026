using System;

using F10Y.T0004;


namespace F10Y.L0026.T001
{
    /// <summary>
    /// A visibility descriptor type that is invalid (for use in testing).
    /// </summary>
    [DataTypeMarker]
    public class VisibilityDescriptor_Invalid : IVisibilityDescriptor
    {
        #region Static

        public static VisibilityDescriptor_Invalid Instance { get; } = new();

        #endregion


        /// <summary>
        /// Singleton.
        /// </summary>
        private VisibilityDescriptor_Invalid()
        {
            // Do nothing.
        }

        public override string ToString()
        {
            var output = Instances.VisibilityDescriptorOperator.To_String(this);
            return output;
        }
    }
}
