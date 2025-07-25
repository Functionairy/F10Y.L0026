using System;

using F10Y.T0004;


namespace F10Y.L0026.T001
{
    /// <summary>
    /// Indicates that the allowed dependencies set of an instances set is unconstrained.
    /// </summary>
    [DataTypeMarker]
    public class DependencySetDescriptor_Unconstrained : IDependencySetDescriptor
    {
        #region Static

        public static DependencySetDescriptor_Unconstrained Instance { get; } = new();

        #endregion


        /// <summary>
        /// Singleton.
        /// </summary>
        private DependencySetDescriptor_Unconstrained()
        {
            // Do nothing.
        }

        public override string ToString()
        {
            var output = Instances.DependencySetDescriptorOperator.To_String(this);
            return output;
        }
    }
}
